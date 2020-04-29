using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;

namespace S7_1500
{
    public partial class S7_1500_Form : Form
    {
        private S7Client Client;
        private byte[] Buffer = new byte[65536];

        private void ShowResult(int Result)
        {
            // This function returns a textual explaination of the error code
            TextError.Text = Client.ErrorText(Result);
            if (Result == 0)
                TextError.Text = TextError.Text + " (" + Client.ExecutionTime.ToString() + " ms)";
        }

        public S7_1500_Form()
        {
            InitializeComponent();
            Client = new S7Client();
            if (IntPtr.Size == 4)
                this.Text = this.Text + " - Running 32 bit Code";
            else
                this.Text = this.Text + " - Running 64 bit Code";
            CBArea.SelectedIndex = 2;//MK
            CBWLen.SelectedIndex = 7;//Real
            bitValue.SelectedIndex = 0;//False
            ReadBtn.Enabled = false;
            WriteBtn.Enabled = false;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            int Result;
            int Rack = System.Convert.ToInt32(TxtRack.Text);
            int Slot = System.Convert.ToInt32(TxtSlot.Text);
            Result = Client.ConnectTo(TxtIP.Text, Rack, Slot);
            ShowResult(Result);
            if (Result == 0)
            {
                TextError.Text = TextError.Text + " PDU Negotiated : " + Client.PduSizeNegotiated.ToString();
                TxtIP.Enabled = false;
                TxtRack.Enabled = false;
                TxtSlot.Enabled = false;
                ConnectBtn.Enabled = false;
                DisconnectBtn.Enabled = true;
                ReadBtn.Enabled = true;
                WriteBtn.Enabled = true;
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            TextError.Text = "Disconnected";
            TxtIP.Enabled = true;
            TxtRack.Enabled = true;
            TxtSlot.Enabled = true;
            ConnectBtn.Enabled = true;
            DisconnectBtn.Enabled = false;
            ReadBtn.Enabled = false;
            WriteBtn.Enabled = false;
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            int DBNumber;
            int Amount;
            int bias_num;
            int bitStart;
            int byteStart;
            int SizeRead = 0;//读出来的字节数
            int Result;
            DBNumber = System.Convert.ToInt32(TxtDB.Text);
            Amount = System.Convert.ToInt32(TxtSize.Text);
            if (WordLen[CBWLen.SelectedIndex] == S7Consts.S7WLBit)
            {
                byteStart = int.Parse(Offset.Text.Split('.')[0] == "" ? "0" : Offset.Text.Split('.')[0]);
                if (Offset.Text.IndexOf('.') == -1)
                {
                    bitStart = 0;
                }
                else
                {
                    bitStart = int.Parse(Offset.Text.Split('.')[1] == "" ? "0" : Offset.Text.Split('.')[1]);
                }
                bias_num = byteStart * 8 + bitStart;
            }
            else
            {
                bias_num = int.Parse(Offset.Text.Split('.')[0] == "" ? "0" : Offset.Text.Split('.')[0]);//byteStart
            }
            Result = Client.ReadArea(Area[CBArea.SelectedIndex], DBNumber, bias_num, Amount, WordLen[CBWLen.SelectedIndex], Buffer, ref SizeRead);
            ShowResult(Result);
            if (Result == 0)
                ShowDump(TxtDump, Buffer, SizeRead);
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            if (WordLen[CBWLen.SelectedIndex] == S7Consts.S7WLReal)//仅写入实数
            {
                int DBNumber;
                int bias_num;
                int SizeWrite = 0;//写进去的字节数
                int Result;
                DBNumber = System.Convert.ToInt32(TxtDB.Text);
                bias_num = int.Parse(Offset.Text.Split('.')[0] == "" ? "0" : Offset.Text.Split('.')[0]);//System.Convert.ToInt32(Offset.Text);
                UInt32 x = Convert.ToUInt32(TxtToWrite.Text, 16);//字符串转16进制32位无符号整数
                float value = BitConverter.ToSingle(BitConverter.GetBytes(x), 0);//IEEE754 字节转换float
                byte[] data = new byte[4];
                S7.SetRealAt(data, 0, value);
                Result = Client.WriteArea(Area[CBArea.SelectedIndex], DBNumber, bias_num, 1, WordLen[CBWLen.SelectedIndex], data, ref SizeWrite);
            }
            if (WordLen[CBWLen.SelectedIndex] == S7Consts.S7WLBit)
            {
                int DBNumber = System.Convert.ToInt32(TxtDB.Text);
                //int bias_num = System.Convert.ToInt32(Offset.Text);
                bool boolValue = bool.Parse(bitValue.Text);
                int byteStart;//字节地址
                int bitStart;//位点地址
                int SizeRead = 0;//读出来的字节数
                int SizeWrite = 0;//写进去的字节数
                int Result;
                byte[] data = new byte[1];
                byteStart = int.Parse(Offset.Text.Split('.')[0] == "" ? "0" : Offset.Text.Split('.')[0]);
                if (Offset.Text.IndexOf('.') == -1)
                {
                    bitStart = 0;
                }
                else
                {
                    bitStart = int.Parse(Offset.Text.Split('.')[1] == "" ? "0" : Offset.Text.Split('.')[1]);
                }
                Result = Client.ReadArea(Area[CBArea.SelectedIndex], DBNumber, byteStart, 1, S7Consts.S7WLByte, data, ref SizeRead);
                S7.SetBitAt(ref data, 0, bitStart, boolValue);
                Result = Client.WriteArea(Area[CBArea.SelectedIndex], DBNumber, byteStart, 1, S7Consts.S7WLByte, data, ref SizeWrite);
                ShowResult(Result);
            }
        }

        private int[] Area = 
        { 
            S7Consts.S7AreaPE,
            S7Consts.S7AreaPA,
            S7Consts.S7AreaMK,
            S7Consts.S7AreaDB,
            S7Consts.S7AreaCT,
            S7Consts.S7AreaTM
        };
        private int[] WordLen =
        {
            S7Consts.S7WLBit,
            S7Consts.S7WLByte,
            S7Consts.S7WLChar,
            S7Consts.S7WLWord,
            S7Consts.S7WLInt,
            S7Consts.S7WLDWord,
            S7Consts.S7WLDInt,
            S7Consts.S7WLReal,
            S7Consts.S7WLCounter,
            S7Consts.S7WLTimer
        };

        private void ShowDump(TextBox DumpBox, byte[] bytes, int Size)
        {
            if (bytes == null)
                return;
            if (WordLen[CBWLen.SelectedIndex] == S7Consts.S7WLReal)
            {
                int Amount = System.Convert.ToInt32(TxtSize.Text);
                int bias_num = int.Parse(Offset.Text.Split('.')[0] == "" ? "0" : Offset.Text.Split('.')[0]);//System.Convert.ToInt32(Offset.Text);
                string outputstring = "";
                for (int i = 0; i < Amount; i++)
                {
                    Single value = S7.GetRealAt(bytes, i * 4);
                    outputstring += CBArea.Text;
                    outputstring += "\t";
                    outputstring += (bias_num + i * 4).ToString();
                    outputstring += "\t";
                    outputstring += value.ToString("F5");//转string最多只能保留5位小数?
                    outputstring += Environment.NewLine;
                }
                DumpBox.Text = outputstring;
            }
            else if (WordLen[CBWLen.SelectedIndex] == S7Consts.S7WLBit)
            {
                string outputstring = "";
                outputstring += CBArea.Text;
                outputstring += "\t";
                outputstring += Offset.Text;
                outputstring += "\t";
                outputstring += BitConverter.ToBoolean(bytes, 0).ToString();
                outputstring += Environment.NewLine;
                DumpBox.Text = outputstring;
            }
            else
            {
                int bytesLength = Size;
                int bytesPerLine = 16;

                char[] HexChars = "0123456789ABCDEF".ToCharArray();

                int firstHexColumn =
                      8                   // 8 characters for the address
                    + 3;                  // 3 spaces

                int firstCharColumn = firstHexColumn
                    + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                    + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                    + 2;                  // 2 spaces 

                int lineLength = firstCharColumn
                    + bytesPerLine           // - characters to show the ascii value
                    + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

                char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
                int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
                StringBuilder result = new StringBuilder(expectedLines * lineLength);

                for (int i = 0; i < bytesLength; i += bytesPerLine)
                {
                    line[0] = HexChars[(i >> 28) & 0xF];
                    line[1] = HexChars[(i >> 24) & 0xF];
                    line[2] = HexChars[(i >> 20) & 0xF];
                    line[3] = HexChars[(i >> 16) & 0xF];
                    line[4] = HexChars[(i >> 12) & 0xF];
                    line[5] = HexChars[(i >> 8) & 0xF];
                    line[6] = HexChars[(i >> 4) & 0xF];
                    line[7] = HexChars[(i >> 0) & 0xF];

                    int hexColumn = firstHexColumn;
                    int charColumn = firstCharColumn;

                    for (int j = 0; j < bytesPerLine; j++)
                    {
                        if (j > 0 && (j & 7) == 0) hexColumn++;
                        if (i + j >= bytesLength)
                        {
                            line[hexColumn] = ' ';
                            line[hexColumn + 1] = ' ';
                            line[charColumn] = ' ';
                        }
                        else
                        {
                            byte b = bytes[i + j];
                            line[hexColumn] = HexChars[(b >> 4) & 0xF];
                            line[hexColumn + 1] = HexChars[b & 0xF];
                            line[charColumn] = (b < 32 ? '·' : (char)b);
                        }
                        hexColumn += 3;
                        charColumn++;
                    }
                    result.Append(line);
                }
                DumpBox.Text = result.ToString();
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;

namespace S7_IO
{
    /// <summary>
    /// 为了快速抓取相应数据并保存
    /// </summary>
    public partial class Form1 : Form
    {
        private S7Client Client;
        private bool PLCconnected = false;
        private bool ReadStart = false;
        private byte[] Buffer = new byte[65536];
        private int[] Area =
        {
            S7Consts.S7AreaPE,
            S7Consts.S7AreaPA,
            S7Consts.S7AreaMK,
            S7Consts.S7AreaDB
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
            S7Consts.S7WLReal
        };


        public Form1()
        {
            InitializeComponent();
            Client = new S7Client();

            CBArea1.SelectedIndex = 2;
            CBWLen1.SelectedIndex = 1;
            CBArea2.SelectedIndex = 2;
            CBWLen2.SelectedIndex = 1;
            CBArea3.SelectedIndex = 2;
            CBWLen3.SelectedIndex = 1;
            CBArea4.SelectedIndex = 2;
            CBWLen4.SelectedIndex = 1;
            CBArea5.SelectedIndex = 2;
            CBWLen5.SelectedIndex = 1;

            DisconnectBtn.Enabled = false;
            ReadBtn.Enabled = false;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            int Result;
            int Rack = Convert.ToInt32(TxtRack.Text);
            int Slot = Convert.ToInt32(TxtSlot.Text);
            Result = Client.ConnectTo(TxtIP.Text, Rack, Slot);
            if (Result == 0)
            {
                TextError.Text = string.Format("{0} (PDU Negotiated:{1}) ({2}ms)", Client.ErrorText(Result), Client.PduSizeNegotiated.ToString(), Client.ExecutionTime.ToString());
                TxtIP.Enabled = false;
                TxtRack.Enabled = false;
                TxtSlot.Enabled = false;
                ConnectBtn.Enabled = false;
                DisconnectBtn.Enabled = true;
                ReadBtn.Enabled = true;
                PLCconnected = true;
            }
            else
            {
                TextError.Text = string.Format("{0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString());
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            DisConnect();
        }

        private void DisConnect()
        {
            Client.Disconnect();
            TextError.Text = "Disconnected";
            TxtIP.Enabled = true;
            TxtRack.Enabled = true;
            TxtSlot.Enabled = true;
            ConnectBtn.Enabled = true;
            DisconnectBtn.Enabled = false;
            ReadBtn.Enabled = false;
            PLCconnected = false;
        }

        private void ChangeParmBtn(bool BtnAble)
        {
            ReadAble1.Enabled = BtnAble;
            ReadAble2.Enabled = BtnAble;
            ReadAble3.Enabled = BtnAble;
            ReadAble4.Enabled = BtnAble;
            ReadAble5.Enabled = BtnAble;
            CBArea1.Enabled = BtnAble;
            CBArea2.Enabled = BtnAble;
            CBArea3.Enabled = BtnAble;
            CBArea4.Enabled = BtnAble;
            CBArea5.Enabled = BtnAble;
            CBWLen1.Enabled = BtnAble;
            CBWLen2.Enabled = BtnAble;
            CBWLen3.Enabled = BtnAble;
            CBWLen4.Enabled = BtnAble;
            CBWLen5.Enabled = BtnAble;
            TxtDB1.Enabled = BtnAble;
            TxtDB2.Enabled = BtnAble;
            TxtDB3.Enabled = BtnAble;
            TxtDB4.Enabled = BtnAble;
            TxtDB5.Enabled = BtnAble;
            TxtSize1.Enabled = BtnAble;
            TxtSize2.Enabled = BtnAble;
            TxtSize3.Enabled = BtnAble;
            TxtSize4.Enabled = BtnAble;
            TxtSize5.Enabled = BtnAble;
            Offset1.Enabled = BtnAble;
            Offset2.Enabled = BtnAble;
            Offset3.Enabled = BtnAble;
            Offset4.Enabled = BtnAble;
            Offset5.Enabled = BtnAble;
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (!ReadStart)
            {
                ChangeParmBtn(false);
                if (ReadAble1.Checked)
                {
                    StringBuilder Outputsb = new StringBuilder();
                    Outputsb.Append("Time");
                    string Area1 = GetAreaName(Area[CBArea1.SelectedIndex]);
                    int offset1 = Convert.ToInt32(Offset1.Text);
                    int Amount1 = Convert.ToInt32(TxtSize1.Text);
                    int WordSize = S7.DataSizeByte(WordLen[CBWLen1.SelectedIndex]);
                    if (WordLen[CBWLen1.SelectedIndex] == S7Consts.S7WLBit)
                    {
                        for (int i = 0; i < Amount1; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(Area1);
                                Outputsb.Append((offset1 + i * WordSize).ToString());
                                Outputsb.Append(".");
                                Outputsb.Append(j.ToString());
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Amount1; i++)
                        {
                            Outputsb.Append(",");
                            Outputsb.Append(Area1);
                            Outputsb.Append((offset1 + i * WordSize).ToString());
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("Output1.csv", false))
                    {
                        sw.WriteLine(Outputsb.ToString());
                    }
                }
                if (ReadAble2.Checked)
                {
                    StringBuilder Outputsb = new StringBuilder();
                    Outputsb.Append("Time");
                    string Area2 = GetAreaName(Area[CBArea2.SelectedIndex]);
                    int offset2 = Convert.ToInt32(Offset2.Text);
                    int Amount2 = Convert.ToInt32(TxtSize2.Text);
                    int WordSize = S7.DataSizeByte(WordLen[CBWLen2.SelectedIndex]);
                    if (WordLen[CBWLen2.SelectedIndex] == S7Consts.S7WLBit)
                    {
                        for (int i = 0; i < Amount2; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(Area2);
                                Outputsb.Append((offset2 + i * WordSize).ToString());
                                Outputsb.Append(".");
                                Outputsb.Append(j.ToString());
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Amount2; i++)
                        {
                            Outputsb.Append(",");
                            Outputsb.Append(Area2);
                            Outputsb.Append((offset2 + i * WordSize).ToString());
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("Output2.csv", false))
                    {
                        sw.WriteLine(Outputsb.ToString());
                    }
                }
                if (ReadAble3.Checked)
                {
                    StringBuilder Outputsb = new StringBuilder();
                    Outputsb.Append("Time");
                    string Area3 = GetAreaName(Area[CBArea3.SelectedIndex]);
                    int offset3 = Convert.ToInt32(Offset3.Text);
                    int Amount3 = Convert.ToInt32(TxtSize3.Text);
                    int WordSize = S7.DataSizeByte(WordLen[CBWLen3.SelectedIndex]);
                    if (WordLen[CBWLen3.SelectedIndex] == S7Consts.S7WLBit)
                    {
                        for (int i = 0; i < Amount3; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(Area3);
                                Outputsb.Append((offset3 + i * WordSize).ToString());
                                Outputsb.Append(".");
                                Outputsb.Append(j.ToString());
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Amount3; i++)
                        {
                            Outputsb.Append(",");
                            Outputsb.Append(Area3);
                            Outputsb.Append((offset3 + i * WordSize).ToString());
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("Output3.csv", false))
                    {
                        sw.WriteLine(Outputsb.ToString());
                    }
                }
                if (ReadAble4.Checked)
                {
                    StringBuilder Outputsb = new StringBuilder();
                    Outputsb.Append("Time");
                    string Area4 = GetAreaName(Area[CBArea4.SelectedIndex]);
                    int offset4 = Convert.ToInt32(Offset4.Text);
                    int Amount4 = Convert.ToInt32(TxtSize4.Text);
                    int WordSize = S7.DataSizeByte(WordLen[CBWLen4.SelectedIndex]);
                    if (WordLen[CBWLen4.SelectedIndex] == S7Consts.S7WLBit)
                    {
                        for (int i = 0; i < Amount4; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(Area4);
                                Outputsb.Append((offset4 + i * WordSize).ToString());
                                Outputsb.Append(".");
                                Outputsb.Append(j.ToString());
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Amount4; i++)
                        {
                            Outputsb.Append(",");
                            Outputsb.Append(Area4);
                            Outputsb.Append((offset4 + i * WordSize).ToString());
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("Output4.csv", false))
                    {
                        sw.WriteLine(Outputsb.ToString());
                    }
                }
                if (ReadAble5.Checked)
                {
                    StringBuilder Outputsb = new StringBuilder();
                    Outputsb.Append("Time");
                    string Area5 = GetAreaName(Area[CBArea5.SelectedIndex]);
                    int offset5 = Convert.ToInt32(Offset5.Text);
                    int Amount5 = Convert.ToInt32(TxtSize5.Text);
                    int WordSize = S7.DataSizeByte(WordLen[CBWLen5.SelectedIndex]);
                    if (WordLen[CBWLen5.SelectedIndex] == S7Consts.S7WLBit)
                    {
                        for (int i = 0; i < Amount5; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(Area5);
                                Outputsb.Append((offset5 + i * WordSize).ToString());
                                Outputsb.Append(".");
                                Outputsb.Append(j.ToString());
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Amount5; i++)
                        {
                            Outputsb.Append(",");
                            Outputsb.Append(Area5);
                            Outputsb.Append((offset5 + i * WordSize).ToString());
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("Output5.csv", false))
                    {
                        sw.WriteLine(Outputsb.ToString());
                    }
                }
                timer1.Interval = 100;
                timer1.Start();
                ReadBtn.Text = "停止读取";
                ReadStart = true;
            }
            else
            {
                timer1.Stop();
                ReadBtn.Text = "读取";
                ReadStart = false;

                ChangeParmBtn(true);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PLCconnected)
            {
                try
                {
                    int Result = -1;
                    int SizeRead = 0;
                    if (ReadAble1.Checked)
                    {
                        int WLen1 = WordLen[CBWLen1.SelectedIndex];
                        bool isBool = false;
                        if(WLen1 == S7Consts.S7WLBit)
                        {
                            WLen1 = S7Consts.S7WLByte;
                            isBool = true;
                        }
                        int Amount1 = Convert.ToInt32(TxtSize1.Text);
                        //int WordSize1 = S7.DataSizeByte(WLen1);
                        Result = Client.ReadArea(Area[CBArea1.SelectedIndex], Convert.ToInt32(TxtDB1.Text), Convert.ToInt32(Offset1.Text), Amount1, WLen1, Buffer, ref SizeRead);
                        if (Result == 0)
                        {
                            List<string> StrList = GetStringList(Buffer, SizeRead, WLen1, isBool);
                            StringBuilder Outputsb = new StringBuilder();
                            Outputsb.Append(DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                            for(int i = 0;i < StrList.Count; i++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(StrList[i]);
                            }
                            using (StreamWriter sw = new StreamWriter("Output1.csv", true))
                            {
                                sw.WriteLine(Outputsb.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception(string.Format("Read1: {0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString()));
                        }
                    }
                    if (ReadAble2.Checked)
                    {
                        int WLen2 = WordLen[CBWLen2.SelectedIndex];
                        bool isBool = false;
                        if (WLen2 == S7Consts.S7WLBit)
                        {
                            WLen2 = S7Consts.S7WLByte;
                            isBool = true;
                        }
                        int Amount2 = Convert.ToInt32(TxtSize2.Text);
                        //int WordSize2 = S7.DataSizeByte(WLen2);
                        Result = Client.ReadArea(Area[CBArea2.SelectedIndex], Convert.ToInt32(TxtDB2.Text), Convert.ToInt32(Offset2.Text), Amount2, WLen2, Buffer, ref SizeRead);
                        if (Result == 0)
                        {
                            List<string> StrList = GetStringList(Buffer, SizeRead, WLen2, isBool);
                            StringBuilder Outputsb = new StringBuilder();
                            Outputsb.Append(DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                            for (int i = 0; i < StrList.Count; i++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(StrList[i]);
                            }
                            using (StreamWriter sw = new StreamWriter("Output2.csv", true))
                            {
                                sw.WriteLine(Outputsb.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception(string.Format("Read2: {0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString()));
                        }
                    }
                    if (ReadAble3.Checked)
                    {
                        int WLen3 = WordLen[CBWLen3.SelectedIndex];
                        bool isBool = false;
                        if (WLen3 == S7Consts.S7WLBit)
                        {
                            WLen3 = S7Consts.S7WLByte;
                            isBool = true;
                        }
                        int Amount3 = Convert.ToInt32(TxtSize3.Text);
                        //int WordSize3 = S7.DataSizeByte(WLen3);
                        Result = Client.ReadArea(Area[CBArea3.SelectedIndex], Convert.ToInt32(TxtDB3.Text), Convert.ToInt32(Offset3.Text), Amount3, WLen3, Buffer, ref SizeRead);
                        if (Result == 0)
                        {
                            List<string> StrList = GetStringList(Buffer, SizeRead, WLen3, isBool);
                            StringBuilder Outputsb = new StringBuilder();
                            Outputsb.Append(DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                            for (int i = 0; i < StrList.Count; i++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(StrList[i]);
                            }
                            using (StreamWriter sw = new StreamWriter("Output3.csv", true))
                            {
                                sw.WriteLine(Outputsb.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception(string.Format("Read3: {0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString()));
                        }
                    }
                    if (ReadAble4.Checked)
                    {
                        int WLen4 = WordLen[CBWLen4.SelectedIndex];
                        bool isBool = false;
                        if (WLen4 == S7Consts.S7WLBit)
                        {
                            WLen4 = S7Consts.S7WLByte;
                            isBool = true;
                        }
                        int Amount4 = Convert.ToInt32(TxtSize4.Text);
                        //int WordSize4 = S7.DataSizeByte(WLen4);
                        Result = Client.ReadArea(Area[CBArea4.SelectedIndex], Convert.ToInt32(TxtDB4.Text), Convert.ToInt32(Offset4.Text), Amount4, WLen4, Buffer, ref SizeRead);
                        if (Result == 0)
                        {
                            List<string> StrList = GetStringList(Buffer, SizeRead, WLen4, isBool);
                            StringBuilder Outputsb = new StringBuilder();
                            Outputsb.Append(DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                            for (int i = 0; i < StrList.Count; i++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(StrList[i]);
                            }
                            using (StreamWriter sw = new StreamWriter("Output4.csv", true))
                            {
                                sw.WriteLine(Outputsb.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception(string.Format("Read4: {0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString()));
                        }
                    }
                    if (ReadAble5.Checked)
                    {
                        int WLen5 = WordLen[CBWLen5.SelectedIndex];
                        bool isBool = false;
                        if (WLen5 == S7Consts.S7WLBit)
                        {
                            WLen5 = S7Consts.S7WLByte;
                            isBool = true;
                        }
                        int Amount5 = Convert.ToInt32(TxtSize5.Text);
                        //int WordSize5 = S7.DataSizeByte(WLen5);
                        Result = Client.ReadArea(Area[CBArea5.SelectedIndex], Convert.ToInt32(TxtDB5.Text), Convert.ToInt32(Offset5.Text), Amount5, WLen5, Buffer, ref SizeRead);
                        if (Result == 0)
                        {
                            List<string> StrList = GetStringList(Buffer, SizeRead, WLen5, isBool);
                            StringBuilder Outputsb = new StringBuilder();
                            Outputsb.Append(DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"));
                            for (int i = 0; i < StrList.Count; i++)
                            {
                                Outputsb.Append(",");
                                Outputsb.Append(StrList[i]);
                            }
                            using (StreamWriter sw = new StreamWriter("Output5.csv", true))
                            {
                                sw.WriteLine(Outputsb.ToString());
                            }
                        }
                        else
                        {
                            throw new Exception(string.Format("Read5: {0} ({1}ms)", Client.ErrorText(Result), Client.ExecutionTime.ToString()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void ShowError(string ErrorText)
        {
            timer1.Stop();
            ReadBtn.Text = "读取";
            ReadStart = false;
            DisConnect();
            ChangeParmBtn(true);

            this.Invoke(new MethodInvoker(delegate
            {
                TextError.Text = ErrorText;
            }
                ));
        }

        private string GetAreaName(int Area)
        {
            switch(Area)
            {
                case S7Consts.S7AreaPE:
                    return "PE";
                case S7Consts.S7AreaPA:
                    return "PA";
                case S7Consts.S7AreaMK:
                    return "MK";
                case S7Consts.S7AreaDB:
                    return "DB";
                default:
                    return "MK";
            }
        }

        private List<string> GetStringList(byte[] buffer,int Amount, int WordLen, bool isBool)
        {
            List<string> newStringList = new List<string>();

            if(isBool)
            {
                for (int i = 0; i < Amount; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        newStringList.Add(S7.GetBitAt(buffer, i, j).ToString());
                    }
                }
            }
            else
            {
                int wordsize = S7.DataSizeByte(WordLen);
                for (int i = 0; i < Amount; i += wordsize)
                {
                    switch(WordLen)
                    {
                        case S7Consts.S7WLByte:
                            newStringList.Add(S7.GetByteAt(buffer, i).ToString());
                            break;
                        case S7Consts.S7WLChar:
                            newStringList.Add(S7.GetCharsAt(buffer, i ,1).ToString());
                            break;
                        case S7Consts.S7WLWord:
                            newStringList.Add(S7.GetWordAt(buffer, i).ToString());
                            break;
                        case S7Consts.S7WLInt:
                            newStringList.Add(S7.GetIntAt(buffer, i).ToString());
                            break;
                        case S7Consts.S7WLDWord:
                            newStringList.Add(S7.GetDWordAt(buffer, i).ToString());
                            break;
                        case S7Consts.S7WLDInt:
                            newStringList.Add(S7.GetDIntAt(buffer, i).ToString());
                            break;
                        case S7Consts.S7WLReal:
                            newStringList.Add(S7.GetRealAt(buffer, i).ToString());
                            break;
                    }
                }
            }

            return newStringList;
        }
    }
}

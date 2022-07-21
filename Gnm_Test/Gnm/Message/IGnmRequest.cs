
namespace Gnm.Message
{
    /// <summary>
    /// Methods specific to a Gnm request message.
    /// </summary>
    public interface IGnmRequest : IGnmMessage
    {
        /// <summary>
        /// Validate the specified response against the current request.
        /// </summary>
        void ValidateResponse(IGnmMessage response);
    }
}

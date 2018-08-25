namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface for the error-related functions of OpenAL 1.1.
    /// </summary>
    internal interface IErrors
    {
        /// <summary>
        /// Gets the current error state, then clears it.
        /// </summary>
        /// <returns>The error.</returns>
        AudioError GetError();
    }
}

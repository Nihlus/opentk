using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Extensions.EXT.ALAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class ALAWFormat : FormatExtensionBase<ALAWBufferFormat>, IALAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected ALAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}

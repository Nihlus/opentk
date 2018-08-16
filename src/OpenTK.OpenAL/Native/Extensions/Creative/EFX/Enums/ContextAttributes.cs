namespace OpenTK.OpenAL.Native.Extensions.Creative.EFX
{
    public enum ContextAttributes
    {
        /// <summary>
        /// Default: 2
        ///
        /// This Context property can be passed to OpenAL during Context creation (alcCreateContext) to
        /// request a maximum number of Auxiliary Sends desired on each Source. It is not guaranteed that the desired
        /// number of sends will be available, so an application should query this property after creating the context
        /// using alcGetIntergerv.
        /// </summary>
        MaxAuxiliarySends = 0x20003
    }
}

﻿using System;
using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// A list of valid <see cref="double"/> <see cref="IALState.GetFloat"/> parameters. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum ALGetFloatSoft
    {
        /// <summary>
        /// Gets the gain limit of the context.
        /// </summary>
        GainLimit = 0x200E
    }
}

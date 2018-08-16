using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native.Extensions.Soft
{
    /// <summary>
    /// Defines the public interface for the state-related functions of OpenAL 1.1 (OpenAL Soft).
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IALStateSoft : IALExtensions
    {
        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        bool GetBoolean(ALGetBooleanSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        double GetDouble(ALGetDoubleSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        float GetFloat(ALGetFloatSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        int GetInteger(ALGetIntegerSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetPointerSOFT")]
        IntPtr GetPointer(ALGetPointerSoft param);
    }
}


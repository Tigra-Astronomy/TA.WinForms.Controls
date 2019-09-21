// This file is part of the TA.WinForms.Controls project
// Copyright © 2016-2019 Tigra Astronomy, all rights reserved.
// File: ILogger.cs  Last modified: 2019-09-21@02:42 by Tim Long
// Licensed under the Tigra MIT License, see https://tigra.mit-license.org/

using System;
using System.ComponentModel;
using System.Diagnostics;

namespace TA.WinFormsControls
{
    /// <summary>
    ///     Interface <see cref="ILogger" /> - a <see langword="private" /> simple logging
    ///     <see langword="interface" /> for logging errors.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        ///     Writes the diagnostic <paramref name="message" /> and <paramref name="exception" /> at
        ///     the <c>Error</c> level.
        /// </summary>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        void Error(Exception exception, [Localizable(false)] string message);
    }

    /// <summary>
    ///     Class SimpleTraceLogger. An extremely simple default logger implementation. It is
    ///     expected that the caller will inject a more appropriate logger. Implements the
    ///     <see cref="ILogger" />
    /// </summary>
    /// <seealso cref="T:TA.WinFormsControls.ILogger" />
    internal class SimpleTraceLogger : ILogger
    {
        /// <inheritdoc />
        public void Error(Exception exception, string message)
        {
            Trace.TraceError($"{message} (exception: {exception.Message})");
        }
    }
}
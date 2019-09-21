using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace TA.WinFormsControls
{
    /// <summary>
    /// Interface ILogger - a private simple logging interface for logging errors.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Error</c> level.
        /// </summary>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        void Error(Exception exception, [Localizable(false)] string message);
    }


    /// <summary>
    /// Class SimpleTraceLogger. An extremely simple default logger implementation.
    /// It is expected that the caller will inject a more appropriate logger.
    /// Implements the <see cref="TA.WinFormsControls.ILogger" />
    /// </summary>
    /// <seealso cref="TA.WinFormsControls.ILogger" />
    class SimpleTraceLogger : ILogger
    {
        /// <inheritdoc />
        public void Error(Exception exception, string message)
        {
            Trace.TraceError($"{message} (exception: {exception.Message})");
        }
    }
}



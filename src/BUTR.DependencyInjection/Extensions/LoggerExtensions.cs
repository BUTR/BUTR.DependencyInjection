﻿// <auto-generated>
//   This code file has automatically been added by the "BUTR.DependencyInjection" NuGet package (https://www.nuget.org/packages/BUTR.DependencyInjection).
//   Please see https://github.com/BUTR/BUTR.DependencyInjection for more information.
//
//   IMPORTANT:
//   DO NOT DELETE THIS FILE if you are using a "packages.config" file to manage your NuGet references.
//   Consider migrating to PackageReferences instead:
//   https://docs.microsoft.com/en-us/nuget/consume-packages/migrate-packages-config-to-package-reference
//   Migrating brings the following benefits:
//   * The "BUTR.DependencyInjection" folder and the "Extensions/LoggerExtensions.cs" file don't appear in your project.
//   * The added file is immutable and can therefore not be modified by coincidence.
//   * Updating/Uninstalling the package will work flawlessly.
// </auto-generated>

#region License
// MIT License
//
// Copyright (c) Bannerlord's Unofficial Tools & Resources
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

#if !BUTRDEPENDENCYINJECTION_DISABLE
#if !BUTRDEPENDENCYINJECTION_DISABLELOGGER
#nullable enable
#if !BUTRDEPENDENCYINJECTION_ENABLEWARNINGS
#pragma warning disable
#endif

namespace BUTR.DependencyInjection.Logger
{
    using global::System;

#if !BUTRDEPENDENCYINJECTION_PUBLIC
    internal
#else
    public
#endif
    /// <summary>IBUTRLogger extension methods for common scenarios.</summary>
    static class LoggerExtensions
    {
        /// <summary>Formats and writes a debug log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogDebug(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Debug, message, args);
        }

        /// <summary>Formats and writes a debug log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogDebug(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Debug, message, args);
        }

        /// <summary>Formats and writes a trace log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogTrace(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Trace, message, args);
        }

        /// <summary>Formats and writes a trace log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogTrace(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Trace, message, args);
        }

        /// <summary>Formats and writes an informational log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogInformation(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Information, message, args);
        }

        /// <summary>Formats and writes an informational log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogInformation(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Information, message, args);
        }

        /// <summary>Formats and writes a warning log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogWarning(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Warning, message, args);
        }

        /// <summary>Formats and writes a warning log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogWarning(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Warning, message, args);
        }

        /// <summary>Formats and writes an error log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogError(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Error, message, args);
        }

        /// <summary>Formats and writes an error log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogError(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Error, message, args);
        }

        /// <summary>Formats and writes a critical log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogCritical(this IBUTRLogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Critical, message, args);
        }

        /// <summary>Formats and writes a critical log message.</summary>
        /// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.IBUTRLogger" /> to write to.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void LogCritical(this IBUTRLogger logger, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            logger.LogMessage(LogLevel.Critical, message, args);
        }
    }
}

#pragma warning restore
#nullable restore
#endif // BUTRDEPENDENCYINJECTION_DISABLELOGGER
#endif // BUTRDEPENDENCYINJECTION_DISABLE
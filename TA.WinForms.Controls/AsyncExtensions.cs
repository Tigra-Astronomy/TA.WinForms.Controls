// This file is part of the TA.WinForms.Controls project
// Copyright © 2016-2019 Tigra Astronomy, all rights reserved.
// File: AsyncExtensions.cs  Last modified: 2019-09-21@02:42 by Tim Long
// Licensed under the Tigra MIT License, see https://tigra.mit-license.org/

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace TA.WinFormsControls
{
    public static class HelperExtensions
    {
        public static ConfiguredTaskAwaitable<TResult> ContinueOnAnyThread<TResult>(this Task<TResult> task)
        {
            return task.ConfigureAwait(false);
        }

        public static ConfiguredTaskAwaitable ContinueOnAnyThread(this Task task)
        {
            return task.ConfigureAwait(false);
        }

        public static ConfiguredTaskAwaitable ContinueOnCurrentThread(this Task task)
        {
            return task.ConfigureAwait(true);
        }

        public static Maybe<T> Maybe<T>(this WeakReference<T> weakReference) where T : class
        {
            var success = weakReference.TryGetTarget(out var strongReference);
            return success ? new Maybe<T>(strongReference) : WinFormsControls.Maybe<T>.Empty;
        }

        public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(s => ((TaskCompletionSource<bool>) s).TrySetResult(true), tcs))
            {
                if (task != await Task.WhenAny(task, tcs.Task)) throw new OperationCanceledException(cancellationToken);
            }
            return task.Result;
        }
    }
}
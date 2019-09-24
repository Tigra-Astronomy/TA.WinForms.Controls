// This file is part of the TA.WinForms.Controls project
// Copyright © 2016-2019 Tigra Astronomy, all rights reserved.
// File: Maybe.cs  Last modified: 2019-09-21@02:42 by Tim Long
// Licensed under the Tigra MIT License, see https://tigra.mit-license.org/

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace TA.WinFormsControls
{
    /// <summary>
    ///     Represents an object that may or may not have a value (strictly, a collection of zero or one elements). Use
    ///     LINQ expression <c>maybe.Any()</c> to determine if there is a value. Use LINQ expression
    ///     <c>maybe.Single()</c> to retrieve the value.
    /// </summary>
    /// <remarks>
    ///     This type almost completely eliminates any need to return <c>null</c> or deal with possibly
    ///     <see langword="null" /> references, which makes code cleaner and more clearly expresses the intent of 'no
    ///     value' versus 'error'. The value of a <see cref="Maybe`1" /> cannot be <c>null</c> , because <c>null</c>
    ///     really means 'no value' and that is better expressed by using
    ///     <see cref="TA.WinFormsControls.Maybe`1.Empty" /> .
    /// </remarks>
    /// <typeparam name="T">The type of the item in the collection.</typeparam>
    public class Maybe<T> : IEnumerable<T>
    {
        private static readonly Maybe<T> EmptyInstance = new Maybe<T>();

        private readonly IEnumerable<T> values;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TA.WinFormsControls.Maybe`1" /> with a value.
        /// </summary>
        /// <param name="value">The value.</param>
        public Maybe(T value)
        {
            Contract.Requires(value != null);
            values = new[] {value};
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TA.WinFormsControls.Maybe`1" /> with no value.
        /// </summary>
        private Maybe()
        {
            values = new T[0];
        }

        /// <summary>
        ///     Gets an instance that does not contain a value.
        /// </summary>
        /// <value>
        ///     The empty instance.
        /// </value>
        public static Maybe<T> Empty
            {
            get
                {
                Contract.Ensures(Contract.Result<Maybe<T>>() != null);
                return EmptyInstance;
                }
            }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="TA.WinFormsControls.Maybe`1" /> is empty (has no value).
        /// </summary>
        /// <value>
        ///     <c>true</c> if none; otherwise, <c>false</c> .
        /// </value>
        public bool None => ReferenceEquals(this, Empty) || !values.Any();

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the
        ///     collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            Contract.Ensures(Contract.Result<IEnumerator<T>>() != null);
            return values.GetEnumerator();
        }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        [Pure]
        public override string ToString()
        {
            Contract.Ensures(Contract.Result<string>() != null);
            if (Equals(Empty))
                return "{no value}";
            return this.Single().ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Contract.Ensures(Contract.Result<IEnumerator>() != null);
            return GetEnumerator();
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(values != null);
        }
    }
}
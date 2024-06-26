﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/* ========================
 * Auto generated file
 * ===================== */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Toolkit.Extensions;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to throw exceptions
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1618", Justification = "Internal helper methods")]
    internal static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsEmpty{T}(T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsEmpty<T>(T[] array, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must be empty, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size equal to {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeNotEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeNotEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size not equal to {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeOver{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeOver<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size over {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeAtLeast{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeAtLeast<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size of at least {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThan{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThan<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size less than {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size less than or equal to {size}, had a size of {array.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(T[] source, T[] destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size equal to {destination.Length.ToAssertString()} (the destination), had a size of {source.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(T[] source, T[] destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(T[]).ToTypeString()}) must have a size less than or equal to {destination.Length.ToAssertString()} (the destination), had a size of {source.Length.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsInRangeFor<T>(int index, T[] array, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must be in the range given by <0> and {array.Length.ToAssertString()} to be a valid index for the target collection ({typeof(T[]).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsNotInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor<T>(int index, T[] array, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must not be in the range given by <0> and {array.Length.ToAssertString()} to be an invalid index for the target collection ({typeof(T[]).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsEmpty{T}(T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsEmpty<T>(List<T> list, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must be empty, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size equal to {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeNotEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeNotEqualTo<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size not equal to {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeOver{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeOver<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size over {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeAtLeast{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeAtLeast<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size of at least {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThan{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThan<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size less than {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(List<T> list, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size less than or equal to {size}, had a size of {list.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(List<T> source, List<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(List<T> source, List<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(List<T>).ToTypeString()}) must have a size less than or equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsInRangeFor<T>(int index, List<T> list, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must be in the range given by <0> and {list.Count.ToAssertString()} to be a valid index for the target collection ({typeof(List<T>).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsNotInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor<T>(int index, List<T> list, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must not be in the range given by <0> and {list.Count.ToAssertString()} to be an invalid index for the target collection ({typeof(List<T>).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsEmpty{T}(T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsEmpty<T>(ICollection<T> collection, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must be empty, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeNotEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeNotEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size not equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeOver{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeOver<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size over {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeAtLeast{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeAtLeast<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size of at least {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThan{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThan<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size less than {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size less than or equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(ICollection<T> source, ICollection<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(ICollection<T> source, ICollection<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(ICollection<T>).ToTypeString()}) must have a size less than or equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsInRangeFor<T>(int index, ICollection<T> collection, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must be in the range given by <0> and {collection.Count.ToAssertString()} to be a valid index for the target collection ({typeof(ICollection<T>).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsNotInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor<T>(int index, ICollection<T> collection, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must not be in the range given by <0> and {collection.Count.ToAssertString()} to be an invalid index for the target collection ({typeof(ICollection<T>).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsEmpty{T}(T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsEmpty<T>(IReadOnlyCollection<T> collection, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must be empty, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeNotEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeNotEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size not equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeOver{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeOver<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size over {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeAtLeast{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeAtLeast<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size of at least {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThan{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThan<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size less than {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],int,string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size less than or equal to {size}, had a size of {collection.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(IReadOnlyCollection<T> source, ICollection<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(IReadOnlyCollection<T> source, ICollection<T> destination, string name)
        {
            ThrowArgumentException(name, $"The source {name.ToAssertString()} ({typeof(IReadOnlyCollection<T>).ToTypeString()}) must have a size less than or equal to {destination.Count.ToAssertString()} (the destination), had a size of {source.Count.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsInRangeFor<T>(int index, IReadOnlyCollection<T> collection, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must be in the range given by <0> and {collection.Count.ToAssertString()} to be a valid index for the target collection ({typeof(IReadOnlyCollection<T>).ToTypeString()}), was {index.ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> when <see cref="Guard.IsNotInRangeFor{T}(int,T[],string)"/> (or an overload) fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor<T>(int index, IReadOnlyCollection<T> collection, string name)
        {
            ThrowArgumentOutOfRangeException(name, $"Parameter {name.ToAssertString()} (int) must not be in the range given by <0> and {collection.Count.ToAssertString()} to be an invalid index for the target collection ({typeof(IReadOnlyCollection<T>).ToTypeString()}), was {index.ToAssertString()}");
        }
    }
}

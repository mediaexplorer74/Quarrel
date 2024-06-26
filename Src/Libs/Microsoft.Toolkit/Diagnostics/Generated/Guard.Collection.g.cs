﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/* ========================
 * Auto generated file
 * ===================== */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to verify conditions when running code.
    /// </summary>
    public static partial class Guard
    {

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(T[] array, string name)
        {
            if (array.Length != 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsEmpty(array, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(T[] array, string name)
        {
            if (array.Length == 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotEmpty<T[]>(name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(T[] array, int size, string name)
        {
            if (array.Length != size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(T[] array, int size, string name)
        {
            if (array.Length == size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size over a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeOver<T>(T[] array, int size, string name)
        {
            if (array.Length <= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeOver(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(T[] array, int size, string name)
        {
            if (array.Length < size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeAtLeast(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(T[] array, int size, string name)
        {
            if (array.Length >= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see typeparamref="T"/> array instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="array">The input <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(T[] array, int size, string name)
        {
            if (array.Length > size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(array, size, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see typeparamref="T"/> array instance must have the same size of a destination <see typeparamref="T"/> array instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="source">The source <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="destination">The destination <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(T[] source, T[] destination, string name)
        {
            if (source.Length != destination.Length)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see typeparamref="T"/> array instance must have a size of less than or equal to that of a destination <see typeparamref="T"/> array instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="source">The source <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="destination">The destination <see typeparamref="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(T[] source, T[] destination, string name)
        {
            if (source.Length > destination.Length)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(source, destination, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is valid for a given <see typeparamref="T"/> array instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="array"/>.</param>
        /// <param name="array">The input <see typeparamref="T"/> array instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="array"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsInRangeFor<T>(int index, T[] array, string name)
        {
            if ((uint)index >= (uint)array.Length)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, array, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is not valid for a given <see typeparamref="T"/> array instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see typeparamref="T"/> array instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="array"/>.</param>
        /// <param name="array">The input <see typeparamref="T"/> array instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="array"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotInRangeFor<T>(int index, T[] array, string name)
        {
            if ((uint)index < (uint)array.Length)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, array, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(List<T> list, string name)
        {
            if (list.Count != 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsEmpty((ICollection<T>)list, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(List<T> list, string name)
        {
            if (list.Count == 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotEmpty<List<T>>(name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(List<T> list, int size, string name)
        {
            if (list.Count != size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(List<T> list, int size, string name)
        {
            if (list.Count == size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size over a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeOver<T>(List<T> list, int size, string name)
        {
            if (list.Count <= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeOver((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(List<T> list, int size, string name)
        {
            if (list.Count < size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeAtLeast((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(List<T> list, int size, string name)
        {
            if (list.Count >= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="List{T}"/> instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="list">The input <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="list"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(List<T> list, int size, string name)
        {
            if (list.Count > size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo((ICollection<T>)list, size, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="List{T}"/> instance must have the same size of a destination <see cref="List{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(List<T> source, List<T> destination, string name)
        {
            if (source.Count != destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo((ICollection<T>)source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="List{T}"/> instance must have a size of less than or equal to that of a destination <see cref="List{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="List{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(List<T> source, List<T> destination, string name)
        {
            if (source.Count > destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo((ICollection<T>)source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is valid for a given <see cref="List{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="list"/>.</param>
        /// <param name="list">The input <see cref="List{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="list"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsInRangeFor<T>(int index, List<T> list, string name)
        {
            if ((uint)index >= (uint)list.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, (ICollection<T>)list, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is not valid for a given <see cref="List{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="List{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="list"/>.</param>
        /// <param name="list">The input <see cref="List{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="list"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotInRangeFor<T>(int index, List<T> list, string name)
        {
            if ((uint)index < (uint)list.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, (ICollection<T>)list, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(ICollection<T> collection, string name)
        {
            if (collection.Count != 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsEmpty(collection, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(ICollection<T> collection, string name)
        {
            if (collection.Count == 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotEmpty<ICollection<T>>(name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count != size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count == size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size over a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeOver<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count <= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeOver(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count < size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeAtLeast(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count >= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="ICollection{T}"/> instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(ICollection<T> collection, int size, string name)
        {
            if (collection.Count > size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="ICollection{T}"/> instance must have the same size of a destination <see cref="ICollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(ICollection<T> source, ICollection<T> destination, string name)
        {
            if (source.Count != destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="ICollection{T}"/> instance must have a size of less than or equal to that of a destination <see cref="ICollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="ICollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(ICollection<T> source, ICollection<T> destination, string name)
        {
            if (source.Count > destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is valid for a given <see cref="ICollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="collection"/>.</param>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="collection"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsInRangeFor<T>(int index, ICollection<T> collection, string name)
        {
            if ((uint)index >= (uint)collection.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, collection, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is not valid for a given <see cref="ICollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="ICollection{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="collection"/>.</param>
        /// <param name="collection">The input <see cref="ICollection{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="collection"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotInRangeFor<T>(int index, ICollection<T> collection, string name)
        {
            if ((uint)index < (uint)collection.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, collection, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(IReadOnlyCollection<T> collection, string name)
        {
            if (collection.Count != 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsEmpty(collection, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(IReadOnlyCollection<T> collection, string name)
        {
            if (collection.Count == 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotEmpty<IReadOnlyCollection<T>>(name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count != size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count == size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size over a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeOver<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count <= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeOver(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count < size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeAtLeast(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count >= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IReadOnlyCollection{T}"/> instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="collection"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(IReadOnlyCollection<T> collection, int size, string name)
        {
            if (collection.Count > size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(collection, size, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="IReadOnlyCollection{T}"/> instance must have the same size of a destination <see cref="IReadOnlyCollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(IReadOnlyCollection<T> source, ICollection<T> destination, string name)
        {
            if (source.Count != destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="IReadOnlyCollection{T}"/> instance must have a size of less than or equal to that of a destination <see cref="IReadOnlyCollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="IReadOnlyCollection{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(IReadOnlyCollection<T> source, ICollection<T> destination, string name)
        {
            if (source.Count > destination.Count)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination.Count, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is valid for a given <see cref="IReadOnlyCollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="collection"/>.</param>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="collection"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsInRangeFor<T>(int index, IReadOnlyCollection<T> collection, string name)
        {
            if ((uint)index >= (uint)collection.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, collection, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is not valid for a given <see cref="IReadOnlyCollection{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The item of items in the input <see cref="IReadOnlyCollection{T}"/> instance.</typeparam>
        /// <param name="index">The input index to be used to access <paramref name="collection"/>.</param>
        /// <param name="collection">The input <see cref="IReadOnlyCollection{T}"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="collection"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotInRangeFor<T>(int index, IReadOnlyCollection<T> collection, string name)
        {
            if ((uint)index < (uint)collection.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, collection, name);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        #region Private Members

        /// <summary>
        /// Used for selecting random numbers
        /// </summary>
        private static readonly Random mRandom = new();

        #endregion

        #region Public Methods

        /// <summary>
        /// Checks if the specified <paramref name="enumerable"/> is <see cref="null"/> or 
        /// if it doesn't have any items.
        /// </summary>
        /// <param name="enumerable">The enumerable</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this IEnumerable? enumerable)
        {
            if (enumerable is null)
                return true;

            foreach (var _ in enumerable)
                return false;

            return true;
        }

        /// <summary>
        /// Ensures that the returned enumerable is not empty by returning the <paramref name="enumerable"/>
        /// if it is not empty, otherwise a <see cref="Enumerable.Empty{TResult}"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="enumerable">The enumerable</param>
        /// <returns></returns>
        public static IEnumerable<T> ToNonNullEnumerable<T>(this IEnumerable<T>? enumerable) => enumerable ?? Enumerable.Empty<T>();

        /// <summary>
        /// Ensures that the returned enumerable is not empty by returning the <paramref name="enumerable"/>
        /// if it is not empty, otherwise a <see cref="List{TResult}"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="enumerable">The enumerable</param>
        /// <returns></returns>
        public static IList<T> ToNonNullList<T>(this IEnumerable<T>? enumerable)
        {
            if (enumerable is null)
                return new List<T>();

            if (enumerable is IList<T>)
                return (IList<T>)enumerable;

            return enumerable.ToList();
        }

        /// <summary>
        /// Selects a random item from the specified <paramref name="source"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <returns></returns>
        public static T? Random<T>(this IEnumerable<T>? source)
        {
            if (source.IsNullOrEmpty())
                return default(T?);

            return source.ElementAt(mRandom.Next(source.Count()));
        }

        /// <summary>
        /// One-line for each
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="action">The action to run</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }

        /// <summary>
        /// Returns the specified <paramref name="source"/> if it's not null or empty,
        /// otherwise it throws an <see cref="ArgumentNullException"/>
        /// </summary>
        /// <param name="source">The source</param>
        /// <returns></returns>
        public static IEnumerable<T> NotNullOrEmpty<T>(this IEnumerable<T>? source)
        {
            if (source is null || source.Count() == 0)
                throw new ArgumentNullException(nameof(source));

            return source;
        }

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="extractor">The string extractor that is used to convert an item to a string</param>
        /// <param name="func">Delegate that places the extracted strings in order</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<T, string> extractor, Func<string, string, string> func)
        {
            var result = string.Empty;

            foreach (var item in source)
            {
                if (result == string.Empty)
                {
                    result = extractor(item);
                    continue;
                }

                result = func(result, extractor(item));
            }

            return result;
        }

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="extractor">The string extractor that is used to convert an item to a string</param>
        /// <param name="separator">The separator</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<T, string> extractor, string separator = ", ")
            => AggregateString(source, extractor, (value1, value2) => value1 + separator + value2);

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>.
        /// NOTE: This method converts the items of the <paramref name="source"/> to <see cref="string"/>
        ///       using the <see cref="object.ToString()"/> method!
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="func">Delegate that places the extracted strings in order</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, Func<string, string, string> func)
            => AggregateString(source, item => item?.ToString() ?? string.Empty, func);

        /// <summary>
        /// Aggregates the specified <paramref name="source"/> into a <see cref="string"/>.
        /// NOTE: This method converts the items of the <paramref name="source"/> to <see cref="string"/>
        ///       using the <see cref="object.ToString()"/> method!
        /// NOTE: This method uses ", " as the items separator!
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <param name="separator">The separator</param>
        /// <returns></returns>
        public static string AggregateString<T>(this IEnumerable<T> source, string separator = ", ")
            => source.AggregateString((s1, s2) => s1 + separator + s2);

        /// <summary>
        /// Checks if the specified <paramref name="source"/> is of type 
        /// <see cref="List{T}"/> and if so, it casts it to that list and
        /// returns it, otherwise, it creates a list from that <paramref name="source"/>
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="source">The source</param>
        /// <returns></returns>
        public static List<T> AsList<T>(this IEnumerable<T> source)
        {
            if (source is List<T> list)
                return list;

            return source.ToList();
        }

        ///// <summary>
        ///// Concatenates two sequences.
        ///// </summary>
        ///// <typeparam name="TResult">The type to cast the elements of source to.</typeparam>
        ///// <typeparam name="T1">The type of the elements of the first input sequence</typeparam>
        ///// <typeparam name="T2">The type of the elements of the first input sequence</typeparam>
        ///// <param name="firstSequence">The first sequence</param>
        ///// <param name="secondSequence">The second sequence</param>
        ///// <returns></returns>
        //public static IEnumerable<TResult> Concat<TResult, T1, T2>(this IEnumerable<T1> firstSequence, IEnumerable<T2> secondSequence)
        //    where T1 : TResult
        //    where T2 : TResult
        //{
        //    var result = new List<TResult>();

        //    result.AddRange(firstSequence.Select(x => (TResult)x));
        //    result.AddRange(secondSequence.Select(x => (TResult)x));

        //    return result;
        //}

        ///// <summary>
        ///// Concatenates two sequences.
        ///// </summary>
        ///// <typeparam name="T1">The type of the elements of the first input sequence</typeparam>
        ///// <typeparam name="T2">The type of the elements of the first input sequence</typeparam>
        /////  <param name="firstSequence">The first sequence</param>
        ///// <param name="secondSequence">The second sequence</param>
        ///// <returns></returns>
        //public static IEnumerable<T1> Concat<T1, T2>(this IEnumerable<T1> firstSequence, IEnumerable<T2> secondSequence)
        //    where T2 : T1 => firstSequence.Concat<T1, T1, T2>(secondSequence);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool UnorderedEqual<T>(this IEnumerable<T> first, IEnumerable<T> second, IEqualityComparer<T>? comparer = null)
        {
            if (ReferenceEquals(first, second))
                return true;

            if (first is null || second is null || (first.Count() != second.Count()))
                return false;

            comparer ??= EqualityComparer<T>.Default;

            foreach (var item in first)
                if (!second.Any(x => comparer.Equals(x, item)))
                    return false;

            return true;
        }

        /// <summary>
        /// Finds the index of the first item matching an expression in an enumerable.
        /// </summary>
        /// <param name="items">The enumerable to search.</param>
        /// <param name="predicate">The expression to test the items against.</param>
        /// <returns>The index of the first matching item, or -1 if no items match.</returns>
        public static int IndexOf<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            if (items is null)
                throw new ArgumentNullException(nameof(items));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            var retVal = 0;

            foreach (var item in items)
            {
                if (predicate(item))
                    return retVal;

                retVal++;
            }

            return -1;
        }

        /// <summary>
        /// Finds the index of the first item that equals the <paramref name="element"/>.
        /// NOTE: The <see cref="Object.Equals(object?)"/> is used for comparing the elements
        /// </summary>
        /// <param name="items">The enumerable to search.</param>
        /// <param name="element">The element that is searched</param>
        /// <returns>The index of the first matching item, or -1 if no items match.</returns>
        public static int IndexOf<T>(this IEnumerable<T> items, T element)
            => IndexOf<T>(items, x => Equals(x, element));

        /// <summary>
        /// Computes the sum of a sequence of <see cref="TimeSpan"/> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="TimeSpan"/> values to calculate the sum of.</param>
        /// <returns></returns>
        public static TimeSpan Sum(this IEnumerable<TimeSpan> source)
            => Sum(source, x => x);

        /// <summary>
        /// Computes the sum of the sequence of <see cref="TimeSpan"/> values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">A sequence of <see cref="TimeSpan"/> values to calculate the sum of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static TimeSpan Sum<T>(this IEnumerable<T> source, Func<T, TimeSpan> selector)
        {
            var result = new TimeSpan();

            foreach (var item in source)
                result = result.Add(selector(item));

            return result;
        }

        /// <summary>
        /// Computes the sum of a sequence of <see cref="TimeSpan?"/> values.
        /// </summary>
        /// <param name="source">A sequence of <see cref="TimeSpan?"/> values to calculate the sum of.</param>
        /// <returns></returns>
        public static TimeSpan? Sum(this IEnumerable<TimeSpan?> source)
            => Sum(source, x => x);

        /// <summary>
        /// Computes the sum of the sequence of <see cref="TimeSpan?"/> values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="T">The type of the items of the enumerable</typeparam>
        /// <param name="source">A sequence of values that are used for calculating the sum.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static TimeSpan? Sum<T>(this IEnumerable<T> source, Func<T, TimeSpan?> selector)
        {
            var result = default(TimeSpan?);

            foreach (var item in source)
            {
                var timeSpan = selector(item);

                if (timeSpan is null)
                    continue;

                if (result is null)
                    result = new TimeSpan();

                result = result.Value.Add(timeSpan.Value);
            }

            return result;
        }

        /// <summary>
        /// Produces the set difference of two sequences according to a specified <paramref name="propertySelector"/> function.
        /// </summary>
        /// <typeparam name="T">The type of the element</typeparam>
        /// <typeparam name="TKey">The type of the key</typeparam>
        /// <param name="first">The collection whose keys that are not also in second will be returned</param>
        /// <param name="second">The collection whose keys that also occur in the first sequence will cause those elements to be removed from the returned sequence</param>
        /// <param name="propertySelector">A function to extract the key for each element</param>
        /// <returns></returns>
        public static IEnumerable<T> Except<T, TKey>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, TKey> propertySelector)
            => first.ExceptBy(second.Select(x => propertySelector(x)), propertySelector);

        /// <summary>
        /// Produces the set difference of two sequences according to a specified <paramref name="propertySelector"/> function.
        /// </summary>
        /// <typeparam name="T">The type of the element</typeparam>
        /// <param name="first">The collection whose keys that are not also in second will be returned</param>
        /// <param name="second">The collection whose keys that also occur in the first sequence will cause those elements to be removed from the returned sequence</param>
        /// <param name="propertySelector">A function to extract the key for each element</param>
        /// <returns></returns>
        public static IEnumerable<T> Except<T>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, bool> propertySelector)
            => first.Where(firstSequenceElement => !second.Any(secondSequenceElement => propertySelector(firstSequenceElement, secondSequenceElement)));

        /// <summary>
        /// Creates and returns all the possible combinations of the specified <paramref name="sequences"/>.
        /// NOTE: Each combination contains one item from each sequence!
        /// NOTE: Order is not taken into consideration!
        /// </summary>
        /// <typeparam name="T">The type of the items</typeparam>
        /// <param name="sequences">The sequences</param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> CreateCombinations<T>(this IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            return sequences.Aggregate(
                emptyProduct,
                (accumulator, sequence) =>
                    from accseq in accumulator
                    from item in sequence
                    select accseq.Concat(new[] { item }));
        }

        #endregion
    }
}

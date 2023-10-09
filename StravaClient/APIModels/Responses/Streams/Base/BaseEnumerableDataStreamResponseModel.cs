namespace StravaClient
{
    /// <summary>
    /// A <see cref="BaseDataStreamResponseModel{T}"/> that is used for contains a set of enumerable data
    /// </summary>
    /// <typeparam name="T">The type of the values of the enumerable.</typeparam>
    public abstract class BaseEnumerableDataStreamResponseModel<T> : BaseDataStreamResponseModel<IEnumerable<T>>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumerableDataStreamResponseModel() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IEnumerable<T> GetFallbackValue() => Enumerable.Empty<T>();

        #endregion
    }

}
namespace StravaClient
{
    /// <summary>
    /// A <see cref="BaseDataStreamResponseModel{T}"/> that is used for contains a set of <see cref="struct"/> data
    /// </summary>
    /// <typeparam name="T">The type of the struct value.</typeparam>
    public abstract class BaseStructDataStreamResponseModel<T> : BaseDataStreamResponseModel<T>
        where T : struct
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseStructDataStreamResponseModel() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override T GetFallbackValue() => new();

        #endregion
    }

}
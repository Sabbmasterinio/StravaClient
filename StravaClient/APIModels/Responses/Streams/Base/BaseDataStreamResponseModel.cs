namespace StravaClient
{
    /// <summary>
    /// A <see cref="BaseStreamResponseModel"/> that contains a set of <see cref="Data"/>
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    public abstract class BaseDataStreamResponseModel<T> : BaseStreamResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Data"/> property
        /// </summary>
        private T? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The data.
        /// </summary>
        /// <remarks>
        /// Check the remarks of the summary comments of the derived class for more information.
        /// </remarks>
        public T Data
        {
            get => mData ??= GetFallbackValue();

            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDataStreamResponseModel() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the fallback value of type <typeparamref name="T"/>
        /// </summary>
        /// <returns></returns>
        protected abstract T GetFallbackValue();

        #endregion
    }

}
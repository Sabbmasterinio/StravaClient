namespace StravaClient
{
    /// <summary>
    /// Represents how many items will be shown per page, with default value 30.
    /// </summary>
    public readonly record struct PageSize
    {
        #region Public Properties

        /// <summary>
        /// Page size.
        /// </summary>
        public int Items{ get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>
        /// The default value will be 30.
        /// </remarks>
        public PageSize()
        {
            Items = 30;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>
        /// <param name="items">Items per page.</param>
        /// </remarks>
        public PageSize(int items)
        {
            Items = items;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"The items of this page will be: {Items}";

        #endregion
    }
}
using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a photo summary.
    /// </summary>
    public class PhotosSummaryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Primary"/> property
        /// </summary>
        private PhotosSummaryPrimaryResponseModel? mPrimary;

        #endregion

        #region Public Properties

        /// <summary>
        /// The number of photos.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// An instance of PhotosSummary_primary.
        /// </summary>
        [JsonProperty("primary")]
        public PhotosSummaryPrimaryResponseModel Primary
        {
            get => mPrimary ??= new();
            set => mPrimary = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhotosSummaryResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}
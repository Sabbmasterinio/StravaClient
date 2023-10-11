using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed gear.
    /// </summary>
    public class DetailedGearResponseModel : SummaryGearResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="BrandName"/> property
        /// </summary>
        private string? mBrandName;

        /// <summary>
        /// The member of <see cref="ModelName"/> property
        /// </summary>
        private string? mModelName;

        /// <summary>
        /// The member of <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        #endregion

        #region Public Properties

        /// <summary>
        /// The gear's brand name.
        /// </summary>
        [AllowNull]
        [JsonProperty("brand_name")]
        public string BrandName
        {
            get => mBrandName ?? string.Empty;
            set => mBrandName = value;
        }

        /// <summary>
        /// The gear's model name.
        /// </summary>
        [AllowNull]
        [JsonProperty("model_name")]
        public string ModelName
        {
            get => mModelName ?? string.Empty;
            set => mModelName = value;
        }

        /// <summary>
        /// The gear's frame type (bike only).
        /// </summary>
        [JsonProperty("frame_type")]
        public int FrameType { get; set; }

        /// <summary>
        /// The gear's description.
        /// </summary>
        [AllowNull]
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedGearResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => BrandName;

        #endregion
    }
}
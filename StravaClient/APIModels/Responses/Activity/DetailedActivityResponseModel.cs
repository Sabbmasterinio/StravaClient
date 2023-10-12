using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed activity.
    /// </summary>
    public class DetailedActivityResponseModel : SummaryActivityResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of <see cref="Photos"/> property
        /// </summary>
        private PhotosSummaryResponseModel? mPhotos;

        /// <summary>
        /// The member of <see cref="Gear"/> property
        /// </summary>
        private SummaryGearResponseModel? mGear;

        /// <summary>
        /// The member of <see cref="SegmentEfforts"/> property
        /// </summary>
        private IEnumerable<DetailedSegmentEffortResponseModel>? mSegmentEfforts;

        /// <summary>
        /// The member of <see cref="DeviceName"/> property
        /// </summary>
        private string? mDeviceName;

        /// <summary>
        /// The member of <see cref="EmbedToken"/> property
        /// </summary>
        private string? mEmbedToken;

        /// <summary>
        /// The member of <see cref="SplitsMetric"/> property
        /// </summary>
        private IEnumerable<SplitResponseModel>? mSplitsMetric;

        /// <summary>
        /// The member of <see cref="SplitsStandard"/> property
        /// </summary>
        private SplitResponseModel? mSplitsStandard;

        /// <summary>
        /// The member of <see cref="Laps"/> property
        /// </summary>
        private IEnumerable<LapResponseModel>? mLaps;

        /// <summary>
        /// The member of <see cref="BestEfforts"/> property
        /// </summary>
        private IEnumerable<DetailedSegmentEffortResponseModel>? mBestEfforts;

        #endregion

        #region Public Properties

        /// <summary>
        /// The description of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// An instance of PhotosSummary.
        /// </summary>
        [JsonProperty("photos")]
        public PhotosSummaryResponseModel Photos
        {
            get => mPhotos ??= new();
            set => mPhotos = value;
        }

        /// <summary>
        /// An instance of SummaryGear.
        /// </summary>
        [JsonProperty("gear")]
        public SummaryGearResponseModel Gear
        {
            get => mGear ??= new();
            set => mGear = value;
        }

        /// <summary>
        /// The number of kilocalories consumed during this activity.
        /// </summary>
        [JsonProperty("calories")]
        public float Calories { get; set; }

        /// <summary>
        /// A collection of DetailedSegmentEffort objects.
        /// </summary>
        [JsonProperty("segment_efforts")]
        public IEnumerable<DetailedSegmentEffortResponseModel> SegmentEfforts
        {
            get => mSegmentEfforts ?? Enumerable.Empty<DetailedSegmentEffortResponseModel>();
            set => mSegmentEfforts = value;
        }

        /// <summary>
        /// The name of the device used to record the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("device_name")]
        public string DeviceName
        {
            get => mDeviceName ?? string.Empty;
            set => mDeviceName = value;
        }

        /// <summary>
        /// The token used to embed a Strava activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("embed_token")]
        public string EmbedToken
        {
            get => mEmbedToken ?? string.Empty;
            set => mEmbedToken = value;
        }

        /// <summary>
        /// The splits of this activity in metric units (for runs).
        /// </summary>
        [JsonProperty("splits_metric")]
        public IEnumerable<SplitResponseModel> SplitsMetric
        {
            get => mSplitsMetric ??= Enumerable.Empty<SplitResponseModel>();
            set => mSplitsMetric = value;
        }

        /// <summary>
        /// The splits of this activity in imperial units (for runs).
        /// </summary>
        [JsonProperty("splits_standard")]
        public SplitResponseModel SplitsStandard
        {
            get => mSplitsStandard ??= new();
            set => mSplitsStandard = value;
        }

        /// <summary>
        /// A collection of Lap objects.
        /// </summary>
        [JsonProperty("laps")]
        public IEnumerable<LapResponseModel> Laps
        {
            get => mLaps ?? Enumerable.Empty<LapResponseModel>();
            set => mLaps = value;
        }

        /// <summary>
        /// A collection of DetailedSegmentEffort objects.
        /// </summary>
        [JsonProperty("best_efforts")]
        public IEnumerable<DetailedSegmentEffortResponseModel> BestEfforts
        {
            get => mBestEfforts ?? Enumerable.Empty<DetailedSegmentEffortResponseModel>();
            set => mBestEfforts = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedActivityResponseModel() : base()
        {

        }

        #endregion
    }
}
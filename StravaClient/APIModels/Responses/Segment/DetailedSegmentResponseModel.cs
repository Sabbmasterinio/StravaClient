using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed segment.
    /// </summary>
    public class DetailedSegmentResponseModel : SummarySegmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Map"/> property
        /// </summary>
        private PolylineMapResponseModel? mMap;

        #endregion

        #region Public Properties

        /// <summary>
        /// The time at which the segment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time at which the segment was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The segment's total elevation gain.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// An instance of PolylineMap.
        /// </summary>
        [JsonProperty("map")]
        public PolylineMapResponseModel Map
        {
            get => mMap ??= new();
            set => mMap = value;
        }

        /// <summary>
        /// The total number of efforts for this segment.
        /// </summary>
        [JsonProperty("effort_count")]
        public int EffortCount { get; set; }

        /// <summary>
        /// The number of unique athletes who have an effort for this segment.
        /// </summary>
        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        /// <summary>
        /// Whether this segment is considered hazardous.
        /// </summary>
        [JsonProperty("hazardous")]
        public bool Hazardous { get; set; }

        /// <summary>
        /// The number of stars for this segment
        /// </summary>
        [JsonProperty("star_count")]
        public int StarCount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedSegmentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}
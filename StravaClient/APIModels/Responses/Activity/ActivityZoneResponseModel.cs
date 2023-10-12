using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an activity zone response model.
    /// </summary>
    public class ActivityZoneResponseModel 
    {
        #region Private Properties

        /// <summary>
        /// The member of the <see cref="DistributionBuckets"/> property
        /// </summary>
        private IEnumerable<TimedZoneRangeResponseModel>? mDistributionBuckets;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// An instance of TimedZoneDistribution.
        /// </summary>
        /// <remarks>
        /// A collection of TimedZoneRange objects. Stores 
        /// the exclusive ranges representing zones and the 
        /// time spent in each.
        /// </remarks>
        [JsonProperty("distribution_buckets")]
        public IEnumerable<TimedZoneRangeResponseModel> DistributionBuckets
        {
            get => mDistributionBuckets ?? Enumerable.Empty<TimedZoneRangeResponseModel>();

            set => mDistributionBuckets = value;
        }

        /// <summary>
        /// May take one of the following values: heartrate, power.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ActivityZoneTypeToStringJsonConverter))]
        public ActivityZoneType Type { get; set; }
        
        /// <summary>
        /// An instance of boolean.
        /// </summary>
        [JsonProperty("sensor_based")]
        public bool IsSensorBased { get; set; }
        
        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("points")]
        public bool Points { get; set; }
        
        /// <summary>
        /// An instance of boolean.
        /// </summary>
        [JsonProperty("custom_zones")]
        public bool CustomZones { get; set; }
        
        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("max")]
        public bool Max { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityZoneResponseModel() : base()
        {

        }

        #endregion
    }
}
using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents zones.
    /// </summary>
    public class ZonesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="HeartRate"/> property
        /// </summary>
        private HeartRateZoneRangesResponseModel? mHeartRate;

        /// <summary>
        /// The member of <see cref="Power"/> property
        /// </summary>
        private PowerZoneRangesResponseModel? mPower;

        /// <summary>
        /// The member of the <see cref="DistributionBuckets"/> property
        /// </summary>
        private IEnumerable<TimedZoneRangeResponseModel>? mDistributionBuckets;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of HeartRateZoneRanges.
        /// </summary>
        [JsonProperty("heart_rate")]
        public HeartRateZoneRangesResponseModel HeartRate
        {
            get => mHeartRate ??= new();
            set => mHeartRate = value;
        }

        /// <summary>
        /// An instance of PowerZoneRanges.
        /// </summary>
        [JsonProperty("power")]
        public PowerZoneRangesResponseModel Power
        {
            get => mPower ??= new();
            set => mPower = value;
        }
        /// <summary>
        /// May take one of the following values: heartrate, power.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ActivityZoneTypeToStringJsonConverter))]
        public ActivityZoneType Type { get; set; }

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
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

        /// <summary>
        /// An instance of boolean.
        /// </summary>
        [JsonProperty("sensor_based")]
        public bool IsSensorBased { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ZonesResponseModel() : base()
        {

        }

        #endregion
    }
}
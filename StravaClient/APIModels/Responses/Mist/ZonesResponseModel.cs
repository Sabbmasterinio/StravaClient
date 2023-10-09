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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ZonesResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}
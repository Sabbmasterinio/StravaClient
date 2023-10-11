using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a heart rate zone ranges.
    /// </summary>
    public class HeartRateZoneRangesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Zones"/> property
        /// </summary>
        private IEnumerable<ZoneRangeResponseModel>? mZones;

        #endregion

        #region Public Properties

        /// <summary>
        /// Whether the athlete has set their own custom heart rate zones.
        /// </summary>
        [JsonProperty("custom_zones")]
        public bool IsCustomZones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("zones")]
        public IEnumerable<ZoneRangeResponseModel> Zones
        {
            get => mZones ?? Enumerable.Empty<ZoneRangeResponseModel>();

            set => mZones = value;
        }

        #endregion

        #region Constructors

        #endregion
    }
}
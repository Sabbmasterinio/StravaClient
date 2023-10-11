using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a power zone ranges.
    /// </summary>
    public class PowerZoneRangesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Zones"/> property
        /// </summary>
        private IEnumerable<ZoneRangeResponseModel>? mZones;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of ZoneRanges.
        /// </summary>
        [JsonProperty("zones")]
        public IEnumerable<ZoneRangeResponseModel> Zones
        {
            get => mZones ?? Enumerable.Empty<ZoneRangeResponseModel>();
            set => mZones = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PowerZoneRangesResponseModel() : base()
        {

        }

        #endregion
    }
}
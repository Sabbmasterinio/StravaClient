using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving segments explore.
    /// </summary>
    public class SegmentsExploreAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The latitude and longitude for two points describing a
        /// rectangular boundary for the search: 
        /// [southwest corner latitude, southwest corner longitude, northeast corner latitude, northeast corner longitude].
        /// </summary>
        [JsonProperty("bounds")]
        public Coordinates[]? Bounds{ get; set; }

        /// <summary>
        /// Desired activity type. May take one of the following values: running, riding.
        /// </summary>
        [JsonProperty("activity_type")]
        public ActivityType? ActivityType{ get; set; }

        /// <summary>
        /// The minimum climbing category.
        /// </summary>
        [JsonProperty("min_cat")]
        public int? MinCat{ get; set; }
        
        /// <summary>
        /// The maximum climbing category.
        /// </summary>
        [JsonProperty("max_cat")]
        public int? MaxCat{ get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SegmentsExploreAPIArgs() : base()
        {

        }

        #endregion
    }
}

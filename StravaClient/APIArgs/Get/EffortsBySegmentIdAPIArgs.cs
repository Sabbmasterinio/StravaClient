using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving segment efforts by segment id.
    /// </summary>
    public class EffortsBySegmentIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Start date of the effort in ISO 8601 formatted date time.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTimeOffset? StartDateLocal { get; set; }
        
        /// <summary>
        /// End date of the effort in ISO 8601 formatted date time.
        /// </summary>
        [JsonProperty("end_date_local")]
        public DateTimeOffset? EndDateLocal { get; set; }

        /// <summary>
        /// Number of items per page. Defaults to 30.
        /// </summary>
        [JsonProperty("per_page")]
        public int? PerPage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EffortsBySegmentIdAPIArgs() : base()
        {

        }

        #endregion
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving a set of streams for a segment effort.
    /// </summary>
    public class SegmentEffortStreamsAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Desired stream types. May take one of the following values:
        /// </summary>
        [JsonProperty("keys")]
        public string[]? Keys { get; set; }

        /// <summary>
        /// Must be true.
        /// </summary>
        [JsonProperty("key_by_type")]
        public bool? IsKeyByType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SegmentEffortStreamsAPIArgs() : base()
        {

        }

        #endregion
    }
}

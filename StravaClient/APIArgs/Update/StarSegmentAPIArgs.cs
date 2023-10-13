using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for the star of the segment.
    /// </summary>
    internal class StarSegmentAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// If true, star the segment; if false, unstar the segment.
        /// </summary>
        [JsonProperty("starred")]
        public bool? IsStarred { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StarSegmentAPIArgs() : base()
        {

        }

        #endregion
    }
}

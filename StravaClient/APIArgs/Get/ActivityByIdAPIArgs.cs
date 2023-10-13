using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving activities by id.
    /// </summary>
    public class ActivityByIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// To include all segments efforts.
        /// </summary>
        [JsonProperty("include_all_efforts")]
        public bool? IncludeAllEfforts { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityByIdAPIArgs() : base()
        {

        }

        #endregion

    }
}

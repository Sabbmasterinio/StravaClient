using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving activities of an athlete.
    /// </summary>
    public class AthleteActivitiesAPIArgs : BasePageParameters
    {
        #region Public Properties

        /// <summary>
        /// An epoch timestamp to use for filtering activities
        /// that have taken place before a certain time.
        /// </summary>
        [JsonProperty("before")]
        public int? Before { get; set; }

        /// <summary>
        /// An epoch timestamp to use for filtering activities
        /// that have taken place after a certain time.
        /// </summary>
        [JsonProperty("after")]
        public int? After { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AthleteActivitiesAPIArgs() : base()
        {

        }

        #endregion
    }
}
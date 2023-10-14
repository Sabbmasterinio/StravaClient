using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for updating logged in athlete.
    /// </summary>
    public class UpdateLoggedInAthleteAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The weight of the athlete in kilograms.
        /// </summary>
        [JsonProperty("weight")]
        public float? Weight { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdateLoggedInAthleteAPIArgs() : base()
        {

        }
        
        #endregion
    }
}
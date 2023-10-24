using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// Request model used for updating the logged in athlete.
    /// </summary>
    public class UpdateLoggedInAthleteRequestModel
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
        public UpdateLoggedInAthleteRequestModel() : base()
        {

        }
        
        #endregion
    }
}
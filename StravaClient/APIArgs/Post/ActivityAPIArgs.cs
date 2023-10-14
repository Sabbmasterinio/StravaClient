using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving activities.
    /// </summary>
    public class ActivityAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type of activity. For example - Run, Ride etc.
        /// </summary>
        [JsonProperty("type")]
        public ActivityType? Type { get; set; }

        /// <summary>
        /// Sport type of activity. For example - Run, MountainBikeRide, Ride, etc.
        /// </summary>
        [JsonProperty("sport_type")]
        public SportType? SportType { get; set; }

        /// <summary>
        /// The start date of the activity in ISO 8601 formatted date time.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTimeOffset? StartDateLocal { get; set; }

        /// <summary>
        /// The elapsed time of the activity in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan? ElapsedTime { get; set; }

        /// <summary>
        /// Description of the activity.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// Distance in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Set to 1 to mark as a trainer activity.
        /// </summary>
        [JsonProperty("trainer")]
        public bool? IsTrainer { get; set; }

        /// <summary>
        /// et to 1 to mark as commute.
        /// </summary>
        [JsonProperty("commute")]
        public bool? IsCommute { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityAPIArgs() : base()
        {

        }

        #endregion
    }
}
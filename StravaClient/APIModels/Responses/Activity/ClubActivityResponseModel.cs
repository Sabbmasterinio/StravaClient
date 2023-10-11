using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a club activity.
    /// </summary>
    public class ClubActivityResponseModel
    {
        #region Private Members
        
        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of MetaAthlete.
        /// </summary>
        [JsonProperty("athlete")]
        public MetaAthleteResponseModel Athlete
        {
            get => mAthlete ??= new();

            set => mAthlete = value;
        }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;

            set => mName = value;
        }

        /// <summary>
        /// The activity's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The activity's moving time, in seconds.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// The activity's elapsed time, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        /// <summary>
        /// The activity's total elevation gain.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        [JsonConverter(typeof(SportTypeToStringJsonConverter))]
        public SportType SportType { get; set; }

        /// <summary>
        /// The activity's workout type.
        /// </summary>
        [JsonProperty("workout_type")]
        public int WorkoutType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubActivityResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "The activity's elapsed time, in seconds : " + ElapsedTime;

        #endregion
    }
}
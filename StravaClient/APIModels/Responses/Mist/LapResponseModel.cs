using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a lap.
    /// </summary>
    public class LapResponseModel
    {
        #region Private Methods

        /// <summary>
        /// The member of <see cref="Activity"/> property
        /// </summary>
        private MetaActivityResponseModel? mActivity;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this lap.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

        /// <summary>
        /// An instance of MetaActivity.
        /// </summary>
        [JsonProperty("activity")]
        public MetaActivityResponseModel Activity
        {
            get => mActivity ??= new();
            set => mActivity = value;
        }

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
        /// The lap's average cadence.
        /// </summary>
        [JsonProperty("average_cadence")]
        public float AverageCadence { get; set; }

        /// <summary>
        /// The lap's average speed.
        /// </summary>
        [JsonProperty("average_speed")]
        public float AverageSpeed { get; set; }

        /// <summary>
        /// The lap's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The lap's elapsed time, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        /// <summary>
        /// The start index of this effort in its activity's stream.
        /// </summary>
        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        /// <summary>
        /// The end index of this effort in its activity's stream.
        /// </summary>
        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        /// <summary>
        /// The index of this lap in the activity it belongs to.
        /// </summary>
        [JsonProperty("lap_index")]
        public int LapIndex { get; set; }

        /// <summary>
        /// The maximum speed of this lap, in meters per second.
        /// </summary>
        [JsonProperty("max_speed")]
        public float MaxSpeed { get; set; }

        /// <summary>
        /// The lap's moving time, in seconds.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// The name of the lap.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The athlete's pace zone during this lap.
        /// </summary>
        [JsonProperty("pace_zone")]
        public int PaceZone { get; set; }

        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("split")]
        public int Split { get; set; }

        /// <summary>
        /// The time at which the lap was started.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The time at which the lap was started in the local timezone.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTimeOffset StartDateLocal { get; set; }

        /// <summary>
        /// The elevation gain of this lap, in meters.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// Whether the wattage was reported by a dedicated recording device.
        /// </summary>
        [JsonProperty("device_watts")]
        public bool IsDeviceWatts { get; set; }

        /// <summary>
        /// The average wattage of this lap.
        /// </summary>
        [JsonProperty("average_watts")]
        public float AverageWatts { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LapResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Name;

        #endregion
    }
}
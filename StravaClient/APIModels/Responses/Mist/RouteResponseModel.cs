using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a route.
    /// </summary>
    public class RouteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private SummaryAthleteResponseModel? mAthlete;

        /// <summary>
        /// The member of <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of <see cref="IdStr"/> property
        /// </summary>
        private string? mIdStr;

        /// <summary>
        /// The member of <see cref="Map"/> property
        /// </summary>
        private PolylineMapResponseModel? mMap;

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;
        
        /// <summary>
        /// The member of <see cref="Segments"/> property
        /// </summary>
        private IEnumerable<SummarySegmentResponseModel>? mSegments;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of SummaryAthlete.
        /// </summary>
        [JsonProperty("athlete")]
        public SummaryAthleteResponseModel Athlete
        {
            get => mAthlete ??= new();
            set => mAthlete = value;
        }

        /// <summary>
        /// The description of the route.
        /// </summary>
        [AllowNull]
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The route's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The route's elevation gain.
        /// </summary>
        [JsonProperty("elevation_gain")]
        public float ElevationGain { get; set; }

        /// <summary>
        /// The unique identifier of this route.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The unique identifier of the route in string format.
        /// </summary>
        [AllowNull]
        [JsonProperty("id_str")]
        public string IdStr
        {
            get => mIdStr ?? string.Empty;
            set => mIdStr = value;
        }

        /// <summary>
        /// An instance of PolylineMap.
        /// </summary>
        [JsonProperty("map")]
        public PolylineMapResponseModel Map
        {
            get => mMap ??= new();
            set => mMap = value;
        }

        /// <summary>
        /// The name of this route.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// Whether this route is private.
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Whether this route is starred by the logged-in athlete.
        /// </summary>
        [JsonProperty("starred")]
        public bool Starred { get; set; }

        /// <summary>
        /// An epoch timestamp of when the route was created.
        /// </summary>
        [JsonProperty("timestamp")]
        public int TimeStamp { get; set; }

        /// <summary>
        /// This route's type (1 for ride, 2 for runs).
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(RouteTypeToIntJsonConverter))]
        public RouteType Type { get; set; }

        /// <summary>
        /// </summary>
        /// This route's sub-type.
        /// <remarks>
        /// (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed).
        /// </remarks>
        [JsonProperty("sub_type")]
        [JsonConverter(typeof(RouteSubTypeToIntJsonConverter))]
        public RouteSubType SubType { get; set; }

        /// <summary>
        /// The time at which the route was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time at which the route was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Estimated time in seconds for the authenticated athlete to complete route.
        /// </summary>
        [JsonProperty("estimated_moving_time")]
        public int EstimatedMovingTime { get; set; }

        /// <summary>
        /// The segments traversed by this route.
        /// </summary>
        [JsonProperty("segments")]
        public IEnumerable<SummarySegmentResponseModel> Segments 
        {
            get => mSegments ?? Enumerable.Empty<SummarySegmentResponseModel>();
            set => mSegments = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RouteResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Name;

        #endregion
    }
}
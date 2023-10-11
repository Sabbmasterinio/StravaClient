using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a polyline map.
    /// </summary>
    public class PolylineMapResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of <see cref="Polyline"/> property
        /// </summary>
        private string? mPolyline;

        /// <summary>
        /// The member of <see cref="SummaryPolyline"/> property
        /// </summary>
        private string? mSummaryPolyline;

        #endregion

        #region Public Properties

        /// <summary>
        /// The identifier of the map.
        /// </summary>
        [AllowNull]
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        /// <summary>
        /// The polyline of the map, only returned on detailed representation of an object.
        /// </summary>
        [AllowNull]
        [JsonProperty("polyline")]
        public string Polyline
        {
            get => mPolyline ?? string.Empty;
            set => mPolyline = value;
        }

        /// <summary>
        /// The polyline of the map, only returned on detailed representation of an object.
        /// </summary>
        [AllowNull]
        [JsonProperty("summary_polyline")]
        public string SummaryPolyline
        {
            get => mSummaryPolyline ?? string.Empty;
            set => mSummaryPolyline = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PolylineMapResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Polyline;

        #endregion
    }
}
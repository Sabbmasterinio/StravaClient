using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an explorer response.
    /// </summary>
    public class ExplorerResponseResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Segments"/> property
        /// </summary>
        private IEnumerable<ExplorerSegmentResponseModel>? mSegments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The set of segments matching an explorer request.
        /// </summary>
        [JsonProperty("segments")]
        public IEnumerable<ExplorerSegmentResponseModel> Segments
        {
            get => mSegments ?? Enumerable.Empty<ExplorerSegmentResponseModel>();
            set => mSegments = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExplorerResponseResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}
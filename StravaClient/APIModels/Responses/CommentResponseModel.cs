using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a comment.
    /// </summary>
    public class CommentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Text"/> property
        /// </summary>
        private string? mText;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private SummaryAthleteResponseModel? mAthlete;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this comment.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The identifier of the activity this comment is related to.
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// The content of the comment.
        /// </summary>
        [AllowNull]
        [JsonProperty("text")]
        public string Text
        {
            get => mText ?? string.Empty;
            set => mText = value;
        }

        /// <summary>
        /// The resource state.
        /// </summary>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

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
        /// The time at which this comment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CommentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Text;

        #endregion
    }
}
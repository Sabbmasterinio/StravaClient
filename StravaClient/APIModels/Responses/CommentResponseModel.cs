using Newtonsoft.Json;
using System.Data;
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
        /// The member of <see cref="MentionsMetadata"/> property
        /// </summary>
        private string? mMentionsMetadata;
        

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private SummaryAthleteResponseModel? mAthlete;

        /// <summary>
        /// The member of <see cref="Cursor"/> property
        /// </summary>
        private string? mCursor;

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
        /// The post id.
        /// </summary>
        [JsonProperty("post_id")]
        public long? PostId { get; set; }

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
        /// The mentions metadata.
        /// </summary>
        [AllowNull]
        [JsonProperty("mentions_metadata")]
        public string MentionsMetadata
        {
            get => mMentionsMetadata ?? string.Empty;
            set => mMentionsMetadata = value;
        }

        /// <summary>
        /// The time at which this comment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

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
        /// A cursor.
        /// </summary>
        [JsonProperty("cursor")]
        public string Cursor
        {
            get => mCursor ?? string.Empty;
            set => mCursor = value;
        }

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
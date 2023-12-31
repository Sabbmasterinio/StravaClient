﻿using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary pr segment effort.
    /// </summary>
    public class SummaryPRSegmentEffortResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the activity related to the PR effort.
        /// </summary>
        [JsonProperty("pr_activity_id")]
        public long PersonalRecordActivityId { get; set; }

        /// <summary>
        /// The elapsed time of the PR effort.
        /// </summary>
        [JsonProperty("pr_elapsed_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan PersonalRecordElapsedTime { get; set; }

        /// <summary>
        /// The time at which the PR effort was started.
        /// </summary>
        [JsonProperty("pr_date")]
        public DateTimeOffset PersonalRecordDate { get; set; }

        /// <summary>
        /// Number of efforts by the authenticated athlete on this segment.
        /// </summary>
        [JsonProperty("effort_count")]
        public int EffortCount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummaryPRSegmentEffortResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "Number of efforts by the authenticated athlete on this segment : " + EffortCount;

        #endregion
    }
}
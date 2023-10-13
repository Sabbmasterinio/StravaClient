using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for uploading a new data file.
    /// </summary>
    public class UploadAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The uploaded file.
        /// </summary>
        [JsonProperty("file")]
        public string? File { get; set; }

        /// <summary>
        /// The desired name of the resulting activity.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// The desired name of the resulting activity.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the resulting activity should be marked
        /// as having been performed on a trainer.
        /// </summary>
        [JsonProperty("trainer")]
        public string? Trainer { get; set; }

        /// <summary>
        /// Whether the resulting activity should be tagged as a commute.
        /// </summary>
        [JsonProperty("commute")]
        public string? Commute { get; set; }

        /// <summary>
        /// The format of the uploaded file. May take one of the following values:
        /// fit, fit.gz, tcx, tcx.gz, gpx, gpx.gz .
        /// </summary>
        [JsonProperty("data_type")]
        public string? DataType { get; set; }

        /// <summary>
        /// The desired external identifier of the resulting activity.
        /// </summary>
        [JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadAPIArgs() : base()
        {

        }

        #endregion
    }
}

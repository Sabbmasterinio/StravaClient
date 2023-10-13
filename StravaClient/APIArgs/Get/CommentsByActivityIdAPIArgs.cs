using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving comments by activity id.
    /// </summary>
    public class CommentsByActivityIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Number of items per page. Defaults to 30.
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Cursor of the last item in the previous page of results,
        /// used to request the subsequent page of results. When 
        /// omitted, the first page of results is fetched.
        /// </summary>
        [JsonProperty("after_cursor")]
        public string? AfterCursor { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CommentsByActivityIdAPIArgs() : base()
        {

        }

        #endregion
    }
}

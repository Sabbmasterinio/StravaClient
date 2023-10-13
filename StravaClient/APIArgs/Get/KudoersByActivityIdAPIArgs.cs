﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving kudoers by activity id.
    /// </summary>
    public class KudoersByActivityIdAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// Page number. Defaults to 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of items per page. Defaults to 30.
        /// </summary>
        [JsonProperty("per_page")]
        public int? PerPage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public KudoersByActivityIdAPIArgs() : base()
        {

        }

        #endregion
    }
}

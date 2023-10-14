using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Represents a page parameters for API arguments.
    /// </summary>
    public class BasePageParameters
    {
        #region Private members

        /// <summary>
        /// The member of <see cref="Page"/> property
        /// </summary>
        private int mPage = 1;

        /// <summary>
        /// The member of <see cref="PerPage"/> property
        /// </summary>
        private int mPerPage = 30;

        #endregion

        #region Public Properties

        /// <summary>
        /// Page number. Defaults to 1.
        /// </summary>
        [JsonProperty("page")]
        public int Page
        {
            get => mPage;
            set => mPage = value;
        }

        /// <summary>
        /// Number of items per page. Defaults to 30.
        /// </summary>
        [JsonProperty("per_page")]
        public int PerPage
        {
            get => mPerPage;
            set => mPerPage = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePageParameters() : base()
        {

        }

        #endregion
    }
}

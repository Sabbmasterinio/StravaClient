using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving logged in athlete starred segments.
    /// </summary>
    public class StarredSegmentsAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StarredSegmentsAPIArgs() : base()
        {

        }

        #endregion
    }
}
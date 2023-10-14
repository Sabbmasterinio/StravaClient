using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving routes by athlete id.
    /// </summary>
    public class RoutesByAthleteIdAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RoutesByAthleteIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
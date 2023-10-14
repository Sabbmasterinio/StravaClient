using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving clubs with logged in athlete.
    /// </summary>
    public class ClubsLoggedInAthleteAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubsLoggedInAthleteAPIArgs() : base()
        {

        }

        #endregion
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving club activities by id.
    /// </summary>
    public class ClubActivitiesByIdAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubActivitiesByIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
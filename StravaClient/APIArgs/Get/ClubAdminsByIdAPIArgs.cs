using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving club admin by id.
    /// </summary>
    public class ClubAdminsByIdAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubAdminsByIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
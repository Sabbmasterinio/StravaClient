using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Arguments used for retrieving members of a club by id.
    /// </summary>
    public class ClubMembersByIdAPIArgs : BasePageParameters
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubMembersByIdAPIArgs() : base()
        {

        }

        #endregion
    }
}
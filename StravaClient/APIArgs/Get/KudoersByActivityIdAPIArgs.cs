using Newtonsoft.Json;
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
    public class KudoersByActivityIdAPIArgs : BasePageParameters
    {
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
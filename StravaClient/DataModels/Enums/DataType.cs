using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Provides enumeration over the file data type.
    /// </summary>
    public enum DataType 
    {
        fit,
        fit.gz,
        tcx,
        tcx.gz,
        gpx,
        gpx.gz
    }
}

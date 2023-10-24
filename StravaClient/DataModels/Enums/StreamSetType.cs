using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// Provides enumeration over the type of a stream set.
    /// </summary>
    public enum StreamSetType
    {
        /// <summary>
        /// Time
        /// </summary>
        Time,

        /// <summary>
        /// Distance
        /// </summary>
        Distance,

        /// <summary>
        /// Coordinates
        /// </summary>
        Coordinates,

        /// <summary>
        /// Altitude
        /// </summary>
        Altitude,

        /// <summary>
        /// Velocity smooth
        /// </summary>
        VelocitySmooth,

        /// <summary>
        /// Heartrate
        /// </summary>
        Heartrate,

        /// <summary>
        /// Cadence
        /// </summary>
        Cadence,

        /// <summary>
        /// Watts
        /// </summary>
        Watts,

        /// <summary>
        /// Temperature
        /// </summary>
        Temperature,

        /// <summary>
        /// Moving
        /// </summary>
        Moving,

        /// <summary>
        /// Grade smooth
        /// </summary>
        GradeSmooth
    }
}

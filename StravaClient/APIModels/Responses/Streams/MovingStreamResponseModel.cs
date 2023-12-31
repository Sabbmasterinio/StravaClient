﻿namespace StravaClient
{
    /// <summary>
    /// Represents a moving stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of moving values for this stream.
    /// </remarks>
    public class MovingStreamResponseModel : BaseEnumerableDataStreamResponseModel<bool>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovingStreamResponseModel() : base()
        {

        }

        #endregion
    }
}
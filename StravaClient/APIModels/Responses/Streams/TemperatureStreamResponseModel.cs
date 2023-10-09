namespace StravaClient
{
    /// <summary>
    /// Represents a temperature stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of temperature values for this stream, in celsius degrees.
    /// </remarks>
    public class TemperatureStreamResponseModel : BaseEnumerableDataStreamResponseModel<int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TemperatureStreamResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}
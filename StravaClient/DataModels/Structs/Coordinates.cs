namespace StravaClient
{
    /// <summary>
    /// Represents a struct of latitude and longitude.
    /// </summary>
    public readonly record struct Coordinates
    {
        #region Public Properties

        /// <summary>
        /// Longitude in decimal degrees.
        /// </summary>
        public double Longitude { get; }

        /// <summary>
        /// Latitude in decimal degrees.
        /// </summary>
        public double Latitude { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="latitude">Longitude in decimal degrees.</param>
        /// <param name="longitude">Latitude in decimal degrees.</param>
        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Latitude: {Latitude}, Longitude: {Longitude}";

        #endregion
    }
}
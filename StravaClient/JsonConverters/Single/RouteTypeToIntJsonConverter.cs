using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="RouteType"/> to a <see cref="int"/>.
    /// </summary>
    public sealed class RouteTypeToIntJsonConverter : BaseEnumToValueJsonConverter<RouteType, int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RouteTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<RouteType, int> GetMapper() => StravaClientConstants.RouteTypeToIntMapper;

        #endregion
    }
}
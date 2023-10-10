using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="RouteSubType"/> to a <see cref="int"/>.
    /// </summary>
    public sealed class RouteSubTypeToIntJsonConverter : BaseEnumToValueJsonConverter<RouteSubType, int>
    {
            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public RouteSubTypeToIntJsonConverter() : base()
            {

            }

            #endregion

            #region Protected Methods

            /// <inheritdoc/>
            protected override IReadOnlyDictionary<RouteSubType, int> GetMapper() => StravaClientConstants.RouteSubTypeToIntMapper;

            #endregion
    }
}



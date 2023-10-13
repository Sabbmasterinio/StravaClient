using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="ActivityZoneType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class ActivityZoneTypeToStringJsonConverter : BaseEnumToValueJsonConverter<ActivityZoneType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityZoneTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ActivityZoneType, string> GetMapper() => StravaClientConstants.ActivityZoneTypeToStringMapper;

        #endregion
    }
}
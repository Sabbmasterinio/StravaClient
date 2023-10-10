using Newtonsoft.Json;
using StravaClient;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting an <see cref="ActivityType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class ActivityTypeToStringJsonConverter : BaseEnumToValueJsonConverter<ActivityType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ActivityType, string> GetMapper() => StravaClientConstants.ActivityTypeToStringMapper;

        #endregion
    }
}
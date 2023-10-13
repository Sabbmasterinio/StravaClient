using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{IEnumerable}"/> that is used for converting a set of <see cref="ActivityType"/>s to a set of <see cref="string"/>s.
    /// </summary>
    public class ActivityTypeEnumerableToStringEnumerableJsonConverter : BaseEnumEnumerableToValuesEnumerableConverter<ActivityType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityTypeEnumerableToStringEnumerableJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ActivityType, string> GetMapper() => StravaClientConstants.ActivityTypeToStringMapper;

        #endregion
    }
}
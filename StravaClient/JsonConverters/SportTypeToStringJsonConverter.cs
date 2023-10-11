using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="SportType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class SportTypeToStringJsonConverter : BaseEnumToValueJsonConverter<SportType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SportTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SportType, string> GetMapper() => StravaClientConstants.SportTypeToStringMapper;

        #endregion
    }
}
using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting an <see cref="ClubType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class ClubTypeToStringJsonConverter : BaseEnumToValueJsonConverter<ClubType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ClubType, string> GetMapper() => StravaClientConstants.ClubTypeToStringMapper;

        #endregion
    }
}
using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting an <see cref="ClubType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class StreamSetTypeToStringJsonConverter : BaseEnumToValueJsonConverter<StreamSetType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StreamSetTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StreamSetType, string> GetMapper() => StravaClientConstants.StreamSetTypeToStringMapper;

        #endregion
    }
}
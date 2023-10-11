using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="StreamResolution"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class StreamResolutionToStringJsonConverter : BaseEnumToValueJsonConverter<StreamResolution, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StreamResolutionToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StreamResolution, string> GetMapper() => StravaClientConstants.StreamResolutionToStringMapper;

        #endregion
    }
}
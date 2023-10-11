using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="StreamSeriesType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class StreamSeriesTypeToStringJsonConverter : BaseEnumToValueJsonConverter<StreamSeriesType, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StreamSeriesTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StreamSeriesType, string> GetMapper() => StravaClientConstants.StreamSeriesTypeToStringMapper;

        #endregion
    }
}
using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="MeasurementPreference"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class MeasurementPreferenceToStringJsonConverter : BaseEnumToValueJsonConverter<MeasurementPreference, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementPreferenceToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementPreference, string> GetMapper() => StravaClientConstants.MeasurementPreferenceToStringMapper;

        #endregion
    }
}
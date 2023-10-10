using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="SegmentActivityType"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class SegmentActivityTypeToStringJsonConverter : BaseEnumToValueJsonConverter<SegmentActivityType, string>
    {
            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public SegmentActivityTypeToStringJsonConverter() : base()
            {

            }

            #endregion

            #region Protected Methods

            /// <inheritdoc/>
            protected override IReadOnlyDictionary<SegmentActivityType, string> GetMapper() => StravaClientConstants.SegmentActivityTypeToStringMapper;

            #endregion
    }
}



using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="Membership"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class MembershipToStringJsonConverter : BaseEnumToValueJsonConverter<Membership, string>
    {
            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public MembershipToStringJsonConverter() : base()
            {

            }

            #endregion

            #region Protected Methods

            /// <inheritdoc/>
            protected override IReadOnlyDictionary<Membership, string> GetMapper() => StravaClientConstants.MembershipToStringMapper;

            #endregion
    }
}



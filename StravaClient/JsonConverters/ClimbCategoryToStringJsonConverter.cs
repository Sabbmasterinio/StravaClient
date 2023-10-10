using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="ClimbCategory"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class ClimbCategoryToStringJsonConverter : BaseEnumToValueJsonConverter<ClimbCategory, string>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClimbCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ClimbCategory, string> GetMapper() => StravaClientConstants.ClimbCategoryToStringMapper;

        #endregion
    }
}



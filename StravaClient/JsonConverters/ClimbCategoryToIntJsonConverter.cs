using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="ClimbCategory"/> to a <see cref="int"/>.
    /// </summary>
    public sealed class ClimbCategoryToIntJsonConverter : BaseEnumToValueJsonConverter<ClimbCategory, int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClimbCategoryToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ClimbCategory, int> GetMapper() => StravaClientConstants.ClimbCategoryToIntMapper;

        #endregion
    }
}
using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="ResourceState"/> to a <see cref="int"/>.
    /// </summary>
    public sealed class ResourceStateToIntJsonConverter : BaseEnumToValueJsonConverter<ResourceState, int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ResourceStateToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ResourceState, int> GetMapper() => StravaClientConstants.ResourceStateToIntMapper;

        #endregion
    }
}
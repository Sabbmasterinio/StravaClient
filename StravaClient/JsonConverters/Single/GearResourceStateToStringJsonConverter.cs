using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="GearResourceState"/> to a <see cref="int"/>.
    /// </summary>
    public sealed class GearResourceStateToIntJsonConverter : BaseEnumToValueJsonConverter<GearResourceState, int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GearResourceStateToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<GearResourceState, int> GetMapper() => StravaClientConstants.GearResourceStateToIntMapper;

        #endregion
    }
}
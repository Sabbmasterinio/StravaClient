using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{

    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="AthleteSex"/> to a <see cref="string"/>.
    /// </summary>
    public sealed class AthleteSexToStringJsonConverter : BaseEnumToValueJsonConverter<AthleteSex, string>
    {
            #region Constructors

            /// <summary>
            /// Default constructor
            /// </summary>
            public AthleteSexToStringJsonConverter() : base()
            {

            }

            #endregion

            #region Protected Methods

            /// <inheritdoc/>
            protected override IReadOnlyDictionary<AthleteSex, string> GetMapper() => StravaClientConstants.AthleteSexToStringMapper;

            #endregion
    }
}
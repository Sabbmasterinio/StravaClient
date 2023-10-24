using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="DateTimeOffset"/> to an <see cref="int"/>.
    /// </summary>
    /// <remarks>
    /// Note that the calculation for the date time is based in seconds since the epoch (1/1/1970).
    /// </remarks>
    public class DateTimeOffsetToIntJsonConverter : JsonConverter<DateTimeOffset>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateTimeOffsetToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DateTimeOffset ReadJson(JsonReader reader, Type objectType, DateTimeOffset existingValue, bool hasExistingValue, JsonSerializer serializer)
        {          
            return DateTimeOffset.FromUnixTimeSeconds(serializer.Deserialize<long>(reader));
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
        
        #endregion
    }
}
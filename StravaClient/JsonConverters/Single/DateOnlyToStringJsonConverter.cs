using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="DateOnly"/> to a <see cref="string"/>.
    /// </summary>
    public class DateOnlyToStringJsonConverter : JsonConverter<DateOnly>
    {
        #region Constants

        /// <summary>
        /// The date format that is used for deserializing and serializing the date value.
        /// </summary>
        public const string DateFormat = "MM/dd/yyyy";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateOnlyToStringJsonConverter() : base()
        {
                
        }

        #endregion

        #region Public Properties

        /// <inheritdoc/>
        public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var s = serializer.Deserialize<string>(reader);

            if (s is null)
                return default;

            return DateOnly.ParseExact(s, DateFormat);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString(DateFormat));
        }

        #endregion
    }
}
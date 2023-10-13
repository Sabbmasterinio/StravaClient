using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{LatitudeAndLongitude}"/> that is used for converting a <see cref="Coordinates?"/> to a <see cref="double[]"/>.
    /// </summary>
    public class CoordinatesToDoubleArrayJsonConverter : JsonConverter<Coordinates?>
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CoordinatesToDoubleArrayJsonConverter() : base()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override Coordinates? ReadJson(JsonReader reader, Type objectType, Coordinates? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<double[]>(reader);

            if (readerValue is null)
                return null;

            return new(readerValue[0], readerValue[1]);
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, Coordinates? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();

                return;
            }
            
            writer.WriteStartArray();
            writer.WriteValue($"{value.Value.Latitude}, {value.Value.Longitude}");
            writer.WriteEndArray();
        } 

        #endregion
    }
}
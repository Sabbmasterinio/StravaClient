using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{LatitudeAndLongitude}"/> that is used for converting a <see cref="IEnumerable{Coordinates}"/> to a <see cref="IEnumerable{double[]}"/>.
    /// </summary>
    public class CoordinatesEnumerableToDoubleArrayEnumerableJsonConverter : JsonConverter<IEnumerable<Coordinates>>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CoordinatesEnumerableToDoubleArrayEnumerableJsonConverter() : base()
        {
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        public override IEnumerable<Coordinates>? ReadJson(JsonReader reader, Type objectType, IEnumerable<Coordinates>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<IEnumerable<double[]>>(reader);

            if (readerValue is null)
                return Enumerable.Empty<Coordinates>();

            var result = new List<Coordinates>();

            foreach (var value in readerValue)
                    result.Add(new Coordinates(value[0], value[1]));

            return result;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, IEnumerable<Coordinates>? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartArray();
            foreach(var item in value)
            {
                writer.WriteStartArray();
                
                writer.WriteValue(item.Latitude);
                writer.WriteValue(item.Longitude);

                writer.WriteEndArray();
            }
            writer.WriteEndArray();
        }

        #endregion
    }
}
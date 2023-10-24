using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{TimeSpan}"/> that is used for converting a <see cref="IEnumerable{TimeSpan}"/> to a <see cref="IEnumerable{int}"/>.
    /// </summary>
    public class TimeSpanEnumerableToIntArrayEnumerableJsonConverter : JsonConverter<IEnumerable<TimeSpan>>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeSpanEnumerableToIntArrayEnumerableJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        public override IEnumerable<TimeSpan>? ReadJson(JsonReader reader, Type objectType, IEnumerable<TimeSpan>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<IEnumerable<int>>(reader);

            if (readerValue is null)
                return Enumerable.Empty<TimeSpan>();

            var result = new List<TimeSpan>();

            foreach (var value in readerValue) 
                result.Add(TimeSpan.FromSeconds(value));

            return result;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, IEnumerable<TimeSpan>? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartArray();
            
            foreach(var item in value)
                writer.WriteValue(item.TotalSeconds);

            writer.WriteEndArray();
        }

        #endregion
    }
}
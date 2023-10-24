using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="TimeSpan"/> to an <see cref="int"/> that represents
    /// the time span in seconds.
    /// </summary>
    public class TimeSpanToIntJsonConverter : JsonConverter<TimeSpan>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeSpanToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return TimeSpan.FromSeconds(serializer.Deserialize<int>(reader));
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            writer.WriteValue(value.TotalSeconds);
        }

        #endregion
    }
}
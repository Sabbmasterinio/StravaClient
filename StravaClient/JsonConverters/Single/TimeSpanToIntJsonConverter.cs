using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <see cref="TimeSpan"/> to an <see cref="int"/> that represents
    /// the time span in seconds.
    /// </summary>
    public class TimeSpanToIntJsonConverter : JsonConverter<TimeSpan>
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
        public TimeSpanToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Public Properties

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

using Newtonsoft.Json;
using System.Linq;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{IEnumerable}"/> that is used for converting set of <typeparamref name="TEnum"/> to a set of <typeparamref name="TValue"/>.
    /// </summary>
    public abstract class BaseEnumEnumerableToValuesEnumerableConverter<TEnum, TValue> : JsonConverter<IEnumerable<TEnum>>
        where TEnum : struct, Enum
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BaseEnumEnumerableToValuesEnumerableConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public sealed override IEnumerable<TEnum> ReadJson(JsonReader reader, Type objectType, IEnumerable<TEnum>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<IEnumerable<TValue>?>(reader);

            if (readerValue is null)
                return Enumerable.Empty<TEnum>();

            var result = new List<TEnum>();

            foreach (var value in readerValue)
                foreach (var item in GetMapper())
                    if (Equals(value, item.Value))
                        result.Add(item.Key);

            return result;
        }

        /// <inheritdoc/>
        public sealed override void WriteJson(JsonWriter writer, IEnumerable<TEnum>? value, JsonSerializer serializer)
        {
            writer.WriteStartArray();

            if (value is not null)
                foreach(var v in value)
                    writer.WriteValue(GetMapper()[v]);

            writer.WriteEndArray();
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets a mapper that maps the enum values to other values.
        /// </summary>
        protected abstract IReadOnlyDictionary<TEnum, TValue> GetMapper();

        #endregion
    }
}
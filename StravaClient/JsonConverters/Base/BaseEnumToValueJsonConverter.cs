using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that is used for converting a <typeparamref name="TEnum"/> to a <typeparamref name="TValue"/>.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TValue">The type of the values that are mapped to the enum values.</typeparam>
    public abstract class BaseEnumToValueJsonConverter<TEnum, TValue> : JsonConverter<TEnum>
        where TEnum : struct, Enum
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseEnumToValueJsonConverter() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<TValue>(reader);

            foreach (var item in GetMapper())
                if (Equals(item.Value, readerValue))
                    return item.Key;

            //throw new InvalidOperationException($"The value '{reader}' is not contained in the {nameof(StravaClientConstants.ResourceStateToIntMapper)}!");
            return default;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, TEnum value, JsonSerializer serializer)
        {
            writer.WriteValue(GetMapper()[value]);
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

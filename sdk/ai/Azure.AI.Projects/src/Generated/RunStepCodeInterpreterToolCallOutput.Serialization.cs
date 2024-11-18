// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    [PersistableModelProxy(typeof(UnknownRunStepCodeInterpreterToolCallOutput))]
    public partial class RunStepCodeInterpreterToolCallOutput : IUtf8JsonSerializable, IJsonModel<RunStepCodeInterpreterToolCallOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunStepCodeInterpreterToolCallOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RunStepCodeInterpreterToolCallOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepCodeInterpreterToolCallOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepCodeInterpreterToolCallOutput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        RunStepCodeInterpreterToolCallOutput IJsonModel<RunStepCodeInterpreterToolCallOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepCodeInterpreterToolCallOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepCodeInterpreterToolCallOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepCodeInterpreterToolCallOutput(document.RootElement, options);
        }

        internal static RunStepCodeInterpreterToolCallOutput DeserializeRunStepCodeInterpreterToolCallOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "image": return RunStepCodeInterpreterImageOutput.DeserializeRunStepCodeInterpreterImageOutput(element, options);
                    case "logs": return RunStepCodeInterpreterLogOutput.DeserializeRunStepCodeInterpreterLogOutput(element, options);
                }
            }
            return UnknownRunStepCodeInterpreterToolCallOutput.DeserializeUnknownRunStepCodeInterpreterToolCallOutput(element, options);
        }

        BinaryData IPersistableModel<RunStepCodeInterpreterToolCallOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepCodeInterpreterToolCallOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepCodeInterpreterToolCallOutput)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepCodeInterpreterToolCallOutput IPersistableModel<RunStepCodeInterpreterToolCallOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepCodeInterpreterToolCallOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepCodeInterpreterToolCallOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepCodeInterpreterToolCallOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepCodeInterpreterToolCallOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RunStepCodeInterpreterToolCallOutput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepCodeInterpreterToolCallOutput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

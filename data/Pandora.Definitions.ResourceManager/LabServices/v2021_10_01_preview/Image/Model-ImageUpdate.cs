using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.LabServices.v2021_10_01_preview.Image
{

    internal class ImageUpdateModel
    {
        [JsonPropertyName("properties")]
        public ImageUpdatePropertiesModel? Properties { get; set; }
    }
}

using System;
using System.Text.Json.Serialization;

namespace Destiny.Config
{
    public struct ImagePyramidEntry
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("factor")]
        public float Factor { get; set; }
    }
}
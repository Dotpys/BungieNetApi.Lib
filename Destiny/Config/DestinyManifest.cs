using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Destiny.Config
{

    public struct DestinyManifest
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("mobileAssetContentPath")]
        public string MobileAssetContentPath { get; set; }

        [JsonPropertyName("mobileGearAssetDataBases")]
        public GearAssetDataBaseDefinition[] MobileGearAssetDataBases { get; set; }

        [JsonPropertyName("mobileWorldContentPaths")]
        public Dictionary<string, string> MobileWorldContentPaths { get; set; }

        [JsonPropertyName("jsonWorldContentPaths")]
        public Dictionary<string, string> JsonWorldContentPaths { get; set; }

        [JsonPropertyName("jsonWorldComponentContentPaths")]
        public Dictionary<string, object> JsonWorldComponentContentPaths { get; set; }

        [JsonPropertyName("jsonWorldClanBannerDatabasePath")]
        public string JsonWorldClanBannerDatabasePath { get; set; }

        [JsonPropertyName("mobileGearCDN")]
        public Dictionary<string, string> MobileGearCDN { get; set; }

        [JsonPropertyName("iconImagePyramidInfo")]
        public ImagePyramidEntry[] IconImagePyramidInfo { get; set; }
    }
}
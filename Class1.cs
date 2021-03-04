using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieNetApi.Lib
{
    public class BungieCore
    {
        public const string HOST = "https://www.bungie.net/Platform";

        public static async Task Test(string apikey) {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("X-API_Key", apikey);

            var response = await hc.GetAsync(HOST + "/Destiny2/Manifest/");
            string content = await response.Content.ReadAsStringAsync();

            var t = JsonSerializer.Deserialize<BungieResponse<Destiny.Config.DestinyManifest>>(content);

            System.IO.File.WriteAllText("manifest.json", JsonSerializer.Serialize<Destiny.Config.DestinyManifest>(t.Response, new JsonSerializerOptions() {WriteIndented = true}));
        }
    }

    public struct BungieResponse<T>
    {
        public T Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string> MessageData { get; set; }
        public string DetailedErrorTrace { get; set; }
    }
}

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

    public struct GearAssetDataBaseDefinition
    {
        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }
    }

    public struct ImagePyramidEntry
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("factor")]
        public float Factor { get; set; }
    }
}

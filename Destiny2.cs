using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Destiny.Config;

namespace BungieNetApi
{
    public class Destiny2
    {
        public const string HOST = "https://www.bungie.net";

        public static async Task<DestinyManifest?> GetDestinyManifest(HttpClient httpClient, string apiKey)
        {
            if (!httpClient.DefaultRequestHeaders.Contains("X-API-Key"))
            {
                httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            }
            HttpResponseMessage response = await httpClient.GetAsync(HOST + "/Platform/Destiny2/Manifest/");
            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                var bungieResponse = JsonSerializer.Deserialize<BungieResponse<DestinyManifest>>(jsonContent);
                return bungieResponse.Response;
            }
            return null;
        }
    }
}
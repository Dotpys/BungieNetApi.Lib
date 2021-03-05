using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BungieNetApi.Converters;
using BungieNetApi.Entities.Destiny.Config;
using BungieNetApi.Entities.User;

namespace BungieNetApi
{
    public class Destiny2
    {
        public const string HOST = "https://www.bungie.net";

        public static async Task<DestinyManifest?> GetDestinyManifestAsync(HttpClient httpClient, string apiKey)
        {
            if (!httpClient.DefaultRequestHeaders.Contains("X-API-Key"))
                httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            string requestUri = $"{HOST}/Platform/Destiny2/Manifest/";
            var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyManifest>>(requestUri);
            return response.Response;
        }

        public static async Task<ICollection<UserInfoCard>> SearchDestinyPlayer(HttpClient httpClient, string apiKey, string displayName, int membershipType, bool returnOriginalProfile=false)
        {
            if (!httpClient.DefaultRequestHeaders.Contains("X-API-Key"))
                httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
            string requestUri = $"{HOST}/Platform/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}?returnOriginalProfile={returnOriginalProfile}";
            var jsonOptions = new JsonSerializerOptions()
            {
                Converters =
                {
                    new LongConverter()
                }
            };
            var response = await httpClient.GetFromJsonAsync<BungieResponse<ICollection<UserInfoCard>>>(requestUri, jsonOptions);
            return response.Response;
        }
    }
}
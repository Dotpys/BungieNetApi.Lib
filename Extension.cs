using System.Net.Http;

namespace BungieNetApi
{
	public static class ExtensionMethods
	{
		public static void EnsureApiKey(this HttpClient httpClient, string apiKey)
		{
			if (!httpClient.DefaultRequestHeaders.Contains("X-API-Key"))
				httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
		}
	}
}
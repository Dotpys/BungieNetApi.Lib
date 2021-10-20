using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BungieNetApi.Entities.Config;
using BungieNetApi.Entities.User;
using BungieNetApi.Entities.User.Models;

namespace BungieNetApi
{
	public class User
	{
		/// <summary>
		/// Loads a bungienet user by membership id.
		/// </summary>
		/// <param name="httpClient">The http client that will be used to make the actual request.</param>
		/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
		/// <param name="id">The requested Bungie.net membership id.</param>
		public static async Task<GeneralUser> GetBungieNetUserByIdAsync(HttpClient httpClient, string apiKey, long id)
		{
			httpClient.EnsureApiKey(apiKey);
			string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/User/GetBungieNetUserById/{id}/";
			var response = await httpClient.GetFromJsonAsync<BungieResponse<GeneralUser>>(requestUri, StaticData.bungieApiJsonConverter);
			return response.Response;
		}

		/// <summary>
		/// Returns a list of possible users based on the search string
		/// </summary>
		/// <param name="httpClient">The http client that will be used to make the actual request.</param>
		/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
		/// <param name="query">The search string.</param>
		public static async Task<GeneralUser[]> SearchUsersAsync(HttpClient httpClient, string apiKey, string query)
		{
			httpClient.EnsureApiKey(apiKey);
			string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/User/SearchUsers/?q={query}";
			var response = await httpClient.GetFromJsonAsync<BungieResponse<GeneralUser[]>>(requestUri, StaticData.bungieApiJsonConverter);
			return response.Response;
		}

		/// <summary>
		/// Returns a list of credential types attached to the requested account
		/// </summary>
		/// <param name="httpClient">The http client that will be used to make the actual request.</param>
		/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
		/// <param name="membershipId">The user's membership id</param>
		public static async Task<GetCredentialTypesForAccountResponse> GetCredentialTypesForTargetAccountAsync(HttpClient httpClient, string apiKey, long membershipId)
		{
			httpClient.EnsureApiKey(apiKey);
			string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/User/GetCredentialTypesForTargetAccount/{membershipId}/";
			var response = await httpClient.GetFromJsonAsync<BungieResponse<GetCredentialTypesForAccountResponse>>(requestUri, StaticData.bungieApiJsonConverter);
			return response.Response;
		}

		/// <summary>
		/// Returns a list of all available user themes.
		/// </summary>
		/// <param name="httpClient">The http client that will be used to make the actual request.</param>
		/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
		public static async Task<UserTheme[]> GetAvailableThemesAsync(HttpClient httpClient, string apiKey)
		{
			httpClient.EnsureApiKey(apiKey);
			string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/User/GetAvailableThemes/";
			var response = await httpClient.GetFromJsonAsync<BungieResponse<UserTheme[]>>(requestUri, StaticData.bungieApiJsonConverter);
			return response.Response;
		}

		/// <summary>
		/// Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
		/// </summary>
		/// <param name="httpClient">The http client that will be used to make the actual request.</param>
		/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
		/// <param name="membershipId">The membership ID of the target user.</param>
		/// <param name="membershipType">Type of the supplied membership ID. The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.</param>
		public static async Task<UserMembershipData> GetMembershipDataByIdAsync(HttpClient httpClient, string apiKey, long membershipId, int membershipType)
		{
			httpClient.EnsureApiKey(apiKey);
			string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/User/GetMembershipsById/{membershipId}/{membershipType}/";
			var response = await httpClient.GetFromJsonAsync<BungieResponse<UserMembershipData>>(requestUri, StaticData.bungieApiJsonConverter);
			return response.Response;
		}
	}
}
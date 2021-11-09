using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BungieNetApi.Entities;
using BungieNetApi.Entities.Destiny;
using BungieNetApi.Entities.Destiny.Config;
using BungieNetApi.Entities.Destiny.Definitions;
using BungieNetApi.Entities.Destiny.Responses;
using BungieNetApi.Entities.User;

using System.Linq;

namespace BungieNetApi;

public class Destiny2
{
	/// <summary>
	/// Returns the current version of the manifest as a json object.
	/// </summary>
	/// <param name="httpClient">The http client that will be used to make the actual request.</param>
	/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
	public static async Task<DestinyManifest> GetDestinyManifestAsync(HttpClient httpClient, string apiKey)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/Manifest/";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyManifest>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}

	/// <summary>
	/// Returns the static definition of an entity of the given Type and hash identifier.
	/// Examine the API Documentation for the Type Names of entities that have their own definitions.
	/// Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found.
	/// Please don't use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.
	/// </summary>
	/// <param name="httpClient">The http client that will be used to make the actual request.</param>
	/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
	/// <param name="entityType">The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param>
	/// <param name="hashIdentifier">The hash identifier for the specific Entity you want returned.</param>
	public static async Task<DestinyDefinition> GetDestinyEntityDefinitionAsync(HttpClient httpClient, string apiKey, string entityType, uint hashIdentifier)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/Manifest/{entityType}/{hashIdentifier}/";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyDefinition>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}

	/// <summary>
	/// Returns a list of Destiny memberships given a full Gamertag or PSN ID. Unless you pass returnOriginalProfile=true, this will return membership information for the users' Primary Cross Save Profile if they are engaged in cross save rather than any original Destiny profile that is now being overridden.
	/// </summary>
	/// <param name="httpClient">The http client that will be used to make the actual request.</param>
	/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
	/// <param name="displayName">The full gamertag or PSN id of the player. Spaces and case are ignored.</param>
	/// <param name="membershipType">A valid non-BungieNet membership type, or All. The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.</param>
	/// <param name="returnOriginalProfile">(optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile.</param>
	public static async Task<ICollection<UserInfoCard>> SearchDestinyPlayerAsync(HttpClient httpClient, string apiKey, string displayName, BungieMembershipType membershipType, bool returnOriginalProfile=false)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/?returnOriginalProfile={returnOriginalProfile}";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<ICollection<UserInfoCard>>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}

	/// <summary>
	/// Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.
	/// </summary>
	/// <param name="httpClient">The http client that will be used to make the actual request.</param>
	/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
	/// <param name="membershipId">The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don't pass us a PSN membership ID and the XBox membership type, it's not going to work!</param>
	/// <param name="membershipType">The type for the membership whose linked Destiny accounts you want returned. The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.</param>
	/// <param name="getAllMemberships">(optional) if set to 'true', all memberships regardless of whether they're obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what.</param>
	public static async Task<DestinyLinkedProfilesResponse> GetLinkedProfilesAsync(HttpClient httpClient, string apiKey, long membershipId, BungieMembershipType membershipType, bool getAllMemberships=false)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/{(int)membershipType}/Profile/{membershipId}/LinkedProfiles/?getAllMemberships={getAllMemberships}";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyLinkedProfilesResponse>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}

	/// <summary>
	/// Returns Destiny Profile information for the supplied membership.
	/// </summary>
	/// <param name="httpClient">The http client that will be used to make the actual request.</param>
	/// <param name="apiKey">The api key used to authenticate the app to the Bungie.net platform.</param>
	/// <param name="destinyMembershipId">Destiny membership ID.</param>
	/// <param name="membershipType">A valid non-BungieNet membership type.</param>
	/// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
	public static async Task<DestinyProfileResponse> GetProfileAsync(HttpClient httpClient, string apiKey, long destinyMembershipId, BungieMembershipType membershipType, DestinyComponentType[] components)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/{(int)membershipType}/Profile/{destinyMembershipId}/?components={string.Join(',', components.Select( c => (int)c))}";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyProfileResponse>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}

	public static async Task<DestinyItemResponse> GetItemAsync(HttpClient httpClient, string apiKey, long destinyMembershipId, long itemInstanceId, BungieMembershipType membershipType, DestinyComponentType[] components)
	{
		httpClient.EnsureApiKey(apiKey);
		string requestUri = $"{StaticData.BUNGIE_NET_ENDPOINT}/Platform/Destiny2/{(int)membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/?components={string.Join(',', components.Select(c => (int)c))}";
		var response = await httpClient.GetFromJsonAsync<BungieResponse<DestinyItemResponse>>(requestUri, StaticData.bungieApiJsonConverter);
		return response.Response;
	}
}
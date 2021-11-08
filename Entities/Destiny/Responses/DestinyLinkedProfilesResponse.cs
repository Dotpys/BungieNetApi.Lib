using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.User;

namespace BungieNetApi.Entities.Destiny.Responses;

/// <summary>
/// This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose.
/// </summary>
public struct DestinyLinkedProfilesResponse
{
	/// <summary>
	/// Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)
	/// </summary>
	[JsonPropertyName("profiles")]
	public DestinyProfileUserInfoCard[] Profiles { get; set; }

	/// <summary>
	/// If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.
	/// </summary>
	[JsonPropertyName("bnetMembership")]
	public UserInfoCard BnetMembership { get; set; }

	/// <summary>
	/// This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.
	/// </summary>
	[JsonPropertyName("profilesWithErrors")]
	public DestinyErrorProfile[] ProfilesWithErrors { get; set; }
}
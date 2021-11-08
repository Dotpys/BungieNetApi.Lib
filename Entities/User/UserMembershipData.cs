using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.GroupsV2;

namespace BungieNetApi.Entities.User;

public class UserMembershipData
{
	/// <summary>
	/// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
	/// </summary>
	[JsonPropertyName("destinyMemberships")]
	public GroupUserInfoCard[] DestinyMemberships { get; set; }

	/// <summary>
	/// If this property is populated, it will have the membership ID of the account considered to be "primary" in this user's cross save relationship.
	/// If null, this user has no cross save relationship, nor primary account.
	/// </summary>
	[JsonPropertyName("primaryMembershipId")]
	public long? PrimaryMembershipId { get; set; }

	[JsonPropertyName("bungieNetUser")]
	public GeneralUser BungieNetUser { get; set; }
}
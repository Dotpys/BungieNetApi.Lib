using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Inventory;

namespace BungieNetApi.Entities.Destiny.Responses;

public struct DestinyProfileUserInfoCard
{
	[JsonPropertyName("dateLastPlayed")]
	public DateTime DateLastPlayed { get; set; }

	/// <summary>
	/// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.
	/// </summary>
	[JsonPropertyName("isOverridden")]
	public bool IsOverridden { get; set; }

	/// <summary>
	/// If true, this account is hooked up as the "Primary" cross save account for one or more platforms.
	/// </summary>
	[JsonPropertyName("isCrossSavePrimary")]
	public bool IsCrossSavePrimary { get; set; }

	/// <summary>
	/// This is the silver available on this Profile across any platforms on which they have purchased silver. This is only available if you are requesting yourself
	/// </summary>
	[JsonPropertyName("platformSilver")]
	public DestinyPlatformSilverComponent PlatformSilver { get; set; }

	/// <summary>
	/// This is the silver available on this Profile across any platforms on which they have purchased silver. This is only available if you are requesting yourself
	/// </summary>
	[JsonPropertyName("unpairedGameVersions")]
	public DestinyGameVersions UnpairedGameVersions { get; set; }
	
	/// <summary>
	/// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
	/// </summary>
	[JsonPropertyName("supplementalDisplayName")]
	public string SupplementalDisplayName { get; set; }

	/// <summary>
	/// URL the Icon if available.
	/// </summary>
	[JsonPropertyName("iconPath")]
	public string IconPath { get; set; }

	/// <summary>
	/// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
	/// </summary>
	[JsonPropertyName("crossSaveOverride")]
	public int CrossSaveOverride { get; set; }

	/// <summary>
	/// The list of Membership Types indicating the platforms on which this Membership can be used.
	/// Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list
	/// </summary>
	[JsonPropertyName("applicableMembershipTypes")]
	public int[] ApplicableMembershipTypes { get; set; }

	/// <summary>
	/// If True, this is a public user membership.
	/// </summary>
	[JsonPropertyName("isPublic")]
	public bool IsPublic { get; set; }

	/// <summary>
	/// Type of the membership. Not necessarily the native type.
	/// </summary>
	[JsonPropertyName("membershipType")]
	public int MembershipType { get; set; }

	/// <summary>
	/// Membership ID as they user is known in the Accounts service
	/// </summary>
	[JsonPropertyName("membershipId")]
	public long MembershipId { get; set; }

	/// <summary>
	/// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
	/// </summary>
	[JsonPropertyName("displayName")]
	public string DisplayName { get; set; }
}
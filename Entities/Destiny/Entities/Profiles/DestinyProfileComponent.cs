using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Vendors;
using BungieNetApi.Entities.User;

namespace BungieNetApi.Entities.Destiny.Entities.Profiles;

/// <summary>
/// The most essential summary information about a Profile (in Destiny 1, we called these "Accounts").
/// </summary>
public struct DestinyProfileComponent
{
	/// <summary>
	/// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
	/// </summary>
	[JsonPropertyName("userInfo")]
	public UserInfoCard UserInfo { get; set; }

	/// <summary>
	/// The last time the user played with any character on this Profile.
	/// </summary>
	[JsonPropertyName("dateLastPlayed")]
	public DateTime DateLastPlayed { get; set; }

	/// <summary>
	/// If you want to know what expansions they own, this will contain that data.
	/// </summary>
	[JsonPropertyName("versionsOwned")]
	public DestinyGameVersions VersionsOwned { get; set; }

	/// <summary>
	/// A list of the character IDs, for further querying on your part.
	/// </summary>
	[JsonPropertyName("characterIds")]
	public long[] CharacterIds { get; set; }

	/// <summary>
	/// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.Seasons.DestinySeasonDefinition</remarks>
	[JsonPropertyName("seasonHashes")]
	public uint[] SeasonHashes { get; set; }

	/// <summary>
	/// If populated, this is a reference to the season that is currently active.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.Seasons.DestinySeasonDefinition</remarks>
	[JsonPropertyName("currentSeasonHash")]
	public uint? CurrentSeasonHash { get; set; }

	/// <summary>
	/// If populated, this is the reward power cap for the current season.
	/// </summary>
	[JsonPropertyName("currentSeasonRewardPowerCap")]
	public int? CurrentSeasonRewardPowerCap { get; set; }
}
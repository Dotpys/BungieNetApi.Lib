using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Profiles;

/// <summary>
/// This is some bare minimum information about a party member in a Fireteam. Unfortunately, without great computational expense on our side we can only get at the data contained here. I'd like to give you a character ID for example, but we don't have it. But we do have these three pieces of information. May they help you on your quest to show meaningful data about current Fireteams.
/// Notably, we don't and can't feasibly return info on characters. If you can, try to use just the data below for your UI and purposes. Only hit us with further queries if you absolutely must know the character ID of the currently playing character. Pretty please with sugar on top.
/// </summary>
public struct DestinyProfileTransitoryPartyMember
{
	[JsonPropertyName("membershipId")]
	public long membershipId { get; set; }

	[JsonPropertyName("emblemHash")]
	public uint EmblemHash { get; set; }

	[JsonPropertyName("displayName")]
	public string DisplayName { get; set; }

	[JsonPropertyName("status")]
	public int Status { get; set; }
}
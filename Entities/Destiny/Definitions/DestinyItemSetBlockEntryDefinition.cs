using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemSetBlockEntryDefinition
{
	[JsonPropertyName("trackingValue")]
	public int TrackingValue { get; set; }

	[JsonPropertyName("itemHash")]
	public uint ItemHash { get; set; }
}


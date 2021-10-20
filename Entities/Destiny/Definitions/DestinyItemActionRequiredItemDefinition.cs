using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemActionRequiredItemDefinition
{
	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("itemHash")]
	public uint ItemHash { get; set; }

	[JsonPropertyName("deleteOnAction")]
	public bool DeleteOnAction { get; set; }
}

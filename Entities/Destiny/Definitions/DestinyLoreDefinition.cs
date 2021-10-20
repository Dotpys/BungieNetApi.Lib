using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// These are definitions for in-game "Lore," meant to be narrative enhancements of the game experience.
/// </summary>
public class DestinyLoreDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("subtitle")]
	public string Subtitle { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}


using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyDestinationDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("placeHash")]
	public uint PlaceHash { get; set; }

	[JsonPropertyName("defaultFreeroamActivityHash")]
	public uint DefaultFreeroamActivityHash { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("activityGraphEntries")]
	//public DestinyActivityGraphListEntryDefinition[] ActivityGraphEntries { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("bubbleSettings")]
	//public DestinyDestinationBubbleSettingDefinition[] BubbleSettings { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("bubbles")]
	//public DestinyBubbleDefinition[] Bubbles { get; set; }
}

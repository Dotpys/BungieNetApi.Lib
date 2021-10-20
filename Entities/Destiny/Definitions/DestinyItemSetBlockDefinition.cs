using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemSetBlockDefinition
{
	[JsonPropertyName("itemList")]
	public DestinyItemSetBlockEntryDefinition[] ItemList { get; set; }

	[JsonPropertyName("requireOrderedSetItemAdd")]
	public bool RequireOrderedSetItemAdd { get; set; }

	[JsonPropertyName("setIsFeatured")]
	public bool SetIsFeatured { get; set; }

	[JsonPropertyName("setType")]
	public string SetType { get; set; }

	[JsonPropertyName("questLineName")]
	public string QuestLineName { get; set; }

	[JsonPropertyName("questLineDescription")]
	public string QuestLineDescription { get; set; }

	[JsonPropertyName("questStepSummary")]
	public string QuestStepSummary { get; set; }
}


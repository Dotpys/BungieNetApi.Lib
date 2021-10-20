using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions

public class DestinyProgressionRewardDefinition
{
	[JsonPropertyName("progressionMappingHash")]
	public uint ProgressionMappingHash { get; set; }

	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	[JsonPropertyName("applyThrottles")]
	public bool ApplyThrottles { get; set; }
}


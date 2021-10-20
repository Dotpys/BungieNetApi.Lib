using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyInventoryItemStatDefinition
{
	[JsonPropertyName("statHash")]
	public uint StatHash { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }

	[JsonPropertyName("minimum")]
	public int Minimum { get; set; }

	[JsonPropertyName("maximum")]
	public int Maximum { get; set; }

	[JsonPropertyName("displayMaximum")]
	public uint? DisplayMaximum { get; set; }
}

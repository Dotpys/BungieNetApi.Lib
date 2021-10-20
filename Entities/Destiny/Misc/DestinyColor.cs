using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Misc;

public class DestinyColor
{
	[JsonPropertyName("red")]
	public byte Red { get; set; }

	[JsonPropertyName("green")]
	public byte Green { get; set; }

	[JsonPropertyName("blue")]
	public byte Blue { get; set; }

	[JsonPropertyName("alpha")]
	public byte Alpha { get; set; }
}
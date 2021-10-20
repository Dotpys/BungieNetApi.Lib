using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions.Common;

public class DestinyIconSequenceDefinition
{
	[JsonPropertyName("frames")]
	public string[] Frames { get; set; }
}
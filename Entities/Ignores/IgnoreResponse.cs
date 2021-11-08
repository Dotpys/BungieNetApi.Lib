using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Ignores;

public class IgnoreResponse
{
	[JsonPropertyName("isIgnored")]
	public bool IsIgnored { get; set; }
		
	[JsonPropertyName("ignoreFlags")]
	public int IgnoreFlags { get; set; }
}
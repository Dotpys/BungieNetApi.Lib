using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Lib.Entities;

internal abstract class DictionaryComponentResponses<T>
{
	[JsonPropertyName("data")]
	public Dictionary<long, T> Data { get; set; }

	[JsonPropertyName("privacy")]
	public int Privacy { get; set; }

	[JsonPropertyName("disabled")]
	public bool? Disabled { get; set; }
}
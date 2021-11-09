using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities;

public abstract class DestinyComponent
{
	[JsonPropertyName("privacy")]
	public int Privacy { get; set; }

	[JsonPropertyName("disabled")]
	public bool? Disabled { get; set; }
}

public class SingleDestinyComponent<T> : DestinyComponent
{
	[JsonPropertyName("data")]
	public T Data { get; set; }
}

public class DictionaryDestinyComponent<K, V> : DestinyComponent
{
	[JsonPropertyName("data")]
	public Dictionary<K, V> Data { get; set; }
}
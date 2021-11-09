using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

public class DestinyStat
{
	[JsonPropertyName("statHash")]
	public uint StatHash { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }
}

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

public struct DyeReference
{
	[JsonPropertyName("channelHash")]
	public uint ChannelHash { get; set; }

	[JsonPropertyName("dyeHash")]
	public uint DyeHash { get; set; }
}

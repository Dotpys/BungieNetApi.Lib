using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyMaterialRequirement
{
	[JsonPropertyName("itemHash")]
	public uint ItemHash { get; set; }

	[JsonPropertyName("deleteOnAction")]
	public bool DeleteOnAction { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("omitFromRequirements")]
	public bool OmitFromRequirements { get; set; }
}

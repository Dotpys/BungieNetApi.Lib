using BungieNetApi.Entities.Destiny.Entities.Items;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Responses;

public class DestinyItemResponse
{
	[JsonPropertyName("characterId")]
	public long? CharacterId { get; set; }

	[JsonPropertyName("item")]
	public SingleDestinyComponent<DestinyItemComponent> Item { get; set; }

	//TODO: Add missing properties.

	[JsonPropertyName("renderData")]
	public SingleDestinyComponent<DestinyItemRenderComponent> RenderData { get; set; }
}
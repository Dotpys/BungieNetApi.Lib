using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Responses;

public class DestinyItemResponse
{
	[JsonPropertyName("characterId")]
	public long? CharacterId { get; set; }

	[JsonPropertyName("item")]
	public SingleComponentResponseOfDestinyItemComponent Item { get; set; }

	//TODO: Add missing properties.

	[JsonPropertyName("renderData")]
	public SingleComponentResponseOfDestinyItemRenderComponent RenderData { get; set; }
}
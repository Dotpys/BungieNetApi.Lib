using BungieNetApi.Entities.Destiny.Entities.Items;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities
{
	public class SingleComponentResponseOfDestinyItemRenderComponent
	{
		[JsonPropertyName("data")]
		public DestinyItemRenderComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
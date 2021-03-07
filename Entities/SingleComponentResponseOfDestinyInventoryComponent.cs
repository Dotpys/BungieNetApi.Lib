using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Entities.Inventory;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyInventoryComponent
	{
		[JsonPropertyName("data")]
		public DestinyInventoryComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Inventory;
using BungieNetApi.Entities.Destiny.Entities.Inventory;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyPlatformSilverComponent
	{
		[JsonPropertyName("data")]
		public DestinyPlatformSilverComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
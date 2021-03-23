using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Collectibles;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyProfileCollectiblesComponent
	{
		[JsonPropertyName("data")]
		public DestinyProfileCollectiblesComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
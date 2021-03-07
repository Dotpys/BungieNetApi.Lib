using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Kiosks;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyKiosksComponent
	{
		[JsonPropertyName("data")]
		public DestinyKiosksComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
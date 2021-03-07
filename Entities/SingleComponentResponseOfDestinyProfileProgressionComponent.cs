using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Profiles;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyProfileProgressionComponent
	{
		[JsonPropertyName("data")]
		public DestinyProfileProgressionComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
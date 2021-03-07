using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Entities.Profiles;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyProfileComponent
	{
		[JsonPropertyName("data")]
		public DestinyProfileComponent? Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
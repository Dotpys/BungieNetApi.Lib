using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.Records;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyProfileRecordsComponent
	{
		[JsonPropertyName("data")]
		public DestinyProfileRecordsComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
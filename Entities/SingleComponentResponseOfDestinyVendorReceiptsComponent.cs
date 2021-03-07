using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Profiles;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyVendorReceiptsComponent
	{
		[JsonPropertyName("data")]
		public DestinyVendorReceiptsComponent? Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
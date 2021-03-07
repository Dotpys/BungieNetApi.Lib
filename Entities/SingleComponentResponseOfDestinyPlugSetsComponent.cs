using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Components.PlugSets;

namespace BungieNetApi.Entities
{
	public struct SingleComponentResponseOfDestinyPlugSetsComponent
	{
		[JsonPropertyName("data")]
		public DestinyPlugSetsComponent Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
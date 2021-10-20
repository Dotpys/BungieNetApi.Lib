using BungieNetApi.Entities.Destiny.Entities.Items;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities
{
	public class SingleComponentResponseOfDestinyItemComponent
	{
		[JsonPropertyName("data")]
		public Dictionary<long, DestinyItemComponent> Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}

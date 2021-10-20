using BungieNetApi.Entities.Destiny.Entities.Inventory;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities
{
	public class DictionaryComponentResponseOfint64AndDestinyInventoryComponent
	{
		[JsonPropertyName("data")]
		public Dictionary<long, DestinyInventoryComponent> Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}
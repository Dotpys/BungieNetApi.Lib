using BungieNetApi.Entities.Destiny.Entities.Characters;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities
{
	public class DictionaryComponentResponseOfint64AndDestinyCharacterComponent
	{
		[JsonPropertyName("data")]
		public Dictionary<long, DestinyCharacterComponent> Data { get; set; }

		[JsonPropertyName("privacy")]
		public int Privacy { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }
	}
}

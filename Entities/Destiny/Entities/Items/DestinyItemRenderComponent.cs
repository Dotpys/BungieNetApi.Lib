using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Entities.Items
{
	public class DestinyItemRenderComponent
	{
		[JsonPropertyName("useCustomDyes")]
		public bool UseCustomDyes { get; set; }

		[JsonPropertyName("artRegions")]
		public Dictionary<int, int> ArtRegions { get; set; }
	}
}

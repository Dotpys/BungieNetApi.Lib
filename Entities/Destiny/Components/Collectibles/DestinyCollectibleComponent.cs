using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Collectibles
{
	public class DestinyCollectibleComponent
	{
		[JsonPropertyName("state")]
		public int State { get; set; }
	}
}
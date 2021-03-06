using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Config
{
	public struct GearAssetDataBaseDefinition
	{
		[JsonPropertyName("version")]
		public int Version { get; set; }

		[JsonPropertyName("path")]
		public string Path { get; set; }
	}
}
using BungieNetApi.Entities.Destiny.Quests;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Items;

public class DestinyItemPlugComponent
{
	[JsonPropertyName("plugObjectives")]
	public DestinyObjectiveProgress[] PlugObjectives { get; set; }

	[JsonPropertyName("plugItemHash")]
	public uint PlugItemHash { get; set; }

	[JsonPropertyName("canInsert")]
	public bool CanInsert { get; set; }

	[JsonPropertyName("enabled")]
	public bool Enabled { get; set; }

	[JsonPropertyName("insertFailIndexes")]
	public int[] InsertFailIndexes { get; set; }

	[JsonPropertyName("enableFailIndexes")]
	public int[] EnableFailIndexes { get; set; }
}
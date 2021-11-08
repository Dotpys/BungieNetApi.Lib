using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

/// <summary>
/// Represents a season and the number of resets you had in that season.
/// We do not necessarily - even for progressions with resets - track it over all seasons. So be careful and check the season numbers being returned.
/// </summary>
public struct DestinyProgressionResetEntry
{
	[JsonPropertyName("season")]
	public int Season { get; set; }

	[JsonPropertyName("resets")]
	public int Resets { get; set; }
}

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

public class DestinyTalentNodeStatBlock
{
	[JsonPropertyName("currentStepStats")]
	public DestinyStat[] CurrentStepStats { get; set; }

	[JsonPropertyName("nextStepStats")]
	public DestinyStat[] NextStepStats { get; set; }
}

using BungieNetApi.Entities.Destiny.Quests;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Challenges;

public class DestinyChallengeStatus
{
	[JsonPropertyName("objective")]
	public DestinyObjectiveProgress Objective { get; set; }
}

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Constants;

public class DestinyEnvironmentLocationMapping
{
	[JsonPropertyName("locationHash")]
	public uint LocationHash { get; set; }

	[JsonPropertyName("activationSource")]
	public string ActivationSource { get; set; }

	[JsonPropertyName("itemHash")]
	public uint? ItemHash { get; set; }

	[JsonPropertyName("objectiveHash")]
	public uint? ObjectiveHash { get; set; }

	[JsonPropertyName("activityHash")]
	public uint? ActivityHash { get; set; }
}

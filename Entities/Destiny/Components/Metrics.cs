using BungieNetApi.Entities.Destiny.Quests;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Metrics;

public class DestinyMetricsComponent
{
	[JsonPropertyName("metrics")]
	public Dictionary<uint, DestinyMetricComponent> Metrics { get; set; }

	[JsonPropertyName("metricsRootNodeHash")]
	public uint MetricsRootNodeHash { get; set; }
}

public class DestinyMetricComponent
{
	[JsonPropertyName("invisible")]
	public bool Invisible { get; set; }

	[JsonPropertyName("objectiveProgress")]
	public DestinyObjectiveProgress ObjectiveProgress { get; set; }
}

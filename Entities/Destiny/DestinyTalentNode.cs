using BungieNetApi.Entities.Destiny.Definitions;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

public class DestinyTalentNode
{
	[JsonPropertyName("nodeIndex")]
	public int NodeIndex { get; set; }

	[JsonPropertyName("nodeHash")]
	public uint NodeHash { get; set; }

	[JsonPropertyName("state")]
	public int State { get; set; }

	[JsonPropertyName("isActivated")]
	public bool IsActivated { get; set; }

	[JsonPropertyName("stepIndex")]
	public int StepIndex { get; set; }

	[JsonPropertyName("materialsToUpgrade")]
	public DestinyMaterialRequirement[] MaterialsToUpgrade { get; set; }

	[JsonPropertyName("activationGridLevel")]
	public int ActivationGridLevel { get; set; }

	[JsonPropertyName("progressPercent")]
	public float ProgressPercent { get; set; }

	[JsonPropertyName("hidden")]
	public bool Hidden { get; set; }

	[JsonPropertyName("nodeStatsBlock")]
	public DestinyTalentNodeStatBlock NodeStatsBlock { get; set; }
}

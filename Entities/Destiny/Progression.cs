using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Progression;

public class DestinyFactionProgression
{
	[JsonPropertyName("factionHash")]
	public uint FactionHash { get; set; }

	[JsonPropertyName("factionVendorIndex")]
	public int FactionVendorIndex { get; set; }

	[JsonPropertyName("progressionHash")]
	public uint ProgressionHash { get; set; }

	[JsonPropertyName("dailyProgress")]
	public int DailyProgress { get; set; }

	[JsonPropertyName("dailyLimit")]
	public int DailyLimit { get; set; }

	[JsonPropertyName("weeklyProgress")]
	public int WeeklyProgress { get; set; }

	[JsonPropertyName("weeklyLimit")]
	public int WeeklyLimit { get; set; }

	[JsonPropertyName("currentProgress")]
	public int CurrentProgress { get; set; }

	[JsonPropertyName("level")]
	public int Level { get; set; }

	[JsonPropertyName("levelCap")]
	public int LevelCap { get; set; }

	[JsonPropertyName("stepIndex")]
	public int StepIndex { get; set; }

	[JsonPropertyName("progressToNextLevel")]
	public int ProgressToNextLevel { get; set; }

	[JsonPropertyName("nextLevelAt")]
	public int NextLevelAt { get; set; }

	[JsonPropertyName("currentResetCount")]
	public int? CurrentResetCount { get; set; }

	[JsonPropertyName("seasonResets")]
	public DestinyProgressionResetEntry[] SeasonResets { get; set; }

	[JsonPropertyName("rewardItemStates")]
	public int[] RewardItemStates { get; set; }
}


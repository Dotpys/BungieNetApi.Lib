using BungieNetApi.Entities.Destiny.Challenges;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

public class DestinyActivity
{
	[JsonPropertyName("activityHash")]
	public uint ActivityHash { get; set; }

	[JsonPropertyName("isNew")]
	public bool IsNew { get; set; }

	[JsonPropertyName("canLead")]
	public bool CanLead { get; set; }

	[JsonPropertyName("canJoin")]
	public bool CanJoin { get; set; }

	[JsonPropertyName("isCompleted")]
	public bool IsCompleted { get; set; }

	[JsonPropertyName("isVisible")]
	public bool IsVisible { get; set; }

	[JsonPropertyName("displayLevel")]
	public int? DisplayLevel { get; set; }

	[JsonPropertyName("recommendedLight")]
	public int? RecommendedLight { get; set; }

	[JsonPropertyName("difficultyTier")]
	public int DifficultyTier { get; set; }

	[JsonPropertyName("challenges")]
	public DestinyChallengeStatus[] Challenges { get; set; }

	[JsonPropertyName("modifierHashes")]
	public uint[] ModifierHashes { get; set; }

	[JsonPropertyName("booleanActivityOptions")]
	public Dictionary<uint, bool> BooleanActivityOptions { get; set; }

	[JsonPropertyName("loadoutRequirementIndex")]
	public int? LoadoutRequirementIndex { get; set; }
}

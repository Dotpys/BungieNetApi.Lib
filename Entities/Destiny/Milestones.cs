using BungieNetApi.Entities.Destiny.Challenges;
using BungieNetApi.Entities.Destiny.Quests;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Milestones;

public class DestinyMilestone
{
	[JsonPropertyName("milestoneHash")]
	public uint MilestoneHash { get; set; }

	[JsonPropertyName("aviableQuests")]
	public DestinyMilestoneQuest[] AviableQuests { get; set; }

	[JsonPropertyName("activities")]
	public DestinyMilestoneChallengeActivity[] Activities { get; set; }

	[JsonPropertyName("values")]
	public Dictionary<string, float> Values { get; set; }

	[JsonPropertyName("vendorHashes")]
	public uint[] VendorHashes { get; set; }

	[JsonPropertyName("vendors")]
	public DestinyMilestoneVendor[] Vendors { get; set; }

	[JsonPropertyName("rewards")]
	public DestinyMilestoneRewardCategory[] Rewards { get; set; }

	[JsonPropertyName("startDate")]
	public DateTime? StartDate { get; set; }

	[JsonPropertyName("endDate")]
	public DateTime? EndDate { get; set; }

	[JsonPropertyName("order")]
	public int Order { get; set; }
}

public class DestinyMilestoneQuest
{
	[JsonPropertyName("questItemHash")]
	public uint QuestItemHash { get; set; }

	[JsonPropertyName("status")]
	public DestinyQuestStatus Status { get; set; }

	[JsonPropertyName("activity")]
	public DestinyMilestoneActivity Activity { get; set; }

	[JsonPropertyName("challenges")]
	public DestinyChallengeStatus Challenges { get; set; }
}

public class DestinyMilestoneActivity
{
	[JsonPropertyName("activityHash")]
	public uint ActivityHash { get; set; }

	[JsonPropertyName("activityModeHash")]
	public uint? ActivityModeHash { get; set; }

	[JsonPropertyName("activityModeType")]
	public int? ActivityModeType { get; set; }

	[JsonPropertyName("modifierHashes")]
	public uint[] ModifierHashes { get; set; }

	[JsonPropertyName("variants")]
	public DestinyMilestoneActivityVariant[] Variants { get; set; }
}

public class DestinyMilestoneActivityVariant
{
	[JsonPropertyName("activityHash")]
	public uint ActivityHash { get; set; }

	[JsonPropertyName("completionStatus")]
	public DestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }

	[JsonPropertyName("activityModeHash")]
	public uint? ActivityModeHash { get; set; }

	[JsonPropertyName("activityModeType")]
	public int? ActivityModeType { get; set; }
}

public class DestinyMilestoneActivityCompletionStatus
{
	[JsonPropertyName("completed")]
	public bool Completed { get; set; }

	[JsonPropertyName("phases")]
	public DestinyMilestoneActivityPhase Phases { get; set; }
}

public class DestinyMilestoneActivityPhase
{
	[JsonPropertyName("completed")]
	public bool Completed { get; set; }

	[JsonPropertyName("phaseHash")]
	public uint PhaseHash { get; set; }
}

public class DestinyMilestoneChallengeActivity
{
	[JsonPropertyName("activityHash")]
	public uint ActivityHash { get; set; }

	[JsonPropertyName("activityModeHash")]
	public uint? ActivityModeHash { get; set; }

	[JsonPropertyName("activityModeType")]
	public int? ActivityModeType { get; set; }

	[JsonPropertyName("modifierHashes")]
	public uint[] ModifierHashes { get; set; }

	[JsonPropertyName("variants")]
	public DestinyMilestoneActivityVariant[] Variants { get; set; }
}

public class DestinyMilestoneVendor
{
	[JsonPropertyName("vendorHash")]
	public uint VendorHash { get; set; }

	[JsonPropertyName("previewItemHash")]
	public uint? PreviewItemHash { get; set; }
}

public class DestinyMilestoneRewardCategory
{
	[JsonPropertyName("rewardCategoryHash")]
	public uint RewardCategoryHash { get; set; }

	[JsonPropertyName("entries")]
	public DestinyMilestoneRewardEntry[] Entries { get; set; }
}

public class DestinyMilestoneRewardEntry
{
	[JsonPropertyName("rewardEntryHash")]
	public uint RewardEntryHash { get; set; }

	[JsonPropertyName("earned")]
	public bool Earned { get; set; }

	[JsonPropertyName("redeemed")]
	public bool Redeemed { get; set; }
}

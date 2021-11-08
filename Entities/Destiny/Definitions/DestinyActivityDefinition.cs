using BungieNetApi.Entities.Destiny.Constants;
using BungieNetApi.Entities.Destiny.Definitions.Common;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyActivityDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("originalDisplayProperties")]
	public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }

	[JsonPropertyName("selectionScreenDisplayProperties")]
	public DestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }

	[JsonPropertyName("releaseIcon")]
	public string ReleaseIcon { get; set; }

	[JsonPropertyName("releaseTime")]
	public int ReleaseTime { get; set; }

	[JsonPropertyName("activityLightLevel")]
	public int ActivityLightLevel { get; set; }

	[JsonPropertyName("destinationHash")]
	public uint DestinationHash { get; set; }

	[JsonPropertyName("placeHash")]
	public uint PlaceHash { get; set; }

	[JsonPropertyName("activityTypeHash")]
	public uint ActivityTypeHash { get; set; }

	[JsonPropertyName("tier")]
	public int Tier { get; set; }

	[JsonPropertyName("pgcrImage")]
	public string PGCRImage { get; set; }

	[JsonPropertyName("rewards")]
	public DestinyActivityRewardDefinition Rewards { get; set; }

	[JsonPropertyName("modifiers")]
	public DestinyActivityModifierReferenceDefinition Modifiers { get; set; }

	[JsonPropertyName("isPlaylist")]
	public bool IsPlaylist { get; set; }

	[JsonPropertyName("challenges")]
	public DestinyActivityChallengeDefinition Challenges { get; set; }

	[JsonPropertyName("optionalUnlockStrings")]
	public DestinyActivityUnlockStringDefinition OptionalUnlockStrings { get; set; }

	[JsonPropertyName("playlistItems")]
	public DestinyActivityPlaylistItemDefinition PlaylistItems { get; set; }

	[JsonPropertyName("activityGraphList")]
	public DestinyActivityGraphListEntryDefinition ActivityGraphList { get; set; }

	[JsonPropertyName("matchmaking")]
	public DestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }

	[JsonPropertyName("guidedGame")]
	public DestinyActivityGuidedBlockDefinition GuidedGame { get; set; }

	[JsonPropertyName("directActivityModeHash")]
	public uint? DirectActivityModeHash { get; set; }

	[JsonPropertyName("directActivityModeType")]
	public DirectActivityModeType? DirectActivityModeType { get; set; }

	[JsonPropertyName("loadouts")]
	public DestinyActivityLoadoutRequirementSet[] Loadouts { get; set; }

	[JsonPropertyName("activityModeHashes")]
	public uint[] ActivityModeHashes { get; set; }

	[JsonPropertyName("activityModeTypes")]
	public int[] ActivityModeTypes { get; set; }

	[JsonPropertyName("isPvP")]
	public bool IsPvP { get; set; }

	[JsonPropertyName("insertionPoints")]
	public DestinyActivityInsertionPointDefinition[] InsertionPoints { get; set; }

	[JsonPropertyName("activityLocationMappings")]
	public DestinyEnvironmentLocationMapping[] ActivityLocationMappings { get; set; }
}

public class DestinyActivityRewardDefinition
{
	[JsonPropertyName("rewardText")]
	public string RewardText { get; set; }

	[JsonPropertyName("rewardItems")]
	public DestinyItemQuantity[] RewardItems { get; set; }
}

public class DestinyActivityModifierReferenceDefinition
{
	[JsonPropertyName("activityModifierHash")]
	public uint ActivityModifierHash { get; set; }
}

public class DestinyActivityChallengeDefinition
{
	[JsonPropertyName("objectiveHash")]
	public uint ObjectiveHash { get; set; }

	[JsonPropertyName("dummyRewards")]
	public DestinyItemQuantity[] DummyRewards { get; set; }
}

public enum DirectActivityModeType : int
{
	None = 0,
	Story = 2,
	Strike = 3,
	Raid = 4,
	AllPvP = 5,
	Patrol = 6,
	AllPvE = 7,
	Reserved9 = 9,
	Control = 10,
	Reserved11 = 11,
	Clash = 12,
	Reserved13 = 13,
	CrimsonDoubles = 15,
	Nightfall = 16,
	HeroicNightfall = 17,
	AllStrikes = 18,
	IronBanner = 19,
	Reserved20 = 20,
	Reserved21 = 21,
	Reserved22 = 22,
	Reserved24 = 24,
	AllMayhem = 25,
	Reserved26 = 26,
	Reserved27 = 27,
	Reserved28 = 28,
	Reserved29 = 29,
	Reserved30 = 30,
	Supremacy = 31,
	PrivateMatchesAll = 32,
	Survival = 37,
	Countdown = 38,
	TrialsOfTheNine = 39,
	Social = 40,
	TrialsCountdown = 41,
	TrialsSurvival = 42,
	IronBannerControl = 43,
	IronBannerClash = 44,
	IronBannerSupremacy = 45,
	ScoredNightfall = 46,
	ScoredHeroicNightfall = 47,
	Rumble = 48,
	AllDoubles = 49,
	Doubles = 50,
	PrivateMatchesClash = 51,
	PrivateMatchesControl = 52,
	PrivateMatchesSupremacy = 53,
	PrivateMatchesCountdown = 54,
	PrivateMatchesSurvival = 55,
	PrivateMatchesMayhem = 56,
	PrivateMatchesRumble = 57,
	HeroicAdventure = 58,
	Showdown = 59,
	Lockdown = 60,
	Scorched = 61,
	ScorchedTeam = 62,
	Gambit = 63,
	AllPvECompetitive = 64,
	Breakthrough = 65,
	BlackArmoryRun = 66,
	Salvage = 67,
	IronBannerSalvage = 68,
	PvPCompetitive = 69,
	PvPQuickplay = 70,
	ClashQuickplay = 71,
	ClashCompetitive = 72,
	ControlQuickplay = 73,
	ControlCompetitive = 74,
	GambitPrime = 75,
	Reckoning = 76,
	Menagerie = 77,
	VexOffensive = 78,
	NightmareHunt = 79,
	Elimination = 80,
	Momentum = 81,
	Dungeon = 82,
	Sundial = 83,
	TrialsOfOsiris = 84
}

public class DestinyActivityUnlockStringDefinition
{
	[JsonPropertyName("displayString")]
	public string DisplayString { get; set; }
}

public class DestinyActivityPlaylistItemDefinition
{
	[JsonPropertyName("activityHash")]
	public uint ActivityHash { get; set; }

	[JsonPropertyName("directActivityModeHash")]
	public uint? DirectActivityModeHash { get; set; }

	[JsonPropertyName("directActivityModeType")]
	public DirectActivityModeType? DirectActivityModeType { get; set; }

	[JsonPropertyName("activityModeHashes")]
	public uint[] ActivityModeHashes { get; set; }

	[JsonPropertyName("activityModeTypes")]
	public DirectActivityModeType[] ActivityModeTypes { get; set; }
}

public class DestinyActivityGraphListEntryDefinition
{
	[JsonPropertyName("activityGraphHash")]
	public uint ActivityGraphHash { get; set; }
}

public class DestinyActivityMatchmakingBlockDefinition
{
	[JsonPropertyName("isMatchmade")]
	public bool IsMatchmade { get; set; }

	[JsonPropertyName("minParty")]
	public int MinParty { get; set; }

	[JsonPropertyName("maxParty")]
	public int MaxParty { get; set; }

	[JsonPropertyName("maxPlayers")]
	public int MaxPlayers { get; set; }

	[JsonPropertyName("requiresGuardianOath")]
	public bool RequiresGuardianOath { get; set; }
}

public class DestinyActivityGuidedBlockDefinition
{
	[JsonPropertyName("guidedMaxLobbySize")]
	public int GuidedMaxLobbySize { get; set; }

	[JsonPropertyName("guidedMinLobbySize")]
	public int GuidedMinLobbySize { get; set; }

	[JsonPropertyName("guidedDisbandCount")]
	public int GuidedDisbandCount { get; set; }
}

public class DestinyActivityLoadoutRequirementSet
{
	[JsonPropertyName("requirements")]
	public DestinyActivityLoadoutRequirement[] Requirements { get; set; }
}

public class DestinyActivityLoadoutRequirement
{
	[JsonPropertyName("equipmentSlotHash")]
	public uint EquipmentSlotHash { get; set; }

	[JsonPropertyName("allowedEquippedItemHashes")]
	public uint[] AllowedEquippedItemHashes { get; set; }

	[JsonPropertyName("allowedWeaponSubTypes")]
	public int[] AllowedWeaponSubTypes { get; set; }
}

public class DestinyActivityInsertionPointDefinition
{
	[JsonPropertyName("phaseHash")]
	public uint PhaseHash { get; set; }
}

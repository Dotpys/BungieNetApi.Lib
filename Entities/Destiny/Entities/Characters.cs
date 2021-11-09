using BungieNetApi.Entities.Destiny.Artifacts;
using BungieNetApi.Entities.Destiny.Character;
using BungieNetApi.Entities.Destiny.Entities.Items;
using BungieNetApi.Entities.Destiny.Milestones;
using BungieNetApi.Entities.Destiny.Misc;
using BungieNetApi.Entities.Destiny.Progression;
using BungieNetApi.Entities.Destiny.Quests;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Entities.Characters;

public class Characters
{
	[JsonPropertyName("membershipId")]
	public long MembershipId { get; set; }

	[JsonPropertyName("membershipType")]
	public int MembershipType { get; set; }

	[JsonPropertyName("characterId")]
	public long CharacterId { get; set; }

	[JsonPropertyName("dateLastPlayed")]
	public DateTime DateLastPlayed { get; set; }

	[JsonPropertyName("minutesPlayedThisSession")]
	public long MinutesPlayedThisSession { get; set; }

	[JsonPropertyName("minutesPlayedTotal")]
	public long MinutesPlayedTotal { get; set; }

	[JsonPropertyName("light")]
	public int Light { get; set; }

	[JsonPropertyName("stats")]
	public Dictionary<uint, int> Stats { get; set; }

	[JsonPropertyName("raceHash")]
	public uint RaceHash { get; set; }

	[JsonPropertyName("genderHash")]
	public uint GenderHash { get; set; }

	[JsonPropertyName("classHash")]
	public uint ClassHash { get; set; }

	[JsonPropertyName("raceType")]
	public int RaceType { get; set; }

	[JsonPropertyName("classType")]
	public int ClassType { get; set; }

	[JsonPropertyName("rgenderType")]
	public int GenderType { get; set; }

	[JsonPropertyName("emblemPath")]
	public string EmblemPath { get; set; }

	[JsonPropertyName("emblemBackgroundPath")]
	public string EmblemBackgroundPath { get; set; }

	[JsonPropertyName("emblemHash")]
	public uint EmblemHash { get; set; }

	[JsonPropertyName("emblemColor")]
	public DestinyColor EmblemColor { get; set; }

	[JsonPropertyName("levelProgression")]
	public DestinyProgression LevelProgression { get; set; }

	[JsonPropertyName("baseCharacterLevel")]
	public int BaseCharacterLevel { get; set; }

	[JsonPropertyName("percentToNextLevel")]
	public float PercentToNextLevel { get; set; }

	[JsonPropertyName("titleRecordHash")]
	public uint TitleRecordHash { get; set; }
}

public class DestinyCharacterProgressionComponent
{
	[JsonPropertyName("progressions")]
	public Dictionary<uint, DestinyProgression> Progressions { get; set; }

	[JsonPropertyName("factions")]
	public Dictionary<uint, DestinyFactionProgression> Factions { get; set; }

	[JsonPropertyName("milestones")]
	public Dictionary<uint, DestinyMilestone> Milestones { get; set; }

	[JsonPropertyName("quests")]
	public DestinyQuestStatus[] Quests { get; set; }

	//TODO: WHAT?
	[JsonPropertyName("uninstancedItemObjectives")]
	public Dictionary<uint, DestinyObjectiveProgress[]> UninstancedItemObjectives { get; set; }

	[JsonPropertyName("uninstancedItemPerks")]
	public Dictionary<uint, DestinyItemPerksComponent> UninstancedItemPerks { get; set; }

	//TODO: WHAT?
	[JsonPropertyName("checklists")]
	public Dictionary<uint, Dictionary<uint, bool>> Checklists { get; set; }

	[JsonPropertyName("seasonalArtifact")]
	public DestinyArtifactCharacterScoped SeasonalArtifact { get; set; }
}

public class DestinyCharacterRenderComponent
{
	[JsonPropertyName("customDyes")]
	public DyeReference[] CustomDyes { get; set; }

	[JsonPropertyName("customization")]
	public DestinyCharacterCustomization Customization { get; set; }

	[JsonPropertyName("peerView")]
	public DestinyCharacterPeerView PeerView { get; set; }
}

public class DestinyCharacterActivitiesComponent
{
	[JsonPropertyName("dateActivityStarted")]
	public DateTime DateActivityStarted { get; set; }

	[JsonPropertyName("availableActivities")]
	public DestinyActivity[] AvailableActivities { get; set; }

	[JsonPropertyName("currentActivityHash")]
	public uint CurrentActivityHash { get; set; }

	[JsonPropertyName("currentActivityModeHash")]
	public uint CurrentActivityModeHash { get; set; }

	[JsonPropertyName("currentActivityModeType")]
	public int? CurrentActivityModeType { get; set; }

	[JsonPropertyName("currentActivityModeHashes")]
	public uint[] CurrentActivityModeHashes { get; set; }

	[JsonPropertyName("currentActivityModeTypes")]
	public int[] CurrentActivityModeTypes { get; set; }

	[JsonPropertyName("currentPlaylistActivityHash")]
	public uint? CurrentPlaylistActivityHash { get; set; }

	[JsonPropertyName("lastCompletedStoryHash")]
	public uint LastCompletedStoryHash { get; set; }
}

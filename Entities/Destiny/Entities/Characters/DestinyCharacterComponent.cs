using BungieNetApi.Entities.Destiny.Misc;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Entities.Characters;

public class DestinyCharacterComponent
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

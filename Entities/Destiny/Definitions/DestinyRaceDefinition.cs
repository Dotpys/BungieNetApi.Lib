using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// In Destiny, "Races" are really more like "Species".
/// Sort of. I mean, are the Awoken a separate species from humans? I'm not sure. But either way, they're defined here.
/// You'll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.
/// </summary>
public class DestinyRaceDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	/// <summary>
	/// An enumeration defining the existing, known Races/Species for player characters.
	/// This value will be the enum value matching this definition.
	/// </summary>
	[JsonPropertyName("raceType")]
	public int RaceType { get; set; }

	/// <summary>
	/// A localized string referring to the singular form of the Race's name when referred to in gendered form.
	/// Keyed by the DestinyGender.
	/// </summary>
	[JsonPropertyName("genderedRaceNames")]
	public Dictionary<string, string> GenderedRaceNames { get; set; }

	[JsonPropertyName("genderedRaceNamesByGenderHash")]
	public Dictionary<uint, string> GenderedRaceNamesByGenderHash { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}


using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// Defines a Character Class in Destiny 2. These are types of characters you can play, like Titan, Warlock, and Hunter.
/// </summary>
public class DestinyClassDefinition : DestinyDefinition
{
	/// <summary>
	/// In Destiny 1, we added a convenience Enumeration for referring to classes.
	/// We've kept it, though mostly for posterity.
	/// This is the enum value for this definition's class.
	/// </summary>
	[JsonPropertyName("classType")]
	public int ClassType { get; set; }

	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	/// <summary>
	/// A localized string referring to the singular form of the Class's name when referred to in gendered form.
	/// Keyed by the DestinyGender.
	/// </summary>
	[JsonPropertyName("genderedClassNames")]
	public Dictionary<string, string> GenderedClassNames { get; set; }

	[JsonPropertyName("genderedClassNamesByGenderHash")]
	public Dictionary<uint, string> GenderedClassNamesByGenderHash { get; set; }

	/// <summary>
	/// Mentors don't really mean anything anymore. Don't expect this to be populated.
	/// </summary>
	[JsonPropertyName("mentorVendorHash")]
	public uint? MentorVendorHash { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}
using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// Gender is a social construct, and as such we have definitions for Genders.
/// Right now there happens to only be two, but we'll see what the future holds.
/// </summary>
public class DestinyGenderDefinition : DestinyDefinition
{
	/// <summary>
	/// This is a quick reference enumeration for all of the currently defined Genders.
	/// We use the enumeration for quicker lookups in related data, like DestinyClassDefinition.genderedClassNames.
	/// </summary>
	[JsonPropertyName("genderType")]
	public int GenderType { get; set; }

	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}
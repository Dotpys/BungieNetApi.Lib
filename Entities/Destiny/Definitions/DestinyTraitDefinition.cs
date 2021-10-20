using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyTraitDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("traitCategoryId")]
	public string TraitCategoryId { get; set; }

	[JsonPropertyName("traitCategoryHash")]
	public uint TraitCategoryHash { get; set; }

	public override string ToString()
	{
		return DisplayProperties.Name;
	}
}

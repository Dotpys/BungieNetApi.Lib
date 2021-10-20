using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinySandboxPerkDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("perkIdentifier")]
	public string PerkIdentifier { get; set; }

	[JsonPropertyName("isDisplayable")]
	public bool IsDisplayable { get; set; }

	[JsonPropertyName("damageType")]
	public int DamageType { get; set; }

	[JsonPropertyName("damageTypeHash")]
	public uint? DamageTypeHash { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("perkGroups")]
	//public DestinyTalentNodeStepGroups PerkGroups { get; set; }

	public override string ToString()
	{
		return DisplayProperties.Name;
	}
}


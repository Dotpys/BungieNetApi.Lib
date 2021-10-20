using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions.Common;

/// <summary>
/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
/// </summary>
public class DestinyDisplayPropertiesDefinition
{
	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("icon")]
	public string Icon { get; set; }

	public string IconLink
	{
		get => HasIcon ? StaticData.BUNGIE_NET_ENDPOINT + Icon : "";
	}

	[JsonPropertyName("iconSequences")]
	public DestinyIconSequenceDefinition[] IconSequences { get; set; }

	[JsonPropertyName("highResIcon")]
	public string HighResIcon { get; set; }

	public string HighResIconLink
	{
		get => HasIcon ? StaticData.BUNGIE_NET_ENDPOINT + HighResIcon : "";
	}

	[JsonPropertyName("hasIcon")]
	public bool HasIcon { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// All damage types that are possible in the game are defined here, along with localized info and icons as needed.
/// </summary>
public class DestinyDamageTypeDefinition : DestinyDefinition
{
	/// <summary>
	/// The description of the damage type, icon etc...
	/// </summary>
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	/// <summary>
	/// A variant of the icon that is transparent and colorless.
	/// </summary>
	[JsonPropertyName("transparentIconPath")]
	public string TransparentIconPath { get; set; }

	/// <summary>
	/// If TRUE, the game shows this damage type's icon. Otherwise, it doesn't.
	/// Whether you show it or not is up to you.
	/// </summary>
	[JsonPropertyName("showIcon")]
	public bool ShowIcon { get; set; }

	/// <summary>
	/// We have an enumeration for damage types for quick reference.
	/// This is the current definition's damage type enum value.
	/// </summary>
	[JsonPropertyName("enumValue")]
	public int EnumValue { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}

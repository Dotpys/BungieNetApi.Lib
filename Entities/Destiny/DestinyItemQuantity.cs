using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny;

/// <summary>
/// Used in a number of Destiny contracts to return data about an item stack and its quantity. Can optionally return an itemInstanceId if the item is instanced - in which case, the quantity returned will be 1. If it's not... uh, let me know okay? Thanks.
/// </summary>
public struct DestinyItemQuantity
{
	/// <summary>
	/// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyInventoryItemDefinition</remarks>
	[JsonPropertyName("itemHash")]
	public uint ItemHash { get; set; }

	/// <summary>
	/// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
	/// </summary>
	[JsonPropertyName("itemInstanceId")]
	public long? ItemInstanceId { get; set; }

	/// <summary>
	/// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
	/// </summary>
	[JsonPropertyName("quantity")]
	public int quantity { get; set; }
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

using BungieNetApi.Entities.Destiny.Entities.Items;

namespace BungieNetApi.Entities.Destiny.Components.Inventory;

public class DestinyPlatformSilverComponent
{
	/// <summary>
	/// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
	/// </summary>
	[JsonPropertyName("platformSilver")]
	public Dictionary<int, DestinyItemComponent> PlatformSilver { get; set; }
}

public class DestinyCurrenciesComponent
{
	[JsonPropertyName("itemQuantities")]
	public Dictionary<uint, int> ItemQuantities { get; set; }
}

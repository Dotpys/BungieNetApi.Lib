using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Entities.Items;
using BungieNetApi.Entities.User;

namespace BungieNetApi.Entities.Destiny.Components.Inventory;

public struct DestinyPlatformSilverComponent
{
	/// <summary>
	/// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
	/// </summary>
	[JsonPropertyName("platformSilver")]
	public Dictionary<int, DestinyItemComponent> PlatformSilver { get; set; }
}

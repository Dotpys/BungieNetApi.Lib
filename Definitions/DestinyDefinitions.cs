using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using BungieNetApi.Entities.Destiny.Definitions;

namespace BungieNetApi.Definitions;

public class DestinyDefinitions// : Dictionary<string, object>
{
	[JsonPropertyName("DestinyInventoryItemDefinition")]
	public Dictionary<string, DestinyInventoryItemDefinition> DestinyInventoryItemDefinitions {get;set;}
}
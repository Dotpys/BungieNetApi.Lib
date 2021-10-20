using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using BungieNetApi.Entities.Destiny.Definitions;
using BungieNetApi.Entities.Destiny.Definitions.Common;

namespace BungieNetApi.Definitions
{
	public class DestinyDefinitions// : Dictionary<string, object>
	{
		[JsonPropertyName("DestinyInventoryItemDefinition")]
		public Dictionary<string, DestinyInventoryItemDefinition> DestinyInventoryItemDefinitions {get;set;}
	}
}
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.StringVariables;

public class DestinyStringVariablesComponent
{
	[JsonPropertyName("integerValuesByHash")]
	public Dictionary<uint, int> IntegerValuesByHash { get; set; }
}


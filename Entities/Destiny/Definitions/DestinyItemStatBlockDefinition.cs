using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemStatBlockDefinition
{
	[JsonPropertyName("disablePrimaryStatDisplay")]
	public bool DisablePrimaryStatDisplay { get; set; }

	[JsonPropertyName("statGroupHash")]
	public uint StatGroupHash { get; set; }

	[JsonPropertyName("stats")]
	public Dictionary<uint, DestinyInventoryItemStatDefinition> Stats { get; set; }

	[JsonPropertyName("hasDisplayableStats")]
	public bool HasDisplayableStats { get; set; }

	[JsonPropertyName("primaryBaseStatHash")]
	public uint PrimaryBaseStatHash { get; set; }
}


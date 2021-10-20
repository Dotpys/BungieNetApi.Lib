using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemTooltipNotification
{
	[JsonPropertyName("displayString")]
	public string DisplayString { get; set; }

	[JsonPropertyName("displayStyle")]
	public string DisplayStyle { get; set; }
}

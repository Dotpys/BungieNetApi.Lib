using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemActionBlockDefinition
{
	[JsonPropertyName("verbName")]
	public string VerbName { get; set; }

	[JsonPropertyName("verbDescription")]
	public string VerbDescription { get; set; }

	[JsonPropertyName("isPositive")]
	public bool IsPositive { get; set; }

	[JsonPropertyName("overlayScreenName")]
	public string OverlayScreenName { get; set; }

	[JsonPropertyName("overlayIcon")]
	public string OverlayIcon { get; set; }

	[JsonPropertyName("requiredCooldownSeconds")]
	public int RequiredCooldownSeconds { get; set; }

	[JsonPropertyName("requiredItems")]
	public DestinyItemActionRequiredItemDefinition[] RequiredItems { get; set; }

	[JsonPropertyName("progressionRewards")]
	public DestinyItemActionRequiredItemDefinition[] ProgressionRewards { get; set; }

	[JsonPropertyName("actionTypeLabel")]
	public string ActionTypeLabel { get; set; }

	[JsonPropertyName("requiredLocation")]
	public string RequiredLocation { get; set; }

	[JsonPropertyName("requiredCooldownHash")]
	public uint RequiredCooldownHash { get; set; }

	[JsonPropertyName("deleteOnAction")]
	public bool DeleteOnAction { get; set; }

	[JsonPropertyName("consumeEntireStack")]
	public bool ConsumeEntireStack { get; set; }

	[JsonPropertyName("useOnAcquire")]
	public bool UseOnAcquire { get; set; }
}

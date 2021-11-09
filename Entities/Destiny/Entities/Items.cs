using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using BungieNetApi.Entities.Destiny.Perks;
using BungieNetApi.Entities.Destiny.Quests;

namespace BungieNetApi.Entities.Destiny.Entities.Items;

/// <summary>
/// The base item component, filled with properties that are generally useful to know in any item request or that don't feel worthwhile to put in their own component.
/// </summary>
public class DestinyItemComponent
{
	/// <summary>
	/// The identifier for the item's definition, which is where most of the useful static information for the item can be found.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyInventoryItemDefinition</remarks>
	//[JsonPropertyName("itemHash")]
	//public uint ItemHash { get; set; }

	/// <summary>
	/// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
	/// </summary>
	[JsonPropertyName("itemInstanceId")]
	public ulong? ItemInstanceId { get; set; }

	/// <summary>
	/// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
	/// </summary>
	[JsonPropertyName("quantity")]
	public int Quantity { get; set; }

	/// <summary>
	/// If the item is bound to a location, it will be specified in this enum.
	/// </summary>
	[JsonPropertyName("bindStatus")]
	public int BindStatus { get; set; }

	/// <summary>
	/// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
	/// </summary>
	[JsonPropertyName("location")]
	public int Location { get; set; }

	/// <summary>
	/// The hash identifier for the specific inventory bucket in which the item is located.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyInventoryBucketDefinition</remarks>
	[JsonPropertyName("bucketHash")]
	public uint BucketHash { get; set; }

	/// <summary>
	/// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
	/// </summary>
	[JsonPropertyName("transferStatus")]
	public int TransferStatus { get; set; }

	/// <summary>
	/// If the item can be locked, this will indicate that state.
	/// </summary>
	[JsonPropertyName("lockable")]
	public bool Lockable { get; set; }

	/// <summary>
	/// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it's tracked or locked for example, or whether it has a masterwork plug inserted.
	/// </summary>
	[JsonPropertyName("state")]
	public int State { get; set; }

	/// <summary>
	/// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.
	/// If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyInventoryItemDefinition</remarks>
	[JsonPropertyName("overrideStyleItemHash")]
	public uint? OverrideStyleItemHash { get; set; }

	/// <summary>
	/// If the item can expire, this is the date at which it will/did expire.
	/// </summary>
	[JsonPropertyName("expirationDate")]
	public DateTime? ExpirationDate { get; set; }

	/// <summary>
	/// If this is true, the object is actually a "wrapper" of the object it's representing. This means that it's not the actual item itself, but rather an item that must be "opened" in game before you have and can use the item.
	/// Wrappers are an evolution of "bundles", which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you "open" it.
	/// </summary>
	[JsonPropertyName("isWrapper")]
	public bool IsWrapper { get; set; }

	/// <summary>
	/// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
	/// </summary>
	[JsonPropertyName("tooltipNotificationIndexes")]
	public int[] TooltipNotificationIndexes { get; set; }

	/// <summary>
	/// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
	/// </summary>
	[JsonPropertyName("metricHash")]
	public uint? MetricHash { get; set; }

	/// <summary>
	/// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
	/// </summary>
	[JsonPropertyName("metricObjective")]
	public DestinyObjectiveProgress MetricObjective { get; set; }

	/// <summary>
	/// The version of this item, used to index into the versions list in the item definition quality block.
	/// </summary>
	[JsonPropertyName("versionNumber")]
	public int? VersionNumber { get; set; }
}

public class DestinyItemRenderComponent
{
	[JsonPropertyName("useCustomDyes")]
	public bool UseCustomDyes { get; set; }

	[JsonPropertyName("artRegions")]
	public Dictionary<int, int> ArtRegions { get; set; }
}

public class DestinyItemPerksComponent
{
	[JsonPropertyName("perks")]
	public DestinyPerkReference[] Perks { get; set; }
}

public class DestinyItemInstanceComponent
{
	[JsonPropertyName("damageType")]
	public int DamageType { get; set; }

	[JsonPropertyName("damageTypeHash")]
	public uint? DamageTypeHash { get; set; }

	[JsonPropertyName("primaryStat")]
	public DestinyStat PrimaryStat { get; set; }

	[JsonPropertyName("itemLevel")]
	public int ItemLevel { get; set; }

	[JsonPropertyName("quality")]
	public int Quality { get; set; }

	[JsonPropertyName("isEquipped")]
	public bool IsEquipped { get; set; }

	[JsonPropertyName("canEquip")]
	public bool CanEquip { get; set; }

	[JsonPropertyName("equipRequiredLevel")]
	public int EquipRequiredLevel { get; set; }

	[JsonPropertyName("unlockHashesRequiredToEquip")]
	public uint UnlockHashesRequiredToEquip { get; set; }

	[JsonPropertyName("cannotEquipReason")]
	public int CannotEquipReason { get; set; }

	[JsonPropertyName("breakerType")]
	public int? BreakerType { get; set; }

	[JsonPropertyName("breakerTypeHash")]
	public int? BreakerTypeHash { get; set; }

	[JsonPropertyName("energy")]
	public DestinyItemInstanceEnergy Energy { get; set; }
}

public class DestinyItemInstanceEnergy
{
	[JsonPropertyName("energyTypeHash")]
	public uint EnergyTypeHash { get; set; }

	[JsonPropertyName("energyType")]
	public int EnergyType { get; set; }

	[JsonPropertyName("energyCapacity")]
	public int EnergyCapacity { get; set; }

	[JsonPropertyName("energyUsed")]
	public int EnergyUsed { get; set; }

	[JsonPropertyName("energyUnused")]
	public int EnergyUnused { get; set; }
}

public class DestinyItemObjectivesComponent
{
	[JsonPropertyName("objectives")]
	public DestinyObjectiveProgress[] Objectives { get; set; }

	[JsonPropertyName("flavorObjective")]
	public DestinyObjectiveProgress FlavorObjective { get; set; }

	[JsonPropertyName("dateCompleted")]
	public DateTime? DateCompleted { get; set; }
}

public class DestinyItemStatsComponent
{
	[JsonPropertyName("stats")]
	public Dictionary<uint, DestinyStat> Stats { get; set; }
}

public class DestinyItemSocketsComponent
{
	[JsonPropertyName("sockets")]
	public DestinyItemSocketState[] Sockets { get; set; }
}

public class DestinyItemSocketState
{
	[JsonPropertyName("plugHash")]
	public uint? PlugHash { get; set; }

	[JsonPropertyName("isEnabled")]
	public bool IsEnabled { get; set; }

	[JsonPropertyName("isVisible")]
	public bool IsVisible { get; set; }

	[JsonPropertyName("enableFailIndexes")]
	public int[] EnableFailIndexes { get; set; }
}

public class DestinyItemReusablePlugsComponent
{
	//TODO: WHAT?
	[JsonPropertyName("plugs")]
	public Dictionary<int, object> Plugs { get; set; }
}

public class DestinyItemPlugObjectivesComponent
{
	//TODO: WHAT?
	[JsonPropertyName("objectivesPerPlug")]
	public Dictionary<uint, object> ObjectivesPerPlug { get; set; }
}

public class DestinyItemTalentGridComponent
{
	[JsonPropertyName("talentGridHash")]
	public uint TalentGridHash { get; set; }

	[JsonPropertyName("nodes")]
	public DestinyTalentNode[] Nodes { get; set; }

	[JsonPropertyName("isGridComplete")]
	public bool IsGridComplete { get; set; }

	[JsonPropertyName("gridProgression")]
	public DestinyProgression GridProgression { get; set; }
}

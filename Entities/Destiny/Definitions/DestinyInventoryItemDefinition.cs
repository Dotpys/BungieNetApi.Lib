using BungieNetApi.Entities.Destiny.Definitions.Common;
using BungieNetApi.Entities.Destiny.Misc;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

/// <summary>
/// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.
/// In practice, you will want to associate this data with "live" item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
/// </summary>
public class DestinyInventoryItemDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("tooltipNotifications")]
	public DestinyItemTooltipNotification[] TooltipNotifications { get; set; }

	[JsonPropertyName("collectibleHash")]
	public uint? CollectibleHash { get; set; }

	[JsonPropertyName("iconWatermark")]
	public string IconWatermark { get; set; }

	[JsonPropertyName("iconWatermarkShelved")]
	public string IconWatermarkShelved { get; set; }

	[JsonPropertyName("secondaryIcon")]
	public string SecondaryIcon { get; set; }

	[JsonPropertyName("secondaryOverlay")]
	public string SecondaryOverlay { get; set; }

	[JsonPropertyName("secondarySpecial")]
	public string SecondarySpecial { get; set; }

	[JsonPropertyName("backgroundColor")]
	public DestinyColor BackgroundColor { get; set; }

	[JsonPropertyName("screenshot")]
	public string Screenshot { get; set; }

	[JsonPropertyName("itemTypeDisplayName")]
	public string ItemTypeDisplayName { get; set; }

	[JsonPropertyName("flavorText")]
	public string FlavorText { get; set; }

	[JsonPropertyName("uiItemDisplayStyle")]
	public string UiItemDisplayStyle { get; set; }

	[JsonPropertyName("itemTypeAndTierDisplayName")]
	public string ItemTypeAndTierDisplayName { get; set; }

	[JsonPropertyName("displaySource")]
	public string DisplaySource { get; set; }

	[JsonPropertyName("tooltipStyle")]
	public string TooltipStyle { get; set; }

	[JsonPropertyName("action")]
	public DestinyItemActionBlockDefinition Action { get; set; }

	[JsonPropertyName("inventory")]
	public DestinyItemInventoryBlockDefinition Inventory { get; set; }

	[JsonPropertyName("setData")]
	public DestinyItemSetBlockDefinition SetData { get; set; }

	[JsonPropertyName("stats")]
	public DestinyItemStatBlockDefinition Stats { get; set; }

	[JsonPropertyName("emblemObjectiveHash")]
	public uint? EmblemObjectiveHash { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("equippingBlock")]
	//public DestinyEquippingBlockDefinition EquippingBlock { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("translationBlock")]
	//public DestinyItemTranslationBlockDefinition TranslationBlock { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("preview")]
	//public DestinyItemPreviewBlockDefinition Preview { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("quality")]
	//public DestinyItemQualityBlockDefinition Quality { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("value")]
	//public DestinyItemValueBlockDefinition Value { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("sourceData")]
	//public DestinyItemSourceBlockDefinition SourceData { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("objectives")]
	//public DestinyItemObjectiveBlockDefinition Objectives { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("metrics")]
	//public DestinyItemMetricBlockDefinition Metrics { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("plug")]
	//public DestinyItemGearsetBlockDefinition Plug { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("sack")]
	//public DestinyItemSackBlockDefinition Sack { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("sockets")]
	//public DestinyItemSocketBlockDefinition Sockets { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("summary")]
	//public DestinyItemSummaryBlockDefinition Summary { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("talentGrid")]
	//public DestinyItemTalentGridBlockDefinition TalentGrid { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("investmentStats")]
	//public DestinyItemInvestmentStatDefinition InvestmentStats { get; set; }

	// TODO: Implementare
	//[JsonPropertyName("perks")]
	//public DestinyItemPerkEntryDefinition Perks { get; set; }

	/// <summary>
	/// If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.
	/// </summary>
	[JsonPropertyName("loreHash")]
	public uint LoreHash { get; set; }

	/// <summary>
	/// There are times when the game will show you a "summary/vague" version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.
	/// </summary>
	[JsonPropertyName("summaryItemHash")]
	public uint SummaryItemHash { get; set; }

	/// <summary>
	/// If any animations were extracted from game content for this item, these will be the definitions of those animations.
	/// </summary>
	//[JsonPropertyName("animations")]
	//public DestinyAnimationReference Animations { get; set; }

	/// <summary>
	/// BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.
	/// </summary>
	[JsonPropertyName("allowActions")]
	public bool AllowActions { get; set; }

	/// <summary>
	/// If we added any help or informational URLs about this item, these will be those links.
	/// </summary>
	// TODO: Implementare
	//[JsonPropertyName("links")]
	//public HyperlinkReference Links { get; set; }

	[JsonPropertyName("doesPostmasterPullHaveSideEffects")]
	public bool DoesPostmasterPullHaveSideEffects { get; set; }

	[JsonPropertyName("nonTransferrable")]
	public bool NonTransferrable { get; set; }

	[JsonPropertyName("itemCategoryHashes")]
	public uint[] ItemCategoryHashes { get; set; }

	[JsonPropertyName("specialItemType")]
	public int SpecialItemType { get; set; }

	[JsonPropertyName("itemType")]
	public int ItemType { get; set; }

	[JsonPropertyName("itemSubType")]
	public int ItemSubType { get; set; }

	[JsonPropertyName("classType")]
	public int ClassType { get; set; }

	[JsonPropertyName("breakerType")]
	public int BreakerType { get; set; }

	[JsonPropertyName("breakerTypeHash")]
	public uint BreakerTypeHash { get; set; }

	[JsonPropertyName("equippable")]
	public bool Equippable { get; set; }

	[JsonPropertyName("damageTypeHashes")]
	public uint[] DamageTypeHashes { get; set; }

	[JsonPropertyName("damageTypes")]
	public int[] DamageTypes { get; set; }

	[JsonPropertyName("defaultDamageType")]
	public int DefaultDamageType { get; set; }

	[JsonPropertyName("defaultDamageTypeHash")]
	public uint DefaultDamageTypeHash { get; set; }

	[JsonPropertyName("seasonHash")]
	public uint? SeasonHash { get; set; }

	[JsonPropertyName("isWrapper")]
	public bool IsWrapper { get; set; }

	[JsonPropertyName("traitIds")]
	public string[] TraitIds { get; set; }

	[JsonPropertyName("traitHashes")]
	public uint[] TraitHashes { get; set; }

	public override string ToString()
	{
		return DisplayProperties.ToString();
	}
}

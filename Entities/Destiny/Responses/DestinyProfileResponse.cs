using System.Collections.Generic;
using System.Text.Json.Serialization;

using BungieNetApi.Entities.Destiny.Components.Collectibles;
using BungieNetApi.Entities.Destiny.Components.Inventory;
using BungieNetApi.Entities.Destiny.Components.Kiosks;
using BungieNetApi.Entities.Destiny.Components.Metrics;
using BungieNetApi.Entities.Destiny.Components.PlugSets;
using BungieNetApi.Entities.Destiny.Components.Presentation;
using BungieNetApi.Entities.Destiny.Components.Profiles;
using BungieNetApi.Entities.Destiny.Components.Records;
using BungieNetApi.Entities.Destiny.Components.StringVariables;
using BungieNetApi.Entities.Destiny.Entities.Characters;
using BungieNetApi.Entities.Destiny.Entities.Inventory;
using BungieNetApi.Entities.Destiny.Entities.Profiles;
using BungieNetApi.Entities.Profiles;

namespace BungieNetApi.Entities.Destiny.Responses;

/// <summary>
/// The response for GetDestinyProfile, with components for character and item-level data.
/// </summary>
public struct DestinyProfileResponse
{
	[JsonPropertyName("vendorReceipts")]
	public SingleDestinyComponent<DestinyVendorReceiptsComponent> VendorReceipts { get; set; }

	[JsonPropertyName("profileInventory")]
	public SingleDestinyComponent<DestinyInventoryComponent> ProfileInventory { get; set; }

	[JsonPropertyName("profileCurrencies")]
	public SingleDestinyComponent<DestinyInventoryComponent> ProfileCurrencies { get; set; }

	[JsonPropertyName("profile")]
	public SingleDestinyComponent<DestinyProfileComponent> Profile { get; set; }

	[JsonPropertyName("platformSilver")]
	public SingleDestinyComponent<DestinyPlatformSilverComponent> PlatformSilver { get; set; }

	[JsonPropertyName("profileKiosks")]
	public SingleDestinyComponent<DestinyKiosksComponent> ProfileKiosks { get; set; }

	[JsonPropertyName("profilePlugSets")]
	public SingleDestinyComponent<DestinyPlugSetsComponent> ProfilePlugSets { get; set; }

	[JsonPropertyName("profileProgression")]
	public SingleDestinyComponent<DestinyProfileProgressionComponent> ProfileProgression { get; set; }

	[JsonPropertyName("profilePresentationNodes")]
	public SingleDestinyComponent<DestinyPresentationNodesComponent> ProfilePresentationNodes { get; set; }

	[JsonPropertyName("profileRecords")]
	public SingleDestinyComponent<DestinyProfileRecordsComponent> ProfileRecords { get; set; }

	[JsonPropertyName("profileCollectibles")]
	public SingleDestinyComponent<DestinyProfileCollectiblesComponent> ProfileCollectibles { get; set; }

	[JsonPropertyName("profileTransitoryData")]
	public SingleDestinyComponent<DestinyProfileTransitoryComponent> ProfileTransitoryData { get; set; }

	[JsonPropertyName("metrics")]
	public SingleDestinyComponent<DestinyMetricsComponent> Metrics { get; set; }

	[JsonPropertyName("profileStringVariables")]
	public SingleDestinyComponent<DestinyStringVariablesComponent> ProfileStringVariables { get; set; }

	[JsonPropertyName("characters")]
	public DictionaryDestinyComponent<long, Characters> Characters { get; set; }

	[JsonPropertyName("characterInventories")]
	public DictionaryDestinyComponent<long, DestinyInventoryComponent> CharacterInventories { get; set; }

	[JsonPropertyName("characterProgressions")]
	public DictionaryDestinyComponent<long, DestinyCharacterProgressionComponent> CharacterProgressions { get; set; }

	[JsonPropertyName("characterRenderData")]
	public DictionaryDestinyComponent<long, DestinyCharacterRenderComponent> CharacterRenderData { get; set; }

	[JsonPropertyName("characterActivities")]
	public DictionaryDestinyComponent<long, DestinyCharacterActivitiesComponent> CharacterActivities { get; set; }

	[JsonPropertyName("characterEquipment")]
	public DictionaryDestinyComponent<long, DestinyInventoryComponent> CharacterEquipment { get; set; }

	[JsonPropertyName("characterKiosks")]
	public DictionaryDestinyComponent<long, DestinyKiosksComponent> CharacterKiosks { get; set; }

	[JsonPropertyName("characterPlugSets")]
	public DictionaryDestinyComponent<long, DestinyPlugSetsComponent> CharacterPlugSets { get; set; }

	[JsonPropertyName("characterUninstancedComponents")]
	public Dictionary<long, DestinyBaseItemComponentSet<uint>> CharacterUninstancedComponents { get; set; }

	[JsonPropertyName("characterPresentationNodes")]
	public DictionaryDestinyComponent<long, DestinyPresentationNodesComponent> CharacterPresentationNodes { get; set; }

	[JsonPropertyName("characterRecords")]
	public DictionaryDestinyComponent<long, DestinyCharacterRecordsComponent> CharacterRecords { get; set; }

	[JsonPropertyName("characterCollectibles")]
	public DictionaryDestinyComponent<long, DestinyCollectibleComponent> CharacterCollectibles { get; set; }

	[JsonPropertyName("characterStringVariables")]
	public DictionaryDestinyComponent<long, DestinyStringVariablesComponent> CharacterStringVariables { get; set; }

	[JsonPropertyName("itemComponents")]
	public DestinyItemComponentSet<long> ItemComponents { get; set; }

	[JsonPropertyName("characterCurrencyLookups")]
	public DictionaryDestinyComponent<long, DestinyCurrenciesComponent> CharacterCurrencyLookups { get; set; }
}
using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.User;

namespace BungieNetApi.Entities.Destiny.Responses;

/// <summary>
/// The response for GetDestinyProfile, with components for character and item-level data.
/// </summary>
public struct DestinyProfileResponse
{
	/// <summary>
	/// Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...
	/// </summary>
	[JsonPropertyName("vendorReceipts")]
	public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }

	/// <summary>
	/// The profile-level inventory of the Destiny Profile.
	/// </summary>
	[JsonPropertyName("profileInventory")]
	public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; }
	
	/// <summary>
	/// The profile-level currencies owned by the Destiny Profile.
	/// </summary>
	[JsonPropertyName("profileCurrencies")]
	public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; }

	/// <summary>
	/// The basic information about the Destiny Profile (formerly "Account").
	/// </summary>
	[JsonPropertyName("profile")]
	public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; }

	/// <summary>
	/// Silver quantities for any platform on which this Profile plays destiny.
	/// </summary>
	[JsonPropertyName("platformSilver")]
	public SingleComponentResponseOfDestinyPlatformSilverComponent PlatformSilver { get; set; }

	/// <summary>
	/// Items available from Kiosks that are available Profile-wide (i.e. across all characters)
	/// </summary>
	[JsonPropertyName("profileKiosks")]
	public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; }

	/// <summary>
	/// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this is the set of plugs and their states that are profile-scoped.
	/// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on requested items.
	/// </summary>
	[JsonPropertyName("profilePlugSets")]
	public SingleComponentResponseOfDestinyPlugSetsComponent ProfilePlugSets { get; set; }

	/// <summary>
	/// When we have progression information - such as Checklists - that may apply profile-wide, it will be returned here rather than in the per-character progression data.
	/// </summary>
	[JsonPropertyName("profileProgression")]
	public SingleComponentResponseOfDestinyProfileProgressionComponent ProfileProgression { get; set; }

	[JsonPropertyName("profilePresentationNodes")]
	public SingleComponentResponseOfDestinyPresentationNodesComponent ProfilePresentationNodes { get; set; }

	[JsonPropertyName("profileRecords")]
	public SingleComponentResponseOfDestinyProfileRecordsComponent ProfileRecords { get; set; }

	[JsonPropertyName("profileCollectibles")]
	public SingleComponentResponseOfDestinyProfileCollectiblesComponent ProfileCollectibles { get; set; }

	[JsonPropertyName("profileTransitoryData")]
	public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; set; }

	//[JsonPropertyName("metrics")]
	//public SingleComponentResponseOfDestinyProfileTransitoryComponent ProfileTransitoryData { get; set; }

	[JsonPropertyName("characters")]
	public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; }

	//TODO: Add remaining fields.

	[JsonPropertyName("characterEquipment")]
	public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; }
}
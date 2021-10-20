using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinyItemInventoryBlockDefinition
{
	[JsonPropertyName("stackUniqueLabel")]
	public string StackUniqueLabel { get; set; }

	[JsonPropertyName("maxStackSize")]
	public int MaxStackSize { get; set; }

	[JsonPropertyName("bucketTypeHash")]
	public uint BucketTypeHash { get; set; }

	[JsonPropertyName("recoveryBucketTypeHash")]
	public uint RecoveryBucketTypeHash { get; set; }

	[JsonPropertyName("tierTypeHash")]
	public uint TierTypeHash { get; set; }

	[JsonPropertyName("isInstanceItem")]
	public bool IsInstanceItem { get; set; }

	[JsonPropertyName("tierTypeName")]
	public string TierTypeName { get; set; }

	[JsonPropertyName("tierType")]
	public int TierType { get; set; }

	[JsonPropertyName("expirationTooltip")]
	public string ExpirationTooltip { get; set; }

	[JsonPropertyName("expiredInActivityMessage")]
	public string ExpiredInActivityMessage { get; set; }

	[JsonPropertyName("expiredInOrbitMessage")]
	public string ExpiredInOrbitMessage { get; set; }

	[JsonPropertyName("suppressExpirationWhenObjectivesComplete")]
	public bool SuppressExpirationWhenObjectivesComplete { get; set; }
}


using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Artifacts;

/// <summary>
/// Represents a Seasonal Artifact and all data related to it for the requested Account.
/// It can be combined with Character-scoped data for a full picture of what a character has available/has chosen, or just these settings can be used for overview information.
/// </summary>
public struct DestinyArtifactProfileScoped
{
	/// <remarks>Mapped to Destiny.Definitions.Artifacts.DestinyArtifactDefinition</remarks>
	[JsonPropertyName("artifactHash")]
	public uint ArtifactHash { get; set; }

	[JsonPropertyName("pointProgression")]
	public DestinyProgression PointProgression { get; set; }

	[JsonPropertyName("pointsAcquired")]
	public int PointsAcquired { get; set; }

	[JsonPropertyName("powerBonusProgression")]
	public DestinyProgression PowerBonusProgression { get; set; }

	[JsonPropertyName("powerBonus")]
	public int powerBonus { get; set; }
}

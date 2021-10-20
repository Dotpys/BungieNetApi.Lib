using BungieNetApi.Entities.Destiny.Definitions.Common;

using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Definitions;

public class DestinySeasonDefinition : DestinyDefinition
{
	[JsonPropertyName("displayProperties")]
	public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

	[JsonPropertyName("backgroundImagePath")]
	public string BackgroundImagePath { get; set; }

	[JsonPropertyName("seasonNumber")]
	public int DeasonNumber { get; set; }

	[JsonPropertyName("startDate")]
	public DateTime? StartDate { get; set; }

	[JsonPropertyName("endDate")]
	public DateTime? EndDate { get; set; }

	[JsonPropertyName("seasonPassHash")]
	public uint? SeasonPassHash { get; set; }

	[JsonPropertyName("seasonPassProgressionHash")]
	public uint? SeasonPassProgressionHash { get; set; }

	[JsonPropertyName("artifactItemHash")]
	public uint? ArtifactItemHash { get; set; }

	[JsonPropertyName("sealPresentationNodeHash")]
	public uint? SealPresentationNodeHash { get; set; }

	[JsonPropertyName("seasonalChallengesPresentationNodeHash")]
	public uint? SeasonalChallengesPresentationNodeHash { get; set; }

	/// <summary>
	/// Defines the promotional text, images, and links to preview this season.
	/// </summary>
	// TODO: Implementare
	//[JsonPropertyName("preview")]
	//public DestinySeasonPreviewDefinition Preview { get; set; }

	public override string ToString()
	{
		return DisplayProperties.Name;
	}
}


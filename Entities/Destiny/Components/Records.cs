﻿using BungieNetApi.Entities.Destiny.Quests;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Records;

public class DestinyProfileRecordsComponent
{
	/// <summary>
	/// Your 'active' Triumphs score, maintained for backwards compatibility.
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; set; }

	/// <summary>
	/// Your 'active' Triumphs score.
	/// </summary>
	[JsonPropertyName("activeScore")]
	public int ActiveScore { get; set; }

	/// <summary>
	/// Your 'legacy' Triumphs score.
	/// </summary>
	[JsonPropertyName("legacyScore")]
	public int LegacyScore { get; set; }

	/// <summary>
	/// Your 'lifetime' Triumphs score.
	/// </summary>
	[JsonPropertyName("lifetimeScore")]
	public int LifetimeScore { get; set; }

	/// <summary>
	/// If this profile is tracking a record, this is the hash identifier of the record it is tracking.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.Records.DestinyRecordDefinition</remarks>
	[JsonPropertyName("trackedRecordHash")]
	public uint? TrackedRecordHash { get; set; }

	[JsonPropertyName("records")]
	public Dictionary<uint, DestinyRecordComponent> Records { get; set; }

	/// <summary>
	/// The hash for the root presentation node definition of Triumph categories.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition</remarks>
	[JsonPropertyName("recordCategoriesRootNodeHash")]
	public uint RecordCategoriesRootNodeHash { get; set; }

	/// <summary>
	/// The hash for the root presentation node definition of Triumph Seals.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition</remarks>
	[JsonPropertyName("recordSealsRootNodeHash")]
	public uint RecordSealsRootNodeHash { get; set; }
}

public class DestinyRecordComponent
{
	[JsonPropertyName("state")]
	public int State { get; set; }

	[JsonPropertyName("objectives")]
	public DestinyObjectiveProgress[] Objectives { get; set; }

	[JsonPropertyName("intervalObjectives")]
	public DestinyObjectiveProgress[] IntervalObjectives { get; set; }

	[JsonPropertyName("intervalsRedeemedCount")]
	public int IntervalsRedeemedCount { get; set; }
}

public class DestinyCharacterRecordsComponent
{
	[JsonPropertyName("featuredRecordHashes")]
	public uint[] FeaturedRecordHashes { get; set; }

	[JsonPropertyName("records")]
	public Dictionary<uint, DestinyRecordComponent> Records { get; set; }

	[JsonPropertyName("recordCategoriesRootNodeHash")]
	public uint RecordCategoriesRootNodeHash { get; set; }

	[JsonPropertyName("recordSealsRootNodeHash")]
	public uint RecordSealsRootNodeHash { get; set; }
}

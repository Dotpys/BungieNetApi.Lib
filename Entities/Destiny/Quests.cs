using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Quests;

/// <summary>
/// Returns data about a character's status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
/// </summary>
public class DestinyObjectiveProgress
{
	/// <summary>
	/// The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyObjectiveDefinition</remarks>
	[JsonPropertyName("objectiveHash")]
	public uint ObjectiveHash { get; set; }

	/// <summary>
	/// If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyDestinationDefinition</remarks>
	[JsonPropertyName("destinationHash")]
	public uint? DestinationHash { get; set; }

	/// <summary>
	/// If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.
	/// </summary>
	/// <remarks>Mapped to Destiny.Definitions.DestinyActivityDefinition</remarks>
	[JsonPropertyName("activityHash")]
	public uint? ActivityHash { get; set; }

	/// <summary>
	/// If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.
	/// </summary>
	[JsonPropertyName("progress")]
	public int? Progress { get; set; }

	/// <summary>
	/// As of Forsaken, objectives' completion value is determined dynamically at runtime.
	/// This value represents the threshold of progress you need to surpass in order for this objective to be considered "complete".
	/// If you were using objective data, switch from using the DestinyObjectiveDefinition's "completionValue" to this value.
	/// </summary>
	[JsonPropertyName("completionValue")]
	public int CompletionValue { get; set; }

	/// <summary>
	/// Whether or not the Objective is completed.
	/// </summary>
	[JsonPropertyName("complete")]
	public bool Complete { get; set; }

	/// <summary>
	/// If this is true, the objective is visible in-game. Otherwise, it's not yet visible to the player. Up to you if you want to honor this property.
	/// </summary>
	[JsonPropertyName("visible")]
	public bool Visible { get; set; }
}

public class DestinyQuestStatus
{
	[JsonPropertyName("questHash")]
	public uint QuestHash { get; set; }

	[JsonPropertyName("stepHash")]
	public uint StepHash { get; set; }

	[JsonPropertyName("stepObjectives")]
	public DestinyObjectiveProgress[] StepObjectives { get; set; }

	[JsonPropertyName("tracked")]
	public bool Tracked { get; set; }

	[JsonPropertyName("itemInstanceId")]
	public long ItemInstanceId { get; set; }

	[JsonPropertyName("completed")]
	public bool Completed { get; set; }

	[JsonPropertyName("redeemed")]
	public bool Redeemed { get; set; }

	[JsonPropertyName("started")]
	public bool Started { get; set; }

	[JsonPropertyName("vendorHash")]
	public uint? VendorHash { get; set; }
}
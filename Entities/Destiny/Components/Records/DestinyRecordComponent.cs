using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Destiny.Quests;

namespace BungieNetApi.Entities.Destiny.Components.Records
{
	public struct DestinyRecordComponent
	{
		[JsonPropertyName("state")]
		public int State { get; set; }

		[JsonPropertyName("objectives")]
		public DestinyObjectiveProgress[] Objectives { get; set; }

		[JsonPropertyName("intervalObjectives")]
		public DestinyObjectiveProgress[] intervalObjectives { get; set; }

		[JsonPropertyName("intervalsRedeemedCount")]
		public int IntervalsRedeemedCount { get; set; }
	}
}

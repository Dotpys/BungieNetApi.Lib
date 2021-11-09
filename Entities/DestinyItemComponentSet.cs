using BungieNetApi.Entities.Destiny.Components.Items;
using BungieNetApi.Entities.Destiny.Entities.Items;

using System.Text.Json.Serialization;

namespace BungieNetApi.Entities;

public class DestinyBaseItemComponentSet<T>
{
	[JsonPropertyName("objectives")]
	public DictionaryDestinyComponent<T, DestinyItemObjectivesComponent> Objectives { get; set; }

	[JsonPropertyName("perks")]
	public DictionaryDestinyComponent<T, DestinyItemPerksComponent> Perks { get; set; }
}

public class DestinyItemComponentSet<T> : DestinyBaseItemComponentSet<T>
{
	[JsonPropertyName("instances")]
	public DictionaryDestinyComponent<T, DestinyItemInstanceComponent> Instances { get; set; }

	[JsonPropertyName("renderData")]
	public DictionaryDestinyComponent<T, DestinyItemRenderComponent> RenderData { get; set; }

	[JsonPropertyName("stats")]
	public DictionaryDestinyComponent<T, DestinyItemStatsComponent> Stats { get; set; }

	[JsonPropertyName("sockets")]
	public DictionaryDestinyComponent<T, DestinyItemSocketsComponent> Sockets { get; set; }

	[JsonPropertyName("reusablePlugs")]
	public DictionaryDestinyComponent<T, DestinyItemReusablePlugsComponent> ReusablePlugs { get; set; }

	[JsonPropertyName("plugObjectives")]
	public DictionaryDestinyComponent<T, DestinyItemPlugObjectivesComponent> PlugObjectives { get; set; }

	[JsonPropertyName("talentGrids")]
	public DictionaryDestinyComponent<T, DestinyItemTalentGridComponent> TalentGrids { get; set; }

	[JsonPropertyName("plugStates")]
	public DictionaryDestinyComponent<T, DestinyItemPlugComponent> PlugStates { get; set; }
}
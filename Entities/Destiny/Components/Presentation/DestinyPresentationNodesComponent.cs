using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Components.Presentation;

public class DestinyPresentationNodesComponent
{
	/// <remarks>Mapped to Destiny.Definitions.Presentation.DestinyPresentationNodeDefinition</remarks>
	[JsonPropertyName("nodes")]
	public Dictionary<uint, DestinyPresentationNodeComponent> Nodes { get; set; }
}

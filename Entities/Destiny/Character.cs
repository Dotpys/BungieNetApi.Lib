using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Character;

public class DestinyCharacterCustomization
{
	[JsonPropertyName("personality")]
	public uint Personality { get; set; }

	[JsonPropertyName("face")]
	public uint Face { get; set; }

	[JsonPropertyName("skinColor")]
	public uint SkinColor { get; set; }

	[JsonPropertyName("lipColor")]
	public uint LipColor { get; set; }

	[JsonPropertyName("eyeColor")]
	public uint EyeColor { get; set; }

	[JsonPropertyName("hairColors")]
	public uint HairColors { get; set; }

	[JsonPropertyName("featureColors")]
	public uint FeatureColors { get; set; }

	[JsonPropertyName("decalColor")]
	public uint DecalColor { get; set; }

	[JsonPropertyName("wearHelmet")]
	public uint WearHelmet { get; set; }

	[JsonPropertyName("hairIndex")]
	public uint HairIndex { get; set; }

	[JsonPropertyName("featureIndex")]
	public uint FeatureIndex { get; set; }

	[JsonPropertyName("decalIndex")]
	public uint DecalIndex { get; set; }
}

public class DestinyCharacterPeerView
{
	[JsonPropertyName("equipment")]
	public DestinyItemPeerView[] Equipment { get; set; }
}

public class DestinyItemPeerView
{
	[JsonPropertyName("itemHash")]
	public uint ItemHash { get; set; }

	[JsonPropertyName("dyes")]
	public DyeReference[] Dyes { get; set; }
}

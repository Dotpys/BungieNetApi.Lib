using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Destiny.Perks;

public class DestinyPerkReference
{
	[JsonPropertyName("perkHash")]
	public uint PerkHash { get; set; }

	[JsonPropertyName("iconPath")]
	public uint IconPath { get; set; }

	[JsonPropertyName("isActive")]
	public bool IsActive { get; set; }

	[JsonPropertyName("visible")]
	public bool Visible { get; set; }
}

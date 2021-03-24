using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.Config
{
	public class UserTheme
	{
		[JsonPropertyName("userThemeId")]
		public int UserThemeId { get; set; }

		[JsonPropertyName("userThemeName")]
		public string UserThemeName { get; set; }

		[JsonPropertyName("userThemeDescription")]
		public string UserThemeDescription { get; set; }
	}
}
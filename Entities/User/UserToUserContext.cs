using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.Ignores;

namespace BungieNetApi.Entities.User;

public class UserToUserContext
{
	[JsonPropertyName("isFollowing")]
	public bool IsFollowing { get; set; }
		
	[JsonPropertyName("ignoreStatus")]
	public IgnoreResponse IgnoreStatus { get; set; }

	[JsonPropertyName("globalIgnoreEndDate")]
	public DateTime? GlobalIgnoreEndDate { get; set; }
}
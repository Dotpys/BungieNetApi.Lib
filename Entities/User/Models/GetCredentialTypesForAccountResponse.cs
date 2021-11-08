using System;
using System.Text.Json.Serialization;

namespace BungieNetApi.Entities.User.Models;

public class GetCredentialTypesForAccountResponse
{
	[JsonPropertyName("credentialType")]
	public byte CredentialType { get; set; }

	[JsonPropertyName("credentialDisplayName")]
	public string CredentialDisplayName { get; set; }

	[JsonPropertyName("isPublic")]
	public bool IsPublic { get; set; }

	[JsonPropertyName("credentialAsString")]
	public string CredentialAsString { get; set; }
}
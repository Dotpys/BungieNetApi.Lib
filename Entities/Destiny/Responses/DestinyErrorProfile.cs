using System;
using System.Text.Json.Serialization;
using BungieNetApi.Entities.User;

namespace BungieNetApi.Entities.Destiny.Responses;

/// <summary>
/// If a Destiny Profile can't be returned, but we're pretty certain it's a valid Destiny account, this will contain as much info as we can get about the profile for your use.
/// Assume that the most you'll get is the Error Code, the Membership Type and the Membership ID.
/// </summary>
public struct DestinyErrorProfile
{
	/// <summary>
	/// The error that we encountered. You should be able to look up localized text to show to the user for these failures.
	/// </summary>
	[JsonPropertyName("errorCode")]
	public int ErrorCode { get; set; }

	/// <summary>
	/// Basic info about the account that failed. Don't expect anything other than membership ID, Membership Type, and displayName to be populated.
	/// </summary>
	[JsonPropertyName("infoCard")]
	public UserInfoCard InfoCard { get; set; }
}
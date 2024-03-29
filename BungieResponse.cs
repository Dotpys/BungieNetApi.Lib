using System;
using System.Collections.Generic;

namespace BungieNetApi;

public struct BungieResponse<T>
{
	public T Response { get; set; }
	public int ErrorCode { get; set; }
	public int ThrottleSeconds { get; set; }
	public string ErrorStatus { get; set; }
	public string Message { get; set; }
	public Dictionary<string, string> MessageData { get; set; }
	public string DetailedErrorTrace { get; set; }
}
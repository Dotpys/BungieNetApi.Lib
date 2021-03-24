using System;
using System.Text.Json;
using BungieNetApi.Converters;

namespace BungieNetApi
{
	public class StaticData
	{
		public const string BUNGIE_NET_ENDPOINT = "https://www.bungie.net";
		public static readonly JsonSerializerOptions bungieApiJsonConverter = new JsonSerializerOptions()
		{
			Converters =
			{
				new LongConverter()
			}
		};
	}
}
using System;

namespace ComicBook
{
	public static class ServerInfo
	{
		public static Uri AuthorizationEndpoint = new Uri("http://10.0.0.18.xip.io/MVCOauthProject/OAuth2/Authorize");
		public static Uri TokenEndpoint         = new Uri("http://10.0.0.18.xip.io/MVCOauthProject/OAuth2/token");
		public static Uri ApiEndpoint           = new Uri("http://10.0.0.18.xip.io/WebApiOauth/api/Customers");
		public static Uri RedirectionEndpoint 		= new Uri("http://www.xamarin.com");
		public static string ClientId 				= "A8375B66";
		public static string ClientSecret 			= "A32D8C3CBE9A";
	}
}
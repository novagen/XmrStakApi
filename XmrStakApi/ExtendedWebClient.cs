using System;
using System.Net;

namespace XmrStakApi
{
	public class ExtendedWebClient : WebClient
	{
		public int TimeOut { get; set; }

		protected override WebRequest GetWebRequest(Uri uri)
		{
			var webRequest = base.GetWebRequest(uri);

			if (TimeOut > 0)
			{
				webRequest.Timeout = TimeOut * 60 * 1000;
			}

			return webRequest;
		}
	}
}

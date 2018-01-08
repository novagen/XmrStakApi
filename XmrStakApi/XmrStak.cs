using Newtonsoft.Json;
using System;
using System.Net;

namespace XmrStakApi
{
    public class XmrStak
    {
		private const int _defaultTimeOut = 30;

		private WebProxy Proxy { get; set; }
		private int TimeOut { get; set; }

		public XmrStak()
		{
		}

		public XmrStak(int timeOut = _defaultTimeOut)
		{
			TimeOut = timeOut;
		}

		public XmrStak(WebProxy proxy, int timeOut = _defaultTimeOut)
		{
			Proxy = proxy;
			TimeOut = timeOut;
		}

		public void SetProxy(WebProxy proxy)
		{
			Proxy = proxy;
		}

		public void SetTimeOut(int timeOut)
		{
			TimeOut = timeOut;
		}

		public MinerResponse GetData(Miner miner)
		{
			var result = new MinerResponse();

			using (var client = new ExtendedWebClient())
			{
				client.TimeOut = TimeOut;

				if (Proxy != null)
				{
					WebRequest.DefaultWebProxy = Proxy;
					client.Proxy = Proxy;
				}

				if (miner.Credentials != null)
				{
					client.Credentials = miner.Credentials;

					try
					{
						client.OpenRead(miner.Uri);
					}
					catch (Exception e)
					{
						result.Error = new WebError(DateTime.Now, e.Message);
					}
				}

				try
				{
					var response = client.DownloadString(miner.Uri);

					if (response != null)
					{
						result.Data = JsonConvert.DeserializeObject<Data>(response);
						result.Status = true;
					}
				}
				catch (Exception e)
				{
					result.Error = new WebError(DateTime.Now, e.Message);
				}
			}

			return result;
		}
    }
}

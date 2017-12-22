using System;
using System.Net;

namespace XmrStakApi
{
    public class XmrStak
    {
		public WebProxy Proxy { get; set; }

		public XmrStak()
		{
		}

		public Miner GetData(Miner miner)
		{
			miner.Error = null;

			if (!miner.Url.StartsWith("http"))
			{
				miner.Url = $"http://{miner.Url}";
			}

			using (var client = new WebClient())
			{
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
						miner.Error = new WebError(DateTime.Now, e.Message);
					}
				}

				try
				{
					miner.Response = client.DownloadString(miner.Uri);
				}
				catch (Exception e)
				{
					miner.Error = new WebError(DateTime.Now, e.Message);
				}
			}

			return miner;
		}
    }
}

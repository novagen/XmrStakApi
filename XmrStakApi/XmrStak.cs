using System;
using System.Net;

namespace XmrStakApi
{
    public class XmrStak
    {
		public static Miner GetData(Miner miner)
		{
			miner.Error = null;

			if (!miner.Url.StartsWith("http"))
			{
				miner.Url = $"http://{miner.Url}";
			}

			using (var client = new WebClient())
			{
				if (miner.Proxy != null)
				{
					WebRequest.DefaultWebProxy = miner.Proxy;
					client.Proxy = miner.Proxy;
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

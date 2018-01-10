namespace XmrStakApi.Extensions
{
	[System.ComponentModel.DesignerCategory("Code")]
	public class TimeoutClient : System.Net.WebClient, System.ComponentModel.INotifyPropertyChanged
	{
		private int _timeout { get; set; }
		private bool _disableCache { get; set; }

		public int Timeout
		{
			get
			{
				return _timeout;
			}

			set
			{
				if (_timeout == value) return;

				_timeout = value;
				OnPropertyChanged(nameof(Timeout));
			}
		}

		public bool DisableCache
		{
			get
			{
				return _disableCache;
			}

			set
			{
				if (_disableCache == value) return;

				_disableCache = value;
				OnPropertyChanged(nameof(DisableCache));
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		public TimeoutClient(int timeout) : base()
		{
			_timeout = timeout;
		}

		public TimeoutClient(bool disableCache) : base()
		{
			_disableCache = disableCache;
		}

		public TimeoutClient(int timeout, bool disableCache) : base()
		{
			_timeout = timeout;
			_disableCache = disableCache;
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		protected override System.Net.WebRequest GetWebRequest(System.Uri uri)
		{
			var webRequest = base.GetWebRequest(uri);

			if (Timeout > 0)
			{
				webRequest.Timeout = Timeout * 60 * 1000;
			}

			if (DisableCache)
			{
				webRequest.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
			}
			else
			{
				webRequest.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.Default);
			}

			return webRequest;
		}
	}
}
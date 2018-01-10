using Newtonsoft.Json;

namespace XmrStakApi.Data
{
	public class MinerData : Notifiable
	{
		private string _version { get; set; }
		private Hashrate _hashrate { get; set; }
		private Results _results { get; set; }
		private Connection _connection { get; set; }

		[JsonProperty("version")]
		public string Version
		{
			get
			{
				return _version;
			}

			set
			{
				if (_version == value) return;

				_version = value;
				OnPropertyChanged(nameof(Version));
			}
		}

		[JsonProperty("hashrate")]
		public Hashrate Hashrate
		{
			get
			{
				return _hashrate;
			}

			set
			{
				if (_hashrate == value) return;

				_hashrate = value;
				OnPropertyChanged(nameof(Hashrate));
			}
		}

		[JsonProperty("results")]
		public Results Results
		{
			get
			{
				return _results;
			}

			set
			{
				if (_results == value) return;

				_results = value;
				OnPropertyChanged(nameof(Results));
			}
		}

		[JsonProperty("connection")]
		public Connection Connection
		{
			get
			{
				return _connection;
			}

			set
			{
				if (_connection == value) return;

				_connection = value;
				OnPropertyChanged(nameof(Connection));
			}
		}
	}
}
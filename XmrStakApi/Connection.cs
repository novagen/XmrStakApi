using Newtonsoft.Json;
using System.Collections.Generic;

namespace XmrStakApi
{
	public class Connection : Notifiable
	{
		private string _pool { get; set; }
		private int _uptime { get; set; }
		private int _ping { get; set; }
		private List<object> _errorLog { get; set; }

		[JsonProperty("pool")]
		public string Pool
		{
			get
			{
				return _pool;
			}

			set
			{
				if (_pool == value) return;

				_pool = value;
				OnPropertyChanged(nameof(Pool));
			}
		}

		[JsonProperty("uptime")]
		public int Uptime
		{
			get
			{
				return _uptime;
			}

			set
			{
				if (_uptime == value) return;

				_uptime = value;
				OnPropertyChanged(nameof(Uptime));
			}
		}

		[JsonProperty("ping")]
		public int Ping
		{
			get
			{
				return _ping;
			}

			set
			{
				if (_ping == value) return;

				_ping = value;
				OnPropertyChanged(nameof(Ping));
			}
		}

		[JsonProperty("error_log")]
		public List<object> ErrorLog
		{
			get
			{
				return _errorLog;
			}

			set
			{
				if (_errorLog == value) return;

				_errorLog = value;
				OnPropertyChanged(nameof(ErrorLog));
			}
		}

		public Connection()
		{
			ErrorLog = new List<object>();
		}
	}
}
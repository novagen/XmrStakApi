using Newtonsoft.Json;

namespace XmrStakApi
{
	public class Data
	{
		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("hashrate")]
		public Hashrate Hashrate { get; set; }

		[JsonProperty("results")]
		public Results Results { get; set; }

		[JsonProperty("connection")]
		public Connection Connection { get; set; }
	}

	public class Hashrate
	{
		[JsonProperty("threads")]
		public float?[][] Threads { get; set; }

		[JsonProperty("total")]
		public float?[] Total { get; set; }

		[JsonProperty("highest")]
		public float Highest { get; set; }
	}

	public class Results
	{
		[JsonProperty("diff_current")]
		public int DiffCurrent { get; set; }

		[JsonProperty("shares_good")]
		public int SharesGood { get; set; }

		[JsonProperty("shares_total")]
		public int SharesTotal { get; set; }

		[JsonProperty("avg_time")]
		public float AvgTime { get; set; }

		[JsonProperty("hashes_total")]
		public int HashesTotal { get; set; }

		[JsonProperty("best")]
		public int[] Best { get; set; }

		[JsonProperty("error_log")]
		public Error_Log[] ErrorLog { get; set; }
	}

	public class Error_Log
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("last_seen")]
		public int LastSeen { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }
	}

	public class Connection
	{
		[JsonProperty("pool")]
		public string Pool { get; set; }

		[JsonProperty("uptime")]
		public int Uptime { get; set; }

		[JsonProperty("ping")]
		public int Ping { get; set; }

		[JsonProperty("error_log")]
		public object[] ErrorLog { get; set; }
	}
}
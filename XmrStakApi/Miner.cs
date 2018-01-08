using Newtonsoft.Json;
using System;
using System.Net;

namespace XmrStakApi
{
	public class Miner
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public int Port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		public MinerResponse Data { get; set; }

		public Miner() { }

		public Miner(string name, string url, int port, string username, string password)
		{
			Name = name;
			Url = url;
			Port = port;
			Username = username;
			Password = password;
		}

		public Uri Uri
		{
			get
			{
				var result = $"{Url}:{Port}/api.json";

				if (!result.StartsWith("http"))
				{
					result = $"http://{result}";
				}

				return new Uri(result);
			}
		}

		public bool Secured
		{
			get
			{
				return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
			}
		}

		public NetworkCredential Credentials
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
				{
					return new NetworkCredential(Username, Password);
				}

				return null;
			}
		}

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}
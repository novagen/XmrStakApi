using Newtonsoft.Json;
using System;
using System.Net;
using XmrStakApi.Response;
using XmrStakApi.Extensions;

namespace XmrStakApi
{
	public class Miner : Notifiable
	{
		private string _id { get; set; }
		private string _name { get; set; }
		private string _url { get; set; }
		private int _port { get; set; }
		private string _username { get; set; }
		private string _password { get; set; }
		private MinerResponse _data { get; set; }

		public string Id
		{
			get
			{
				return _id;
			}

			set
			{
				if (_id == value) return;

				_id = value;
				OnPropertyChanged(nameof(Id));
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				if (_name == value) return;

				_name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public string Url
		{
			get
			{
				return _url;
			}

			set
			{
				if (_url == value) return;

				_url = value;
				OnPropertyChanged(nameof(Url));
			}
		}

		public int Port
		{
			get
			{
				return _port;
			}

			set
			{
				if (_port == value) return;

				_port = value;
				OnPropertyChanged(nameof(Port));
			}
		}

		public string Username
		{
			get
			{
				return _username;
			}

			set
			{
				if (_username == value) return;

				_username = value;
				OnPropertyChanged(nameof(Username));
			}
		}

		public string Password
		{
			get
			{
				return _password;
			}

			set
			{
				if (_password == value) return;

				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		public MinerResponse Data
		{
			get
			{
				return _data;
			}

			set
			{
				if (_data == value) return;

				_data = value;
				OnPropertyChanged(nameof(Data));
			}
		}

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
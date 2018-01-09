using Newtonsoft.Json;
using System.Collections.Generic;

namespace XmrStakApi
{
	public class Hashrate : Notifiable
	{
		private List<List<float?>> _threads { get; set; }
		private List<float?> _total { get; set; }
		private float _highest { get; set; }

		[JsonProperty("threads")]
		public List<List<float?>> Threads
		{
			get
			{
				return _threads;
			}

			set
			{
				if (_threads == value) return;

				_threads = value;
				OnPropertyChanged(nameof(Threads));
			}
		}

		[JsonProperty("total")]
		public List<float?> Total
		{
			get
			{
				return _total;
			}

			set
			{
				if (_total == value) return;

				_total = value;
				OnPropertyChanged(nameof(Total));
			}
		}

		[JsonProperty("highest")]
		public float Highest
		{
			get
			{
				return _highest;
			}

			set
			{
				if (_highest == value) return;

				_highest = value;
				OnPropertyChanged(nameof(Highest));
			}
		}

		public Hashrate()
		{
			Threads = new List<List<float?>>();
			Total = new List<float?>();
		}
	}
}
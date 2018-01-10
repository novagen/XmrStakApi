using Newtonsoft.Json;
using System.Collections.Generic;
using XmrStakApi.Extensions;

namespace XmrStakApi.Data
{
	public class Results : Notifiable
	{
		private int _diffCurrent { get; set; }
		private int _sharesGood { get; set; }
		private int _sharesTotal { get; set; }
		private float _avgTime { get; set; }
		private int _hashesTotal { get; set; }
		private List<int> _best { get; set; }
		private List<ErrorLog> _errorLog { get; set; }

		[JsonProperty("diff_current")]
		public int DiffCurrent
		{
			get
			{
				return _diffCurrent;
			}

			set
			{
				if (_diffCurrent == value) return;

				_diffCurrent = value;
				OnPropertyChanged(nameof(DiffCurrent));
			}
		}

		[JsonProperty("shares_good")]
		public int SharesGood
		{
			get
			{
				return _sharesGood;
			}

			set
			{
				if (_sharesGood == value) return;

				_sharesGood = value;
				OnPropertyChanged(nameof(SharesGood));
			}
		}

		[JsonProperty("shares_total")]
		public int SharesTotal
		{
			get
			{
				return _sharesTotal;
			}

			set
			{
				if (_sharesTotal == value) return;

				_sharesTotal = value;
				OnPropertyChanged(nameof(SharesTotal));
			}
		}

		[JsonProperty("avg_time")]
		public float AvgTime
		{
			get
			{
				return _avgTime;
			}

			set
			{
				if (_avgTime == value) return;

				_avgTime = value;
				OnPropertyChanged(nameof(AvgTime));
			}
		}

		[JsonProperty("hashes_total")]
		public int HashesTotal
		{
			get
			{
				return _hashesTotal;
			}

			set
			{
				if (_hashesTotal == value) return;

				_hashesTotal = value;
				OnPropertyChanged(nameof(HashesTotal));
			}
		}

		[JsonProperty("best")]
		public List<int> Best
		{
			get
			{
				return _best;
			}

			set
			{
				if (_best == value) return;

				_best = value;
				OnPropertyChanged(nameof(Best));
			}
		}

		[JsonProperty("error_log")]
		public List<ErrorLog> ErrorLog
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

		public Results()
		{
			Best = new List<int>();
			ErrorLog = new List<ErrorLog>();
		}
	}
}
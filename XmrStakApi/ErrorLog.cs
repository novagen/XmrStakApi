using Newtonsoft.Json;

namespace XmrStakApi
{
	public class ErrorLog : Notifiable
	{
		private int _count { get; set; }
		private int _lastSeen { get; set; }
		private string _text { get; set; }

		[JsonProperty("count")]
		public int Count
		{
			get
			{
				return _count;
			}

			set
			{
				if (_count == value) return;

				_count = value;
				OnPropertyChanged(nameof(Count));
			}
		}

		[JsonProperty("last_seen")]
		public int LastSeen
		{
			get
			{
				return _lastSeen;
			}

			set
			{
				if (_lastSeen == value) return;

				_lastSeen = value;
				OnPropertyChanged(nameof(LastSeen));
			}
		}

		[JsonProperty("text")]
		public string Text
		{
			get
			{
				return _text;
			}

			set
			{
				if (_text == value) return;

				_text = value;
				OnPropertyChanged(nameof(Text));
			}
		}
	}
}
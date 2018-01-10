using System;

namespace XmrStakApi.Data
{
	public class WebError : Notifiable
	{
		private DateTime _time { get; set; }
		private string _message { get; set; }

		public DateTime Time
		{
			get
			{
				return _time;
			}

			set
			{
				if (_time == value) return;

				_time = value;
				OnPropertyChanged(nameof(Time));
			}
		}

		public string Message
		{
			get
			{
				return _message;
			}

			set
			{
				if (_message == value) return;

				_message = value;
				OnPropertyChanged(nameof(Message));
			}
		}

		public WebError(DateTime time, string message)
		{
			Time = time;
			Message = message;
		}
	}
}

namespace XmrStakApi
{
	public class MinerResponse : Notifiable
	{
		private WebError _error { get; set; }
		private bool _status { get; set; }
		private Data _data { get; set; }

		public WebError Error
		{
			get
			{
				return _error;
			}

			set
			{
				if (_error == value) return;

				_error = value;
				OnPropertyChanged(nameof(Error));
			}
		}

		public bool Status
		{
			get
			{
				return _status;
			}

			set
			{
				if (_status == value) return;

				_status = value;
				OnPropertyChanged(nameof(Status));
			}
		}

		public Data Data
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
	}
}

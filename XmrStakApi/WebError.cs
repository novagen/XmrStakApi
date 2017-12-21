using System;

namespace XmrStakApi
{
	public class WebError
	{
		public DateTime Time { get; set; }
		public string Message { get; set; }

		public WebError(DateTime time, string message)
		{
			Time = time;
			Message = message;
		}
	}
}

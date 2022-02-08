using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitExample.Results
{
	public struct Result
	{
		public int StatusCode { get; set; }
		public string Message { get; set; }
		public bool IsOk { get; set; }
		public object Data { get; set; }
	}
}

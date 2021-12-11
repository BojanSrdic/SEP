using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.DTOs
{
	public class CreateTransaction
	{
		public double Amount { get; set; }
		public string SourceAccount { get; set; }
		public string DestinationAccount { get; set; }
	}
}

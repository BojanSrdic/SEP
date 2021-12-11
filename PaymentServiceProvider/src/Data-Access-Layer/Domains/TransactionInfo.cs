using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Domains
{
	public class TransactionInfo
	{
		public int Id { get; set; }
		public double Amount { get; set; }
		public string SourceAccount { get; set; }
		public string DestinationAccount { get; set; }
	}
}

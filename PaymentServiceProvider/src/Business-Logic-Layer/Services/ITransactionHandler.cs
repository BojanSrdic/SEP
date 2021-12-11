using Business_Logic_Layer.DTOs;
using Data_Access_Layer.DbConnection;
using Data_Access_Layer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business_Logic_Layer.Services
{
	public interface ITransactionHandler
	{
		void CreateTransaction(CreateTransaction model);
		List<TransactionInfo> GetAll();
	}

	public class TransactionHandler : ITransactionHandler
	{
		private readonly DatabaseContext _context;
		public TransactionHandler(DatabaseContext context)
		{
			_context = context;
		}
		public void CreateTransaction(CreateTransaction model)
		{
			var tran = new TransactionInfo
			{
				Amount = model.Amount,
				SourceAccount = model.SourceAccount,
				DestinationAccount = model.DestinationAccount
			};

			_context.Transactions.Add(tran);
			_context.SaveChanges();
		}

		public List<TransactionInfo> GetAll()
		{
			return _context.Transactions.ToList();
		}
	}
}

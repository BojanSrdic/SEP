using Data_Access_Layer.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.DbConnection
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
		{

		}
		public DbSet<TransactionInfo> Transactions { get; set; }
	}
}

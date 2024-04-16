using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Tests.Mocks
{
	public static class DatabaseMock
	{
		public static ApplicationDbContext Instance
		{
			get
			{
				var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
					.UseInMemoryDatabase("GroceryHubInMemoryDb" + DateTime.Now.Ticks.ToString())
					.Options;

				return new ApplicationDbContext(dbContextOptions, false);
			}
		}
	}
}

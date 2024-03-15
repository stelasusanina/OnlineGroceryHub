using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
	public class BlogService:IBlogService
	{
		private readonly ApplicationDbContext context;

		public BlogService(ApplicationDbContext context)
		{
			this.context = context;
		}


	}
}

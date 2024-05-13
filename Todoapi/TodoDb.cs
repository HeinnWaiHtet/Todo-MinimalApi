using System;
using Microsoft.EntityFrameworkCore;

namespace Todoapi
{
	public class TodoDb: DbContext
	{
		public TodoDb(DbContextOptions<TodoDb> options): base(options)
		{
		}

		public DbSet<TodoItem> Todos { get; set; }
	}
}


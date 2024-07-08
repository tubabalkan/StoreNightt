﻿using Microsoft.EntityFrameworkCore;
using StoreNightt.Application.Interfaces;
using StoreNightt.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNightt.Persistance.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly StoreContext _context;

		public Repository(StoreContext context)
		{
			_context = context;
		}

		public async Task CreateAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var value=await _context.Set<T>().FindAsync(id);
			_context.Set<T>().Remove(value);
			await _context.SaveChangesAsync();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}

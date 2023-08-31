﻿using Amazon.DataAccess.Data;
using Amazon.DataAccess.Repository.IRepository;
using Amazon.Models;

namespace Amazon.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
    }
}

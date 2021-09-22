using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart_DataAccess.Repository.IRepository;
using ShoppingCart_Models;
using ShoppingCart_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    
        public void Update(OrderDetails obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}

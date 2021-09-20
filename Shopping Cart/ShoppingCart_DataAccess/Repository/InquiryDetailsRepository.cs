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
    public class InquiryDetailsRepository : Repository<InquiryDetails>, IInquiryDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    
        public void Update(InquiryDetails obj)
        {
            _db.InquiryDetails.Update(obj);
        }      
    }
}

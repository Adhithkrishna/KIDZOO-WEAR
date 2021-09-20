﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart_Utility
{
    public static class WC
    {
        public static string Imagepath = @"\Images\Product\";
        public static string SessionCart = "ShoppingCartSession";
        public static string SessionInquiryId = "InquirySession";

        public const string AdminRole = "Admin";
        public const string CustomerRole = "Customer";

        public static string EmailAdmin = "adhith.devops@gmail.com";

        public const string CategoryName = "Category";

        public const string Success = "Success";
        public const string Error = "Error";
    }
}

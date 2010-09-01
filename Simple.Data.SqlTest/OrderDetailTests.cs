﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simple.Data.SqlTest
{
    [TestClass]
    public class OrderDetailTests
    {
        [TestMethod]
        public void TestOrderDetail()
        {
            var db = DatabaseHelper.Open();
            var order = db.Orders.FindByOrderDate(DateTime.Today);
            IEnumerable<dynamic> orderItems = order.OrderItems;
            var orderItem = orderItems.FirstOrDefault();
            var item = orderItem.Item;
            Assert.AreEqual("Widget", item.Name);
        }
    }
}

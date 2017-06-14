using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace TeslaSalesTable.Test
{
    [TestClass]
    public class TeslaSalsesTableTest
    {
        private List<ISalesTableData> CreatTeslaSalesTable()
        {
            List<ISalesTableData> list = new List<ISalesTableData>();

            list.Add(new TeslaSalesTableData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            list.Add(new TeslaSalesTableData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            list.Add(new TeslaSalesTableData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            list.Add(new TeslaSalesTableData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            list.Add(new TeslaSalesTableData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            list.Add(new TeslaSalesTableData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            list.Add(new TeslaSalesTableData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            list.Add(new TeslaSalesTableData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            list.Add(new TeslaSalesTableData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            list.Add(new TeslaSalesTableData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            list.Add(new TeslaSalesTableData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
            return list;
        }

        [TestMethod]
        public void TestTable_三筆一組取Cost總和()
        {
            //arrange
            List<ISalesTableData> datalist = CreatTeslaSalesTable();
            var expected = new List<int> { 6, 15, 24, 21 };

            //act
            List<int> actual = TeslaSalesTable.CheckEveryGroupSumByColumnName(datalist, 3, "Cost");

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void TestTable_四筆一組取Revenue總和()
        {
            //arrange
            List<ISalesTableData> datalist = CreatTeslaSalesTable();
            var expected = new List<int> { 50, 66, 60 };

            //act
            List<int> actual = TeslaSalesTable.CheckEveryGroupSumByColumnName(datalist, 4, "Revenue");

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}

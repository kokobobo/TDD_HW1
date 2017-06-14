using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSalesTable
{
    public class TeslaSalesTable
    {
        public static List<int> CheckEveryGroupSumByColumnName(List<ISalesTableData> salestablelist, int itemInGroup, string columnname) 
        {
            List<int> result = new List<int>();
            int groupSum = 0;
            int itemCount = 1;

            //筆數輸入負或零數，預期會拋 ArgumentException
            if (itemInGroup <= 0)
            {
                throw new ArgumentException("Group number less or equal zero!");
            }

            //尋找的欄位若不存在，預期會拋 ArgumentException
            if (salestablelist.First().GetType().GetProperty(columnname) == null)
            {
                throw new ArgumentException("SalesTable doesn't contain this columnName !");
            }

            foreach (ISalesTableData item in salestablelist)
            {
                groupSum += (int)item.GetType().GetProperty(columnname).GetValue(item);
                if (itemCount % itemInGroup != 0)
                {
                    if (itemCount == salestablelist.Count)
                    {
                        result.Add(groupSum);
                    } 
                }
                else
                {
                    result.Add(groupSum);
                    groupSum = 0;
                }
                itemCount++;
            }
            return result;
        }
    }

    public class TeslaSalesTableData : ISalesTableData
    {
        public int Cost { get; set;}
        public int Id { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

}

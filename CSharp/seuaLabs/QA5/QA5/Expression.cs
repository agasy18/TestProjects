using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA5
{
    public class Expression
    {
        //public static int Calculate(string str)
        //{
        //    string[] operands = str.Split(new char[] { '+', '-', '*', '/' });
        //
        //}

        public static double Calc(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), str);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
            }
            catch(Exception e)
            {
                throw new ArgumentException("can't parse", "input sting ("+str+")", e);
            }
        }
    }
}

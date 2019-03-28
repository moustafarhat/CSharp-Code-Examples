using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 150;
            string accountNo = "";
            float anyNo = 3.1f;

            accountNo = serialNo.ToString();

            Console.WriteLine(accountNo);

            //serialNo = Convert.ToInt32(anyNo);
            serialNo = (int)anyNo;

            Console.WriteLine(serialNo);
        }
    }
}

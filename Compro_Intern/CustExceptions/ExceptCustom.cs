using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compro_Intern.CustExceptions
{
    public class ExceptCustom: Exception
    {
        public ExceptCustom(string a):base(String.Format(a))
            //: base(String.Format("Invalid Email ,,the email is already registerd"))
        {
            //String.Format(a);

        }

        //public ExceptCustom(string s)
        //{

        //}
    }

   
}

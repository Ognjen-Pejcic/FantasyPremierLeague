using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Validation
{
    public class Validation : ValidationAttribute
    { 
        public override bool IsValid(object value)
        {
            ErrorMessage = "Nestoo";
            if(value is string s)
            {
                if (s.Length < 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}

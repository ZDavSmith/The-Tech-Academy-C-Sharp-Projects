using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProjectTechAcad
{
    public class Number
    {
        public static Number Addition(int userNum)
        {
            Number num = new Number();
            num.Adding = userNum + 5;
            return num.Adding;
        }


    public int Adding { get; set; }
    }
}

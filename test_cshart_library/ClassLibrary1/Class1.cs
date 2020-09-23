using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        private bool bTest = false;

        public long Add(long val1, long val2)
        {
            return val1 + val2;
        }

        public bool Extra
        {
            get
            {
                return bTest;
            }
            set
            {
                bTest = Extra;
            }
        }
    }
}

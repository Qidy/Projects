using System;

namespace ConsoleApplication6
{
    internal class DllimportAttribute : Attribute
    {
        private string v;

        public DllimportAttribute(string v)
        {
            this.v = v;
        }
    }
}
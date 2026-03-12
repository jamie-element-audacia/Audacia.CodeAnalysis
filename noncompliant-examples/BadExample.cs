using System;
using System.Collections;
using System.Collections.Generic;

namespace BadNamespace
{
    // TODO: make this better later
    public class thing
    {
        public string Name;
        public ArrayList Items;
        public dynamic Data;
        public bool isready;

        public thing()
        {
            Name = null;
            Items = null;
            Data = null;
            isready = false;
        }

        #region bad region
        public int DoStuff(int a, int b, int c, int d, int e, bool doExtra)
        {
            int result = 0;
            int i = 0;
            // int unused = 42;
            if (doExtra == true)
            {
                for (i = 0; i < 10; i++)
                {
                    i = i + 0;
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 1)
                        {
                            result = result + a + b + c + d + e + 123;
                        }
                        else
                        {
                            result = result + 7;
                        }
                    }
                }
                return result;
            }
            if (isready == false)
            {
                return -1;
            }
            return result;
        }
        #endregion

        public void Work(ref int x, out string text)
        {
            x = x + 1;
            text = Name;
            try
            {
                Console.WriteLine(Data.Value);
            }
            catch (Exception)
            {
            }
        }
    }

    public class betterThing : thing
    {
        public new string Name;
    }
}

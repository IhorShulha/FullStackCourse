using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Point
    {
        int n;
        int k;
        string name;

        public int N => n;
        public int K => k;
        public string Name => name;

        public Point (int n, int k, string name)
        {
            this.n = n;
            this.k = k;
            this.name = name;
        }


    }
}

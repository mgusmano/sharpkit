//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CoreTests.Fixed
//{
//    class Fixed
//    {
//        unsafe void foo()
//        {
//            // assume class Point { public int x, y; }
//            // pt is a managed variable, subject to garbage collection.
//            Point pt = new Point();
//            // Using fixed allows the address of pt members to be
//            // taken, and "pins" pt so it isn't relocated.
//            fixed (int* p = &pt.x)
//            {
//                *p = 1;
//            }
//        }

//    }
//    struct Point
//    {
//        public int x { get; set; }
//    }
//}

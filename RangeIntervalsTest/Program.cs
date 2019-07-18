using System;
using RangeIntervals;

namespace RangeIntervalsTest {

    public class MyRange : Range<Int32> {

        /// <summary>
        /// MANDATORY Parameterless Constructor
        /// Initializes a new instance of the <see cref="MyRange"/> class.
        /// </summary>
        public MyRange() {
        }

        public MyRange(Int32 x, Int32 y) : base(x, y) { }

        /// <summary>
        /// MANDATORY OVERRIDE
        /// Returns the next element of x
        /// </summary>
        /// <param name="x">An element in the T space</param>
        /// <returns></returns>
        public override int Next(int x) {
            return x + 1;
        }

        /// <summary>
        /// MANDATORY OVERRIDE
        /// Returns the previous element of x
        /// </summary>
        /// <param name="x">An element in the T space</param>
        /// <returns></returns>
        public override int Prev(int x) {
            return x - 1;
        }
    }

    internal class Program {
        private static void Main(string[] args) {
            RangeSetO<MyRange, int> set = new RangeSetO<MyRange, int>(true);
            for (int i = 0; i < 10; i++) {
                set.AddRange(i);
                Console.WriteLine(set.ToString());
            }
            MyRange r2 = new MyRange(5, 6);
            MyRange r1 = new MyRange(3, 4);
            MyRange r3 = new MyRange(10, 12);
            r3.IsInRange(55);
            MyRange r4 = new MyRange(22, 28);
            MyRange r5 = new MyRange(1, 26);
            set.AddRange(r2);
            Console.WriteLine(set.ToString());
            set.AddRange(r1);
            Console.WriteLine(set.ToString());
            set.AddRange(9);
            Console.WriteLine(set.ToString());
            set.IsInSet(9);
            /*set.AddRange(r1);
            Console.WriteLine(set.ToString());
            set.AddRange(r2);
            Console.WriteLine(set.ToString());
            set.AddRange(r3);
            Console.WriteLine(set.ToString());
            set.AddRange(r4);
            Console.WriteLine(set.ToString());
            set.AddRange(r5);
            Console.WriteLine(set.ToString());*/

        }
    }

}

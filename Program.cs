using System;

namespace repro_csc_timespanequals
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = TimeSpan.FromSeconds(1);

            DidIGetTheTime(t); // no problem
            DidIGetTheTime();  // also no problem, somehow?
        }

        static void DidIGetTheTime(TimeSpan t = default(TimeSpan))
        {
            if (t == null) // whoops!
            {
                throw new ArgumentOutOfRangeException("no TimeSpan provided!");
            }
        }
    }
}

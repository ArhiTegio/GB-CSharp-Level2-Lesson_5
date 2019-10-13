using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    enum Months
    {
        January = 1,
        February, 
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Time : byte
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }

    enum Priority
    {
        SkipIt,
        Neutrally,
        Importantly,
        ReallyImportant,
        HighlyImportant,
        Immediately
    }
}

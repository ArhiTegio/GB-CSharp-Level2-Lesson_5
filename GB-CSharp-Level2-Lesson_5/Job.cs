using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    class Job
    {
        Time deadline = new Time();
        Time timeIsDone = new Time();
        Priority priority = Priority.SkipIt;

        internal Time Deadline { get => deadline; set => deadline = value; }
        internal Time TimeIsDone { get => timeIsDone; set => timeIsDone = value; }
        internal Priority Priority { get => priority; set => priority = value; }
    }
}

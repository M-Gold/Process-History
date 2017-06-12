using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProcessHistory
{
    class ProcessSnapshotCollection
    {
        private class SystemSnapshot
        {
            Process[] procList;
            DateTime time;

            public SystemSnapshot(Process[] p, DateTime t)
            {
                procList = p;
                time = t;
            }
        }

    

        List<SystemSnapshot> snapshopList;
        public Process[] TakeSnapshot()
        {
            Process[] pList = Process.GetProcesses();
            SystemSnapshot ss = new SystemSnapshot(pList, DateTime.Now);
            snapshopList.Add(ss);
            return pList;
        }
        


    }
}

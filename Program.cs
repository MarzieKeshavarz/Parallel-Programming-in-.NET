using System;
using Parallel_Programmin_In_DotNet.Data_Sharing_And_Syncronization;
using Parallel_Programmin_In_DotNet.Task_Programming;

namespace Parallel_Programmin_In_DotNet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // CreatingAndStartingTasks.Start(args);
            // CancelingTasks.Start(args);
            // WaitingForTimeToPass.Start(args);
            // WaitingForTasks.Start(args);
            // ExceptionHandling.Start();
            // CriticalSections.Start();
            // InterlockedOperations.Start();
            // SpinLocking.Start();
            MutexExample.Start();
        }
    }
}
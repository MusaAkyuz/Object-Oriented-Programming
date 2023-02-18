using ProcessTransactions;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProcessTransaction
{
	class Program
	{
		public static void Main()
		{
			Process[] processes = Process.GetProcesses();
			List<ProcessModel> processInfo = new List<ProcessModel>(); 

			// Iterate over each process and check its status
			foreach (Process process in processes)
			{
				try
				{
					// Try to access the process status property
					if (process.Responding)
					{
						//Process is running
						processInfo.Add(new ProcessModel { processName = process.ProcessName, processId = process.Id, processStatus = "Running"});
					}
					else if (process.Threads.Count > 0)
					{
						// Process is suspended
						processInfo.Add(new ProcessModel { processName = process.ProcessName, processId = process.Id, processStatus = "Suspended" });
					}
					else
					{
						// Process has no threads (not currently running)
						processInfo.Add(new ProcessModel { processName = process.ProcessName, processId = process.Id, processStatus = "NotRunning" });
					}
				}
				catch (Exception ex)
				{
					// Ignore any exceptions that occur when accessing the process status
					Console.WriteLine("Error getting status for process {0}: {1}", process.ProcessName, ex.Message);
				}
			}

			processInfo.Sort((x, y) => String.Compare(x.processStatus, y.processStatus));

			Console.WriteLine(String.Format("{0,-40} {1,-14} {2, -30}", "Process Name", "Process Id", "Process Status"));
			foreach (ProcessModel p in processInfo)
			{
				Console.WriteLine(String.Format("{0,-40} {1,-14} {2, -30}", p.processName, p.processId.ToString(), p.processStatus));
			}

		}
	}
}


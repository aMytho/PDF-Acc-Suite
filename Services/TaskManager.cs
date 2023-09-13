using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Acc_Toolset.Services
{
	public class TaskManager
	{
		private static readonly AccessibilityTask[] Tasks = Array.Empty<AccessibilityTask>();

		public static void RunQueuedTasks()
		{

		}

		public static void AddTask(AccessibilityTask task)
		{
			_ = Tasks.Append(task);
		}
	}
}

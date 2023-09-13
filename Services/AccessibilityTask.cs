using iText.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Acc_Toolset.Services
{
	public abstract class AccessibilityTask
	{
		public Document Document;

		public AccessibilityTask(Document document)
		{
			this.Document = document;
		}

		public abstract void Run();
	}
}

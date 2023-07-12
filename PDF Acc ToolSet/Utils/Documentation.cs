using System.Diagnostics;

namespace PDF_Acc_ToolSet.Utils
{
    internal static class Documentation
    {
        public static readonly string matterhornPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets\\Matterhorn-Protocol-1-1.pdf");

        /// <summary>
        /// Open the Matterhorn PDF
        /// </summary>
        public static void OpenMatterhorn()
        {
            try
            {
                Process process = new();
                process.StartInfo.FileName = "explorer";
                process.StartInfo.Arguments = "\"" + matterhornPath + "\"";
                process.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open the Matterhorn protocol. Ensure that you have write access to this application's source code.", "Failed to Open");
            }
        }

        /// <summary>
        /// Opens the Matterhorn PDF on a specified page
        /// </summary>
        /// <param name="page"></param>
        public static void OpenMatterhorn(string page)
        {
            try
            {
                // NOTE - This does not work, explorer does not support cmd line arguements.
                // The PDF will be converted to HTML so we can link to it directly.
                Process process = new();
                process.StartInfo.FileName = "explorer";
                process.StartInfo.Arguments = "\"" + matterhornPath + "#page=" + page;
                process.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open the Matterhorn protocol. Ensure that you have write access to this application's source code.", "Failed to Open");
            }
        }
    }
}

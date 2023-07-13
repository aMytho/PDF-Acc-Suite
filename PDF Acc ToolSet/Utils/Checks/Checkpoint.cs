
namespace PDF_Acc_ToolSet.Utils.Checks
{
    public class Checkpoint
    {
        public Checkpoint() {}
        /// <summary>
        /// A list of checks in this checkpoint
        /// </summary>
        public List<Check> checks = new();
        /// <summary>
        /// The page number of the section. Enter only the number ex: 5
        /// </summary>
        public string matterhornLocation;
    }
}

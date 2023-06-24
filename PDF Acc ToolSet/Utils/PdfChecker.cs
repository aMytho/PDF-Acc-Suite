namespace PDF_Acc_ToolSet.Utils
{
    /// <summary>
    /// A class to help with Acc validation. Most checks are from the Matterhorn Protocol
    /// </summary>
    internal class PdfChecker
    {
    }

    internal abstract class Check
    {
        /// <summary>
        /// Index of the check. In form xx-xxx such as 01-001 would be checkpoint 1, check 1.
        /// </summary>
        internal string index;
        /// <summary>
        /// A string of text indicating what went wrong, and how to fix it.
        /// </summary>
        internal string FailureCondition;
        /// <summary>
        /// UA section to refer to.
        /// </summary>
        internal string Section;
        /// <summary>
        /// Is this a human or manual check?
        /// </summary>
        internal Validator validator;

        internal CheckStatus state;

        public Check(string index, string section, string failureCondition, Validator validator)
        {
            this.index = index;
            Section = section;
            FailureCondition = failureCondition;
            this.validator = validator;
        }

        public abstract CheckStatus RunCheck();
    }

    enum Validator
    {
        /// <summary>
        /// The check must be done by a human
        /// </summary>
        Human,
        /// <summary>
        /// This check can be safely completed automatically
        /// </summary>
        Machine
    }

    enum CheckStatus
    {
        Success,
        Failure,
        Unknown
    }
}

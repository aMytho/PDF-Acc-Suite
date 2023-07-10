using iText.Kernel.Pdf.Tagging;
using iText.Kernel.Pdf.Tagutils;

namespace PDF_Acc_ToolSet.Utils.Checks
{
    internal class Checkpoint9 : Checkpoint
    {
        public Check005 Check005;

        public Checkpoint9(TagTreePointer pointer) {
            // Load the checks for checkpoiont 9
            Check005 = new("09-005", "UA1:7.2.1", "Check that each list is valid", Validator.Machine, pointer);
            checks.Add(Check005);
        }
        
        public static Check CheckSpecific(Check check)
        {
            check.RunCheck();
            throw new NotImplementedException();
        }
    }

    internal class Check005 : Check
    {
        private TagTreePointer tagPointer;

        public Check005(string index, string section, string failureCondition, Validator validator, TagTreePointer tagPointer) : base(index, section, failureCondition, validator)
        {
            this.tagPointer = tagPointer;
        }

        public override CheckStatus RunCheck()
        {
            return RunTest(tagPointer);
        }

        private CheckStatus RunTest(TagTreePointer pointer) 
        {
            // Get every list
            List<IStructureNode> listElements = TagUtil.GetTagsByType(TagType.L, pointer);

            // The element we are searching for
            string listItemElement = TagUtil.GetTagByEnum(TagType.Li, true);
            string listItemBodyElement = TagUtil.GetTagByEnum(TagType.LBody, true);
            string listLabelElement = TagUtil.GetTagByEnum(TagType.Lbl, true);

            // For each list...
            foreach (IStructureNode node in listElements)
            {
                // Check that each child is a list item. We don't check each LI for sub lists because it is included in the GetTagsByType
                foreach (IStructureNode child in node.GetKids())
                {
                    // Handle role mapping
                    string tagName = TagUtil.ConvertRole(child.GetRole());
                    // Check that each child maps to a list item
                    if (tagName == listItemElement)
                    {
                        // Each LI must have a liBody and an optional label. No more and no less
                        IList<IStructureNode> liChildren = child.GetKids();
                        if (liChildren != null && liChildren.Count > 0 && liChildren.Count <= 2)
                        {
                            // Check both elements.
                            bool hasLBody = false;
                            
                            // There is at least 1 element. 
                            IStructureNode elem1 = liChildren.ElementAt(0);
                            if (TagUtil.ConvertRole(elem1.GetRole()) == listItemBodyElement)
                            {
                                hasLBody = true;
                            } else if (TagUtil.ConvertRole(elem1.GetRole()) != listLabelElement)
                            {
                                // Its not a lbody or lbl, must fail
                                return FailCheck();
                            }
                            
                            // The second element may not exist. If it doesn't, an errow is thrown
                            try
                            {
                                IStructureNode elem2 = liChildren.ElementAt(1);
                                string role = TagUtil.ConvertRole(elem2.GetRole());
                                
                                // Several possible scenerarios exist.
                                
                                // Both are lBody
                                if (role == listItemBodyElement && hasLBody)
                                    return FailCheck();
                                // 2 is not a label or a lbody
                                if (role != listItemBodyElement && role != listLabelElement)
                                    return FailCheck();
                                // They might be both labels. However, we catch that below
                                // Check that it is a list item body
                                if (role == listItemBodyElement)
                                    hasLBody = true;
                            } catch
                            {
                                // No second element.
                            }

                            // No lbody, must fail
                            if (hasLBody == false)
                                return FailCheck();
                        } else
                        {
                            // No kids or too many kids, failed!
                            return FailCheck();
                        }
                    } else
                    {
                        // Not a list item
                        return FailCheck();
                    }
                }
            };

            // Check passed!
            status = CheckStatus.Success;
            return CheckStatus.Success;
        }

        private CheckStatus FailCheck()
        {
            status = CheckStatus.Failure;
            return CheckStatus.Failure;
        }
    }
}
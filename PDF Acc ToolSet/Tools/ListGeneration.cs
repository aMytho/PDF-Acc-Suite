﻿namespace PDF_Acc_ToolSet.Tools
{
    public struct ListGeneration
    {
        // The amount of items to generate
        public int listItems;
        // Should we add labels? Labels are optional in most PDF spec. Still helpful though!
        public bool addLabels;
        // The title of the list element. Used for identification during remediation.
        public string title;

        // Constructor, assign initial values
        public ListGeneration(int listItems, bool addLabels, string title)
        {
            this.listItems = listItems;
            this.addLabels = addLabels;
            this.title = title;
        }
    }
}
﻿using System;
using System.Windows;
using EnvDTE;

namespace YuriyGuts.Midichlorian.VSPackage
{
    public class ExecuteVsCommandAction : IdeAutomatableAction
    {
        public override string Name
        {
            get { return "VS Command"; }
        }

        public override int DisplayOrder
        {
            get { return 1; }
        }

        public override void Execute(object state)
        {
            var dte = state as DTE;
            if (dte != null)
            {
                try
                {
                    dte.ExecuteCommand(Parameters["CommandName"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Midichlorian", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
    }
}

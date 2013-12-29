﻿using System.Collections.Generic;

namespace YuriyGuts.Midichlorian.VSPackage
{
    public abstract class IdeAutomatableAction
    {
        protected IdeAutomatableAction()
        {
            Parameters = new Dictionary<string, string>();
        }

        public abstract string Name { get; }

        public virtual int DisplayOrder
        {
            get { return int.MaxValue; }
        }

        public Dictionary<string, string> Parameters { get; set; }

        public abstract void Execute(object state);

        public override string ToString()
        {
            return Name;
        }
    }
}

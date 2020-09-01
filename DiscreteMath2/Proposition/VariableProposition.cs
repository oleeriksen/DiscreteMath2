using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public class VariableProposition : AProposition
    {
        string mName;

        public VariableProposition(string name) { mName = name; }

        public override ISet<string> Names
        {
            get
            {
                ISet<string> result = new HashSet<string>();
                result.Add(mName);
                return result;
            }
        }

        public override bool Evaluate(Dictionary<string, bool> state)
        {
            return state[mName];
        }
    }
}

using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public abstract class AProposition : IProposition
    {
        public bool IsTautology { get { return false;  } }

        public bool IsSatisfiable { get { return true; } }


        public abstract bool Evaluate(Dictionary<string, bool> state);

        public abstract ISet<string> Names { get; }

        public abstract override string ToString();

        
    }
}

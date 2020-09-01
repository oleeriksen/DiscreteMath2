using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public abstract class AProposition : IProposition
    {
        public bool IsTautology { get { return false;  } }

        public bool IsSatisfiable { get { return true; } }

        abstract public ISet<string> Names { get; }

        string IProposition.ToString { get; }

        abstract public bool Evaluate(Dictionary<string, bool> state);
    }
}

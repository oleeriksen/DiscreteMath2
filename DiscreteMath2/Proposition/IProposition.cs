using System;
using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public interface IProposition
    {
        bool Evaluate(Dictionary<string, bool> state);
        bool IsTautology { get;  }
        bool IsSatisfiable { get;  }
        ISet<string> Names { get;  }
        string ToString { get; }
    }
}

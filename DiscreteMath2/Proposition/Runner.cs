using System;
using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public class Runner
    {

        public void Test01() {
            // (a and b) => c
            IProposition p = new ImpliesProposition(
                                 new AndProposition(
                                     new VariableProposition("a"),
                                     new VariableProposition("b")),
                                 new VariableProposition("c"));

            Dictionary<string, bool> state = new Dictionary<string, bool>();
            state.Add("a", true); state.Add("b", true); state.Add("c", false);
            Console.WriteLine("The value " + p.Evaluate(state));
            Console.WriteLine("Test toString" + p.ToString());
            Console.WriteLine("The vartiables " + p.Names);
        }

    }
}

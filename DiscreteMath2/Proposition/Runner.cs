﻿using System;
namespace DiscreteMath2.Proposition
{
    public class Runner
    {

        public void Test01() {
            IProposition p = new ImpliesProposition(
                                 new AndProposition(
                                     new VariableProposition("a"),
                                     new VariableProposition("b")),
                                 new VariableProposition("c"));


            Console.WriteLine("Test toString" + p.ToString());
            Console.WriteLine("The vartiables " + p.Names);
        }

    }
}

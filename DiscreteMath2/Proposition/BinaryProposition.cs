using System;
using System.Collections.Generic;

namespace DiscreteMath2.Proposition
{
    public abstract class BinaryProposition : AProposition
    {
        IProposition mLeft, mRight;

        public BinaryProposition(IProposition left, IProposition right)
        {
            mLeft = left; mRight = right;
        }

        public override ISet<string> Names {
            get {
                ISet<string> result = mLeft.Names;
                result.UnionWith(mRight.Names);
                return result;
            }
        }

        public override bool Evaluate(Dictionary<string, bool> state)
        {
            return LogicFunction(mLeft.Evaluate(state), mRight.Evaluate(state));
        }

        public abstract bool LogicFunction(bool op1, bool op2);
    }


    public class AndProposition : BinaryProposition
    {
        public AndProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2)
        {
            return op1 && op2;
        }
    }

    public class OrProposition : BinaryProposition
    {
        public OrProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2)
        {
            return op1 || op2;
        }
    }

    public class ImpliesProposition : BinaryProposition
    {
        public ImpliesProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2)
        {
            return !op1 || op2;
        }
    }
}

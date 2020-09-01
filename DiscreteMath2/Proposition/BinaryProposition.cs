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

        public override string ToString()
            {
                return mLeft.ToString() + " " + Name + " " + mRight.ToString();
            }
        

        public abstract bool LogicFunction(bool op1, bool op2);
        public abstract string Name { get;  }
    }


    public class AndProposition : BinaryProposition
    {
        public AndProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2)
        {
            return op1 && op2;
        }

        public override string Name { get { return "and"; } }
    }

    public class OrProposition : BinaryProposition
    {
        public OrProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2) {
            return op1 || op2;
        }

        public override string Name { get { return "or"; } }

    }

    public class ImpliesProposition : BinaryProposition
    {
        public ImpliesProposition(IProposition left, IProposition right)
            : base(left, right) { }
        public override bool LogicFunction(bool op1, bool op2){
            return !op1 || op2;
        }
        public override string Name { get { return "=>"; } }

    }
}

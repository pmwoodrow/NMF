﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMF.Expressions.Arithmetics
{
    internal class ObservableIntMinus : ObservableReversableBinaryExpressionBase<int, int, int>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableIntMinus(INotifyExpression<int> left, INotifyExpression<int> right)
            : base(left, right) { }

        protected override int GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<int> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableIntMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<int> left, int right, int result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<int> right, int left, int result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }

    internal class ObservableLongMinus : ObservableReversableBinaryExpressionBase<long, long, long>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableLongMinus(INotifyExpression<long> left, INotifyExpression<long> right)
            : base(left, right) { }

        protected override long GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<long> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableLongMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<long> left, long right, long result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<long> right, long left, long result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }

    internal class ObservableUIntMinus : ObservableReversableBinaryExpressionBase<uint, uint, uint>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableUIntMinus(INotifyExpression<uint> left, INotifyExpression<uint> right)
            : base(left, right) { }

        protected override uint GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<uint> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableUIntMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<uint> left, uint right, uint result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<uint> right, uint left, uint result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }

    internal class ObservableULongMinus : ObservableReversableBinaryExpressionBase<ulong, ulong, ulong>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableULongMinus(INotifyExpression<ulong> left, INotifyExpression<ulong> right)
            : base(left, right) { }

        protected override ulong GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<ulong> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableULongMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<ulong> left, ulong right, ulong result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<ulong> right, ulong left, ulong result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }

    internal class ObservableFloatMinus : ObservableReversableBinaryExpressionBase<float, float, float>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableFloatMinus(INotifyExpression<float> left, INotifyExpression<float> right)
            : base(left, right) { }

        protected override float GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<float> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableFloatMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<float> left, float right, float result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<float> right, float left, float result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }

    internal class ObservableDoubleMinus : ObservableReversableBinaryExpressionBase<double, double, double>
    {
        protected override string Format
        {
            get
            {
                return "({0} - {1})";
            }
        }

        public ObservableDoubleMinus(INotifyExpression<double> left, INotifyExpression<double> right)
            : base(left, right) { }

        protected override double GetValue()
        {
            return Left.Value - Right.Value;
        }

        protected override INotifyExpression<double> ApplyParametersCore(IDictionary<string, object> parameters, IDictionary<INotifiable, INotifiable> trace)
        {
            return new ObservableDoubleMinus(Left.ApplyParameters(parameters, trace), Right.ApplyParameters(parameters, trace));
        }

        protected override void SetLeftValue(INotifyReversableExpression<double> left, double right, double result)
        {
            if (left.Value - right != result)
            {
                left.Value = right + result;
            }
        }

        protected override void SetRightValue(INotifyReversableExpression<double> right, double left, double result)
        {
            if (left - right.Value != result)
            {
                right.Value = left - result;
            }
        }
    }
}

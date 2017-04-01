using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMO_Project
{
    class SMOModel1:SMOBase
    {
        private double _factor;
        private int _amountReq;
        public SMOModel1(int t,int m,int a,int d,int count):base(t,m,a,d)
        {
            _amountReq = count;
        }

        public override void calculate()
        {
            _factor = (_depthThread * _amountReq) / (_intensityService*Math.Pow(_criticalAmountReqs,2));
        }

        public override string getResult()
        {
            _template = (_factor > 1) ? "При количестве заявок {0}, система переходит в поглощающее состояние" : "При количестве заявок {0}, система не переходит в поглощающее состояние";
            return String.Format(_template, _amountReq);
        }
    }
}

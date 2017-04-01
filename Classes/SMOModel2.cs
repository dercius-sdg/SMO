using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMO_Project
{
    class SMOModel2:SMOBase
    {
        private double _factor;
        private double _queryLength;
        private double _queryAverageTime;
        public SMOModel2(int t,int m,int a,int d):base(t,m,a,d)
        {
            _factor = _depthThread / _intensityService;
        }

        public override void calculate()
        {
            double freeFactor = 0;
            for (int counter=0;counter<_criticalAmountReqs;counter++)
            {
                freeFactor += (Math.Pow(_factor, counter)) / getFactorial(counter);
            }
            freeFactor += (Math.Pow(_factor, _criticalAmountReqs + 1)) / (getFactorial(_criticalAmountReqs) * (_criticalAmountReqs - _factor));
            freeFactor = 1 / freeFactor;
            _queryLength = freeFactor * (Math.Pow(_factor, _criticalAmountReqs + 1)) / (_criticalAmountReqs * getFactorial(_criticalAmountReqs) * Math.Pow(1 - _factor / _criticalAmountReqs, 2));
            _queryAverageTime = _queryLength / _intensityService;
        }

        public override string getResult()
        {
            _template = "Длина очереди составляет {0:f2}.Среднее время пребывания в очереди {1:f0}";
            return String.Format(_template, _queryLength, _queryAverageTime);
        }

        public double getFactorial(int number)
        {
            double result = 1;
            if (number>1)
            {
                for(int counter=2;counter<=number; counter++)
                {
                    result *= counter;
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMO_Project
{
    abstract class SMOBase : ISMO
    {
        protected int _totalMemory, _minimalMemory,_averageTime,_depthThread, _criticalAmountReqs;
        protected double _intensityService;
        protected string _template;
        public SMOBase(int t,int m,int a, int d)
        {
            _totalMemory = t;
            _minimalMemory = m;
            _averageTime = a;
            _depthThread = d;
            _criticalAmountReqs = (_totalMemory) * 1024 / _minimalMemory;
            _intensityService = 60 / _averageTime;
        }
        public virtual void calculate()
        {

        }

        public virtual string getResult()
        {
            return String.Empty;
        }
    }
}

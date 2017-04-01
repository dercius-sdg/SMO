using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMO_Project
{
    class SMOFabric
    {
        ISMO SMOObject;
        private int _totalMemory,_minimalMemory,_quantityReq,_depthThread,_averageTime;
        public SMOFabric(int t,int m,int q,int d,int a)
        {
            this._totalMemory = t;
            this._minimalMemory = m;
            this._quantityReq = q;
            this._depthThread = d;
            this._averageTime = a;
        }

        public ISMO getModel(int id)
        {
            switch (id)
            {
                case 1:
                    SMOObject=new SMOModel1(_totalMemory,_minimalMemory,_averageTime,_depthThread,_quantityReq);
                    break;
                case 2:
                    SMOObject=new SMOModel2(_totalMemory,_minimalMemory,_averageTime,_depthThread);
                    break;
                case 3:
                    SMOObject=new SMOModel3(_totalMemory,_minimalMemory,_averageTime,_depthThread);
                    break;
                default:
                    SMOObject = null;
                    break;
            }
            return SMOObject;
        }
        
        public int totalMemory
        {
            get
            {
                return _totalMemory;
            }
            set
            {
                _totalMemory = value;
            }
        }

        public int minimalMemory
        {
            get
            {
                return _minimalMemory;
            }
            set
            {
                _minimalMemory = value;
            }
        }

        public int quantityReq
        {
            get
            {
                return _quantityReq;
            }
            set
            {
                _quantityReq = value;
            }
        }

        public int depthThread
        {
            get
            {
                return _depthThread;
            }
            set
            {
                _depthThread = value;
            }
        }

        public int averageTime
        {
            get
            {
                return _averageTime;
            }
            set
            {
                _averageTime = value;
            }
        }
    }
}

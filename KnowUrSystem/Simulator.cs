using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowUrSystem
{
    public class Simulator : ISimulator
    {
        private int _timesOfSimulation;

        public int TradesPerMonth { get; set; }

        public int TimesOfSimulation {
            get
            {
                //if (_timesOfSimulation < 2500)
                //{
                //    return 2500;
                //}
                //else 
                if (_timesOfSimulation > 10000)
                {
                    return 10000;
                }
                return _timesOfSimulation;
            }
            set
            {
                _timesOfSimulation = value;
            } 
        }


        public int MaxNumOfConsecutiveLosses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int AvgNumOfConsecutiveLosses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Simulate()
        {
            throw new NotImplementedException();
        }
    }
}

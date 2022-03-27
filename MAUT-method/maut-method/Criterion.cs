using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maut_method_project
{
    class Criterion
    {
        string _name;
        double _weight;
        bool _benefit;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public bool Benefit
        {
            get { return _benefit; }
            set { _benefit = value; }
        }
        public string GetCriterionDisplay() => Benefit == true ? "Benefit" : "Cost";
    }
}
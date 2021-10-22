using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface IVehicle
	{
		void TurnLeft();
		void TurnRight();
		void GoForward();
		void GoBackwards();
		void Land();
		void TakeOff();
	}
}

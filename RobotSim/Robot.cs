using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSim {
	class Robot {
		#region Variables
		RobotDef Body;

		#endregion Variables
		#region Functions
		public Robot() { Body = new RobotDef(0.1, 0.1); }
		public void Forward() { }
		public void Back() { }
		public void TurnLeft() { }
		public void TurnRight() { }

		public void Tick(int dT) {
			Body.Tick(dT); // Physics!



		}

		#endregion Functions

	}

}

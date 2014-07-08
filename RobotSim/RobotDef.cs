using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSim {
	class RobotDef {
		#region Variables
		#region Physical Constants
		// http://en.wikipedia.org/wiki/Propeller#Forces_acting_on_a_foil
		private const double AR = Math.PI / 180.0;
		private const double airDensity = 1.46E-5; // m2/s

		#endregion Physical Constants
		#region Robot Specifications
		private double[] _wheelPos = new double[2];
		private double[] _wheelRpm = new double[2];
		private double[] _wheelDia = new double[2];
		private double _wheelBase;

		private double[] _rotorPos = new double[4];
		private double[] _rotorRpm = new double[4];
		private double[] _rotorDia = new double[4];
		private double[] _rotorAoA = new double[4];
		#endregion Robot Specifications

		#endregion Variables
		#region Functions
		public RobotDef(double nWheelDia, double nWheelBase) {
			_wheelPos[0] = _wheelPos[1] = 0;
			_wheelRpm[0] = _wheelRpm[1] = 0;
			_wheelDia[0] = _wheelDia[1] = nWheelDia;
			_wheelBase = nWheelBase;

		}
		public void Tick(int dT) {

		}


		#endregion Functions

	}
}

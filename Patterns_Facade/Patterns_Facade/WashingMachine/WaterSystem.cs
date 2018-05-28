using System;

namespace Patterns_Facade.WashingMachine {

	public class WaterSystem {

		public void WaterIn (int litres) {
			Console.WriteLine ("Fill {0} litres of water", litres);
		}

		public void WaterOut () {
			Console.WriteLine ("Empty water tank");
		}

	}
}

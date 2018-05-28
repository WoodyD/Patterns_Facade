using System;

namespace Patterns_Facade.WashingMachine {

	public class ThermoSystem {

		public void Heat (int temperature) {
			Console.WriteLine ("Heat water to {0} degrees", temperature);
		}

	}
}

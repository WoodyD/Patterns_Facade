using System;
using Patterns_Facade.WashingMachine;

namespace Patterns_Facade {

	class Program {

		static void Main (string[] args) {
			WashingMachineSystems _washingMachine = new WashingMachineSystems ();

			_washingMachine.CottonWash ();

			Console.WriteLine ();

			_washingMachine.WoolWash ();

			Console.ReadLine ();
		}
	}
}

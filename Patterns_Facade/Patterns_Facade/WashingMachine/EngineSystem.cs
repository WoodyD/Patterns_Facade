using System;

namespace Patterns_Facade.WashingMachine {

	public class EngineSystem {

		public void StartRotate (int time, int turnsPerSecond) {
			Console.WriteLine ("Start rotating. Will rotate for {0} minutes with rotating speed {1} per second", time, turnsPerSecond);
		}

		public void StopRotate () {
			Console.WriteLine ("Stop rotating");
		}

	}
}

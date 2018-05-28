using System;

namespace Patterns_Facade.WashingMachine {

	class WashingMachineSystems {

		WaterSystem _water;
		EngineSystem _engine;
		ThermoSystem _thermo;

		public WashingMachineSystems () {
			_water = new WaterSystem ();
			_engine = new EngineSystem ();
			_thermo = new ThermoSystem ();
		}

		public void CottonWash () {
			Console.WriteLine ("Start cotton washing program");
			_water.WaterIn (8);
			_thermo.Heat (60);
			_engine.StartRotate (60, 20);
			_engine.StopRotate ();
			_water.WaterOut ();
			_water.WaterIn (10);
			_engine.StartRotate (30, 20);
			_engine.StopRotate ();
			_water.WaterOut ();
			_engine.StartRotate (10, 1000);
			Console.WriteLine ("End cotton washing program");
		}

		public void WoolWash () {
			Console.WriteLine ("Start wool washing program");
			_water.WaterIn (8);
			_thermo.Heat (30);
			_engine.StartRotate (40, 20);
			_engine.StopRotate ();
			_water.WaterOut ();
			_water.WaterIn (10);
			_engine.StartRotate (20, 20);
			_engine.StopRotate ();
			_water.WaterOut ();
			_engine.StartRotate (10, 500);
			Console.WriteLine ("End wool washing program");
		}

	}
}

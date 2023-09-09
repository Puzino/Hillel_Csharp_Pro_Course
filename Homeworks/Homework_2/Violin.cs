using System;
using System.Drawing;

namespace Homework_2
{
	public class Violin : MusicalInstrument
    {
		public Violin(string InstrumentName, decimal Length, decimal Width, string InstrumentalSound, string InstrumentalHistory, string Description)
			: base(InstrumentName, Length, Width, InstrumentalSound , InstrumentalHistory, Description)
        {
        }
    }
}


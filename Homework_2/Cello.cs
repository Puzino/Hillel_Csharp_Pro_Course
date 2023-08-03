using System;
namespace Homework_2
{
	public class Cello : MusicalInstrument
    {
        public Cello(string InstrumentName, decimal Length, decimal Width, string InstrumentalSound, string InstrumentalHistory, string Description)
            : base(InstrumentName, Length, Width, InstrumentalSound, InstrumentalHistory, Description)
        {
        }
    }
}


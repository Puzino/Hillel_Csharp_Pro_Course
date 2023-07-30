using System;
namespace Homework_2
{
	public class Ukulele : MusicalInstrument
    {
        public Ukulele(string InstrumentName, decimal Length, decimal Width, string InstrumentalSound, string InstrumentalHistory, string Description)
            : base(InstrumentName, Length, Width, InstrumentalSound, InstrumentalHistory, Description)
        {
        }
    }
}


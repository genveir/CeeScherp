using NUnit.Framework;
using Systeem;

namespace Tests.Neenheid
{
    public static class Stel
    {
        public static void ZijnGelijk(getal verwacht, object feitelijk) => Assert.AreEqual(verwacht, feitelijk);
        public static void ZijnGelijk(sliert verwacht, object feitelijk) => Assert.AreEqual(verwacht, feitelijk);
    }
}

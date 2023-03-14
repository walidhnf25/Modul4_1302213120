using System;

namespace tpmodul4_1302213120
{
    class KodeBuah
    {
        public enum buah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Ceri, Kelapa, Blackberry, Jagung, Kurma,
            Durian, Anngurr, Melon, Semangka
        }

        public static string GetKodeBuah(buah kodebuah)
        {
            string[] kodeposArray = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
            return kodeposArray[(int)kodebuah];
        }
    }

    public class DoorMachine
    {
        enum State { TERKUNCI, TERBUKA };
        private State state = State.TERKUNCI;

        public DoorMachine()
        {
            Console.WriteLine("Pintu terkunci");
        }

        public void Buka()
        {
            if (state == State.TERBUKA)
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
            else
            {
                state = State.TERBUKA;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void Kunci()
        {
            if (state == State.TERKUNCI)
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
            else
            {
                state = State.TERKUNCI;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Apel); 
            Console.WriteLine("Apel : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Aprikot);
            Console.WriteLine("Aprikot : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Alpukat);
            Console.WriteLine("Alpukat : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Pisang);
            Console.WriteLine("Pisang : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Paprika);
            Console.WriteLine("Paprika : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Blackberry);
            Console.WriteLine("Blackberry : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Ceri);
            Console.WriteLine("Ceri : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Kelapa);
            Console.WriteLine("Kelapa: " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Jagung);
            Console.WriteLine("Jagung : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Kurma);
            Console.WriteLine("Kurma : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Durian);
            Console.WriteLine("Durian : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Blackberry);
            Console.WriteLine("Anggur : " + kodebuah);
            kodebuah = KodeBuah.GetKodeBuah(KodeBuah.buah.Melon);
            Console.WriteLine("Melon : " + kodebuah + "\n");

            DoorMachine door = new DoorMachine();
            door.Buka();    /// Output: "Pintu tidak terkunci"
            door.Kunci();   /// Output: "Pintu terkunci"
            door.Kunci();   /// Output: "Pintu sudah terkunci"
            door.Buka();    /// Output: "Pintu tidak terkunci"
        }
    }
}
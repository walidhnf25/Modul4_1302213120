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


    class Program
    {
        enum State { BERDIRI, TERBANG, JONGKOK, TENGKURAP };
        static void Main(string[] args)
        {
            //Soal Nomor 1
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

            //Soal Nomor 2
            
            State state = State.BERDIRI;
            string[] screenName = { "BERDIRI", "TERBANG", "JONGKOK", "TENGKURAP" };
            while (state != State.BERDIRI)
            {
                Console.WriteLine(screenName[(int)state] + " SCREEN");
                Console.Write("Enter Command : ");

                string command = Console.ReadLine();
                switch (state)
                {
                    case State.TENGKURAP:
                        if (command == "TombolW")
                            state = State.TERBANG;
                        else if (command == "TombolS")
                            state = State.JONGKOK;
                        else
                            state = State.BERDIRI;
                        break;
                }
            }
            Console.WriteLine("TERBANG");
            Console.WriteLine("JONGKOK");
        }
    }
}
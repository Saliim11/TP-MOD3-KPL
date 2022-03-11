using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kode = new KodePos();
            int kodePos = kode.getKodePos(KodePos.Kelurahan.Batununggal);
            Console.WriteLine(kodePos);

            DoorMachine pintu1 = new DoorMachine();
            Console.WriteLine("Kondisi Pintu Awal : "+pintu1.currentState);
            pintu1.activeTrigger(DoorMachine.Trigger.BukaPintu);
        }
    }
}

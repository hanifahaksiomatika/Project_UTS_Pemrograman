using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            Console.WriteLine("Masukkan NIK dosen: ");
            int nikDosen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMasukkan nama dosen: ");
            string namaDosen = Console.ReadLine();

            dosen.SetDosen(nikDosen, namaDosen);

            Console.WriteLine("\nMasukkan Nama Matakuliah: ");
            string namaMatakuliah = Console.ReadLine();

            dosen.SetMatakuliah(namaMatakuliah);

            Console.WriteLine("\n\nData Dosen:");
            Console.WriteLine("====================");
            Console.WriteLine("NIK        : " + dosen.NIK);
            Console.WriteLine("Nama       : " + dosen.Nama);
            Console.WriteLine("Matakuliah : " + dosen.Matakuliah);

            Console.ReadLine();

        }
    }
}

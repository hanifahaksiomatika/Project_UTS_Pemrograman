using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectuts
{
    class Dosen
    {
        public string Matakuliah { get; set; }
        public string Nama { get; set; }
        public int NIK { get; set; }

        public Dosen()
        {
            // Default constructor
        }

        public void SetDosen(int nik, string nama)
        {
            NIK = nik;
            Nama = nama;
        }

        public void SetMatakuliah(string matakuliah)
        {
            Matakuliah = matakuliah;
        }

    }
}

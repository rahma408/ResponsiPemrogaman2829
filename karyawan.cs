namespace ResponsiPemrograman2829
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int Nik, string Nama, int GajiBulanan)
        {
            this.Nik = Nik;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
        public void karyawan()
        {
            Console.WriteLine("{0}   {1} \t   {2}", Nik, Nama, GajiBulanan);
        }
        public void NaikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}   {1} \t    {2}", Nik, Nama, GajiBulanan);
        }
    }
}
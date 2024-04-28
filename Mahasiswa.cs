namespace tpmodul10_1302220031
{
	public class Mahasiswa
	{
		public String Nama { get; set; }		//saya mencoba menggunakan private tapi gagal
		public String Nim { get; set; }

        public Mahasiswa(string Nama, string Nim)
		{
			this.Nama = Nama;
            this.Nim = Nim;
		}
	}
}


using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220031.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MhsController : ControllerBase
    {
        private static List<Mahasiswa> listMhs = new List<Mahasiswa>
        {
            new Mahasiswa("Hasan Nurrahman Pane", "1302220031"),
            new Mahasiswa("Marjauza Naswansyah", "1302220009"),
            new Mahasiswa("Nizar Rasyiid", "1302220037"),
            new Mahasiswa("Matthew Theodore Lempas", "1302223116")
        };

        [HttpGet]                                               //Untuk menampilkan list mahasiswa
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        [HttpPost]                                              //Untuk menambahkan objek baru
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMhs.Add(mahasiswa);
        }

        [HttpGet("{id}")]                                       //Untuk menampilkan list berdasar id
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        [HttpDelete("{id}")]                                    //Untuk menghapus objek yang ada
        public void Delete(int id)
        {
            listMhs.RemoveAt(id);
        }
    }
}


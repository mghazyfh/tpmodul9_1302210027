using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using tpmodul9_1302210027;

namespace tpmodul9_1302210027.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mhs> _data = new List<Mhs>
        {
            new Mhs ("Muhammad Ghazy Fawaz Hakim", "1302210027"),
            new Mhs ("Muhammad Aulia Rifqi Hafid", "1302210094"),
            new Mhs ("Yakup Asmaidy Atanggae", "1302210113"),
            new Mhs ("Bintang Rayhan", "1302213002"),
            new Mhs ("Ahmad Muflih Nawir", "1302213007"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mhs> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mhs Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mhs>
        [HttpPost]
        public void Post([FromBody] Mhs value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mhs>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmodul9_1302210027
{
    public class Mhs
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mhs (string nama, string nim) { this.Nama = nama; this.Nim = nim; }
    }
}

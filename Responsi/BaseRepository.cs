using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Responsi
{
    public class BaseRepository
    {
        protected string connString = "Host=localhost;port=5432;Username=postgres;Password=informatika;Database=responsi";
    }
}

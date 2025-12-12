using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Responsi
{
    public class DeveloperRepository : BaseRepository
    {
        public List<developer> GetAllDeveloper()
        {
            var list = new List<developer>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT k.id_dev, k.nama_dev, k.status_kontrak, k.fitur_selesai, k.jumlah_bug, p.id_proyek, p.nama_proyek, p.client, p.budget FROM developer AS k JOIN proyek AS p ON k.id_proyek = p.id_proyek";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new developer
                        {
                            idDeveloper = reader.GetInt32(0),
                            nama = reader.GetString(1),
                            status = reader.GetString(2),
                            fitur = reader.GetString(3),
                            bug = reader.GetString(4),
                            idProyek = reader.GetString(5)
                        });
                    }
                }
                  
            }
        return list;
        }

        public List<proyek> GetAllproyek()
        {
            var list = new List<proyek>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id_proyek, nama_proyek, client, budget FROM proyek";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new proyek
                        {
                            idProyek = reader.GetInt32(0),
                            proyekName = reader.GetString(1),
                            client = reader.GetString(2),
                            budget = reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }

        public void Add(developer list)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                    string sql = "SELECT dev_insert(@nama, @status, @fitur, @bug, @id_proyek)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", list.nama);
                    cmd.Parameters.AddWithValue("@status", list.status);
                    cmd.Parameters.AddWithValue("@fitur", list.fitur);
                    cmd.Parameters.AddWithValue("@bug", list.bug);
                    cmd.Parameters.AddWithValue("@id_proyek", list.idProyek);
                    cmd.ExecuteScalar();
                }
            }
        }

        public void Update(developer list)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT dev_update(@id_dev,@nama, @status, @fitur, @bug, @id_proyek)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_dev", list.idDeveloper);
                    cmd.Parameters.AddWithValue("@status", list.status);
                    cmd.Parameters.AddWithValue("@fitur", list.fitur);
                    cmd.Parameters.AddWithValue("@bug", list.bug);
                    cmd.Parameters.AddWithValue("@id_proyek", list.idProyek);
                    cmd.ExecuteScalar();
                }
            }
        }

        public void Delete(developer list)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT dev_delete(@id_dev)";
                using (var cmd = new NpgsqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@id_dev", list.idDeveloper);
                    cmd.ExecuteScalar();
                }
            }
        }
    }

    
}

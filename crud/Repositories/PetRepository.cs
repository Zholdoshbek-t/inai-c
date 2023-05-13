using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using crud.Models;

namespace crud.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {

        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Pet order by Pet_id desc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PetModel = new PetModel();
                        PetModel.Id = (int)reader[0];
                        PetModel.Name = reader[1].ToString();
                        PetModel.Type = reader[2].ToString();
                        PetModel.Color = reader[3].ToString();
                        petList.Add(PetModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Pet " +
                                    "where Pet_Id=@id or Pet_Name like @name + '%'" +
                                    "order by Pet_id desc";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = petId; 
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PetModel = new PetModel();
                        PetModel.Id = (int)reader[0];
                        PetModel.Name = reader[1].ToString();
                        PetModel.Type = reader[2].ToString();
                        PetModel.Color = reader[3].ToString();
                        petList.Add(PetModel);
                    }
                }
            }
            return petList;
        }
    }
}

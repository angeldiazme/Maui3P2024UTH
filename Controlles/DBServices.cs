using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maui3P2024UTH.Models;
using SQLite;

namespace Maui3P2024UTH.Controlles
{
    public class DBServices
    {
        readonly SQLiteAsyncConnection _connection;
        public DBServices() {
            SQLite.SQLiteOpenFlags extensiones = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "DBPerson.db3"), extensiones);

            _connection.CreateTableAsync<Personas>();

        }

        //CRUD
        //Crear

        public async Task<int> StorePerson(Models.Personas person)
        {
            if (person.Id == 0)
            {
                return await _connection.InsertAsync(person);
            }
            else { 
            return await _connection.UpdateAsync(person);
            }
        }

        //Actualizar
        public async Task<Models.Personas> GetPerson(int pid)
        {

            return await _connection.Table<Models.Personas>().Where(i=> i.Id == pid).FirstOrDefaultAsync();

        }



        //Delete
        public async Task<int> DeletePerson(Models.Personas person)
        {


            return await _connection.DeleteAsync(person);
          }
        }

    }

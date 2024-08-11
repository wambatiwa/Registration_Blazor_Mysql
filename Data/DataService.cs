using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace Registrar.Data;

public class DataService(string connectionSTring)
{
    private readonly string connectionString = connectionSTring;

    // LoadData - retrieving data
    public async Task<List<T>> LoadData<T,U> (string sql, U parameters)
    {
        using (var connection = new MySqlConnection(connectionString) )
        {
            var rows = await connection.QueryAsync<T>(sql,parameters);
            return rows.ToList();
        }
    }
    public async Task<T> LoadSingleData<T,U> (string sql, U parameters)
    {
        using(var connection = new MySqlConnection(connectionString))
        {
            var record = await connection.QueryFirstOrDefaultAsync<T>(sql,parameters);
            return record;
        }
    }

    public async Task SaveData<U>(string sql, U parameters)
    {
        using(var connection = new MySqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql,parameters);
        }
    }
}

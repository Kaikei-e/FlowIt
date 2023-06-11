module Flow.Repository.DbFactory

open System
open MySql.Data.MySqlClient

type public EstablishConnection() =
    static member Start() =
        let connectionString = "Server=localhost;Database=flow;Uid=root;Pwd=;"
        let connection = new MySqlConnection(connectionString)
        connection.Open()
        connection
namespace Flow.Repository

open MySql.Data.MySqlClient

module DbFactory =
    type public EstablishConnection() =
        static member Pool =
             let credential = "Server=localhost;Database=flow;Uid=root;Pwd=;"
             let connection = new MySqlConnection(credential)
             let isAlive = connection.Ping()
             if not isAlive then
                 failwith "Connection to database failed"
             connection
             
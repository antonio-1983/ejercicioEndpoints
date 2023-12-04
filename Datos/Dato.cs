using MySql.Data.MySqlClient;
using Dapper;
namespace Datos
{
    public class Dato
    {
        string connection = @"Server=localhost; Database=ejercicioEndpoints; Uid=root;";
        string sqlId = "select Id,Nombre,Email from Usuarios where Id = @Id;";
        string sqlInsert = "insert into Usuarios (Nombre,Email,Contrasena) values (@Nombre,@Email,@Contrasena);";
       // string sqlDelete = "update Usuarios set Activo = 0 where id=@id;";
        string sqlDelete = "delete from Usuarios where id=@id;";
        string sqlUpdate = "update Usuarios set Nombre = @Nombre, Email=@Email,Contrasena=@Contrasena where Id = @Id;";


        public Usuario ObtenerUsuario(int id)
        {
            using (var db = new MySqlConnection(connection))
            {
                Usuario result = new Usuario();
                result = db.QueryFirstOrDefault<Usuario>(sqlId, new { Id = id });
                return result;
            }
        }

        public void InsertarUsuario(string nombre, string email, string contrasena)
        {
            using (var db = new MySqlConnection(connection))
            {

                var result = db.Execute(sqlInsert, new { nombre, email,contrasena });

            }

        }

        /* public void EliminarUsuario(int id)
         {
             using (var db = new MySqlConnection(connection))
             {

                 var result = db.Execute(sqlDelete, new { id });

             }

         }
        */
        public void EliminarUsuario(int id)
        {
            using (var db = new MySqlConnection(connection))
            {

                var result = db.Execute(sqlDelete, new { id });

            }

        }


        public void ActualizarUsuario(int id,string nombre, string email, string contrasena)
        {
            using (var db = new MySqlConnection(connection))
            {

                var result = db.Execute(sqlUpdate, new { id , nombre, email, contrasena});

            }
        }

    }
}
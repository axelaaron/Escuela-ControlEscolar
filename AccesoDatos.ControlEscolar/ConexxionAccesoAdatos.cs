using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDatos.ControlEscolar
{
    public class ConexxionAccesoAdatos
    {
        private MySqlConnection conn;
        public ConexxionAccesoAdatos(string servidor, string usuario, string password, string database, uint puerto)
        {
            MySqlConnectionStringBuilder cadenaconexion = new MySqlConnectionStringBuilder();
            cadenaconexion.Server = servidor;
            cadenaconexion.UserID = usuario;
            cadenaconexion.Password = password;
            cadenaconexion.Database = database;
            cadenaconexion.Port = puerto;
            conn = new MySqlConnection(cadenaconexion.ToString());
        }
        public void EjecutarConsult(string consulta)
        {
            conn.Open();
            var command = new MySqlCommand(consulta, conn);

            command.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);
            da.Fill(ds, tabla);
            return ds;
        }

        /*
        public int Existencia(string cadena)
        {
            var res = 0;
            var conexion = new SQLiteConnection("Data Source= " + connection[0] + ";Version=" + connection[1] + ";");
            //var conexion = new SqlConnection("Data Source = DESKTOP-1HB4GQ1\\MSSQL;" + "Initial Catalog = InformacionTec;" + "User ID = sa; Password=Abcd1234");
            var Inserta = new SQLiteCommand(cadena, conexion);
            try
            {
                conexion.Open();
                res = int.Parse(Inserta.ExecuteScalar().ToString());
                conexion.Close();
            }
            catch (System.Exception)
            {

                conexion.Close();
            }

            return res;
        }
        */
        
    }

}


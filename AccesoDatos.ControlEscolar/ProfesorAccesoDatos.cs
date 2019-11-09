using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class ProfesorAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;
        public ProfesorAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void Guardar(Profesor profesor)
        {
            if (profesor.Id == 0)
            {
                string consulta = string.Format("insert into profesor values(null,  {0} , '{1}' , '{2}' , '{3}' , '{4}' , '{5}' , '{6}' , '{7}' , {8}, '{9}', '{10}')", profesor.Idprofesor ,profesor.Numerocontrol, profesor.Nombre, profesor.Apellidopaterno, profesor.Apellidometarno, profesor.Direccion, profesor.Estado, profesor.Municipio, profesor.Numerocedula, profesor.Titulo, profesor.Fechadenacimiento);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update profesor set idincrementable = {0} numerocontrol = '{1}',  nombre = '{2}',apellidop = '{3}', apellidom = '{4}', definicion = '{5}', fkestados = '{6}', fkmunicipios = '{7}',   numerocedula = {8}, titulo = '{9}', fechanaci = '{10}'  where id =  {11}", profesor.Idprofesor, profesor.Numerocontrol, profesor.Nombre, profesor.Apellidopaterno, profesor.Apellidometarno, profesor.Direccion, profesor.Estado, profesor.Municipio, profesor.Numerocedula, profesor.Titulo, profesor.Fechadenacimiento, profesor.Id);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int idprofe)
        {
            string consulta = string.Format("Delete from profesor where id = {0}", idprofe);
            conexxion.EjecutarConsult(consulta);
        }

        public DataTable idprofesor(string fecha)
        {
            var dt = new DataTable();
            var ds = new DataSet();
            string consulta = "Select max(substring(numerocontrol,6)+1)as Nextincremento from profesor where numerocontrol like '%" + fecha + "%' ";
            ds = conexxion.ObtenerDatos(consulta, "profesor");
            dt = ds.Tables[0];
            return dt;

        }
        /*
        public int ObtenerNumControl(string noControl)
        {
            var res = _conexion.Existencia("select count(*) from Maestros where noControl = '" + noControl + "'");

            return res;
        }
        /*
        public int idprofesor2(string dato)
        {
            var dt = new DataTable();
            var ds = new DataSet();
            string consulta = "Select max(substring(id,-2))as Nextid from profesor where id like '%" + dato + "%' ";
            ds = conexxion.ObtenerDatos(consulta, "profesor");
            dt = ds.Tables[0];
            int dx;
            dx = int.Parse(dt.ToString() + 1);

            return dx;

        }
        */
        public List<Profesor> GetProfesors(string filtro)
        {
            var lp = new List<Profesor>();
            var ds = new DataSet();
            string consulta = "Select * from profesor where nombre like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "profesor");
            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach(DataRow row in dt.Rows)
            {
                var profesor = new Profesor
                {
                    Id = Convert.ToInt32(row["id"]),
                    Idprofesor = Convert.ToInt32(row["idincrementable"]),
                    Numerocontrol = row["numerocontrol"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidop"].ToString(),
                    Apellidometarno = row["apellidom"].ToString(),
                    Direccion = row["definicion"].ToString(),
                    Estado = row["fkestados"].ToString(),
                    Municipio = row["fkmunicipios"].ToString(),
                    Numerocedula = Convert.ToInt32(row["numerocedula"]),
                    Titulo = row["titulo"].ToString(),
                    Fechadenacimiento = row["fechanaci"].ToString()


                    
                };
                lp.Add(profesor);

            }
            return lp;
        }
    }
}

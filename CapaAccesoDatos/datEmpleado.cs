using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entEmpleado> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    Emp.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    Emp.nomEmpleado = dr["nomEmpleado"].ToString();
                    Emp.arTrabajo = dr["areTrabajo"].ToString();
                    Emp.estEmpleado = Convert.ToBoolean(dr["estEmpleado"]);
                    lista.Add(Emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos
    }
}

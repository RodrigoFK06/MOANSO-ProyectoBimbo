using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<entEmpleado> ListarCliente()
        {
            return datEmpleado.Instancia.ListarCliente();
        }


        ///inserta
        //public void InsertaCliente(entCliente Cli)
        //{
        //    datCliente.Instancia.InsertarCliente(Cli);
        //}
        ////edita
        //public void EditaCliente(entCliente Cli)
        //{
        //    datCliente.Instancia.EditarCliente(Cli);
        //}
        //public void DeshabilitarCliente(entCliente Cli)
        //{
        //    datCliente.Instancia.DeshabilitarCliente(Cli);
        //}
        #endregion metodos
    }


}


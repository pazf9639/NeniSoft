using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Usuario
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idUsuario { get; set; }

        public string nombre { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public int idTipoUsuario { get; set; }

        public bool activo { get; set; }

        public Usuario()
        {
        }

        public Usuario Login()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@username", username);
            parametros.Add("@password", password);
	        return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuario_login", parametros);
        }
    }
}

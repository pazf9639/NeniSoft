using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Venta
    {

        private DataAccess dataAccess = DataAccess.Instance();
        public int idVenta { get; set; }
        public   DateTime fecha { get; set; }
        public decimal total { get; set; }
        public string tipoEnvio { get; set; }
        public bool activo { get; set; }

        public Venta()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@fecha", fecha);
            parametros.Add("@total", total);
            parametros.Add("@tipoEnvio", tipoEnvio);
            return dataAccess.Execute("stp_Ventas_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_Ventas_delete", parametros);
        }

        public List<Venta> GetAll()
        {
            return dataAccess.Query<Venta>("stp_Ventas_getall");
        }

        public Venta GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            return dataAccess.QuerySingle<Venta>("stp_ventas_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            parametros.Add("@fecha", fecha);
            parametros.Add("@total", total);
            parametros.Add("@tipoEnvio", tipoEnvio);
            return dataAccess.Execute("stp_Ventas_update", parametros);
        }
    }
}

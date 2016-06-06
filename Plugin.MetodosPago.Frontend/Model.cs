using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCPOS.FrontEnd.DataClasses;

namespace Plugin.MetodosPago.Frontend
{
    
    public class TipoPagoChequeCabecera : LocalDBClassBase
    {        
        /* ################################## */
        // [DbTable("bes_cheque_c")]
        /* ################################## */
        [DbField("id")]
        public int id;
        [DbField("transaction_id")]
        public int transaction_id;
        [DbField("rut_cheque")]
        public String rut_cheque;
        [DbField("nombre")]
        public String nombre;
        [DbField("cant_cheques")]
        public int cant_cheques;
        [DbField("fecha_cheque")]
        public DateTime fecha_cheque;
        [DbField("monto")]
        public decimal monto;
        [DbField("tasa_interes")]
        public double tasa_interes; 
        

    }

    public class TipoPagoChequeDetalle : LocalDBClassBase
    {
        /* ################################## */
        // [DbTable("bes_cheque_d")]
        /* ################################## */
        [DbField("bes_cheque_c_id")]
        public int bes_cheque_c_id;
        [DbField("rut_cheque")]
        public String rut_cheque;
        [DbField("banco")]
        public String banco;
        [DbField("cta_cte")]
        public int cta_cte;
        [DbField("num_cheque")]
        public int num_cheque;
        [DbField("monto")]
        public decimal monto;
        [DbField("autorizacion")]
        public String autorizacion;
    }

    public class TipoPagoDebito : LocalDBClassBase
    {
        /* ################################## */
        // [DbTable("bes_debito")]
        /* ################################## */        
        [DbField("transaction_id")]
        public int transaction_id;
        [DbField("num_td")]
        public int num_td;
        [DbField("num_operacion")]
        public int num_operacion;
        [DbField("monto")]
        public decimal monto;
        [DbField("autorizacion")]
        public String autorizacion;
    }

    public class TipoPagoCredito : LocalDBClassBase
    {
        /* ################################## */
        // [DbTable("bes_credito")]
        /* ################################## */
        [DbField("transaction_id")]
        public int transaction_id;
        [DbField("num_tc")]
        public int num_tc;
        [DbField("tipo_tc")]
        public String tipo_tc;
        [DbField("cuotas")]
        public int cuotas;
        [DbField("num_operacion")]
        public int num_operacion;
        [DbField("monto")]
        public decimal monto;
        [DbField("autorizacion")]
        public String autorizacion;
    }
    
}

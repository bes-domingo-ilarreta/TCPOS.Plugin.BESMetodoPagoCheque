using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCPOS.DbHelper;
using TCPOS.FrontEnd.BusinessLogic;
using TCPOS.FrontEnd.BusinessLogic.Plugins;
using TCPOS.FrontEnd.DataClasses;
using TCPOS.FrontEnd.UserInterface;

namespace Plugin.MetodosPago.Frontend
{
    public partial class ViewFormCheque : Form
    {
        private BLogic BL;

        // Variables Cheque
               
        public String CampoBanco;
        public long CampoNroCheque;
        public decimal CampoMonto;
        public decimal CampoTasaInteres;
        public String CampoRutCheque;  // 10
        public String CampoNombre;
        public DateTime CampoFechaCheque;
        public long CampoNroCuentaCte;
        public long CampoCodigoAuthCheque;
        

        public void SetupForm(BLogic BL)
        {
            this.BL = BL;
            UserInterfaceHelper.TranslateForm(this);
            UserInterfaceHelper.CenterWindow(this);
            UserInterfaceHelper.VisibleForms.Add(this);
        }
        public ViewFormCheque()
        {
            InitializeComponent();
                      
            // Dia
            for (int i = 1; i <= 31; i++){x_dia_cheque.Items.Add(i.ToString());}
            // Mes
            for (int i = 1; i <= 12; i++) { x_mes_cheque.Items.Add(i.ToString()); }
            // Año
            for (int i = 2016; i <= 2018; i++) { x_anio_cheque.Items.Add(i.ToString()); }
            // Colores --> Verde: #2a9800 - Rojo: #d74a2b - Naranja: #ffa909
            aceptar.BackColor = ColorTranslator.FromHtml("#2a9800");
            cancelar.BackColor = ColorTranslator.FromHtml("#d74a2b");
            
            // Bancos
            x_banco_cheque.Items.Add("Banco de Chile");
            x_banco_cheque.Items.Add("BBVA Chile");
            x_banco_cheque.Items.Add("Scotiabank Chile");
            x_banco_cheque.Items.Add("Banco Internacional");
            x_banco_cheque.Items.Add("Banco de Crédito e Inversiones");
            x_banco_cheque.Items.Add("Corpbanca");
            x_banco_cheque.Items.Add("Banco Bice");
            x_banco_cheque.Items.Add("HSBC Bank (Chile)");
            x_banco_cheque.Items.Add("Banco Santander (Chile)");
            x_banco_cheque.Items.Add("Banco Itaú Chile");
            x_banco_cheque.Items.Add("Banco Security");
            x_banco_cheque.Items.Add("Banco Falabella");
            x_banco_cheque.Items.Add("Deutsche Bank (Chile)");
            x_banco_cheque.Items.Add("Banco Ripley");
            x_banco_cheque.Items.Add("Rabobank Chile");
            x_banco_cheque.Items.Add("Banco Consorcio");
            x_banco_cheque.Items.Add("Banco Penta");
            x_banco_cheque.Items.Add("Banco Paris");
            x_banco_cheque.Items.Add("Banco Bilbao Vizcaya Argentaria");

            /*
            x_banco_cheque.Text = "Banco de Chile";
            x_numero_cheque.Text = "0987654";
            //x_monto.Text = "5000";
            x_tasas_interes.Text = "1";
            rut_cheque.Text = "12345678A";
            x_nombre_completo_cheque.Text = "Domingo Ilarreta";
            x_dia_cheque.Text = "6";
            x_mes_cheque.Text = "6";
            x_anio_cheque.Text = "2016";
            nro_cta_corriente.Text = "09876543";
            x_cod_auth_cheque.Text = "098768000000";
            */
        }

        public void ViewFormCheque_Load(object sender, EventArgs e)
        {
             x_monto.Text = BL.CurrentTransaction.FoodToPay().ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            UserInterfaceHelper.VisibleForms.Remove(this);
        }       

        private void rut_cheque_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            
            String linea;
            bool valor = true;          
            // 1 Nombre Banco 

            if (x_banco_cheque.Text == "" || x_banco_cheque.Text == null) { valor = false; x_banco_cheque.BackColor = ColorTranslator.FromHtml("#d74a2b"); } else { CampoBanco = x_banco_cheque.Text; x_banco_cheque.BackColor = ColorTranslator.FromHtml("#FFFFFF"); }
            if (x_numero_cheque.Text == "" || x_numero_cheque.Text == null) { valor = false; } else { CampoNroCheque = long.Parse(x_numero_cheque.Text); }
            if (x_monto.Text == "" || x_monto.Text == null) { valor = false; } else { CampoMonto = decimal.Parse(x_monto.Text); }
            if (x_tasas_interes.Text == "" || x_tasas_interes.Text == null) { valor = false; } else { CampoTasaInteres = decimal.Parse(x_tasas_interes.Text); }
            if (rut_cheque.Text == "" || rut_cheque.Text == null) { valor = false; } else { CampoRutCheque = rut_cheque.Text; }
            if (x_nombre_completo_cheque.Text == "" || x_nombre_completo_cheque.Text == null) { valor = false; } else { CampoNombre = x_nombre_completo_cheque.Text; }
            if ((x_dia_cheque.Text == "" || x_dia_cheque.Text == null) || (x_mes_cheque.Text == "" || x_mes_cheque.Text == null) || (x_anio_cheque.Text == "" || x_anio_cheque.Text == null)) 
            { valor = false;
            }
            else
            {
                linea = x_dia_cheque.Text + "-" + x_mes_cheque.Text + "-" + x_anio_cheque.Text;
                CampoFechaCheque = Convert.ToDateTime(linea);
            }
            if (nro_cta_corriente.Text == "" || nro_cta_corriente.Text == null) { valor = false; } else { CampoNroCuentaCte = long.Parse(nro_cta_corriente.Text); }
            if (x_cod_auth_cheque.Text == "" || x_cod_auth_cheque.Text == null) { valor = false; } else { CampoCodigoAuthCheque = long.Parse(x_cod_auth_cheque.Text); }
            
            //if (!(File.Exists(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt"))) {  }
            //File.Create(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt");
            if (valor == true)
            {
                CampoBanco = x_banco_cheque.Text;
                CampoNroCheque = long.Parse(x_numero_cheque.Text);
                CampoMonto = decimal.Parse(x_monto.Text);
                CampoTasaInteres = decimal.Parse(x_tasas_interes.Text);
                CampoRutCheque = rut_cheque.Text;
                CampoNombre = x_nombre_completo_cheque.Text;
                linea = x_dia_cheque.Text + "-" + x_mes_cheque.Text + "-" + x_anio_cheque.Text;
                CampoFechaCheque = Convert.ToDateTime(linea);
                CampoNroCuentaCte = long.Parse(nro_cta_corriente.Text);
                CampoCodigoAuthCheque = long.Parse(x_cod_auth_cheque.Text);


                String all;
                all = CampoBanco + ";";
                all += CampoNroCheque.ToString() + ";";
                all += CampoMonto.ToString() + ";";
                all += CampoTasaInteres.ToString() + ";";
                all += CampoRutCheque + ";";
                all += CampoNombre + ";";
                all += CampoFechaCheque.ToString() + ";";
                all += CampoNroCuentaCte.ToString() + ";";
                all += CampoCodigoAuthCheque.ToString() + "";

                File.WriteAllText(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt", all);

                // Cerrar Formulario Emergente "Datos Cheque"
                this.DialogResult = DialogResult.OK;
                UserInterfaceHelper.VisibleForms.Remove(this);
            }
            
            /*
            if (valor!= false)
            {
                if (!System.IO.File.Exists(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt"))
                {
                    System.IO.File.Create(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt");

                    
                }
            } 
             */
            // Creando el Archivo
            //BL.CurrentTransaction.AddPayment(2, 2, 1, CampoMonto);
            //BL.CurrentTransaction.TransNum = 1;
            //BL.CurrentTransaction.AddCashBack();
            //BL.RefreshTransactionItems();
            //BL.CurrentTransaction.TransNum = 1;
            //BL.MsgError(CampoMonto.ToString());
            //BL.CleanDumpTransaction(); 
            // Central
            //BL.DB.CentralDbExecuteNonQuery();
            //BL.DB.LocalDbToRefresh();
            
            //BL.CurrentTransaction.ManualPrintoutSelected = DbPayment.PrintoutType.Bill;           
                       
            //INSERT INTO articles (id,code,description,visibility_criteria_id) VALUES (" + next_id + "," + codigoExample + "," + SqlHelper.Quote(descriptionExample) + ",1)");
            //BL.CurrentTransaction.Resumed;
        }


        private void x_banco_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.DesactivaTeclado(e);
        }

        private void x_numero_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumeros(e);
        }

        private void monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumerosDecimales(e,x_monto.Text);
        }

        private void x_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumeros(e);
        }

        private void nro_cta_corriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumeros(e);
        }

        private void x_cod_auth_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumeros(e);
        }

        private void x_nombre_completo_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloLetras(e);
        }

        private void x_tasas_interes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.SoloNumerosDecimales(e, x_tasas_interes.Text); 
        }

        private void x_dia_cheque_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void x_dia_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.DesactivaTeclado(e);
        }

        private void x_mes_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.DesactivaTeclado(e);
        }

        private void x_anio_cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validates.DesactivaTeclado(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using TCPOS.DbHelper;
using TCPOS.FrontEnd.BusinessLogic;
using TCPOS.FrontEnd.BusinessLogic.Plugins;
using TCPOS.FrontEnd.DataClasses;
using TCPOS.FrontEnd.UserInterface.Interfaces;

namespace Plugin.MetodosPago.Frontend
{
    public class Controller : IPlugin
    {
        private BLogic BL;
              
        // Model
        private TipoPagoChequeCabecera[] TableBesChequeC;
        private TipoPagoChequeDetalle[] TableBesChequeD;
        private TipoPagoDebito[] TableBesDebito;
        private TipoPagoCredito[] TableBesCredito;

        

        public void Register(BLogic BL, PluginManager PM)
        {
            this.BL = BL;
            PM.OnBeforeKeyPress += PM_OnBeforeKeyPress;
            PM.OnDataAvailable += PM_OnDataAvailable;
            //PM.OnBeforeKeyPress += new KeyPressEvent(PM_OnBeforeKeyPress);  // Otra Forma simiLar a "PM.OnBeforeKeyPress += PM_OnBeforeKeyPress;"            
            PM.OnOverrideListBoxItem += PM_OnOverrideListBoxItem;            
            PM.OnSerializeToDbTransItemInElement += PM_OnSerializeToDbTransItemInElement;
            PM.OnAfterCloseTransaction += PM_OnAfterCloseTransaction;           

        }

        void PM_OnAfterCloseTransaction(Transaction transaction)
        {
            
            string all;
            
            all = System.IO.File.ReadAllText(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt");
            string[] campos = all.Split(';');

                                                                                                /*
                                                                                                0 all = CampoBanco +";"; 
                                                                                                1 all += CampoNroCheque.ToString() + ";";
                                                                                                2 all += CampoMonto.ToString() + ";";
                                                                                                3 all += CampoTasaInteres.ToString() + ";";
                                                                                                4 all += CampoRutCheque + ";";
                                                                                                5 all += CampoNombre + ";";
                                                                                                6 all += CampoFechaCheque.ToString() + ";";
                                                                                                7 all += CampoNroCuentaCte.ToString() + ";";
                                                                                                8 all += CampoCodigoAuthCheque.ToString() + "";
                                                                                                 
                                                                                                */
            

            // Ultimo id de la tabla transaction
            string idFinal = BL.DB.CentralDbExecuteScalar("SELECT TOP 1 id  FROM transactions ORDER BY id DESC").ToString();

            BL.DB.CentralDbExecuteNonQuery("UPDATE trans_payments SET x_banco_cheque=" + SqlHelper.Quote(campos[0]) + ", x_numero_cheque=" + int.Parse(campos[1]) + ", currency_id=2, currency_amount=" + decimal.Parse(campos[2]) + ",  x_tasas_cheque=" + decimal.Parse(campos[3]) + ", x_rut_cheque=" + SqlHelper.Quote(campos[4]) + ",  x_codigo_autorizacion_cheque=" + SqlHelper.Quote(campos[8]) + ", x_fecha_cheque='" + Convert.ToDateTime(campos[6]) + "', x_numero_cuenta_corriente=" + int.Parse(campos[7]) + ", x_nombre_completo=" + SqlHelper.Quote(campos[5]) + " WHERE payment_id=4 AND transaction_id=" + int.Parse(idFinal));
            // currency_id CLP = 2
            // currency_amount = 
            /*
            string elBanco = BL.DB.CentralDbExecuteScalar("SELECT x_banco_cheque FROM trans_payments WHERE transaction_id=" + int.Parse(idFinal)).ToString();
            string numero_cheque = BL.DB.CentralDbExecuteScalar("SELECT x_numero_cheque FROM trans_payments WHERE transaction_id=" + int.Parse(idFinal)).ToString();
            string currency_amount = BL.DB.CentralDbExecuteScalar("SELECT currency_amount FROM trans_payments WHERE transaction_id=" + int.Parse(idFinal)).ToString();
            //string elBanco = BL.DB.CentralDbExecuteScalar("SELECT x_banco_cheque FROM trans_payments WHERE transaction_id=" + int.Parse(idFinal)).ToString();
            BL.MsgInfo(elBanco + "-" + numero_cheque + "-" + currency_amount);    
            */
            // Borra el TXT
            //System.IO.File.Delete(@"C:\TCPOS.NET\FrontEnd\Traces\cheque.txt");
        }

        void PM_OnSerializeToDbTransItemInElement(XmlStringWriter writer, TransItem item)
        {
            
        }       
        private void PM_OnOverrideListBoxItem(List<PosListBoxItem> listItems, TransItem transItem, PosListBoxItem listItem, ref bool drawItem)
        {
            /*
            if (transItem is TransArticle)
            {
                TransArticle art = transItem as TransArticle;                
                //if (art.TotalPrice == 0M)
                //listItem.Amount = "";                
                listItem.Description = listItem.Description + " hola";
                //listItem.Description = listItem.Description + "\n" ));
            }
             */           
        }

        

        private void PM_OnDataAvailable()
        {
            if (BL.DB.TableExists("bes_cheque_c")) { TableBesChequeC = BL.DB.SelectObjectArray<TipoPagoChequeCabecera>("select * from bes_cheque_c"); }
            if (BL.DB.TableExists("bes_cheque_d")) { TableBesChequeD = BL.DB.SelectObjectArray<TipoPagoChequeDetalle>("select * from bes_cheque_d"); }
            if (BL.DB.TableExists("bes_debito"))   { TableBesDebito  = BL.DB.SelectObjectArray<TipoPagoDebito>("select * from bes_debito"); }
            if (BL.DB.TableExists("bes_credito"))  { TableBesCredito = BL.DB.SelectObjectArray<TipoPagoCredito>("select * from bes_credito"); }
                
        }

        void PM_OnBeforeKeyPress(KeyData key, ref bool processed)
        {
            if (key.FunctionCode == KeyData.KeyPayment)
            {
                //BL.MsgInfo("Payment");
                switch (key.FunctionParameter)
                {
                    case  1:
                        //BL.MsgInfo("Efectivo");
                        //BL.CurrentTransaction.(customer, cardInfo, true, true);
                        //BL.CurrentTransaction.AddPayment(4, 1, 1, 1);
                        //BL.CurrentTransaction.GetFirstItemOf(typeof(TransPayment));                        
                        // transPayment.Amount.GetType(1);
                    break;

                    case 2:
                    //BL.MsgInfo("Tarjeta de Credito");
                    break;

                    case 3:
                    //BL.MsgInfo("Customer Card");
                    break;

                    case 4:
                    // CHEQUE

                    if (BL.CurrentTransaction.FoodToPay() != 0)
                    {
                        using (ViewFormCheque ViewFormCheque = new ViewFormCheque())
                        {
                            ViewFormCheque.SetupForm(BL);
                            ViewFormCheque.Focus();
                            ViewFormCheque.ShowDialog();
                        }
                    }
                    processed = false;
                    
                    break;


                    case 5:
                    //BL.MsgInfo("Tarjeta de Debito");                    
                    break;
                }
                /*
                if (key.FunctionParameter == 1)
                {
                    
                }
                if (key.FunctionParameter == 2)
                {
                    BL.MsgInfo("Parametro 2");
                }
                if (key.FunctionParameter == 3)
                {
                    BL.MsgInfo("Parametro 3");
                }
                if (key.FunctionParameter == 4)
                {
                    BL.MsgInfo("Parametro 5");
                }
                 */
            }
            return;
        }


        /*
        BL.MsgInfo("Parametro 1");
        
         * /
        // 10001
        // print 1001 [0]
        // print 1001 [1]
        // print 1001 [2]
            
        /*
        if (key.FunctionCode == 10001)
        {
            if (key.FunctionParameter == 0)
            {
                BL.MsgInfo("FUNCTION 0");
            }

            if (key.FunctionParameter == 1)
            {
                BL.MsgInfo("FUNCTION 1");
            }

            if (key.FunctionParameter == 2)
            {

                BL.MsgInfo("FUNCTION 2");
            }

                
        }
        if (key.FunctionCode == 10002)
            {
                BL.MsgInfo("Hello World");
            }
        */

    }
}

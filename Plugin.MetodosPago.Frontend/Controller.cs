using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
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
        public void Register(BLogic BL, PluginManager PM)
        {
            this.BL = BL;
            PM.OnBeforeKeyPress += PM_OnBeforeKeyPress;
            PM.OnDataAvailable += PM_OnDataAvailable;
            //PM.OnBeforeKeyPress += new KeyPressEvent(PM_OnBeforeKeyPress);  // Otra Forma simiLar a "PM.OnBeforeKeyPress += PM_OnBeforeKeyPress;"                        
            PM.OnSerializeToDbTransItemInElement += PM_OnSerializeToDbTransItemInElement;
            
            PM.OnBeforeCloseTransaction += PM_OnBeforeCloseTransaction;
        }

        void PM_OnBeforeCloseTransaction(Transaction transaction, ref bool abort)
        {
            // ID de la Till (Caja) --> transaction.TillID.ToString()
            // TransNum de la Caja  --> transaction.TransNum.ToString()
            // ID DE LA Tienda ID --> BL.DB.ExecuteScalar("SELECT shop_id FROM tills WHERE id=" + transaction.TillID).ToString();            

            ArrayList payments = BL.CurrentTransaction.GetItems(typeof(TransPayment));
            foreach (TransPayment pay in payments)
            {
                if (pay.Data.Type.ToString() == "Cheque")
                {
                    // ID DE LA Tienda ID --> BL.DB.ExecuteScalar("SELECT shop_id FROM tills WHERE id=" + transaction.TillID).ToString();                                
                    string[] campo = pay.Data.Notes.Split(';');
                    // shop_id
                    String linea = BL.DB.ExecuteScalar("SELECT shop_id FROM tills WHERE id=" + transaction.TillID).ToString();
                    int shop_id = int.Parse(linea);
                    // till_id
                    int till_id = transaction.TillID;
                    // trans_num
                    int trans_num = transaction.TransNum;
                    // bank_id
                    int bank_id = int.Parse(campo[0]);
                    // rut_cheque
                    String rut_cheque = campo[1];
                    // nro_cta_corriente
                    String nro_cta_corriente = campo[2];
                    // nro_cheque
                    String nro_cheque = campo[3];
                    // monto
                    decimal monto = decimal.Parse(campo[4]);
                    // code_auth
                    String code_auth = campo[5];
                    // nombre_completo
                    String nombre_completo = campo[6];
                    // tasas
                    decimal tasas = decimal.Parse(campo[7]);
                    // fecha                    
                    //linea = DateTime.Now.ToString("dd") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("yyyy");
                    //DateTime fecha = Convert.ToDateTime(linea);
                    DateTime fecha = Convert.ToDateTime(campo[8]);

                    TransTableBesCheque BesCheque = new TransTableBesCheque(BL.CurrentTransaction);
                    BesCheque.shop_id = shop_id;
                    BesCheque.till_id = till_id;
                    BesCheque.trans_num = trans_num;
                    BesCheque.bank_id = bank_id;
                    BesCheque.rut_cheque = rut_cheque;
                    BesCheque.nro_cta_corriente = nro_cta_corriente;
                    BesCheque.nro_cheque = nro_cheque;
                    BesCheque.monto = monto;
                    BesCheque.tasas = tasas;
                    BesCheque.code_auth = code_auth;
                    BesCheque.nombre_completo = nombre_completo;
                    BesCheque.fecha = fecha;
                    BL.CurrentTransaction.AddItem(BesCheque);

                }
            }
        }           

        private void PM_OnDataAvailable()
        {
            //if (BL.DB.TableExists("bes_cheque")) { TableBesCheque = BL.DB.SelectObjectArray<TipoPagoCheque>("select * from bes_cheque"); }
            //if (BL.DB.TableExists("bes_banks")) { TableBesBanks = BL.DB.SelectObjectArray<BesBanks>("select * from bes_banks"); }
        }

        
        

        void PM_OnSerializeToDbTransItemInElement(XmlStringWriter writer, TransItem item)
        {
            /*
            if (item is TransPayment)
            {
                TransPayment transaction = item as TransPayment;                                            
                string propina = (10 * BL.CurrentTransaction.Total / 100).ToString();
                writer.WriteField("propina", propina);
            }
            */         
        }              

        void PM_OnBeforeKeyPress(KeyData key, ref bool processed)
        {
            // (Default) processed = false       
            //if (key.FunctionCode == KeyData.KeyTotal) {}

            if (key.FunctionCode == KeyData.KeyPayment)           
            {
                /*
                String mostrar = "";                
                mostrar += "Function Code = " + key.FunctionCode.ToString();
                mostrar += " KeyPayment = " + KeyData.KeyPayment.ToString();
                mostrar += " key.FunctionParameter = " + key.FunctionParameter.ToString();
                
                Tipos de Pago
                (payment_id)
                    1 --> Cash
                    2 --> Customer Ca
                    3 --> Credit Card
                    4 --> Vouchers
                    5 --> Cheques
                    6 --> Debitor
                    7 --> Subsidy
               */
                    // Obtiene el id del Boton Payment
                    int PayId = key.FunctionParameter;
                    // Obtiene el ID del Tipo de Pago
                    String Query;
                    Query = BL.DB.ExecuteScalar("SELECT payment_type FROM payments WHERE id=" + PayId + " LIMIT 1").ToString();
                    int PaymentType = int.Parse(Query);
                    
                    if (PaymentType == 5)
                    {                        
                            using (ViewFormCheque ViewFormCheque = new ViewFormCheque())
                            {
                                ViewFormCheque.SetupForm(BL);
                                ViewFormCheque.Focus();
                                ViewFormCheque.ShowDialog();
                            }                            
                            processed = true;
                    }
            }
            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraciticaPOO1
{
    public partial class Form1 : Form
    {


        public void BorrarTextboxes()
        {
            tBoxMontoInresar.Clear();
            tBoxMontoRetirar.Clear();
            tBoxNumeroCuenta.Clear();
            tBoxTitular.Clear();
            tBoxSaldoCuenta.Clear();

        }

        CuentaBancaria[] cuenta = new CuentaBancaria[3];

        public Form1()
        {
            InitializeComponent();

            cuenta[0] = new CuentaBancaria("Javer Miras", 1, 100.00);
            cuenta[1] = new CuentaBancaria("Jose Perez", 2, 50.00);
            cuenta[2] = new CuentaBancaria("Andres Pico", 3, 20.00);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxOperacion.SelectedIndex = 1;
            cBoxCuenta.SelectedIndex = 0;
            Refresh();
        }

        private void cBoxOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BorrarTextboxes();
            if (cBoxOperacion.SelectedIndex == 0)
            {
                tBoxMontoInresar.Enabled = true;
                tBoxMontoRetirar.Enabled = false;
                Refresh();
                
            }

            if (cBoxOperacion.SelectedIndex == 1)
            {
                tBoxMontoInresar.Enabled = false;
                tBoxMontoRetirar.Enabled = false;
                Refresh();

            }
            if (cBoxOperacion.SelectedIndex == 2)
            {
                tBoxMontoInresar.Enabled = false;
                tBoxMontoRetirar.Enabled = false;
                Refresh();

            }
            if (cBoxOperacion.SelectedIndex == 3)
            {
                tBoxMontoInresar.Enabled = false;
                tBoxMontoRetirar.Enabled = true;
                Refresh();

            }
        }

        private void butConfirmarOperacion_Click(object sender, EventArgs e)
        {
            string MensajeError = "Operacion aceptada";
            switch (cBoxOperacion.Text)
          {

                case "INGRESAR":
                    {
                        if (!cuenta[cBoxCuenta.SelectedIndex].SetIngresar(tBoxMontoInresar.Text,ref MensajeError))
                        {
                         MessageBox.Show(MensajeError);
                        }
                    else
                        {
                            MessageBox.Show(MensajeError);
                            BorrarTextboxes();
                        }
                    }
                    break;
                
                case "CONSULTAR":
                    {
                        tBoxSaldoCuenta.Text = cuenta[cBoxCuenta.SelectedIndex].GetConsultar().ToString();
                    }
                    break;
                
                case "INFORMAR":
                    {
                        string titular1="";
                        int numcuenta1=-1;
                        double saldo1 = 0;
                        cuenta[cBoxCuenta.SelectedIndex].GetInformar(ref titular1, ref numcuenta1,ref saldo1);
                        tBoxTitular.Text = titular1;
                        tBoxNumeroCuenta.Text = numcuenta1.ToString();
                        tBoxSaldoCuenta.Text = saldo1.ToString();
                    }
                    break;
                
                case "RETIRAR":
                    {

                        if (!cuenta[cBoxCuenta.SelectedIndex].SetRetirar(tBoxMontoRetirar.Text, ref MensajeError))
                        {
                            MessageBox.Show(MensajeError);
                        }
                        else
                        {
                            MessageBox.Show(MensajeError);
                            BorrarTextboxes();
                        }
                    }
                    break;
            }
              
                
         }

        private void cBoxCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BorrarTextboxes();
        }
    }


    public class CuentaBancaria
    {
        //INICIALIZA LOS OBJETOS DE ESTA CLASE CON ESTOS VALORES POR DEFECTO
        public CuentaBancaria()
        {
            titular = "";
            numero = -1;
            saldo = 0;
        }


        //INICIALIZA LOS OBJETOS DE ESTA CLASE CON LOS VALORES QUE SE LE PASA COMO PARAMETRO
        public CuentaBancaria(string titular1, int numero1, Double saldo1)
        {
            this.titular = titular1;
            this.numero = numero1;
            this.saldo = saldo1;
        }


        // propiedades de la clase (variables)

        private string titular;
        private int numero;
        private double saldo;


        //SetIngresar, este método de clases ingresa el dinero que se la pasa como parametro
        //si no es una cadena numerica o el monto es <0 a cero devuelve error
        public bool SetIngresar(string monto,ref string mensaje)
        {
            double dMonto=0.00;
            try
            {
                dMonto = Convert.ToDouble(monto);
            }
            catch (Exception)
            {
                mensaje = "El formato de los deatos no es correcto, vuelva a intentarlo";
                return false;
            }
            if (dMonto<=0)
            {
                mensaje = "Ingrese un valor superiro a cero";
                return false; 
            }
            else
            {
                this.saldo = this.saldo + dMonto;
                mensaje = "Operacion aceptada";
                return true;
            }
            
    
        }

        //SetRetirar, este método de clases ingresa el dinero que se la pasa como parametro
        //si no es una cadena numerica , el monto es <0 a cero o  intenta retirar mas dinereo del disponible devuelve error

        public bool SetRetirar(string monto,ref string mensaje)
        {
            double dMonto = 0.00;
            try
            {
                dMonto = Convert.ToDouble(monto);
            }
            catch (Exception)
            {
                mensaje = "El formato de los deatos no es correcto, vuelva a intentarlo";
                return false;
            }
            if (dMonto <= 0)
            {
                mensaje = "Ingrese un valor superiro a cero";
                return false;
            }
            else
            {//el monto  a retirar tiene que ser <= que el saldo
                if(dMonto>this.saldo)
                {
                    mensaje = "Intenta retirar un monto mayor al disponible, modifique el monto";
                    return false;
                }
                this.saldo = this.saldo - dMonto;
                mensaje = "Operacion aceptada";
                return true;
            }
        }

        //consultar (método de clase)
        public double GetConsultar() //informa solo el saldo de  la cuenta

        {
            return saldo;
        }

        //informmar (método de clase)

        public void GetInformar(ref string titular,ref int numcuenta,ref double saldo) //informa solo el saldo de  la cuenta

        {
            titular = this.titular;
            numcuenta = this.numero;
            saldo = this.saldo;
        }

    }

}

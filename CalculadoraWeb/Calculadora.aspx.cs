using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace CalculadoraWeb
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            metodo_RadioButton();
            menu_Desplegable();
            CheckBox();
        }
        public void metodo_RadioButton()
        {
            float num1 = 0, num2 = 0, total = 0;
            num1 = float.Parse(TValor1.Text);
            num2 = float.Parse(TValor2.Text);

            if (RadioButtonSuma.Checked)
            {
                total = num1 + num2;
                lResultado.Text = total.ToString();
            }
            else if (RadioButtonResta.Checked)
            {
                total = num1 - num2;
                lResultado.Text = total.ToString();
            }
            else if (RadioButtonMultipicacion.Checked)
            {
                total = num1 * num2;
                lResultado.Text = total.ToString();
            }
          
            else
            {
                total = num1 / num2;
                lResultado.Text = total.ToString();

            }
            
            
          
        }
        public void CheckBox()
        {
            float num1 = 0, num2 = 0, total = 0;
            string valor = "";

            try
            {
                num1 = float.Parse(TValor1.Text);
                num2 = float.Parse(TValor2.Text);

                if (CheckBoxSuma.Checked)
                {
                    total = num1 + num2;
                    valor += "Suma: " + total.ToString() + " ";
                }

                if (CheckBoxResta.Checked)
                {
                    total = num1 - num2;
                    valor += "Resta: " + total.ToString() + " ";
                }

                if (CheckBoxMultiplicacion.Checked)
                {
                    total = num1 * num2;
                    valor += "Multiplicación: " + total.ToString() + " ";
                }

                if (CheckBoxDivision.Checked)
                {
                    if (num2 != 0)
                    {
                        total = num1 / num2;
                        valor += "División: " + total.ToString() + " ";
                    }
                    else
                    {
                        valor += "División: Error (división por cero) ";
                    }
                }

              
                lResultado.Text = valor;
            }
            catch (FormatException)
            {
                lResultado.Text = "Error: Entrada no válida";
            }
        }
        public void menu_Desplegable()
        {
            float num1 = 0, num2 = 0, total = 0;
            num1 = float.Parse(TValor1.Text);
            num2 = float.Parse(TValor2.Text);

            if (ListaDrop.SelectedIndex == 0)
            {
                total = num1 + num2;
                lResultado.Text = total.ToString();
            }
            else if (ListaDrop.SelectedIndex == 1)
            {
                total = num1 - num2;
                lResultado.Text = total.ToString();
            }
            else if (ListaDrop.SelectedIndex == 2)
            {
                total = num1 / num2;
                lResultado.Text = total.ToString();
            }
            else
            {
                total = num1 * num2;
                lResultado.Text = total.ToString();

            }
        
        }

    }
}
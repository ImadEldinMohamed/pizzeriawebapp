using pizzeriawebapp.ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pizzeriawebapp
{
    public partial class Pizzeria : System.Web.UI.Page
    {

        public static List<Pizza> Pizze = new List<Pizza>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string scelta = DropDownList1.SelectedValue;

            if (scelta == "margherita")
            {

                Pizza pizza = new Pizza("margherita", 5);
                for (int i=0;i< CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        Ingredienti ingrediente = new Ingredienti(CheckBoxList1.Items[i].Text, Double.Parse(CheckBoxList1.Items[i].Value));
                        Pizza.listaingrediente.Add(ingrediente);
                    }
                }
                Pizze.Add(pizza);
            }



            if(scelta =="4 formaggi")
            {
                Pizza pizza = new Pizza("4 formaggi", 5);

                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        Ingredienti ingrediente = new Ingredienti(CheckBoxList1.Items[i].Text, Double.Parse(CheckBoxList1.Items[i].Value));
                        Pizza.listaingrediente.Add(ingrediente);
                    }
                }
                Pizze.Add(pizza);
            }

            if( scelta =="solo pomodoro")
            {
                Pizza pizza = new Pizza("solo pomodoro", 7);
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        Ingredienti ingrediente = new Ingredienti(CheckBoxList1.Items[i].Text, Double.Parse(CheckBoxList1.Items[i].Value));
                        Pizza.listaingrediente.Add(ingrediente);
                    }
                }
                Pizze.Add(pizza);
            }

            if(scelta =="frutti di mare")
            {
                Pizza pizza=new Pizza("frutti di mare", 8);
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        Ingredienti ingrediente = new Ingredienti(CheckBoxList1.Items[i].Text, Double.Parse(CheckBoxList1.Items[i].Value));
                        Pizza.listaingrediente.Add(ingrediente);
                    }
                }
                Pizze.Add(pizza);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (Pizza item in Pizze)
            {

               
                Label1.Text = $"{item.Nome} {item.Prezzo}";
            }

            foreach(Ingredienti item in Pizza.listaingrediente)
            {
                double totingredienti = 0;
                totingredienti += item.Prezzo;
                Label1.Text = item.Nome;
             
            }
        }
    }
}
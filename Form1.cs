using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Form1 : Form

    {
        String OrderDetails = " {0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20} ";

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            FirstOutput.Items.Add(String.Format(OrderDetails ,"Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment ","Date of Order ", "Price"));



            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Online Order");


            cmbPayment.Items.Add("Select Type");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Direct Debit");

            FirstBrand.Items.Add("Bangladeshi");
            FirstBrand.Items.Add("African");
            FirstBrand.Items.Add("Canadian");
            FirstBrand.Items.Add("Indian");
            FirstBrand.Items.Add("USA");


            chkBean.Checked = false;
            chkFullSet.Checked = false;
            chkMilk.Checked = false;
            chkRice.Checked = false;

            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbSix.Checked = false;


        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurName.Clear();

            chkBean.Checked = false;
            chkFullSet.Checked = false;
            chkMilk.Checked = false;
            chkRice.Checked = false;

            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbSix.Checked = false;
            FirstBrand.SelectedItems.Clear();
            FirstOutput.Items.Clear();
            FirstOutput.Items.Add(String.Format(OrderDetails, "Customer ID", "Firstname", "Surname", "Order Made", "Method of Payment ", "Date of Order ", "Price"));


            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";
        }

        private void btnOrderItems_Click(object sender, EventArgs e)
        {
            String ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price;
            double Canadian_Price = 5.5;
            double Indian_Price = 4.5;
            double USA_price = 3.79;
            double African_Price = 6.5;
            double Bangladeshi_price = 4.59;




            ID = txtCustomerID.Text;
            Firstname = txtFirstName.Text;
            SurName = txtSurName.Text;
            SelectOrder = cmbOrderMade.Text;
            SelectType = cmbPayment.Text;
            SelectDate = dateTimePicker1.Text;

            if (FirstBrand.Text == "")
            {
                MessageBox.Show("You Must select a Brand", "Brands", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if ((chkBean.Checked == false) && (chkBean.Checked == false) && (chkBean.Checked == false))
            {
                MessageBox.Show("You Must Select an Item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            else if ((rbOne.Checked == false) && (rbTwo.Checked == false) && (rbFour.Checked == false) && (rbSix.Checked == false))
            {
                MessageBox.Show("You Must Select an Quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            /*.......................Canadian...Chkbean.............................................................. */

            if (FirstBrand.Text == "Canadian" && chkBean.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Canadian" && chkBean.Checked == true && rbTwo.Checked == true) 
            {

                Price = String.Format("{0:C}", (Canadian_Price * 2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }
        
            else if (FirstBrand.Text == "Canadian" && chkBean.Checked == true && rbFour.Checked == true) 
            {

                Price = String.Format("{0:C}", (Canadian_Price * 4));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Canadian" && chkBean.Checked == true && rbSix.Checked == true) ;
            {

                Price = String.Format("{0:C}", (Canadian_Price * 6));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            /*.......................ChkRice.............................................................. */



            if (FirstBrand.Text == "Canadian" && chkRice.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 1.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Canadian" && chkRice.Checked == true && rbTwo.Checked == true) 
            {

                Price = String.Format("{0:C}", (Canadian_Price * 2.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Canadian" && chkRice.Checked == true && rbFour.Checked == true) 
            {

                Price = String.Format("{0:C}", (Canadian_Price * 4.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Canadian" && chkRice.Checked == true && rbSix.Checked == true) 
            {

                Price = String.Format("{0:C}", (Canadian_Price * 6.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }




            /*.......................ChkMilk.............................................................. */



            if (FirstBrand.Text == "Canadian" && chkMilk.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 1.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Canadian" && chkMilk.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 2.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Canadian" && chkMilk.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 4.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Canadian" && chkMilk.Checked == true && rbSix.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 6.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }



            /*.......................chkSugar.............................................................. */



            if (FirstBrand.Text == "Canadian" && chkSugar.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 1.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Canadian" && chkSugar.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 2.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Canadian" && chkSugar.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 4.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Canadian" && chkSugar.Checked == true && rbSix.Checked == true)
            {

                Price = String.Format("{0:C}", (Canadian_Price * 6.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }


            /*...................Indian.......................*/


            /*..........................Chkbean.............................................................. */

            if (FirstBrand.Text == "Indian" && chkBean.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Indian" && chkBean.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Indian" && chkBean.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 4));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Indian" && chkBean.Checked == true && rbSix.Checked == true) ;
            {

                Price = String.Format("{0:C}", (Indian_Price * 6));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            /*.......................ChkRice.............................................................. */



            if (FirstBrand.Text == "Indian" && chkRice.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 1.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Indian" && chkRice.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 2.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Indian" && chkRice.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 4.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Indian" && chkRice.Checked == true && rbSix.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 6.1));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }




            /*.......................ChkMilk.............................................................. */



            if (FirstBrand.Text == "Indian" && chkMilk.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 1.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Indian" && chkMilk.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 2.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Indian" && chkMilk.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 4.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Indian" && chkMilk.Checked == true && rbSix.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 6.2));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }



            /*.......................chkSugar.............................................................. */



            if (FirstBrand.Text == "Indian" && chkSugar.Checked == true && rbOne.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 1.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }
            else if (FirstBrand.Text == "Indian" && chkSugar.Checked == true && rbTwo.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 2.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }

            else if (FirstBrand.Text == "Indian" && chkSugar.Checked == true && rbFour.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 4.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));

            }

            else if (FirstBrand.Text == "Indian" && chkSugar.Checked == true && rbSix.Checked == true)
            {

                Price = String.Format("{0:C}", (Indian_Price * 6.3));
                FirstOutput.Items.Add(String.Format(OrderDetails, ID, Firstname, SurName, SelectOrder, SelectType, SelectDate, Price));
            }




        }

        private void chkFullSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullSet.Checked)
            {
                chkRice.Checked = true;
                chkMilk.Checked = true;
                chkSugar.Checked = true;
                chkBean.Checked = true;
            }
            else
            {
                chkRice.Checked = false;
                chkMilk.Checked = false;
                chkSugar.Checked = false;
                chkBean.Checked = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BahrainAirshow
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        decimal total=0;
        static decimal VAT= 0.05m;
        string ProductString = "";

        private void toysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productTableDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productTableDataSet.AirCraftModel' table. You can move, or remove it, as needed.
            this.airCraftModelTableAdapter.Fill(this.productTableDataSet.AirCraftModel);
            // TODO: This line of code loads data into the 'productTableDataSet.Clothing' table. You can move, or remove it, as needed.
            this.clothingTableAdapter.Fill(this.productTableDataSet.Clothing);
            // TODO: This line of code loads data into the 'productTableDataSet.Toys' table. You can move, or remove it, as needed.
            this.toysTableAdapter.Fill(this.productTableDataSet.Toys);

            listBox_BillingList.Items.Add("Your Billing Details:\n");
            listBox_BillingList.Items.Add("ProductID \t \t  Product Name \t  \t\t Price");

        }

        private void Price()
        {
            this.airCraftModelTableAdapter.Fill(this.productTableDataSet.AirCraftModel);
        }

        private void button_BuySpecific_Click(object sender, EventArgs e)
        {
            //textBox_BuySpe.Text = this.productTableDataSet.AirCraftModel.ProductIDColumn.ToString();
            int id = int.Parse(textBox_BuySpe.Text);
            this.airCraftModelTableAdapter.PriceByItemID(this.productTableDataSet.AirCraftModel, id);

            if (id == 2)
            {
                total = total + 23.5000m;
                ProductString = "2 \t \t \t AirbusACJ320 \t\t\t 23.5000";
            }
            if (id == 3)
            {
                total = total + 20.4000m;
                ProductString = "3 \t \t \t GulfStream1125 \t\t\t 20.4000";
            }
            if (id == 4)
            {
                total = total + 35.0000m;
                ProductString = "4 \t \t \t HondaJet \t\t\t 35.0000";
            }
            if (id == 5)
            {
                total = total + 29.0000m;
                ProductString = "5 \t \t \t HawkerJet4000 \t\t\t 29.0000";
            }
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add(ProductString);
        }

        private void button_BuyAll_Click(object sender, EventArgs e)
        {
            decimal sum;
            sum = (decimal)this.airCraftModelTableAdapter.SumAllAirModel();
            //this.airCraftModelTableAdapter.SumAllAirModel.ToString()(this.productTableDataSet.AirCraftModel);
            //textBox_PriceAll.Text = sum.ToString();

            total = sum;
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add("2 \t \t \t AirbusACJ320 \t\t\t 23.5000");
            listBox_BillingList.Items.Add("3 \t \t \t GulfStream1125 \t\t\t 20.4000");
            listBox_BillingList.Items.Add("4 \t \t \t HondaJet \t\t\t 35.0000");
            listBox_BillingList.Items.Add("5 \t \t \t HawkerJet4000 \t\t\t 29.0000");

        }

        private void button_buyAllCloth_Click(object sender, EventArgs e)
        {
            decimal sumCloth;
            sumCloth= (decimal)this.clothingTableAdapter.PriceAllCloth();
            
            //textBox_PriceAllCloth.Text = sumCloth.ToString();

            total = total + sumCloth;
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add("1 \t \t \t CrewNeck  \t\t\t 10");
            listBox_BillingList.Items.Add("2 \t \t \t V-Neck T-Shirt  \t\t\t 5");
            listBox_BillingList.Items.Add("3 \t \t \t Slim Fit SweatPants \t\t 9");
            listBox_BillingList.Items.Add("4 \t \t \t Tape Jogger \t\t\t 15");
            listBox_BillingList.Items.Add("5 \t \t \t Ripped SweatPants \t\t 12");
        }

        private void button_BuyAllToys_Click(object sender, EventArgs e)
        {
            decimal sumToys;
            sumToys = (decimal)this.toysTableAdapter.PriceAllToys();

            //textBox_PriceAllToys.Text = sumToys.ToString();

            total = total + sumToys;
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add("1 \t \t \t Military Transport Set  \t\t 15");
            listBox_BillingList.Items.Add("2 \t \t \t Alaska Airlines  \t\t\t 10");
            listBox_BillingList.Items.Add("3 \t \t \t Pilot doll (Female) \t\t\t 5");
            listBox_BillingList.Items.Add("4 \t \t \t Apache Helicopter \t\t\t 6");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label_TotalBuying.Text = total.ToString() +" BD";
        }

        private void button_useVat_Click(object sender, EventArgs e)
        {
            decimal vatprice;
            vatprice = total+(total * VAT);
            textBox_VatPrice.Text = vatprice.ToString() + " BD";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_SelectedToy.Text);
            this.toysTableAdapter.PriceByItemIDToy(this.productTableDataSet.Toys, id);

            if (id == 1)
            {
                total = total + 15m;
                ProductString = "1 \t \t \t Military Transport Set  \t\t 15";
            }
            if (id == 2)
            {
                total = total + 10m;
                ProductString = "2 \t \t \t Alaska Airlines  \t\t\t 10";
            }
            if (id == 3)
            {
                total = total + 5m;
                ProductString = "3 \t \t \t Pilot doll (Female) \t\t 5";
            }
            if (id == 4)
            {
                total = total + 6m;
                ProductString = "4 \t \t \t Apache Helicopter \t\t\t 6";
            }
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add(ProductString);
        }

        private void button_SelectIDCloth_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_SelectedClothing.Text);
            this.clothingTableAdapter.PriceByItemIDCloth(this.productTableDataSet.Clothing, id);
            
            if (id == 1)
            {
                total = total + 10m;
                ProductString = "1 \t \t \t CrewNeck  \t\t\t 10";
            }
            if (id == 2)
            {
                total = total + 5m;
                ProductString = "2 \t \t \t V-Neck T-Shirt  \t\t\t 5";
            }
            if (id == 3)
            {
                total = total + 9m;
                ProductString = "3 \t \t \t Slim Fit SweatPants \t\t 9";
            }
            if (id == 4)
            {
                total = total + 15m;
                ProductString = "4 \t \t \t Tape Jogger \t\t\t 15";
            }
            if (id == 5)
            {
                total = total + 12m;
                ProductString = "5 \t \t \t Ripped SweatPants \t\t 12";
            }
            label_TotalBuying.Text = total.ToString() + " BD";
            listBox_BillingList.Items.Add(ProductString);
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            //textBox_PriceAll.Text = "";
            textBox_BuySpe.Text = "";
            textBox_VatPrice.Text = "";
            listBox_BillingList.Items.Clear();
            label_TotalBuying.Text = "";
             
        }
    }
}

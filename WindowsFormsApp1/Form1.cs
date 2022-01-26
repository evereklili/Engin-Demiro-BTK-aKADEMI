using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly object dgwProducts;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ETradeContext context = new ETradeContext()) //
            {
                //using şu anlama gelir ETradeContext pahalı bir nesnedir çok yer kaplıyordur. Bu bağlamda bu tip nesneelere f12 gittiğimde 
                //IDisposeble interface implemente edilmektedir. bunu yapınca şunu sağlamış oluruz? method bittiği zaman .net memory yöneticisi garbage collector bunu bellekten atmaya başlıyor. 
                //çöptoplayıcı ile yapar. using kullanmanın avantajı blok bittiği anda garbage collector beklemeden dispose (bellekten atıyoruz.) 

               // dgwProducts.DataSource = context.Products.ToList();


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using Business.Concrate;
using DataAccess.Concrete.EntityFramework;

namespace UITwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAll())
            {
                listBox1.Items.Add(item.ProductName);
            }
        }
    }
}
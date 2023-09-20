using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Xml;
using WindowsForm_CSV_Reader.Database;
using WindowsForm_CSV_Reader.Models;

namespace WindowsForm_CSV_Reader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadDataFromDb();
            btnAdd.Visible = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";
            ofd.ShowDialog();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null,
                Delimiter = ";",
            };
            if (ofd.FileName != "")
            {

                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<DataModel>();
                    List<DataModel> list = records.ToList();
                    list.RemoveAt(0); //Removes first row with headers
                    dataGridView1.DataSource = list;
                    btnAdd.Visible = true;

                }

            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<DataModel> LoadDataFromDb()
        {
            using (var context = new DataContext())
            {
                return context.Items.ToList();
            }
        }
        private void SavaDataInDb(List<DataModel> data)
        {
            using (var context = new DataContext())
            {
                context.Items.AddRange(data);
                context.SaveChanges();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            List<DataModel> data = dataGridView1.DataSource as List<DataModel>;
            SavaDataInDb(data);        
        }

        private void btnGetFromDb_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            dataGridView1.DataSource = LoadDataFromDb();
        }
    }
}
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using WindowsForm_CSV_Reader.Models;

namespace WindowsForm_CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";
            ofd.ShowDialog();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
            if (ofd.FileName != "")
            {
                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<DataModel>();
                    dataGridView1.DataSource = records.ToList();

                }
            }

        }
    }
}
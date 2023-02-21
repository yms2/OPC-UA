using System.Data;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace DataGrid1
{
	public partial class Form1 : Form
	{

		
		public Form1()
		{
			InitializeComponent();
		}

		List<String> x = new List<string>();
		List<String> y = new List<string>();

		private void button1_Click(object sender, EventArgs e)
		{
			StreamReader file = new StreamReader("data.csv");

			DataTable table = new DataTable();
			table.Columns.Add("number");
			table.Columns.Add("count");

			while (!file.EndOfStream)
			{
				string line = file.ReadLine();
				string[] data = line.Split(',');
				table.Rows.Add(data[0],data[1]);

				x.Add(data[0]);
				y.Add(data[1]);
			}
			dataGridView1.DataSource = table;
		}
	}
}
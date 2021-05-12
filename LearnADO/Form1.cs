using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LearnADO
{
    public partial class Form1 : Form
    {

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        string strSqlString;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void initialize()
        {
            
            string strServerName = "(localdb)";
            string strInstanceName = "mssqllocaldb";
            string strDBName = "HospitalDB";

            // @ symbol is for verbatim interprestation of any string
            string strConnectionString = string.Format(@"Data Source={0}\{1};Initial Catalog={2};Integrated Security=SSPI", strServerName, strInstanceName, strDBName);
            
            sqlConnection = new SqlConnection(strConnectionString);
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            initialize();

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            strSqlString = "select * from patients";

            sqlCommand = new SqlCommand(strSqlString, sqlConnection);

            SqlDataReader sqlDataReader = null;

            try
            {
                await sqlConnection.OpenAsync();
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                while (sqlDataReader.Read())
                {
                    table.Rows.Add(sqlDataReader[0], sqlDataReader[1]);
                }

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                displayMessageBox(ex.Message);
            }
            finally
            {
                sqlDataReader?.Close();
                sqlConnection?.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            initialize();

            string strPatientName = textBox1.Text;

            if (strPatientName != "")
            {
                strSqlString = $"insert into patients (name) values('{strPatientName}')";
                
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(strSqlString, sqlConnection);

                    sqlCommand.ExecuteNonQuery();

                    displayMessageBox($"New patient added: {strPatientName}");

                    textBox1.Text = "";
                }
                catch (Exception ex)
                {
                    displayMessageBox(ex.Message);
                }
                finally
                {
                    sqlConnection?.Close();
                }
            }

            else
                displayMessageBox("Enter a name first.");
        }

        public void displayMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }
    }
}

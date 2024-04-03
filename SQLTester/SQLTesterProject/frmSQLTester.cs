using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace SQLTesterProject
{
    public partial class frmSQLTester : Form
    {
        public frmSQLTester()
        {
            InitializeComponent();
        }

        //  Global database variables

        //  Taken from URL:
        //  https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=dotnet-plat-ext-6.0
        //  A SqlConnection object represents a unique session
        //  to a SQL Server data source. With a client/server
        //  database system, it is equivalent to a network
        //  connection to the server. SqlConnection is used
        //  together with SqlDataAdapter and SqlCommand to
        //  increase performance when connecting to a Microsoft
        //  SQL Server database. For all third-party SQL
        //  Server products and other OLE DB-supported data
        //  sources, use OleDbConnection.
        SqlConnection conn = null!;

        //  Taken from URL:
        //  https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand?view=dotnet-plat-ext-6.0
        //  When an instance of SqlCommand is created, the
        //  read/write properties are set to their initial values. 
        SqlCommand queryCommand = null!;

        //  Taken from the following URL:
        //  https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter?view=dotnet-plat-ext-6.0
        //  The SqlDataAdapter, serves as a bridge between a
        //  DataSet and SQL Server for retrieving and saving data.
        //
        //  The SqlDataAdapter provides this bridge by mapping Fill,
        //  which changes the data in the DataSet to match the data
        //  in the data source, and Update, which changes the data
        //  in the data source to match the data in the DataSet,
        //  using the appropriate Transact-SQL statements against
        //  the data source.
        SqlDataAdapter queryAdapter = null! ;

        //  Taken from the following URL:
        //  https://www.c-sharpcorner.com/UploadFile/mahesh/datatable-in-C-Sharp/
        //
        //  The DataTable class in C# ADO.NET is a database table
        //  representation and provides a collection of columns and
        //  rows to store data in a grid form. 
        DataTable table = null!;

        private void frmSQLTester_Load(object sender, EventArgs e)
        {
            //  Establish connection to database
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SalesOrders;Integrated Security=SSPI";

            //  Create SqlConnection based on connString above
            conn = new SqlConnection(connString);

            //  Open connection
            conn.Open();
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            AttemptToExecuteQuery();
        }

        private void AttemptToExecuteQuery()
        {
            //  Validate that the textbox is NOT empty
            if (txtQuery.Text.Trim() == "")
            {
                ShowErrorMessage("Nothing Was Entered Into The TextBox!",
                                 "QUERY TEXTBOX LEFT EMPTY");
                txtQuery.Focus();
                return;
            }

            //  Something WAS entered into the textbox

            //  "Clear out" the query command
            queryCommand = null!;

            //  Instantiate a new SqlDataAdapter
            queryAdapter = new SqlDataAdapter();

            //  Instantiate a new DataTable
            table = new DataTable();

            try
            {
                //  Instantiate a new SqlCommand object
                queryCommand = new SqlCommand(txtQuery.Text.Trim(), conn);

                //  Use queryAdapter as a "bridge" between
                //  the program and the database itself.
                queryAdapter.SelectCommand = queryCommand;

                //  Fill the DataTable table with the output
                //  of the queryAdapter
                queryAdapter.Fill(table);

                //  Set the data source for the datagridview
                dgvResults.DataSource = table;

                //  Set the number of records 
                //  returned in the associated label
                lblNumRecords.Text = table.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                 ex.GetType().ToString() + "\n\n",
                                 "INVALID QUERY ATTEMPTED");
                txtQuery.Text = "";
                txtQuery.Focus();
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            //  https://www.codeproject.com/Questions/332902/how-to-clear-datagridview-in-csharp
            if (this.dgvResults.DataSource != null)
            {
                this.dgvResults.DataSource = null;
            }
            else
            {
                this.dgvResults.Rows.Clear();
            }

            txtQuery.Text = "";
            lblNumRecords.Text = "0";
            txtQuery.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}

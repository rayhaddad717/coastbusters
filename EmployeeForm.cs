using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coast_Busters
{
    public partial class EmployeeForm : Form
    {
        public int PersonID;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet ds;
        private SqlDataAdapter dataAdapter;
        private string selectTable;
        private SqlCommandBuilder commandBuilder;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Connection Conn = new Connection();
            ds = new DataSet();
            connection = Conn.GetSqlConnection();
            editTableTab.SelectedIndex = 4;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds);
                MessageBox.Show("Update Succeeded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTableTab_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = editTableTab.SelectedIndex;
            switch (index)
            {
                case 0: selectTable = "select * from AvailableBikes"; break;
                case 1: selectTable = "select * from AvailableCars"; break;
                case 2: selectTable = "select * from BikeModels"; break;
                case 3: selectTable = "select * from CarModels"; break;
                case 4: selectTable = "select * from LoginCredentials"; break;
                case 5: selectTable = "select * from  People"; break;
                case 6: selectTable = "select * from SubscriptionTypes"; break;
                case 7: selectTable = "select * from Subscriptions"; break;

            }
            dataGridView.Parent = editTableTab.SelectedTab;
            updateButton.Parent = editTableTab.SelectedTab;
            exitButton.Parent = editTableTab.SelectedTab;
            if (index == 4 || index == 5 || index == 7)
            {
                dataGridView.AllowUserToAddRows = false;
            }
            else
            {
                dataGridView.AllowUserToAddRows = true;
            }
            command = new SqlCommand(selectTable, connection);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter(command);
                ds.Reset();
                dataAdapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];

                dataGridView.Refresh();
                dataGridView.Columns[0].ReadOnly = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

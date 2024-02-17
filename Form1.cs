using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        // Created to check whether the selection is made from DataGridView or not
        bool isSelected = false;
        public Form1()
        {
            InitializeComponent();
        }

        // Establishing the connection
        SqlConnection connection = new SqlConnection("Data Source=Cem\\MECSQL;Initial Catalog=Project;Integrated Security=True");

        private void button_add_Click(object sender, EventArgs e)
        {
            bool error = false;

            // Checking whether there is an empty TextBox
            bool whiteSpace =
                 string.IsNullOrWhiteSpace(name.Text) ||
                 string.IsNullOrWhiteSpace(surname.Text) ||
                 string.IsNullOrWhiteSpace(tc.Text) ||
                 string.IsNullOrWhiteSpace(studentNo.Text) ||
                 string.IsNullOrWhiteSpace(city.Text) ||
                 string.IsNullOrWhiteSpace(faculty.Text) ||
                 string.IsNullOrWhiteSpace(scholarshipRate.Text) ||
                 string.IsNullOrWhiteSpace(fee.Text) ||
                 string.IsNullOrWhiteSpace(payment.Text);

            // If there is an empty TextBox, an incorrect input warning is printed on the screen and the remaining operations are not performed.
            if (whiteSpace)
            {
                MessageBox.Show("Incorrect input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Checking whether the entered student ID is already registered or not

                if (!isAvailableNo(studentNo.Text))
                {
                    connection.Open();

                    // Add query is created
                    SqlCommand add = new SqlCommand("insert into tableMain (Name,Surname,TC,[Student No],City,Faculty,[Scholarship Rate],Fee,Payment,Debt)values (@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9,@e10)", connection);

                    add.Parameters.AddWithValue("@e1", name.Text);
                    add.Parameters.AddWithValue("@e2", surname.Text);
                    add.Parameters.AddWithValue("@e3", tc.Text);
                    add.Parameters.AddWithValue("@e4", studentNo.Text);
                    add.Parameters.AddWithValue("@e5", city.Text);
                    add.Parameters.AddWithValue("@e6", faculty.Text);
                    add.Parameters.AddWithValue("@e7", scholarshipRate.Text);
                    add.Parameters.AddWithValue("@e8", float.Parse(fee.Text));

                    try
                    {
                        add.Parameters.AddWithValue("@e9", float.Parse(payment.Text));
                        add.Parameters.AddWithValue("@e10", float.Parse(fee.Text) - (float.Parse(scholarshipRate.Text) * float.Parse(fee.Text) / 100) - float.Parse(payment.Text));
                        add.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        connection.Close();
                        error = true;
                        MessageBox.Show("Incorrect input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // If the try-catch block is successful, it runs and prints the success message on the screen.
                    if (!error)
                    {
                        connection.Close();

                        MessageBox.Show("The record has been added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Automatically refresh the list after adding
                        this.tableMainTableAdapter.Fill(this.projectDataSet.tableMain);
                    }
                }
            }
        }

        // Method to check whether the entered student ID is already registered 
        private bool isAvailableNo(string input)
        {
            int total = 0;
            bool error = false;
            connection.Open();


            SqlCommand query = new SqlCommand("Select COUNT(*) from tableMain where [Student No]=@studentNo", connection);
            query.Parameters.AddWithValue("@studentNo", input);

            // If the entered value is entered with spaces, for example: '111___222', the program will crash. This situation is prevented with try-catch
            try
            {
                // ExecuteScalar() is a method to get the COUNT(*) value. Returns value of type Object
                // The value found with Count is assigned to the variable with the ExecuteScalar() method
                total = Convert.ToInt32(query.ExecuteScalar());
            }
            catch (Exception)
            {
                connection.Close();
                error = true;
                MessageBox.Show("Incorrect input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!error)
            {
                connection.Close();

                if (total > 0)
                {
                    MessageBox.Show("Record is already available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // If there is an error, the value true is returned after the query is made with the method to prevent the remaining operations from running.
            else
            {
                return true;
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            // Runs when selection made from DataGridView
            if (isSelected)
            {
                // Prints a checkbox on the screen with the default option being no
                DialogResult answer = MessageBox.Show("Are you sure you want to permanently delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                // Runs if the selected option is yes
                if (answer == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand sil = new SqlCommand("Delete From tableMain where [Student No] = @s1", connection);
                    sil.Parameters.AddWithValue("@s1", studentNo.Text);
                    sil.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Record deletion successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Automatically refresh the list after deletion
                    this.tableMainTableAdapter.Fill(this.projectDataSet.tableMain);
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            bool error = false;

            // Works if selection is made from DataGridView
            if (isSelected)
            {
                connection.Open();

                // Update query is created
                SqlCommand update = new SqlCommand("Update tableMain set Name=@g1,Surname=@g2,TC=@g3,City=@g5,Faculty=@g6,[Scholarship Rate]=@g7,Fee=@g8,Payment=@g9,Debt=@g10 where [Student No]=@g4", connection);

                update.Parameters.AddWithValue("@g1", name.Text);
                update.Parameters.AddWithValue("@g2", surname.Text);
                update.Parameters.AddWithValue("@g4", studentNo.Text);
                update.Parameters.AddWithValue("@g5", city.Text);
                update.Parameters.AddWithValue("@g6", faculty.Text);
                update.Parameters.AddWithValue("@g7", scholarshipRate.Text);


                // If the entered value is not a number or is entered with spaces, 
                // for example: '111___222', the program will crash. This situation is prevented with try-catch
                try
                {
                    update.Parameters.AddWithValue("@g3", tc.Text);
                    update.Parameters.AddWithValue("@g8", float.Parse(fee.Text));
                    update.Parameters.AddWithValue("@g9", float.Parse(payment.Text));
                    update.Parameters.AddWithValue("@g10", float.Parse(debt.Text));
                    update.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    connection.Close();
                    error = true;
                    MessageBox.Show("Incorrect input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!error)
                {
                    connection.Close();
                    MessageBox.Show("Record update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Automatically refresh the list after adding
                    this.tableMainTableAdapter.Fill(this.projectDataSet.tableMain);
                }
            }
        }

        // Allows the list to be displayed in DataGridView
        private void button_list_Click(object sender, EventArgs e)
        {
            this.tableMainTableAdapter.Fill(this.projectDataSet.tableMain);
        }

        // Clears values in all TextBoxes
        private void button_clear_Click(object sender, EventArgs e)
        {
            name.Text = null;
            surname.Text = null;
            tc.Text = null;
            studentNo.Text = null;
            city.Text = null;
            faculty.Text = null;
            scholarshipRate.Text = null;
            fee.Text = null;
            payment.Text = null;
            debt.Text = null;
        }

        // Takes the row information of the selected cell and places all row values in related TextBoxes
        private void data_CellClick(object sender, DataGridViewCellEventArgs selectedCell)
        {
            // Created to check whether the selection is made from DataGridView
            isSelected = true;

            // Row information of the selected cell is taken and assigned to the variable
            int selectedRow = selectedCell.RowIndex;

            // Created to avoid crashing when pressing the section containing column names
            if (selectedRow >= 0)
            {
                // Values are taken according to rows and columns and transferred to TextBox
                name.Text = data.Rows[selectedRow].Cells["data_name"].Value.ToString();
                surname.Text = data.Rows[selectedRow].Cells["data_surname"].Value.ToString();
                tc.Text = data.Rows[selectedRow].Cells["data_tc"].Value.ToString();
                studentNo.Text = data.Rows[selectedRow].Cells["data_studentNo"].Value.ToString();
                city.Text = data.Rows[selectedRow].Cells["data_city"].Value.ToString();
                faculty.Text = data.Rows[selectedRow].Cells["data_faculty"].Value.ToString();
                scholarshipRate.Text = data.Rows[selectedRow].Cells["data_scholarshipRate"].Value.ToString();
                fee.Text = data.Rows[selectedRow].Cells["data_fee"].Value.ToString();
                payment.Text = data.Rows[selectedRow].Cells["data_payment"].Value.ToString();
                debt.Text = data.Rows[selectedRow].Cells["data_debt"].Value.ToString();
            }
        }

        // Calculating and displaying debt dynamically as inputs change
        private void payment_TextChanged(object sender, EventArgs e)
        {
            calculateDebt();
        }

        private void fee_TextChanged(object sender, EventArgs e)
        {
            calculateDebt();
        }

        private void scholarshipRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            calculateDebt();
        }

        // Calculating debt
        private void calculateDebt()
        {
            try
            {
                float calculatedDebt = float.Parse(fee.Text) - (float.Parse(scholarshipRate.Text) * float.Parse(fee.Text) / 100) - float.Parse(payment.Text);
                debt.Text = calculatedDebt.ToString();
            }
            catch (Exception) { }
        }

    }
}
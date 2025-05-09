using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Semester_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=BB21315\\SPRING;Database=SemesterProj;User ID=Matney;Password=79Panprong; TrustServerCertificate=True";

            // Simplified 'using' statement as per IDE0063    
            using var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=BB21315\\SPRING;Database=SemesterProj;User ID=Matney;Password=79Panprong; TrustServerCertificate=True";

            string query = "SELECT * FROM Menu_Management";

            using var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                ADMIN.Items.Clear();
                while (reader.Read())
                {
                    ADMIN.Items.Add($"{reader["Id"]}: {reader["Name"]} - {reader["Price"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (ADMIN.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to modify.");
                return;
            }

            string? selectedItem = ADMIN.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            string[] parts = selectedItem.Split(':');
            if (parts.Length < 2 || !int.TryParse(parts[0], out int id))
            {
                MessageBox.Show("Invalid item format.");
                return;
            }

            string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter new name:", "Modify Item", "");
            string newPrice = Microsoft.VisualBasic.Interaction.InputBox("Enter new price:", "Modify Item", "");

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newPrice))
            {
                MessageBox.Show("Name and price cannot be empty.");
                return;
            }

            string connectionString = "Server=BB21315\\SPRING;Database=SemesterProj;User ID=Matney;Password=79Panprong; TrustServerCertificate=True";

            string updateQuery = "UPDATE Menu_Management SET Name = @Name, Price = @Price WHERE Id = @Id";

            using var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                using var cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Name", newName);
                cmd.Parameters.AddWithValue("@Price", newPrice);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item updated successfully!");
                    listBox1_SelectedIndexChanged(this, EventArgs.Empty); // Refresh the list    
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=BB21315\\SPRING;Database=SemesterProj;User ID=Matney;Password=79Panprong; TrustServerCertificate=True";

            string query = "SELECT * FROM Order_Processing";

            using var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                Orders.Items.Clear();
                while (reader.Read())
                {
                    Orders.Items.Add($"{reader["OrderId"]}: {reader["CustomerName"]} - {reader["OrderStatus"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
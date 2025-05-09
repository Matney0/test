namespace Lab_assignment_5
{
    public partial class Form1 : Form
    {
        public Form1() { }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());

                // Database connection
                string connectionString = "Server=BB21315\\SPRING;Database=your_database_name;Trusted_Connection=True;";
                using SqlConnection connection = new(connectionString);
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection successful.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database connection failed: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Reference to the DataGridView
                DataGridView grid = (DataGridView)sender;

                string currentValue = grid[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? string.Empty;
                string newValue = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter a new value for the cell (current: '{currentValue}')",
                    "Input Value",
                    currentValue);

                if (!string.IsNullOrEmpty(newValue))
                {
                    // Update cell value with the user input
                    grid[e.ColumnIndex, e.RowIndex].Value = newValue;
                    MessageBox.Show($"Value updated to: {newValue}", "Success");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

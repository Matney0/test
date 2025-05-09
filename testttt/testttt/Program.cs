using System.Data.SqlClient;
using System.Windows.Forms;

namespace testttt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            // Define DataGridView columns (these should match your database table schema)
            dataGridView1.Columns.Add("Column1", "Column1");
            dataGridView1.Columns.Add("Column2", "Column2");
            dataGridView1.AllowUserToAddRows = false; // Disable automatic new row addition
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Load data from the database into the DataGridView
            LoadDataIntoDataGridView();
        }

    }
}
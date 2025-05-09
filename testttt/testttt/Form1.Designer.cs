
using System.Data.SqlClient;

namespace testttt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button connectButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code  

        private void InitializeComponent()
        {
            connectButton = new Button();
            SuspendLayout();
            // 
            // connectButton
            // 
            connectButton.Location = new Point(350, 200);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(100, 30);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connectButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private void connectButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=BB21315\\SPRING;Database=Spring;User Id=Matney;Password=new;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected to database BB21314 successfully!");

                    SqlCommand mySearch = new SqlCommand("SELECT tableKey, custName FROM dbo.Sring", connection);
                    using (SqlDataReader reader = mySearch.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show(String.Format("Hello {0}", reader["custName"]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

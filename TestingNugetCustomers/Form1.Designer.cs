namespace TestingNugetCustomers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cargarCustomers = new Button();
            label1 = new Label();
            lstCustomers = new ListBox();
            SuspendLayout();
            // 
            // cargarCustomers
            // 
            cargarCustomers.Location = new Point(52, 45);
            cargarCustomers.Name = "cargarCustomers";
            cargarCustomers.Size = new Size(85, 65);
            cargarCustomers.TabIndex = 0;
            cargarCustomers.Text = "Cargar Customers";
            cargarCustomers.UseVisualStyleBackColor = true;
            cargarCustomers.Click += cargarCustomers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 24);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista Customers";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.Location = new Point(222, 56);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(263, 244);
            lstCustomers.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCustomers);
            Controls.Add(label1);
            Controls.Add(cargarCustomers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cargarCustomers;
        private Label label1;
        private ListBox lstCustomers;
    }
}

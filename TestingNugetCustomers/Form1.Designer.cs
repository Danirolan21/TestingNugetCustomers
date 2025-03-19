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
            button1 = new Button();
            SuspendLayout();
            // 
            // cargarCustomers
            // 
            cargarCustomers.Location = new Point(89, 90);
            cargarCustomers.Margin = new Padding(5, 6, 5, 6);
            cargarCustomers.Name = "cargarCustomers";
            cargarCustomers.Size = new Size(146, 130);
            cargarCustomers.TabIndex = 0;
            cargarCustomers.Text = "Cargar Customers";
            cargarCustomers.UseVisualStyleBackColor = true;
            cargarCustomers.Click += cargarCustomers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 1;
            label1.Text = "Lista Customers";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.Location = new Point(381, 112);
            lstCustomers.Margin = new Padding(5, 6, 5, 6);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(448, 484);
            lstCustomers.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(89, 273);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(146, 130);
            button1.TabIndex = 3;
            button1.Text = "Cargar Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(button1);
            Controls.Add(lstCustomers);
            Controls.Add(label1);
            Controls.Add(cargarCustomers);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cargarCustomers;
        private Label label1;
        private ListBox lstCustomers;
        private Button button1;
    }
}

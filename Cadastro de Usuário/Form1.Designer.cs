namespace Cadastro_de_Usuário
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
            lblrm = new Label();
            lblcpf = new Label();
            lblnome = new Label();
            lblrrm = new TextBox();
            textBox3 = new TextBox();
            mstCPF = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblrm
            // 
            lblrm.AutoSize = true;
            lblrm.Location = new Point(12, 23);
            lblrm.Name = "lblrm";
            lblrm.Size = new Size(39, 25);
            lblrm.TabIndex = 0;
            lblrm.Text = "RM";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(143, 23);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(42, 25);
            lblcpf.TabIndex = 1;
            lblcpf.Text = "CPF";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(232, 23);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(64, 25);
            lblnome.TabIndex = 2;
            lblnome.Text = "NOME";
            // 
            // lblrrm
            // 
            lblrrm.Location = new Point(12, 54);
            lblrrm.Name = "lblrrm";
            lblrrm.Size = new Size(98, 31);
            lblrrm.TabIndex = 3;
            lblrrm.TextChanged += lblrrm_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 31);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // mstCPF
            // 
            mstCPF.Location = new Point(116, 54);
            mstCPF.Mask = "###,###,###,##";
            mstCPF.Name = "mstCPF";
            mstCPF.Size = new Size(110, 31);
            mstCPF.TabIndex = 6;
            mstCPF.MaskInputRejected += mstCPF_MaskInputRejected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino", "Gosto" });
            comboBox1.Location = new Point(318, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 455);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mstCPF);
            Controls.Add(textBox3);
            Controls.Add(lblrrm);
            Controls.Add(lblnome);
            Controls.Add(lblcpf);
            Controls.Add(lblrm);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblrm;
        private Label lblcpf;
        private Label lblnome;
        private TextBox lblrrm;
        private TextBox textBox3;
        private MaskedTextBox mstCPF;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}

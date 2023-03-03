namespace WinFormsApp1
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
            this.tbx_Cognome = new System.Windows.Forms.TextBox();
            this.tbx_Nome = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbt_m = new System.Windows.Forms.RadioButton();
            this.rbt_F = new System.Windows.Forms.RadioButton();
            this.btn_CalcCF = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbx_Cognome
            // 
            this.tbx_Cognome.Location = new System.Drawing.Point(70, 23);
            this.tbx_Cognome.Name = "tbx_Cognome";
            this.tbx_Cognome.Size = new System.Drawing.Size(195, 31);
            this.tbx_Cognome.TabIndex = 0;
            // 
            // tbx_Nome
            // 
            this.tbx_Nome.Location = new System.Drawing.Point(70, 77);
            this.tbx_Nome.Name = "tbx_Nome";
            this.tbx_Nome.Size = new System.Drawing.Size(195, 31);
            this.tbx_Nome.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // rbt_m
            // 
            this.rbt_m.AutoSize = true;
            this.rbt_m.Location = new System.Drawing.Point(70, 245);
            this.rbt_m.Name = "rbt_m";
            this.rbt_m.Size = new System.Drawing.Size(103, 29);
            this.rbt_m.TabIndex = 3;
            this.rbt_m.TabStop = true;
            this.rbt_m.Text = "Maschio";
            this.rbt_m.UseVisualStyleBackColor = true;
            // 
            // rbt_F
            // 
            this.rbt_F.AutoSize = true;
            this.rbt_F.Location = new System.Drawing.Point(70, 280);
            this.rbt_F.Name = "rbt_F";
            this.rbt_F.Size = new System.Drawing.Size(110, 29);
            this.rbt_F.TabIndex = 4;
            this.rbt_F.TabStop = true;
            this.rbt_F.Text = "Femmina";
            this.rbt_F.UseVisualStyleBackColor = true;
            // 
            // btn_CalcCF
            // 
            this.btn_CalcCF.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CalcCF.Location = new System.Drawing.Point(555, 98);
            this.btn_CalcCF.Name = "btn_CalcCF";
            this.btn_CalcCF.Size = new System.Drawing.Size(178, 102);
            this.btn_CalcCF.TabIndex = 5;
            this.btn_CalcCF.Text = "Calcola il CF";
            this.btn_CalcCF.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_CalcCF);
            this.Controls.Add(this.rbt_F);
            this.Controls.Add(this.rbt_m);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbx_Nome);
            this.Controls.Add(this.tbx_Cognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_Cognome;
        private TextBox tbx_Nome;
        private DateTimePicker dateTimePicker1;
        private RadioButton rbt_m;
        private RadioButton rbt_F;
        private Button btn_CalcCF;
        private ComboBox comboBox1;
    }
}
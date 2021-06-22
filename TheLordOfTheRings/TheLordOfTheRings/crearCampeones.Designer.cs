
namespace TheLordOfTheRings
{
    partial class crearCampeones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCampeon1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtApodoCampeon1 = new System.Windows.Forms.Label();
            this.txtFechaNacCamp1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCampeon1 = new System.Windows.Forms.ComboBox();
            this.crearEquipo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campeon de batalla Cuerpo a Cuerpo";
            // 
            // txtNombreCampeon1
            // 
            this.txtNombreCampeon1.AutoSize = true;
            this.txtNombreCampeon1.Location = new System.Drawing.Point(58, 265);
            this.txtNombreCampeon1.Name = "txtNombreCampeon1";
            this.txtNombreCampeon1.Size = new System.Drawing.Size(44, 13);
            this.txtNombreCampeon1.TabIndex = 2;
            this.txtNombreCampeon1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtApodoCampeon1
            // 
            this.txtApodoCampeon1.AutoSize = true;
            this.txtApodoCampeon1.Location = new System.Drawing.Point(202, 265);
            this.txtApodoCampeon1.Name = "txtApodoCampeon1";
            this.txtApodoCampeon1.Size = new System.Drawing.Size(38, 13);
            this.txtApodoCampeon1.TabIndex = 5;
            this.txtApodoCampeon1.Text = "Apodo";
            // 
            // txtFechaNacCamp1
            // 
            this.txtFechaNacCamp1.AutoSize = true;
            this.txtFechaNacCamp1.Location = new System.Drawing.Point(58, 330);
            this.txtFechaNacCamp1.Name = "txtFechaNacCamp1";
            this.txtFechaNacCamp1.Size = new System.Drawing.Size(90, 13);
            this.txtFechaNacCamp1.TabIndex = 6;
            this.txtFechaNacCamp1.Text = "FechaNacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Campeon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtCampeon1
            // 
            this.txtCampeon1.FormattingEnabled = true;
            this.txtCampeon1.Items.AddRange(new object[] {
            "Humano",
            "Enano",
            "Elfo"});
            this.txtCampeon1.Location = new System.Drawing.Point(205, 345);
            this.txtCampeon1.Name = "txtCampeon1";
            this.txtCampeon1.Size = new System.Drawing.Size(121, 21);
            this.txtCampeon1.TabIndex = 9;
            // 
            // crearEquipo
            // 
            this.crearEquipo.Location = new System.Drawing.Point(138, 392);
            this.crearEquipo.Name = "crearEquipo";
            this.crearEquipo.Size = new System.Drawing.Size(102, 58);
            this.crearEquipo.TabIndex = 18;
            this.crearEquipo.Text = "Crear Equipo";
            this.crearEquipo.UseVisualStyleBackColor = true;
            this.crearEquipo.Click += new System.EventHandler(this.crearEquipo_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 49);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(265, 174);
            this.textBox4.TabIndex = 20;
            // 
            // crearCampeones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 463);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.crearEquipo);
            this.Controls.Add(this.txtCampeon1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaNacCamp1);
            this.Controls.Add(this.txtApodoCampeon1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNombreCampeon1);
            this.Controls.Add(this.label1);
            this.Name = "crearCampeones";
            this.Text = "crearCampeones";
            this.Load += new System.EventHandler(this.crearCampeones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNombreCampeon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtApodoCampeon1;
        private System.Windows.Forms.Label txtFechaNacCamp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox txtCampeon1;
        private System.Windows.Forms.Button crearEquipo;
        private System.Windows.Forms.TextBox textBox4;
    }
}
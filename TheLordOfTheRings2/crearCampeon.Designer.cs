
namespace TheLordOfTheRings2
{
    partial class crearCampeon
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtEspecie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(31, 126);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(100, 20);
            this.txtApodo.TabIndex = 2;
            // 
            // txtFechNac
            // 
            this.txtFechNac.Location = new System.Drawing.Point(31, 169);
            this.txtFechNac.Name = "txtFechNac";
            this.txtFechNac.Size = new System.Drawing.Size(145, 20);
            this.txtFechNac.TabIndex = 3;
            // 
            // txtEspecie
            // 
            this.txtEspecie.FormattingEnabled = true;
            this.txtEspecie.Items.AddRange(new object[] {
            "Humano",
            "Elfo",
            "Enano"});
            this.txtEspecie.Location = new System.Drawing.Point(31, 205);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 21);
            this.txtEspecie.TabIndex = 4;
            // 
            // crearCampeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 383);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtFechNac);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Name = "crearCampeon";
            this.Text = "crearCampeon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.DateTimePicker txtFechNac;
        private System.Windows.Forms.ComboBox txtEspecie;
    }
}
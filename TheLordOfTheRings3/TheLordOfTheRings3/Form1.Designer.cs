
namespace TheLordOfTheRings3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnComenzarJuego = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.ListBox();
            this.btnComenzarBatalla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Lord Of The Ring";
            // 
            // btnComenzarJuego
            // 
            this.btnComenzarJuego.Location = new System.Drawing.Point(330, 46);
            this.btnComenzarJuego.Name = "btnComenzarJuego";
            this.btnComenzarJuego.Size = new System.Drawing.Size(87, 40);
            this.btnComenzarJuego.TabIndex = 1;
            this.btnComenzarJuego.Text = "Comenzar Juego";
            this.btnComenzarJuego.UseVisualStyleBackColor = true;
            this.btnComenzarJuego.Click += new System.EventHandler(this.btnComenzarJuego_Click);
            // 
            // pantalla
            // 
            this.pantalla.FormattingEnabled = true;
            this.pantalla.Location = new System.Drawing.Point(219, 118);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(283, 134);
            this.pantalla.TabIndex = 4;
            this.pantalla.Visible = false;
            // 
            // btnComenzarBatalla
            // 
            this.btnComenzarBatalla.Location = new System.Drawing.Point(307, 279);
            this.btnComenzarBatalla.Name = "btnComenzarBatalla";
            this.btnComenzarBatalla.Size = new System.Drawing.Size(128, 43);
            this.btnComenzarBatalla.TabIndex = 5;
            this.btnComenzarBatalla.Text = "Comenzar Batallas";
            this.btnComenzarBatalla.UseVisualStyleBackColor = true;
            this.btnComenzarBatalla.Visible = false;
            this.btnComenzarBatalla.Click += new System.EventHandler(this.btnComenzarBatalla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de participantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComenzarBatalla);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.btnComenzarJuego);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComenzarJuego;
        private System.Windows.Forms.ListBox pantalla;
        private System.Windows.Forms.Button btnComenzarBatalla;
        private System.Windows.Forms.Label label2;
    }
}


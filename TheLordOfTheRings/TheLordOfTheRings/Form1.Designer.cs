
namespace TheLordOfTheRings
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btnComenzarJuego = new System.Windows.Forms.Button();
            this.panelDeControles = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelDeControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Lord Of The Rings";
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(99, 89);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(578, 195);
            this.pantalla.TabIndex = 1;
            this.pantalla.Visible = false;
            // 
            // btnComenzarJuego
            // 
            this.btnComenzarJuego.Location = new System.Drawing.Point(351, 46);
            this.btnComenzarJuego.Name = "btnComenzarJuego";
            this.btnComenzarJuego.Size = new System.Drawing.Size(94, 37);
            this.btnComenzarJuego.TabIndex = 2;
            this.btnComenzarJuego.Text = "Comenzar";
            this.btnComenzarJuego.UseVisualStyleBackColor = true;
            this.btnComenzarJuego.Click += new System.EventHandler(this.btnComenzarJuego_Click);
            // 
            // panelDeControles
            // 
            this.panelDeControles.ColumnCount = 2;
            this.panelDeControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDeControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDeControles.Controls.Add(this.button2, 0, 0);
            this.panelDeControles.Controls.Add(this.button3, 1, 0);
            this.panelDeControles.Controls.Add(this.button4, 0, 1);
            this.panelDeControles.Controls.Add(this.button5, 1, 1);
            this.panelDeControles.Location = new System.Drawing.Point(99, 299);
            this.panelDeControles.Name = "panelDeControles";
            this.panelDeControles.RowCount = 2;
            this.panelDeControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDeControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDeControles.Size = new System.Drawing.Size(578, 85);
            this.panelDeControles.TabIndex = 3;
            this.panelDeControles.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(292, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 474);
            this.Controls.Add(this.panelDeControles);
            this.Controls.Add(this.btnComenzarJuego);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDeControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btnComenzarJuego;
        private System.Windows.Forms.TableLayoutPanel panelDeControles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


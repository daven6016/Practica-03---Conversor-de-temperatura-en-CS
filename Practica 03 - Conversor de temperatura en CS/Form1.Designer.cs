
namespace Practica_03___Conversor_de_temperatura_en_CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextCelcius = new System.Windows.Forms.Label();
            this.EntradaCelsius = new System.Windows.Forms.TextBox();
            this.EntradaFahrenheit = new System.Windows.Forms.TextBox();
            this.TextFahrenheit = new System.Windows.Forms.Label();
            this.botonCF = new System.Windows.Forms.Button();
            this.botonFC = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextCelcius
            // 
            this.TextCelcius.AutoSize = true;
            this.TextCelcius.Location = new System.Drawing.Point(13, 9);
            this.TextCelcius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextCelcius.Name = "TextCelcius";
            this.TextCelcius.Size = new System.Drawing.Size(50, 17);
            this.TextCelcius.TabIndex = 0;
            this.TextCelcius.Text = "Celcius";
            // 
            // EntradaCelsius
            // 
            this.EntradaCelsius.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EntradaCelsius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradaCelsius.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntradaCelsius.Location = new System.Drawing.Point(13, 30);
            this.EntradaCelsius.Margin = new System.Windows.Forms.Padding(4);
            this.EntradaCelsius.Name = "EntradaCelsius";
            this.EntradaCelsius.Size = new System.Drawing.Size(103, 18);
            this.EntradaCelsius.TabIndex = 1;
            // 
            // EntradaFahrenheit
            // 
            this.EntradaFahrenheit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EntradaFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntradaFahrenheit.Location = new System.Drawing.Point(186, 30);
            this.EntradaFahrenheit.Margin = new System.Windows.Forms.Padding(4);
            this.EntradaFahrenheit.Name = "EntradaFahrenheit";
            this.EntradaFahrenheit.Size = new System.Drawing.Size(100, 18);
            this.EntradaFahrenheit.TabIndex = 2;
            // 
            // TextFahrenheit
            // 
            this.TextFahrenheit.AutoSize = true;
            this.TextFahrenheit.Location = new System.Drawing.Point(183, 9);
            this.TextFahrenheit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextFahrenheit.Name = "TextFahrenheit";
            this.TextFahrenheit.Size = new System.Drawing.Size(72, 17);
            this.TextFahrenheit.TabIndex = 3;
            this.TextFahrenheit.Text = "Fahrenheit";
            this.TextFahrenheit.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonCF
            // 
            this.botonCF.BackColor = System.Drawing.Color.Transparent;
            this.botonCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonCF.Location = new System.Drawing.Point(13, 56);
            this.botonCF.Margin = new System.Windows.Forms.Padding(4);
            this.botonCF.Name = "botonCF";
            this.botonCF.Size = new System.Drawing.Size(100, 30);
            this.botonCF.TabIndex = 4;
            this.botonCF.Text = "Fº -> Cº";
            this.botonCF.UseVisualStyleBackColor = false;
            this.botonCF.Click += new System.EventHandler(this.botonCF_Click);
            // 
            // botonFC
            // 
            this.botonFC.BackColor = System.Drawing.Color.Transparent;
            this.botonFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonFC.Location = new System.Drawing.Point(186, 56);
            this.botonFC.Margin = new System.Windows.Forms.Padding(4);
            this.botonFC.Name = "botonFC";
            this.botonFC.Size = new System.Drawing.Size(100, 30);
            this.botonFC.TabIndex = 5;
            this.botonFC.Text = "Cº -> Fº";
            this.botonFC.UseVisualStyleBackColor = false;
            this.botonFC.Click += new System.EventHandler(this.botonFC_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.botonLimpiar.Location = new System.Drawing.Point(100, 97);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(298, 165);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonFC);
            this.Controls.Add(this.botonCF);
            this.Controls.Add(this.TextFahrenheit);
            this.Controls.Add(this.EntradaFahrenheit);
            this.Controls.Add(this.EntradaCelsius);
            this.Controls.Add(this.TextCelcius);
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Actividad 03 - Conversor de temperatura en C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextCelcius;
        private System.Windows.Forms.TextBox EntradaCelsius;
        private System.Windows.Forms.TextBox EntradaFahrenheit;
        private System.Windows.Forms.Label TextFahrenheit;
        private System.Windows.Forms.Button botonCF;
        private System.Windows.Forms.Button botonFC;
        private System.Windows.Forms.Button botonLimpiar;
    }
}


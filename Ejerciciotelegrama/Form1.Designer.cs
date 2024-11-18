namespace Ejerciciotelegrama
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.RadOrdinario = new System.Windows.Forms.RadioButton();
            this.RadUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(47, 59);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(315, 135);
            this.txtTelegrama.TabIndex = 1;
            // 
            // BCalcular
            // 
            this.BCalcular.Location = new System.Drawing.Point(269, 242);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(93, 27);
            this.BCalcular.TabIndex = 2;
            this.BCalcular.Text = "Calcular";
            this.BCalcular.UseVisualStyleBackColor = true;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 252);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // RadOrdinario
            // 
            this.RadOrdinario.AutoSize = true;
            this.RadOrdinario.Location = new System.Drawing.Point(36, 217);
            this.RadOrdinario.Name = "RadOrdinario";
            this.RadOrdinario.Size = new System.Drawing.Size(67, 17);
            this.RadOrdinario.TabIndex = 6;
            this.RadOrdinario.TabStop = true;
            this.RadOrdinario.Text = "Ordinario";
            this.RadOrdinario.UseVisualStyleBackColor = true;
            // 
            // RadUrgente
            // 
            this.RadUrgente.AutoSize = true;
            this.RadUrgente.Location = new System.Drawing.Point(146, 217);
            this.RadUrgente.Name = "RadUrgente";
            this.RadUrgente.Size = new System.Drawing.Size(63, 17);
            this.RadUrgente.TabIndex = 7;
            this.RadUrgente.TabStop = true;
            this.RadUrgente.Text = "Urgente";
            this.RadUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 323);
            this.Controls.Add(this.RadUrgente);
            this.Controls.Add(this.RadOrdinario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton RadOrdinario;
        private System.Windows.Forms.RadioButton RadUrgente;
    }
}


namespace ClaseFracciones
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
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.numEntero1 = new System.Windows.Forms.NumericUpDown();
            this.numEntero2 = new System.Windows.Forms.NumericUpDown();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblResultadoEntero = new System.Windows.Forms.Label();
            this.lblResultadoNumerador = new System.Windows.Forms.Label();
            this.lblResultadoDenominador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador1.Location = new System.Drawing.Point(82, 37);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(77, 23);
            this.numNumerador1.TabIndex = 0;
            // 
            // numDenominador1
            // 
            this.numDenominador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador1.Location = new System.Drawing.Point(82, 79);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(77, 23);
            this.numDenominador1.TabIndex = 1;
            // 
            // numDenominador2
            // 
            this.numDenominador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador2.Location = new System.Drawing.Point(282, 76);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(77, 23);
            this.numDenominador2.TabIndex = 3;
            // 
            // numNumerador2
            // 
            this.numNumerador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador2.Location = new System.Drawing.Point(282, 37);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(77, 23);
            this.numNumerador2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_____________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_____________";
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(384, 60);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(24, 25);
            this.lblCalcularResultado.TabIndex = 7;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // numEntero1
            // 
            this.numEntero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero1.Location = new System.Drawing.Point(27, 50);
            this.numEntero1.Name = "numEntero1";
            this.numEntero1.Size = new System.Drawing.Size(41, 35);
            this.numEntero1.TabIndex = 9;
            // 
            // numEntero2
            // 
            this.numEntero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero2.Location = new System.Drawing.Point(227, 50);
            this.numEntero2.Name = "numEntero2";
            this.numEntero2.Size = new System.Drawing.Size(41, 35);
            this.numEntero2.TabIndex = 10;
            // 
            // cboOperacion
            // 
            this.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(177, 52);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(34, 28);
            this.cboOperacion.TabIndex = 11;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(478, 60);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(55, 13);
            this.lblLinea.TabIndex = 12;
            this.lblLinea.Text = "________";
            // 
            // lblResultadoEntero
            // 
            this.lblResultadoEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEntero.Location = new System.Drawing.Point(404, 45);
            this.lblResultadoEntero.Name = "lblResultadoEntero";
            this.lblResultadoEntero.Size = new System.Drawing.Size(68, 47);
            this.lblResultadoEntero.TabIndex = 8;
            this.lblResultadoEntero.Text = "x";
            this.lblResultadoEntero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultadoNumerador
            // 
            this.lblResultadoNumerador.AutoSize = true;
            this.lblResultadoNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNumerador.Location = new System.Drawing.Point(497, 37);
            this.lblResultadoNumerador.Name = "lblResultadoNumerador";
            this.lblResultadoNumerador.Size = new System.Drawing.Size(24, 29);
            this.lblResultadoNumerador.TabIndex = 13;
            this.lblResultadoNumerador.Text = "x";
            // 
            // lblResultadoDenominador
            // 
            this.lblResultadoDenominador.AutoSize = true;
            this.lblResultadoDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDenominador.Location = new System.Drawing.Point(497, 80);
            this.lblResultadoDenominador.Name = "lblResultadoDenominador";
            this.lblResultadoDenominador.Size = new System.Drawing.Size(24, 29);
            this.lblResultadoDenominador.TabIndex = 14;
            this.lblResultadoDenominador.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 132);
            this.Controls.Add(this.lblResultadoDenominador);
            this.Controls.Add(this.lblResultadoNumerador);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.numEntero2);
            this.Controls.Add(this.numEntero1);
            this.Controls.Add(this.lblResultadoEntero);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.NumericUpDown numEntero1;
        private System.Windows.Forms.NumericUpDown numEntero2;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblResultadoEntero;
        private System.Windows.Forms.Label lblResultadoNumerador;
        private System.Windows.Forms.Label lblResultadoDenominador;
    }
}


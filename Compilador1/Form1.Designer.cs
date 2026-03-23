namespace Compilador1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.RichTextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstErrores = new System.Windows.Forms.ListBox();
            this.lstReservadas = new System.Windows.Forms.ListBox();
            this.txtNuevaReservada = new System.Windows.Forms.TextBox();
            this.btnAgregarReservada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarReservada = new System.Windows.Forms.Button();
            this.txtNuevoDelimitador = new System.Windows.Forms.TextBox();
            this.btnAgregarDelimitador = new System.Windows.Forms.Button();
            this.btnEliminarDelimitador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDelimitadores = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "INGRESE UNA CADENA DE TEXTO";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(12, 82);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(218, 63);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.Text = "";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(12, 151);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(104, 40);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "RESULTADO";
            // 
            // dgvTokens
            // 
            this.dgvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Tipo});
            this.dgvTokens.Location = new System.Drawing.Point(12, 249);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.Size = new System.Drawing.Size(279, 316);
            this.dgvTokens.TabIndex = 4;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // lstErrores
            // 
            this.lstErrores.FormattingEnabled = true;
            this.lstErrores.Location = new System.Drawing.Point(297, 470);
            this.lstErrores.Name = "lstErrores";
            this.lstErrores.Size = new System.Drawing.Size(248, 95);
            this.lstErrores.TabIndex = 5;
            // 
            // lstReservadas
            // 
            this.lstReservadas.FormattingEnabled = true;
            this.lstReservadas.Location = new System.Drawing.Point(297, 82);
            this.lstReservadas.Name = "lstReservadas";
            this.lstReservadas.Size = new System.Drawing.Size(120, 95);
            this.lstReservadas.TabIndex = 6;
            // 
            // txtNuevaReservada
            // 
            this.txtNuevaReservada.Location = new System.Drawing.Point(297, 183);
            this.txtNuevaReservada.Name = "txtNuevaReservada";
            this.txtNuevaReservada.Size = new System.Drawing.Size(120, 20);
            this.txtNuevaReservada.TabIndex = 7;
            // 
            // btnAgregarReservada
            // 
            this.btnAgregarReservada.Location = new System.Drawing.Point(297, 210);
            this.btnAgregarReservada.Name = "btnAgregarReservada";
            this.btnAgregarReservada.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarReservada.TabIndex = 8;
            this.btnAgregarReservada.Text = "Agregar";
            this.btnAgregarReservada.UseVisualStyleBackColor = true;
            this.btnAgregarReservada.Click += new System.EventHandler(this.btnAgregarReservada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Palabras reservadas";
            // 
            // btnEliminarReservada
            // 
            this.btnEliminarReservada.Location = new System.Drawing.Point(298, 240);
            this.btnEliminarReservada.Name = "btnEliminarReservada";
            this.btnEliminarReservada.Size = new System.Drawing.Size(119, 23);
            this.btnEliminarReservada.TabIndex = 10;
            this.btnEliminarReservada.Text = "Eliminar";
            this.btnEliminarReservada.UseVisualStyleBackColor = true;
            this.btnEliminarReservada.Click += new System.EventHandler(this.btnEliminarReservada_Click);
            // 
            // txtNuevoDelimitador
            // 
            this.txtNuevoDelimitador.Location = new System.Drawing.Point(424, 183);
            this.txtNuevoDelimitador.Name = "txtNuevoDelimitador";
            this.txtNuevoDelimitador.Size = new System.Drawing.Size(121, 20);
            this.txtNuevoDelimitador.TabIndex = 12;
            // 
            // btnAgregarDelimitador
            // 
            this.btnAgregarDelimitador.Location = new System.Drawing.Point(424, 210);
            this.btnAgregarDelimitador.Name = "btnAgregarDelimitador";
            this.btnAgregarDelimitador.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarDelimitador.TabIndex = 13;
            this.btnAgregarDelimitador.Text = "Agregar";
            this.btnAgregarDelimitador.UseVisualStyleBackColor = true;
            this.btnAgregarDelimitador.Click += new System.EventHandler(this.btnAgregarDelimitador_Click);
            // 
            // btnEliminarDelimitador
            // 
            this.btnEliminarDelimitador.Location = new System.Drawing.Point(424, 240);
            this.btnEliminarDelimitador.Name = "btnEliminarDelimitador";
            this.btnEliminarDelimitador.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarDelimitador.TabIndex = 14;
            this.btnEliminarDelimitador.Text = "Eliminar";
            this.btnEliminarDelimitador.UseVisualStyleBackColor = true;
            this.btnEliminarDelimitador.Click += new System.EventHandler(this.btnEliminarDelimitador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delimitadores";
            // 
            // lstDelimitadores
            // 
            this.lstDelimitadores.FormattingEnabled = true;
            this.lstDelimitadores.Location = new System.Drawing.Point(427, 82);
            this.lstDelimitadores.Name = "lstDelimitadores";
            this.lstDelimitadores.Size = new System.Drawing.Size(120, 95);
            this.lstDelimitadores.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(563, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDelimitadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarDelimitador);
            this.Controls.Add(this.btnAgregarDelimitador);
            this.Controls.Add(this.txtNuevoDelimitador);
            this.Controls.Add(this.btnEliminarReservada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarReservada);
            this.Controls.Add(this.txtNuevaReservada);
            this.Controls.Add(this.lstReservadas);
            this.Controls.Add(this.lstErrores);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtEntrada;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.ListBox lstErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.ListBox lstReservadas;
        private System.Windows.Forms.TextBox txtNuevaReservada;
        private System.Windows.Forms.Button btnAgregarReservada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarReservada;
        private System.Windows.Forms.TextBox txtNuevoDelimitador;
        private System.Windows.Forms.Button btnAgregarDelimitador;
        private System.Windows.Forms.Button btnEliminarDelimitador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDelimitadores;
        private System.Windows.Forms.Button button1;
    }
}


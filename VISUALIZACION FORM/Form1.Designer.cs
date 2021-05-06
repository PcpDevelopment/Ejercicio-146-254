
namespace VISUALIZACION_FORM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.LbPromedio = new System.Windows.Forms.Label();
            this.LbMenor = new System.Windows.Forms.Label();
            this.LbMayor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBNotas = new System.Windows.Forms.TextBox();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.BTCalcular = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLibreta = new System.Windows.Forms.ListBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gold;
            this.tabPage1.Controls.Add(this.BtLimpiar);
            this.tabPage1.Controls.Add(this.LbPromedio);
            this.tabPage1.Controls.Add(this.LbMenor);
            this.tabPage1.Controls.Add(this.LbMayor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxBNotas);
            this.tabPage1.Controls.Add(this.listBoxNotas);
            this.tabPage1.Controls.Add(this.BTCalcular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(680, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(68, 226);
            this.BtLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(99, 25);
            this.BtLimpiar.TabIndex = 7;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // LbPromedio
            // 
            this.LbPromedio.AutoSize = true;
            this.LbPromedio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPromedio.Location = new System.Drawing.Point(447, 155);
            this.LbPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPromedio.Name = "LbPromedio";
            this.LbPromedio.Size = new System.Drawing.Size(136, 19);
            this.LbPromedio.TabIndex = 6;
            this.LbPromedio.Text = "Promedio de Notas";
            // 
            // LbMenor
            // 
            this.LbMenor.AutoSize = true;
            this.LbMenor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenor.Location = new System.Drawing.Point(447, 105);
            this.LbMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbMenor.Name = "LbMenor";
            this.LbMenor.Size = new System.Drawing.Size(137, 19);
            this.LbMenor.TabIndex = 5;
            this.LbMenor.Text = "Calificacion Menor";
            // 
            // LbMayor
            // 
            this.LbMayor.AutoSize = true;
            this.LbMayor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMayor.Location = new System.Drawing.Point(447, 56);
            this.LbMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbMayor.Name = "LbMayor";
            this.LbMayor.Size = new System.Drawing.Size(137, 19);
            this.LbMayor.TabIndex = 4;
            this.LbMayor.Text = "Calificacion Mayor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notas ";
            // 
            // TxBNotas
            // 
            this.TxBNotas.Location = new System.Drawing.Point(76, 142);
            this.TxBNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxBNotas.Name = "TxBNotas";
            this.TxBNotas.Size = new System.Drawing.Size(78, 20);
            this.TxBNotas.TabIndex = 2;
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxNotas.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.ItemHeight = 16;
            this.listBoxNotas.Location = new System.Drawing.Point(219, 42);
            this.listBoxNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(169, 196);
            this.listBoxNotas.TabIndex = 1;
            // 
            // BTCalcular
            // 
            this.BTCalcular.Location = new System.Drawing.Point(68, 176);
            this.BTCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTCalcular.Name = "BTCalcular";
            this.BTCalcular.Size = new System.Drawing.Size(99, 25);
            this.BTCalcular.TabIndex = 0;
            this.BTCalcular.Text = "AÑADIR";
            this.BTCalcular.UseVisualStyleBackColor = true;
            this.BTCalcular.Click += new System.EventHandler(this.BTCalcular_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Red;
            this.tabPage2.Controls.Add(this.txTelefono);
            this.tabPage2.Controls.Add(this.txNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listBoxLibreta);
            this.tabPage2.Controls.Add(this.btAgregar);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(680, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(72, 104);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(128, 20);
            this.txTelefono.TabIndex = 5;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(72, 62);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(128, 20);
            this.txNombre.TabIndex = 4;
            this.txNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono";
            // 
            // listBoxLibreta
            // 
            this.listBoxLibreta.FormattingEnabled = true;
            this.listBoxLibreta.Location = new System.Drawing.Point(291, 5);
            this.listBoxLibreta.Name = "listBoxLibreta";
            this.listBoxLibreta.Size = new System.Drawing.Size(269, 303);
            this.listBoxLibreta.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(98, 167);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(82, 50);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LbPromedio;
        private System.Windows.Forms.Label LbMenor;
        private System.Windows.Forms.Label LbMayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBNotas;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.Button BTCalcular;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLibreta;
        private System.Windows.Forms.Button btAgregar;
    }
}


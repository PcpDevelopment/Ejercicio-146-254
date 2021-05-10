
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TxCliente = new System.Windows.Forms.TextBox();
            this.lixboxcliente = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listViewDIc = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPalabra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lixboxRegistros = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.listBoxNotas.Size = new System.Drawing.Size(169, 100);
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Chartreuse;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.TxCliente);
            this.tabPage3.Controls.Add(this.lixboxcliente);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(680, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxCliente
            // 
            this.TxCliente.Location = new System.Drawing.Point(117, 126);
            this.TxCliente.Multiline = true;
            this.TxCliente.Name = "TxCliente";
            this.TxCliente.Size = new System.Drawing.Size(157, 20);
            this.TxCliente.TabIndex = 2;
            // 
            // lixboxcliente
            // 
            this.lixboxcliente.FormattingEnabled = true;
            this.lixboxcliente.Location = new System.Drawing.Point(392, 41);
            this.lixboxcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lixboxcliente.Name = "lixboxcliente";
            this.lixboxcliente.Size = new System.Drawing.Size(171, 212);
            this.lixboxcliente.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(680, 307);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(261, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 177);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(41, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diccionario";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 124);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 147);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Cyan;
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.txPalabra);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.listViewDIc);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(680, 307);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.lixboxRegistros);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(680, 307);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listViewDIc
            // 
            this.listViewDIc.HideSelection = false;
            this.listViewDIc.Location = new System.Drawing.Point(251, 99);
            this.listViewDIc.Name = "listViewDIc";
            this.listViewDIc.Size = new System.Drawing.Size(282, 202);
            this.listViewDIc.TabIndex = 0;
            this.listViewDIc.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "Diccionario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Buscar Palabra";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txPalabra
            // 
            this.txPalabra.Location = new System.Drawing.Point(85, 161);
            this.txPalabra.Name = "txPalabra";
            this.txPalabra.Size = new System.Drawing.Size(118, 20);
            this.txPalabra.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Location = new System.Drawing.Point(106, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lixboxRegistros
            // 
            this.lixboxRegistros.FormattingEnabled = true;
            this.lixboxRegistros.Location = new System.Drawing.Point(280, 6);
            this.lixboxRegistros.Name = "lixboxRegistros";
            this.lixboxRegistros.Size = new System.Drawing.Size(382, 290);
            this.lixboxRegistros.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "REGISTROS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(109, 149);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(165, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ver Registros ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lixboxcliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txPalabra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewDIc;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lixboxRegistros;
    }
}


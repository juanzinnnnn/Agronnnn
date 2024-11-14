namespace Presentacion
{
    partial class FormMovimientoBancario
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
            components = new System.ComponentModel.Container();
            btnBorrar = new Button();
            btnModificar = new Button();
            button2 = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            IdMovimiento = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Banco = new DataGridViewTextBoxColumn();
            Cuenta = new DataGridViewTextBoxColumn();
            Debe = new DataGridViewTextBoxColumn();
            Haber = new DataGridViewTextBoxColumn();
            movimientosBancarioBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            bancoBindingSource1 = new BindingSource(components);
            comboBox3 = new ComboBox();
            cuentaBindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            btnConsultarID = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimientosBancarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(718, 257);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(103, 35);
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(566, 257);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 35);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(855, 345);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 19;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(266, 260);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 32);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdMovimiento, fechaDataGridViewTextBoxColumn, Banco, Cuenta, Debe, Haber });
            dataGridView1.DataSource = movimientosBancarioBindingSource;
            dataGridView1.Location = new Point(266, 11);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(667, 241);
            dataGridView1.TabIndex = 17;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // IdMovimiento
            // 
            IdMovimiento.DataPropertyName = "IdMovimiento";
            IdMovimiento.HeaderText = "IdMovimiento";
            IdMovimiento.Name = "IdMovimiento";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // Banco
            // 
            Banco.DataPropertyName = "NombreBanco";
            Banco.HeaderText = "Banco";
            Banco.Name = "Banco";
            Banco.ReadOnly = true;
            // 
            // Cuenta
            // 
            Cuenta.DataPropertyName = "DetalleCuenta";
            Cuenta.HeaderText = "Cuenta";
            Cuenta.Name = "Cuenta";
            Cuenta.ReadOnly = true;
            // 
            // Debe
            // 
            Debe.DataPropertyName = "Debe";
            Debe.HeaderText = "Debe";
            Debe.Name = "Debe";
            // 
            // Haber
            // 
            Haber.DataPropertyName = "Haber";
            Haber.HeaderText = "Haber";
            Haber.Name = "Haber";
            // 
            // movimientosBancarioBindingSource
            // 
            movimientosBancarioBindingSource.DataSource = typeof(Modelos.MovimientosBancario);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 24);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 15;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 14;
            label2.Text = "HABER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "BANCO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(80, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 64);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 23;
            label4.Text = "FECHA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 127);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 24;
            label5.Text = "CUENTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 25;
            label6.Text = "DEBE";
            // 
            // comboBox2
            // 
            comboBox2.DataSource = bancoBindingSource1;
            comboBox2.DisplayMember = "IdBanco";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(80, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 23);
            comboBox2.TabIndex = 26;
            comboBox2.ValueMember = "IdBanco";
            // 
            // bancoBindingSource1
            // 
            bancoBindingSource1.DataSource = typeof(Modelos.Banco);
            // 
            // comboBox3
            // 
            comboBox3.DataSource = cuentaBindingSource1;
            comboBox3.DisplayMember = "idCuenta";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(80, 121);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(152, 23);
            comboBox3.TabIndex = 27;
            comboBox3.ValueMember = "IdCuenta";
            // 
            // cuentaBindingSource1
            // 
            cuentaBindingSource1.DataSource = typeof(Modelos.Cuenta);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 29;
            // 
            // btnConsultarID
            // 
            btnConsultarID.Location = new Point(395, 257);
            btnConsultarID.Name = "btnConsultarID";
            btnConsultarID.Size = new Size(141, 35);
            btnConsultarID.TabIndex = 30;
            btnConsultarID.Text = "CONSULTAR POR ID";
            btnConsultarID.UseVisualStyleBackColor = true;
            btnConsultarID.Click += btnConsultarID_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 9);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 31;
            // 
            // FormMovimientoBancario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 376);
            Controls.Add(label7);
            Controls.Add(btnConsultarID);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormMovimientoBancario";
            Text = "FormCliente";
            Load += FormMovimientoBancario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimientosBancarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnModificar;
        private Button button2;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button btnConsultarID;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource movimientosBancarioBindingSource;
        private BindingSource bancoBindingSource1;
        private BindingSource cuentaBindingSource1;
        private Label label7;
        private DataGridViewTextBoxColumn IdMovimiento;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Banco;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn Debe;
        private DataGridViewTextBoxColumn Haber;
    }
}
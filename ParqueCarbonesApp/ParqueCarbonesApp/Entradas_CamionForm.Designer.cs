namespace ParqueCarbonesApp
{
    partial class Entradas_CamionForm
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
            volver = new Button();
            dataGrid_Entradas = new DataGridView();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txt_peso = new TextBox();
            txt_fecha_entrada = new TextBox();
            txt_camionero = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            text_camion = new TextBox();
            label7 = new Label();
            insertar = new Button();
            nuevo_registro = new Button();
            id_salida = new TextBox();
            txt_buscar = new TextBox();
            label2 = new Label();
            btn_buscar = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Entradas).BeginInit();
            SuspendLayout();
            // 
            // volver
            // 
            volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            volver.Location = new Point(728, 412);
            volver.Name = "volver";
            volver.Size = new Size(60, 26);
            volver.TabIndex = 2;
            volver.Tag = "";
            volver.Text = "VOLVER";
            volver.TextImageRelation = TextImageRelation.TextBeforeImage;
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // dataGrid_Entradas
            // 
            dataGrid_Entradas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Entradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Entradas.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGrid_Entradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Entradas.Location = new Point(12, 70);
            dataGrid_Entradas.Name = "dataGrid_Entradas";
            dataGrid_Entradas.Size = new Size(776, 136);
            dataGrid_Entradas.TabIndex = 3;
            dataGrid_Entradas.CellClick += dataGrid_Entradas_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 8);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 4;
            label1.Text = "Entrada para cada Camión";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(214, 299);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(325, 23);
            txt_peso.TabIndex = 5;
            // 
            // txt_fecha_entrada
            // 
            txt_fecha_entrada.Location = new Point(214, 270);
            txt_fecha_entrada.Name = "txt_fecha_entrada";
            txt_fecha_entrada.Size = new Size(325, 23);
            txt_fecha_entrada.TabIndex = 6;
            // 
            // txt_camionero
            // 
            txt_camionero.Location = new Point(214, 328);
            txt_camionero.Name = "txt_camionero";
            txt_camionero.ReadOnly = true;
            txt_camionero.Size = new Size(325, 23);
            txt_camionero.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 273);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha_Entrada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 302);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 331);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 12;
            label5.Text = "Id_Camionero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 336);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // text_camion
            // 
            text_camion.Location = new Point(214, 357);
            text_camion.Name = "text_camion";
            text_camion.ReadOnly = true;
            text_camion.Size = new Size(325, 23);
            text_camion.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 360);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 15;
            label7.Text = "Id_Camion";
            // 
            // insertar
            // 
            insertar.BackColor = Color.RosyBrown;
            insertar.Location = new Point(214, 386);
            insertar.Name = "insertar";
            insertar.Size = new Size(122, 23);
            insertar.TabIndex = 17;
            insertar.Text = "EDITAR";
            insertar.UseMnemonic = false;
            insertar.UseVisualStyleBackColor = false;
            insertar.Click += insertar_Click;
            // 
            // nuevo_registro
            // 
            nuevo_registro.BackColor = Color.FromArgb(192, 192, 255);
            nuevo_registro.Location = new Point(411, 386);
            nuevo_registro.Name = "nuevo_registro";
            nuevo_registro.Size = new Size(128, 23);
            nuevo_registro.TabIndex = 18;
            nuevo_registro.Text = "NUEVO REGISTRO";
            nuevo_registro.UseVisualStyleBackColor = false;
            nuevo_registro.Click += nuevo_registro_Click;
            // 
            // id_salida
            // 
            id_salida.Location = new Point(214, 241);
            id_salida.Name = "id_salida";
            id_salida.ReadOnly = true;
            id_salida.Size = new Size(76, 23);
            id_salida.TabIndex = 19;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(12, 41);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(170, 23);
            txt_buscar.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 21;
            label2.Text = "Buscar por un camion determinado:";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(188, 41);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(69, 23);
            btn_buscar.TabIndex = 22;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.Location = new Point(545, 302);
            label8.Name = "label8";
            label8.Size = new Size(242, 13);
            label8.TabIndex = 23;
            label8.Text = "(se redondea a 2 decimales para visualización)";
            // 
            // Entradas_CamionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(btn_buscar);
            Controls.Add(label2);
            Controls.Add(txt_buscar);
            Controls.Add(id_salida);
            Controls.Add(nuevo_registro);
            Controls.Add(insertar);
            Controls.Add(label7);
            Controls.Add(text_camion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_camionero);
            Controls.Add(txt_fecha_entrada);
            Controls.Add(txt_peso);
            Controls.Add(label1);
            Controls.Add(dataGrid_Entradas);
            Controls.Add(volver);
            Name = "Entradas_CamionForm";
            Text = "Entradas_Camion";
            FormClosing += Entradas_CamionForm_FormClosing;
            Load += Entradas_CamionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Entradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volver;
        private DataGridView dataGrid_Entradas;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txt_peso;
        private TextBox txt_fecha_entrada;
        private TextBox txt_camionero;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox text_camion;
        private Label label7;
        private Button insertar;
        private Button nuevo_registro;
        private TextBox id_salida;
        private TextBox txt_buscar;
        private Label label2;
        private Button btn_buscar;
        private Label label8;
    }
}
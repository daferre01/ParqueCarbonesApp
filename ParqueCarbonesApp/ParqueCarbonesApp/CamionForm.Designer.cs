namespace ParqueCarbonesApp
{
    partial class CamionForm
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
            btn_volver = new Button();
            dataGrid_Camiones = new DataGridView();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txt_matricula = new TextBox();
            txt_empresa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            text_id_camion = new TextBox();
            label5 = new Label();
            btn_insertar = new Button();
            btn_nuevo_registro = new Button();
            id_camion = new TextBox();
            rb_permitido = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Camiones).BeginInit();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_volver.Location = new Point(728, 412);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(60, 26);
            btn_volver.TabIndex = 3;
            btn_volver.Text = "VOLVER";
            btn_volver.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += volver_Click;
            // 
            // dataGrid_Camiones
            // 
            dataGrid_Camiones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid_Camiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Camiones.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGrid_Camiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Camiones.Location = new Point(12, 70);
            dataGrid_Camiones.Name = "dataGrid_Camiones";
            dataGrid_Camiones.Size = new Size(776, 136);
            dataGrid_Camiones.TabIndex = 3;
            dataGrid_Camiones.CellClick += dataGrid_Camiones_CellClick_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 22);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 4;
            label1.Text = "Gestión de Camiones";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(214, 270);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(325, 23);
            txt_matricula.TabIndex = 5;
            // 
            // txt_empresa
            // 
            txt_empresa.Location = new Point(214, 299);
            txt_empresa.Name = "txt_empresa";
            txt_empresa.Size = new Size(325, 23);
            txt_empresa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 273);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Matrícula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 302);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 331);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "Permitido";
            // 
            // text_id_camion
            // 
            text_id_camion.Location = new Point(214, 241);
            text_id_camion.Name = "text_id_camion";
            text_id_camion.ReadOnly = true;
            text_id_camion.Size = new Size(76, 23);
            text_id_camion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 244);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 14;
            label5.Text = "ID del Camión";
            // 
            // btn_insertar
            // 
            btn_insertar.BackColor = Color.RosyBrown;
            btn_insertar.Location = new Point(214, 357);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(122, 23);
            btn_insertar.TabIndex = 15;
            btn_insertar.Text = "EDITAR";
            btn_insertar.UseVisualStyleBackColor = false;
            btn_insertar.Click += insertar_Click;
            // 
            // btn_nuevo_registro
            // 
            btn_nuevo_registro.BackColor = Color.FromArgb(192, 192, 255);
            btn_nuevo_registro.Location = new Point(411, 357);
            btn_nuevo_registro.Name = "btn_nuevo_registro";
            btn_nuevo_registro.Size = new Size(128, 23);
            btn_nuevo_registro.TabIndex = 16;
            btn_nuevo_registro.Text = "NUEVO REGISTRO";
            btn_nuevo_registro.UseVisualStyleBackColor = false;
            btn_nuevo_registro.Click += nuevo_registro_Click_1;
            // 
            // id_camion
            // 
            id_camion.Location = new Point(214, 241);
            id_camion.Name = "id_camion";
            id_camion.ReadOnly = true;
            id_camion.Size = new Size(76, 23);
            id_camion.TabIndex = 19;
            // 
            // rb_permitido
            // 
            rb_permitido.AutoSize = true;
            rb_permitido.Location = new Point(214, 330);
            rb_permitido.Name = "rb_permitido";
            rb_permitido.Size = new Size(78, 19);
            rb_permitido.TabIndex = 20;
            rb_permitido.Text = "Permitido";
            rb_permitido.UseVisualStyleBackColor = true;
            // 
            // CamionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(rb_permitido);
            Controls.Add(id_camion);
            Controls.Add(btn_nuevo_registro);
            Controls.Add(btn_insertar);
            Controls.Add(label5);
            Controls.Add(text_id_camion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_empresa);
            Controls.Add(txt_matricula);
            Controls.Add(label1);
            Controls.Add(dataGrid_Camiones);
            Controls.Add(btn_volver);
            Name = "CamionForm";
            Text = "Camiones";
            FormClosing += CamionForm_FormClosing;
            Load += CamionForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Camiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_volver;
        private DataGridView dataGrid_Camiones;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txt_matricula;
        private TextBox txt_empresa;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox text_id_camion;
        private Label label5;
        private Button btn_insertar;
        private Button btn_nuevo_registro;
        private TextBox id_camion;
        private CheckBox rb_permitido;
    }
}

namespace ParqueCarbonesApp
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_entradas_camion = new Button();
            btn_camiones = new Button();
            data_Horas = new DataGridView();
            label_kg = new Label();
            idioma_ruso = new CheckBox();
            idioma_estonio = new CheckBox();
            idioma_aleman = new CheckBox();
            idioma_portugues = new CheckBox();
            idioma_espanol = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)data_Horas).BeginInit();
            SuspendLayout();
            // 
            // btn_entradas_camion
            // 
            btn_entradas_camion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_entradas_camion.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_entradas_camion.Location = new Point(51, 45);
            btn_entradas_camion.Name = "btn_entradas_camion";
            btn_entradas_camion.Size = new Size(801, 74);
            btn_entradas_camion.TabIndex = 1;
            btn_entradas_camion.Tag = "entradas_Camion";
            btn_entradas_camion.Text = "Insertar o Actualizar entradas de un determinado camión";
            btn_entradas_camion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_entradas_camion.UseVisualStyleBackColor = true;
            btn_entradas_camion.Click += entradas_camion_Click;
            // 
            // btn_camiones
            // 
            btn_camiones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_camiones.Font = new Font("Agency FB", 18F);
            btn_camiones.Location = new Point(51, 125);
            btn_camiones.Name = "btn_camiones";
            btn_camiones.Size = new Size(801, 69);
            btn_camiones.TabIndex = 2;
            btn_camiones.Text = "Insertar o Actualizar camiones";
            btn_camiones.UseVisualStyleBackColor = true;
            btn_camiones.Click += camiones_Click;
            // 
            // data_Horas
            // 
            data_Horas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Horas.BackgroundColor = SystemColors.ButtonHighlight;
            data_Horas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Horas.Dock = DockStyle.Bottom;
            data_Horas.Location = new Point(0, 259);
            data_Horas.Name = "data_Horas";
            data_Horas.Size = new Size(882, 328);
            data_Horas.TabIndex = 3;
            // 
            // label_kg
            // 
            label_kg.AutoSize = true;
            label_kg.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_kg.Location = new Point(129, 231);
            label_kg.Name = "label_kg";
            label_kg.Size = new Size(518, 25);
            label_kg.TabIndex = 4;
            label_kg.Text = "Total de kg que ha entrado cada día en el parque de carbones, comparándolo por hora";
            // 
            // idioma_ruso
            // 
            idioma_ruso.AutoSize = true;
            idioma_ruso.Location = new Point(12, 3);
            idioma_ruso.Name = "idioma_ruso";
            idioma_ruso.Size = new Size(65, 19);
            idioma_ruso.TabIndex = 5;
            idioma_ruso.Text = "Россия";
            idioma_ruso.TextAlign = ContentAlignment.MiddleCenter;
            idioma_ruso.UseVisualStyleBackColor = true;
            idioma_ruso.CheckedChanged += idioma_ruso_CheckedChanged;
            // 
            // idioma_estonio
            // 
            idioma_estonio.AutoSize = true;
            idioma_estonio.Location = new Point(83, 3);
            idioma_estonio.Name = "idioma_estonio";
            idioma_estonio.Size = new Size(50, 19);
            idioma_estonio.TabIndex = 6;
            idioma_estonio.Text = "Eesti";
            idioma_estonio.UseVisualStyleBackColor = true;
            idioma_estonio.CheckedChanged += idioma_estonio_CheckedChanged;
            // 
            // idioma_aleman
            // 
            idioma_aleman.AutoSize = true;
            idioma_aleman.Location = new Point(139, 3);
            idioma_aleman.Name = "idioma_aleman";
            idioma_aleman.Size = new Size(92, 19);
            idioma_aleman.TabIndex = 7;
            idioma_aleman.Text = "Deutschland";
            idioma_aleman.UseVisualStyleBackColor = true;
            idioma_aleman.CheckedChanged += idioma_aleman_CheckedChanged;
            // 
            // idioma_portugues
            // 
            idioma_portugues.AutoSize = true;
            idioma_portugues.Location = new Point(237, 3);
            idioma_portugues.Name = "idioma_portugues";
            idioma_portugues.Size = new Size(71, 19);
            idioma_portugues.TabIndex = 8;
            idioma_portugues.Text = "Portugal";
            idioma_portugues.UseVisualStyleBackColor = true;
            idioma_portugues.CheckedChanged += idioma_portugues_CheckedChanged;
            // 
            // idioma_espanol
            // 
            idioma_espanol.AutoSize = true;
            idioma_espanol.Location = new Point(314, 3);
            idioma_espanol.Name = "idioma_espanol";
            idioma_espanol.Size = new Size(67, 19);
            idioma_espanol.TabIndex = 9;
            idioma_espanol.Text = "Español";
            idioma_espanol.UseVisualStyleBackColor = true;
            idioma_espanol.CheckedChanged += idioma_espanol_CheckedChanged;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(882, 587);
            Controls.Add(idioma_espanol);
            Controls.Add(idioma_portugues);
            Controls.Add(idioma_aleman);
            Controls.Add(idioma_estonio);
            Controls.Add(idioma_ruso);
            Controls.Add(label_kg);
            Controls.Add(data_Horas);
            Controls.Add(btn_camiones);
            Controls.Add(btn_entradas_camion);
            Name = "MenuForm";
            Text = "Form1";
            FormClosing += MenuForm_FormClosing;
            Load += MenuForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)data_Horas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entradas_camion;
        private Button btn_camiones;
        private DataGridView data_Horas;
        private Label label_kg;
        private CheckBox idioma_ruso;
        private CheckBox idioma_estonio;
        private CheckBox idioma_aleman;
        private CheckBox idioma_portugues;
        private CheckBox idioma_espanol;
    }
}

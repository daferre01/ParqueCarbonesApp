using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace ParqueCarbonesApp
{
    public partial class MenuForm : Form
    {
        public static MenuForm Menu;
        public MenuForm()
        {   
            InitializeComponent();
            Menu = this;
            idioma_espanol.Checked = true;
        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {
            string connectionString = "Server=DAFERRE\\SQLEXPRESS;Database=PARQUE_CARBONES;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error de conexión: {ex.Message}");
                }
            }
            CargarDatosHoras(connectionString);
        }

        private void CargarDatosHoras(string connectionString)
        {
            string query = @"
                SELECT 
                    CAST(E.Fecha_Entrada AS DATE) AS Dia,
                    DATEPART(HOUR, E.Fecha_Entrada) AS Hora,
                    SUM(E.Peso) AS Total_Peso_Kg 
                FROM 
                    Entradas E
                GROUP BY 
                    CAST(E.Fecha_Entrada AS DATE),
                    DATEPART(HOUR, E.Fecha_Entrada)
                ORDER BY 
                    Dia, Hora;
            ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    data_Horas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void entradas_camion_Click(object sender, EventArgs e)
        {
            Entradas_CamionForm formulario = new Entradas_CamionForm();
            formulario.Show();
            this.Hide();

        }

        private void camiones_Click(object sender, EventArgs e)
        {
            CamionForm formulario = new CamionForm();
            formulario.Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //usuario intenta cerrar manualmente
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar cierre"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void idioma_ruso_CheckedChanged(object sender, EventArgs e)
        {
            if (idioma_ruso.Checked)
            {
                idioma_estonio.Checked = false;
                idioma_aleman.Checked = false;
                idioma_portugues.Checked = false;
                idioma_espanol.Checked = false;
            }
            btn_entradas_camion.Text = "Добавить или обновить записи для конкретного грузовика";
            btn_camiones.Text = "Добавить или обновить грузовики";
            label_kg.Text = "Общее количество кг, поступивших в угольный парк за день, с распределением по часам";

        }

        private void idioma_estonio_CheckedChanged(object sender, EventArgs e)
        {
            if (idioma_estonio.Checked)
            {
                idioma_ruso.Checked = false;
                idioma_aleman.Checked = false;
                idioma_portugues.Checked = false;
                idioma_espanol.Checked = false;
            }
            btn_entradas_camion.Text = "Sisestage või värskendage kindla veoki kandeid";
            btn_camiones.Text = "Sisestage või värskendage veokeid";
            label_kg.Text = "Iga päev söeparki saabunud kilogrammide kogus, võrreldes tundide kaupa";
        }

        private void idioma_aleman_CheckedChanged(object sender, EventArgs e)
        {
            if (idioma_aleman.Checked)
            {
                idioma_ruso.Checked = false;
                idioma_estonio.Checked = false;
                idioma_portugues.Checked = false;
                idioma_espanol.Checked = false;
            }
            btn_entradas_camion.Text = "Einträge eines bestimmten Lkw einfügen oder aktualisieren";
            btn_camiones.Text = "Lkw einfügen oder aktualisieren";
            label_kg.Text = "Gesamtmenge an kg, die täglich in den Kohlepark eingegangen ist, stundenweise verglichen";
        }

        private void idioma_portugues_CheckedChanged(object sender, EventArgs e)
        {
            if (idioma_portugues.Checked)
            {
                idioma_ruso.Checked = false;
                idioma_estonio.Checked = false;
                idioma_aleman.Checked = false;
                idioma_espanol.Checked = false;
            }
            btn_entradas_camion.Text = "Inserir ou atualizar entradas de um determinado caminhão";
            btn_camiones.Text = "Inserir ou atualizar caminhões";
            label_kg.Text = "Total de kg que entrou no parque de carvão por dia, comparado por hora";



        }

        private void idioma_espanol_CheckedChanged(object sender, EventArgs e)
        {
            if (idioma_espanol.Checked)
            {
                idioma_ruso.Checked = false;
                idioma_estonio.Checked = false;
                idioma_aleman.Checked = false;
                idioma_portugues.Checked = false;
            }
            btn_entradas_camion.Text = "Insertar o actualizar entradas de un determinado camion";
            btn_camiones.Text = "Insertar o actualizar camiones";
            label_kg.Text = "Total de kg que ha entrado cada dia en el parque de carbones, comparandolo por hora";
        }

    }
}
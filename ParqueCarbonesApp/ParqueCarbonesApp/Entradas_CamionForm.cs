using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ParqueCarbonesApp
{
    public partial class Entradas_CamionForm : Form
    {
        public Entradas_CamionForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DAFERRE\\SQLEXPRESS;Database=PARQUE_CARBONES;Integrated Security=True;Encrypt=False;";
        String var_id_camion;
        String var_id_camionero;
        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entradas_CamionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.Menu.Show();
        }

        private void Entradas_CamionForm_Load(object sender, EventArgs e)
        {
            CargarDatosEntradas();
        }

        private void CargarDatosEntradas()
        {
            string query = @"SELECT 
                                E.Id_Entrada, 
                                E.Fecha_Entrada, 
                                FORMAT(E.Peso, 'N3') AS Peso, 
                                C.Matricula AS Matricula_Camion, 
                                Co.Documento_Identidad AS Documento,
                                E.Id_Camion,
                                E.Id_Camionero
                             FROM 
                                Entradas E
                             LEFT JOIN 
                                Camiones C ON E.Id_Camion = C.Id_Camion
                             LEFT JOIN  
                                Camioneros Co ON E.Id_Camionero = Co.Id_Camionero;";
            DataTable tablaEntradas = ExecuteQuery(query);
            dataGrid_Entradas.DataSource = tablaEntradas;
        }

        private void dataGrid_Entradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_Entradas.Rows[e.RowIndex];
                id_salida.Text = row.Cells["Id_Entrada"].Value.ToString();
                txt_fecha_entrada.Text = row.Cells["Fecha_Entrada"].Value.ToString();
                txt_peso.Text = row.Cells["Peso"].Value.ToString();
                txt_camionero.Text = row.Cells["Documento"].Value.ToString();
                text_camion.Text = row.Cells["Matricula_Camion"].Value.ToString();
                var_id_camion= row.Cells["Id_Camion"].Value.ToString();
                var_id_camionero = row.Cells["Id_Camionero"].Value.ToString();

            }
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out DateTime fechaEntrada, out decimal peso, out int idCamion, out int idCamionero))
            {
                string query1 = "UPDATE Entradas SET Fecha_Entrada = @Fecha_Entrada, Peso = @Peso WHERE Id_Entrada = @Id_Entrada";
                SqlParameter[] parameters1 = {
                    new SqlParameter("@Id_Entrada", id_salida.Text),
                    new SqlParameter("@Fecha_Entrada", fechaEntrada),
                    new SqlParameter("@Peso", peso)

                };
                ExecuteNonQuery(query1, parameters1);

                CargarDatosEntradas();
            }
        }

        private void nuevo_registro_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out DateTime fechaEntrada, out decimal peso, out int idCamion, out int idCamionero))
            {
                string query1 = "INSERT INTO Entradas (Fecha_Entrada, Peso, Id_Camion, Id_Camionero) " +
                       "VALUES (@Fecha_Entrada, @Peso, @Id_Camion, @Id_Camionero)";
                SqlParameter[] parameters1 = {
                new SqlParameter("@Fecha_Entrada", fechaEntrada),
                new SqlParameter("@Peso", peso),
                new SqlParameter("@Id_Camion", var_id_camion),
                new SqlParameter("@Id_Camionero", var_id_camionero)
                };
                ExecuteNonQuery(query1, parameters1);
                CargarDatosEntradas();
            }
        }

        private bool ValidateInputs(out DateTime fechaEntrada, out decimal peso, out int idCamion, out int idCamionero)
        {
            fechaEntrada = DateTime.MinValue;
            peso = 0;
            idCamion = 0;
            idCamionero = 0;

            if (!DateTime.TryParse(txt_fecha_entrada.Text, out fechaEntrada))
            {
                MessageBox.Show("La fecha de entrada no es válida.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txt_peso.Text, out peso))
            {
                MessageBox.Show("El peso no es válido. Debe ser un número decimal.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Operación realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error SQL: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            string buscar = txt_buscar.Text.Trim();
            string query = @"SELECT 
                        E.Id_Entrada, 
                        E.Fecha_Entrada, 
                        FORMAT(E.Peso, 'N3') AS Peso, 
                        C.Matricula AS Matricula_Camion, 
                        Co.Documento_Identidad AS Documento
                     FROM 
                        Entradas E
                     LEFT JOIN 
                        Camiones C ON E.Id_Camion = C.Id_Camion
                     LEFT JOIN  
                        Camioneros Co ON E.Id_Camionero = Co.Id_Camionero
                     WHERE 
                        C.Matricula LIKE '%" + buscar + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, connectionString);
            DataTable tablaEntradas = new DataTable();
            adaptador.Fill(tablaEntradas);


            dataGrid_Entradas.DataSource = tablaEntradas;
        }


    }
}

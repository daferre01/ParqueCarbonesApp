using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ParqueCarbonesApp
{
    public partial class CamionForm : Form
    {
        public CamionForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DAFERRE\\SQLEXPRESS;Database=PARQUE_CARBONES;Integrated Security=True;Encrypt=False;";

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CamionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.Menu.Show();
        }

        private void CargarDatosCamiones()
        {
            DataTable tablaCamiones = ExecuteQuery("SELECT Id_Camion, Matricula, Empresa, Permitido FROM Camiones;");

            if (tablaCamiones != null && tablaCamiones.Rows.Count > 0)
            {
                dataGrid_Camiones.DataSource = tablaCamiones;
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            string matricula = txt_matricula.Text;
            string empresa = txt_empresa.Text;
            bool permitidos = rb_permitido.Checked;
            if (ValidateInputs(matricula, empresa))
            {
                string query = "UPDATE Camiones SET Matricula = @Matricula, Empresa = @Empresa, Permitido = @Permitido " +
                               "WHERE Id_Camion = @Id_Camion";
                SqlParameter[] parameters = {
                    new SqlParameter("@Id_Camion", id_camion.Text),
                    new SqlParameter("@Matricula", matricula),
                    new SqlParameter("@Empresa", empresa),
                    new SqlParameter("@Permitido", permitidos)
                };

                ExecuteNonQuery(query, parameters);
                CargarDatosCamiones();
            }
        }

        private bool ValidateInputs(string matricula, string empresa)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(empresa))
            {
                MessageBox.Show("La empresa no puede estar vacía.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGrid_Camiones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_Camiones.Rows[e.RowIndex];
                id_camion.Text = row.Cells["Id_Camion"].Value.ToString();
                txt_matricula.Text = row.Cells["Matricula"].Value.ToString();
                txt_empresa.Text = row.Cells["Empresa"].Value.ToString();

                rb_permitido.Checked = Convert.ToBoolean(row.Cells["Permitido"].Value);
            }
        }

        private void CamionForm_Load_1(object sender, EventArgs e)
        {
            CargarDatosCamiones();
        }

        private void nuevo_registro_Click_1(object sender, EventArgs e)
        {
            // Obtención de datos
            string matricula = txt_matricula.Text;
            string empresa = txt_empresa.Text;
            bool permitidos = rb_permitido.Checked;

            if (ValidateInputs(matricula, empresa))
            {
                string query = "INSERT INTO Camiones (Matricula, Empresa, Permitido) " +
                               "VALUES (@Matricula, @Empresa, @Permitido)";
                SqlParameter[] parameters = {
                    new SqlParameter("@Matricula", matricula),
                    new SqlParameter("@Empresa", empresa),
                    new SqlParameter("@Permitido", rb_permitido)
                };

                ExecuteNonQuery(query, parameters);
                CargarDatosCamiones();
            }
        }
    }
}

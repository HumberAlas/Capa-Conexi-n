using DatosLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaConexion
{
    public partial class Form1 : Form
    {
        // Se crea una instancia de CustomerRepository para interactuar con la base de datos de clientes.
        CustomerRepository customerRepository = new CustomerRepository();

        public Form1()
        {
            // Inicializa los componentes del formulario.
            InitializeComponent();
        }

        // Método que se ejecuta cuando se hace clic en el botón "Cargar".
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Obtiene todos los clientes a través del repositorio.
            var Customers = customerRepository.ObtenerTodos();
            // Asigna los clientes obtenidos como la fuente de datos para el DataGridView.
            dataGrid.DataSource = Customers;
        }

        // Método que se ejecuta cuando el texto dentro de textBox1 cambia.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Código comentado para filtrar clientes cuyo nombre de empresa comience con el texto ingresado.
            // var filtro = Customers.FindAll(X => X.CompanyName.StartsWith(tbFiltro.Text));
            // dataGrid.DataSource = filtro;
        }

        // Método que se ejecuta cuando se hace clic en una celda del DataGridView.
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            // Este método está vacío, pero podría manejar acciones al hacer clic en una celda del DataGridView.
        }

        // Método que se ejecuta cuando el formulario se carga.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Código comentado para configurar la conexión a la base de datos.

            /*  DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
                DatosLayer.DataBase.ConnectionTimeout = 30;

                string cadenaConexion = DatosLayer.DataBase.ConnectionString;
                var conxion = DatosLayer.DataBase.GetSqlConnection();
            */
        }

        // Método que se ejecuta cuando se hace clic en el botón "Buscar".
        private void bntBuscar_Click(object sender, EventArgs e)
        {
            // Busca un cliente por ID usando el texto ingresado en txtBuscar.
            var cliente = customerRepository.ObtenerPorID(txtBuscar.Text);

            // Si el cliente se encuentra, muestra su nombre de empresa en un cuadro de mensaje.
            if (cliente != null)
            {
                txtBuscar.Text = cliente.CompanyName;
                MessageBox.Show(cliente.CompanyName);
            }
            // Si no se encuentra, muestra un mensaje indicando que el ID no fue encontrado.
            else
            {
                MessageBox.Show("ID no encontrado");
            }
        }
    }
}


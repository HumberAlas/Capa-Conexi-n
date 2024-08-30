﻿using DatosLayer;
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
        CustomerRepository customerRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var Customers = customerRepository.ObtenerTodos();
            dataGrid.DataSource = Customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // var filtro = Customers.FindAll( X => X.CompanyName.StartsWith(tbFiltro.Text));
            // dataGrid.DataSource = filtro;
        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            /*  DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
             DatosLayer.DataBase.ConnectionTimeout = 30;

             string cadenaConexion = DatosLayer.DataBase.ConnectionString;
               var conxion = DatosLayer.DataBase.GetSqlConnection();
            */
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(txtBuscar.Text);
            if (cliente != null)
            {
                txtBuscar.Text = cliente.CompanyName;
                MessageBox.Show(cliente.CompanyName);
            }
            else
            {
                MessageBox.Show("ID no encontrado");
            }
        }
    }
}

using NugetCarsDRL.Models;
using NugetCarsDRL.Repositories;
using NugetCustomersDRL;

using NugetCustomersDRL.Models;
using NugetCustomersDRL.Services;

namespace TestingNugetCustomers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void cargarCustomers_Click(object sender, EventArgs e)
        {
            ServiceCustomers service =
                new ServiceCustomers();
            CustomersList data = await service.GetCustomersListAsync();
            List<Customer> clients = data.Customers;
            foreach (Customer c in clients)
            {
                this.lstCustomers.Items.Add
                    (c.Contacto + ", " + c.Empresa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepositoryCoches repo =
                new RepositoryCoches();
            List<Coche> coches =
                repo.GetCoches();
            this.lstCustomers.Items.Clear();
            foreach(Coche car in coches)
            {
                this.lstCustomers.Items.Add
                    (car.Marca + " " + car.Modelo);
            }
        }
    }
}

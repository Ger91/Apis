
using ApiOnePiece.Controllers;
using ApiOnePiece.Models;

namespace ApiOnePiece
{
    public partial class Form1 : Form
    {
        private PersonajeController personajeControlador;
        private List< Personaje>? listaPersonaje;
        public Form1()
        {
            InitializeComponent();
            personajeControlador= new PersonajeController();
        }
        
        private async Task getPersonajes()
        {
            listaPersonaje = await personajeControlador.GetAllPersonajes();

            if (listaPersonaje != null && listaPersonaje.Count>0)
            {

                dataGridView1.Rows.Clear(); 

                foreach (var personaje in listaPersonaje)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    row.Cells[0].Value = personaje.Name;
                    row.Cells[1].Value = personaje.Fruit?.Name ?? "sin fruta";
                    row.Cells[2].Value = personaje.Fruit?.Type ?? "N/A";
                    row.Cells[3].Value = personaje.Job ?? "Desconocido" ;

                    dataGridView1.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No se ha podido encontrar ningún peronaje de One Piece");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await getPersonajes();
        }
    }
}
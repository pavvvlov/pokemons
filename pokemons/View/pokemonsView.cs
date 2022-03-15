using pokemons.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemons
{
    public partial class pokemonsView : Form
    {
        pokemonsController p = new pokemonsController();
        public pokemonsView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPokemons.DataSource = p.GetPokemons();
        }
    }
}

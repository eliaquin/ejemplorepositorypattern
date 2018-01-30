using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Entidades;
using LogicaNegocio.Repositorios;

namespace RepositoryEscaNuevo
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Form1(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var maestro = new Maestro
            {
                Nombre = "Escalante",
                Detalles = new List<Detalle>
                {
                    new Detalle
                    {
                        Descripcion = "Espero que funcione pa que esta gente no me mate."
                    }
                }
            };

            _unitOfWork.Maestros.Add(maestro);
            _unitOfWork.Save();
           
        }
    }
}

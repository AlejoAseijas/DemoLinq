using BE;
using BLL;
using BLL.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLinqToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AlumnoService alumnoService = new AlumnoService();
        private MateriaService materiaService = new MateriaService();

        private void Agregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = this.textBox2.Text;
            alumno.Apellido = this.textBox3.Text;
            alumno.DNI = this.textBox4.Text;

            alumnoService.CreateAlumno(alumno);

            refreshAlumnos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshAlumnos();
            this.comboBox1.DataSource = materiaService.GetAllMaterias();
        }

        private void refreshAlumnos()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = alumnoService.GetAllAlumnos();
        }

        private void refreshNotas(int IdAlumno) 
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = alumnoService.GetNotasByIdAlumno(IdAlumno);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = (Alumno)this.dataGridView1.CurrentRow.DataBoundItem;

            if (alumno != null) 
            {
                this.textBox1.Text = alumno.IdAlumno.ToString();
                this.textBox2.Text = alumno.Nombre;
                this.textBox3.Text = alumno.Apellido;
                this.textBox4.Text = alumno.Apellido;

                refreshNotas(alumno.IdAlumno);
                this.button3.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)this.dataGridView1.CurrentRow.DataBoundItem;

            if (alumno != null)
            {
                alumnoService.deleteById(alumno);
                refreshAlumnos();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)this.dataGridView1.CurrentRow.DataBoundItem;
            Materia materia = (Materia)this.comboBox1.SelectedItem;
            float nota = float.Parse(this.textBox6.Text);

            alumnoService.LoadNewNota(alumno, materia, nota);

            refreshNotas(alumno.IdAlumno);

            this.groupBox1.Visible = false;
        }
    }
}

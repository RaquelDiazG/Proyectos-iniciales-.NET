using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDDForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entidades entities = new entidades();

            var personas=entities.Personas;

            foreach (var p in personas)
            {
                listBox1.Items.Add(p);
            }
        }

        private void nuevaPersona(object sender, EventArgs e)
        {
            entidades entities = new entidades();

            Persona persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellidos = textBox2.Text;

            entities.Personas.Add(persona);

            int num=entities.SaveChanges();

            if (num == 1)
            {
                listBox1.Items.Add(persona);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona p=(Persona)((ListBox)sender).SelectedItem;
            entidades entities = new entidades();
            //Persona busco = entities.Personas.Where(x=>x.Id==p.Id).Find();
            foreach (var f in p.Facturas)
            {
                listBox2.Items.Add(f);
            }
        }

       
    }
}

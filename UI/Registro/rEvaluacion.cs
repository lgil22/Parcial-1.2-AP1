using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1._2_AP1.BLL;
using Parcial1._2_AP1.Entidades;

namespace Parcial1._2_AP1.UI
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdtextBox.Text = IdtextBox.Text;
            EstudiantetextBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            ValortextBox.Text = ValortextBox.Text;
            LogradotextBox.Text = LogradotextBox.Text;
            PerdidotextBox.Text = PerdidotextBox.Text;

        }

        private Evaluacion LlenaClase()
        {
            Evaluacion regEv = new Evaluacion();
            //regEv.Id = Convert.ToInt32(IdtextBox.Text);
            regEv.Id = IdtextBox.Text;
            regEv.Estudiante = EstudiantetextBox.Text;
            regEv.Valor = Convert.ToDecimal(ValortextBox.Text);
            regEv.Logrado = Convert.ToDecimal(LogradotextBox.Text);
            regEv.Perdido = Convert.ToDecimal(PerdidotextBox.Text);
            return regEv;

        }

        private void LlenaCampo(Evaluacion regEv)
        {
            IdtextBox.Text = regEv.Id;
            EstudiantetextBox.Text = regEv.Estudiante;
            dateTimePicker.Value = regEv.Fecha;
            ValortextBox.Text = regEv.Valor.ToString();
            LogradotextBox.Text = regEv.Logrado.ToString();
            PerdidotextBox.Text = regEv.Perdido.ToString();
            
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void REvaluacion_Load(object sender, EventArgs e)
        {
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Evaluacion ev;
            bool paso = false;

            if (!Validate())
                return;

            ev = LlenaClase();
            Limpiar();


            if (IdtextBox.Text == 0)
                paso = EvaluacionBLL.Guardar(ev);


            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}




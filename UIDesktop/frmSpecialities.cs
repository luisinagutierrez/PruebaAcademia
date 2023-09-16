﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmSpecialities : Form
    {
        public frmSpecialities()
        {
            InitializeComponent();
        }

        private void frmSpecialities_Load(object sender, EventArgs e)
        {
            Negocio.Specialities nSpecialities = new Negocio.Specialities();
            List<Entidades.Specialities> SpecialitiesList = nSpecialities.GetAll();
            dgvSpecialities.DataSource = SpecialitiesList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateSpecialitie_Click(object sender, EventArgs e)
        {
            if(txtIdSpeciality.Text != "")
            {
                MessageBox.Show("El campo IdSpeciality debe estar vacio para dar de alta una nueva especialidad.");
                return;
            }
            string descrip = Convert.ToString(txtSpecialityDescription.Text);
            if (descrip != " ")
            {
                Negocio.Specialities s = new Negocio.Specialities();
                s.Add(descrip);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("Para poder crear una nueva especialidad debe ingresar su descripcion");
            }
            this.Close();
        }

        private void btnUpdateSpecialitie_Click(object sender, EventArgs e)
        {
            if (txtIdSpeciality.Text == "")
            {
                MessageBox.Show("El campo IdSpeciality no puede estar vacio para actualizar una especialidad.");
                return;
            }

            string descrip = Convert.ToString(txtSpecialityDescription.Text);
            int id = Convert.ToInt32(txtIdSpeciality.Text);

            Negocio.Specialities s = new Negocio.Specialities();
            int sp = s.Update(id, descrip);
            if (sp != 0)
            {
                MessageBox.Show("Se actualizó la especialidad correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }
        }

        private void dgvSpecialities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDeleteSpeciality_Click(object sender, EventArgs e)
        {
            if (txtIdSpeciality.Text == "")
            {
                MessageBox.Show("El campo IdSpeciality no puede estar vacio para eliminar una especialidad.");
                return;
            }
            int idS = Convert.ToInt32(txtIdSpeciality.Text);

            Negocio.Plans p = new Negocio.Plans();
            int pl = p.GetPlansByIdSpeciality(idS);
            if (pl == 0)
            {
                Negocio.Specialities s = new Negocio.Specialities();
                int rts = s.Delete(idS);
                if (rts != 0)
                {
                    MessageBox.Show("Operación exitosa");
                    return;
                }
                else
                {
                    MessageBox.Show("Id especialidad ingresado no valido.");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar la especialidad dado que tiene planes asignados a la misma.");
                return;
            }
        }

        private void frmSpecialities_Load_1(object sender, EventArgs e)
        {
            Negocio.Specialities nSpecialities = new Negocio.Specialities();
            List<Entidades.Specialities> PeopleList = nSpecialities.GetAll();
            dgvSpecialities.DataSource = PeopleList;
        }

        private void dgvSpecialities_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay alguna fila seleccionada
            if (dgvSpecialities.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvSpecialities.SelectedRows[0];

                // Accede a las celdas de la fila y asigna sus valores a los TextBox
                txtIdSpeciality.Text = selectedRow.Cells["IdSpeciality"].Value.ToString();
                txtSpecialityDescription.Text = selectedRow.Cells["SpecialityDescription"].Value.ToString();
                // ... y así sucesivamente para cada TextBox y columna que desees mostrar
            }
            else
            {
                // Si no hay filas seleccionadas, borra los TextBox
                txtIdSpeciality.Text = "";
                txtSpecialityDescription.Text = "";
                // ... y así sucesivamente para cada TextBox que desees borrar
            }
        }
    }
}

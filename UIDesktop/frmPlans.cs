﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class frmPlans : Form
    {
        public frmPlans()
        {
            InitializeComponent();
        }

        private void brnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCreateAndUpdatePlans_Load(object sender, EventArgs e)
        {
            Negocio.Plans nPlans = new Negocio.Plans();
            List<Entidades.Plans> PlansList = nPlans.GetAll();
            dgvPlans.DataSource = PlansList;
        }

        private void btnCreatePlan_Click(object sender, EventArgs e)
        {
            int idS = Convert.ToInt32(txtPlanSpeciality.Text);
            string descrip = Convert.ToString(txtPlanDescription.Text);
            Negocio.Specialities s = new Negocio.Specialities();
            Entidades.Specialities sp = s.GetOne(idS);

            if (sp != null)
            {
                Negocio.Plans p = new Negocio.Plans();
                p.Add(idS, descrip);
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }
            this.Close();
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPlans.Text);
            int idS = Convert.ToInt32(txtPlanSpeciality.Text);
            string descrip = Convert.ToString(txtPlanDescription.Text);

            Negocio.Specialities s = new Negocio.Specialities();
            Entidades.Specialities sp = s.GetOne(idS);

            if (sp != null)
            {
                Negocio.Plans p = new Negocio.Plans();
                int pl = p.UpdatePlan(idP, descrip, idS);
                if (pl == 1)
                {
                    MessageBox.Show("Se actualizó el plan correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el plan.");
                }
            }
            else
            {
                MessageBox.Show("El Id de la especialidad no fue encontrado");
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(txtIdPlans.Text);
            Negocio.Plans p = new Negocio.Plans();
            p.Delete(idP);
            MessageBox.Show("Operación exitosa");
            this.Close();
        }
    }
}
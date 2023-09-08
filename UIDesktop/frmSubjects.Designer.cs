﻿namespace UIDesktop
{
    partial class frmSubjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSubjectsPlan = new TextBox();
            lbSubjectIdPlan = new Label();
            txtSubjectsWeeklyHours = new TextBox();
            lbSubjectsWeeklyHours = new Label();
            lbCreateUpdateSubjects = new Label();
            dgvSubjects = new DataGridView();
            txtSubjectDescription = new TextBox();
            lbSubjectDescription = new Label();
            btnUpdateSubject = new Button();
            btnCreateSubject = new Button();
            btnBack = new Button();
            txtIdSubject = new TextBox();
            lbIdSubject = new Label();
            txtSubjectsTotalHours = new TextBox();
            lbSubjecttotalHours = new Label();
            btnDeleteSubject = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // txtSubjectsPlan
            // 
            txtSubjectsPlan.Location = new Point(825, 273);
            txtSubjectsPlan.Name = "txtSubjectsPlan";
            txtSubjectsPlan.Size = new Size(124, 27);
            txtSubjectsPlan.TabIndex = 54;
            // 
            // lbSubjectIdPlan
            // 
            lbSubjectIdPlan.AutoSize = true;
            lbSubjectIdPlan.Location = new Point(702, 273);
            lbSubjectIdPlan.Name = "lbSubjectIdPlan";
            lbSubjectIdPlan.Size = new Size(55, 20);
            lbSubjectIdPlan.TabIndex = 53;
            lbSubjectIdPlan.Text = "Id plan";
            // 
            // txtSubjectsWeeklyHours
            // 
            txtSubjectsWeeklyHours.Location = new Point(825, 316);
            txtSubjectsWeeklyHours.Name = "txtSubjectsWeeklyHours";
            txtSubjectsWeeklyHours.Size = new Size(124, 27);
            txtSubjectsWeeklyHours.TabIndex = 52;
            // 
            // lbSubjectsWeeklyHours
            // 
            lbSubjectsWeeklyHours.AutoSize = true;
            lbSubjectsWeeklyHours.Location = new Point(702, 316);
            lbSubjectsWeeklyHours.Name = "lbSubjectsWeeklyHours";
            lbSubjectsWeeklyHours.Size = new Size(121, 20);
            lbSubjectsWeeklyHours.TabIndex = 51;
            lbSubjectsWeeklyHours.Text = "Horas semanales";
            lbSubjectsWeeklyHours.Click += lbSubjectsWeeklyHours_Click;
            // 
            // lbCreateUpdateSubjects
            // 
            lbCreateUpdateSubjects.AutoSize = true;
            lbCreateUpdateSubjects.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdateSubjects.Location = new Point(572, 51);
            lbCreateUpdateSubjects.Name = "lbCreateUpdateSubjects";
            lbCreateUpdateSubjects.Size = new Size(108, 25);
            lbCreateUpdateSubjects.TabIndex = 50;
            lbCreateUpdateSubjects.Text = "Materias";
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(39, 128);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.RowTemplate.Height = 29;
            dgvSubjects.Size = new Size(641, 233);
            dgvSubjects.TabIndex = 48;
            dgvSubjects.CellContentClick += dgvSubjects_CellContentClick;
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Location = new Point(825, 184);
            txtSubjectDescription.Multiline = true;
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(221, 71);
            txtSubjectDescription.TabIndex = 47;
            // 
            // lbSubjectDescription
            // 
            lbSubjectDescription.AutoSize = true;
            lbSubjectDescription.Location = new Point(702, 187);
            lbSubjectDescription.Name = "lbSubjectDescription";
            lbSubjectDescription.Size = new Size(87, 20);
            lbSubjectDescription.TabIndex = 46;
            lbSubjectDescription.Text = "Descripcion";
            // 
            // btnUpdateSubject
            // 
            btnUpdateSubject.Location = new Point(776, 447);
            btnUpdateSubject.Name = "btnUpdateSubject";
            btnUpdateSubject.Size = new Size(121, 48);
            btnUpdateSubject.TabIndex = 45;
            btnUpdateSubject.Text = "Actualizar materia";
            btnUpdateSubject.UseVisualStyleBackColor = true;
            btnUpdateSubject.Click += btnUpdateSubject_Click;
            // 
            // btnCreateSubject
            // 
            btnCreateSubject.Location = new Point(572, 447);
            btnCreateSubject.Name = "btnCreateSubject";
            btnCreateSubject.Size = new Size(121, 48);
            btnCreateSubject.TabIndex = 44;
            btnCreateSubject.Text = "Guardar nueva materia";
            btnCreateSubject.UseVisualStyleBackColor = true;
            btnCreateSubject.Click += btnCreateSubject_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(357, 447);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 43;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtIdSubject
            // 
            txtIdSubject.Location = new Point(825, 139);
            txtIdSubject.Name = "txtIdSubject";
            txtIdSubject.Size = new Size(124, 27);
            txtIdSubject.TabIndex = 42;
            // 
            // lbIdSubject
            // 
            lbIdSubject.AutoSize = true;
            lbIdSubject.Location = new Point(702, 142);
            lbIdSubject.Name = "lbIdSubject";
            lbIdSubject.Size = new Size(77, 20);
            lbIdSubject.TabIndex = 41;
            lbIdSubject.Text = "Id materia";
            // 
            // txtSubjectsTotalHours
            // 
            txtSubjectsTotalHours.Location = new Point(1092, 316);
            txtSubjectsTotalHours.Name = "txtSubjectsTotalHours";
            txtSubjectsTotalHours.Size = new Size(124, 27);
            txtSubjectsTotalHours.TabIndex = 56;
            // 
            // lbSubjecttotalHours
            // 
            lbSubjecttotalHours.AutoSize = true;
            lbSubjecttotalHours.Location = new Point(969, 316);
            lbSubjecttotalHours.Name = "lbSubjecttotalHours";
            lbSubjecttotalHours.Size = new Size(103, 20);
            lbSubjecttotalHours.TabIndex = 55;
            lbSubjecttotalHours.Text = "Total de horas";
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(979, 447);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(121, 48);
            btnDeleteSubject.TabIndex = 57;
            btnDeleteSubject.Text = "Eliminar materia";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // frmSubjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1243, 511);
            Controls.Add(btnDeleteSubject);
            Controls.Add(txtSubjectsTotalHours);
            Controls.Add(lbSubjecttotalHours);
            Controls.Add(txtSubjectsPlan);
            Controls.Add(lbSubjectIdPlan);
            Controls.Add(txtSubjectsWeeklyHours);
            Controls.Add(lbSubjectsWeeklyHours);
            Controls.Add(lbCreateUpdateSubjects);
            Controls.Add(dgvSubjects);
            Controls.Add(txtSubjectDescription);
            Controls.Add(lbSubjectDescription);
            Controls.Add(btnUpdateSubject);
            Controls.Add(btnCreateSubject);
            Controls.Add(btnBack);
            Controls.Add(txtIdSubject);
            Controls.Add(lbIdSubject);
            Name = "frmSubjects";
            Text = "Crear o actualizar materias";
            Load += frmCreateAndUpdateSubjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubjectsPlan;
        private Label lbSubjectIdPlan;
        private TextBox txtSubjectsWeeklyHours;
        private Label lbSubjectsWeeklyHours;
        private Label lbCreateUpdateSubjects;
        private DataGridView dgvSubjects;
        private TextBox txtSubjectDescription;
        private Label lbSubjectDescription;
        private Button btnUpdateSubject;
        private Button btnCreateSubject;
        private Button btnBack;
        private TextBox txtIdSubject;
        private Label lbIdSubject;
        private TextBox txtSubjectsTotalHours;
        private Label lbSubjecttotalHours;
        private Button btnDeleteSubject;
    }
}
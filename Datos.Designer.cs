namespace Asistencia2
{
    partial class Datos
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
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblIdpersonal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(12, 9);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel";
            // 
            // lblIdpersonal
            // 
            this.lblIdpersonal.AutoSize = true;
            this.lblIdpersonal.Location = new System.Drawing.Point(49, 9);
            this.lblIdpersonal.Name = "lblIdpersonal";
            this.lblIdpersonal.Size = new System.Drawing.Size(13, 13);
            this.lblIdpersonal.TabIndex = 1;
            this.lblIdpersonal.Text = "1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 278);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdpersonal);
            this.Controls.Add(this.lblNivel);
            this.Name = "Datos";
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblIdpersonal;
        public System.Windows.Forms.Label lblNombre;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblIdpersonal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalirTodo = new System.Windows.Forms.Button();
            this.btnSalirVolver = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(13, 87);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 16);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel";
            // 
            // lblIdpersonal
            // 
            this.lblIdpersonal.AutoSize = true;
            this.lblIdpersonal.Location = new System.Drawing.Point(13, 9);
            this.lblIdpersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdpersonal.Name = "lblIdpersonal";
            this.lblIdpersonal.Size = new System.Drawing.Size(14, 16);
            this.lblIdpersonal.TabIndex = 1;
            this.lblIdpersonal.Text = "1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Square721 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Location = new System.Drawing.Point(35, 9);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Square721 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescuento.Location = new System.Drawing.Point(109, 42);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(74, 28);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "DSTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descuento:";
            // 
            // btnSalirTodo
            // 
            this.btnSalirTodo.BackColor = System.Drawing.Color.Maroon;
            this.btnSalirTodo.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSalirTodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalirTodo.Location = new System.Drawing.Point(68, 87);
            this.btnSalirTodo.Name = "btnSalirTodo";
            this.btnSalirTodo.Size = new System.Drawing.Size(200, 40);
            this.btnSalirTodo.TabIndex = 5;
            this.btnSalirTodo.Text = "Salir de Todo y apagar";
            this.btnSalirTodo.UseVisualStyleBackColor = false;
            this.btnSalirTodo.Click += new System.EventHandler(this.btnSalirTodo_Click);
            // 
            // btnSalirVolver
            // 
            this.btnSalirVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalirVolver.Location = new System.Drawing.Point(501, 87);
            this.btnSalirVolver.Name = "btnSalirVolver";
            this.btnSalirVolver.Size = new System.Drawing.Size(160, 40);
            this.btnSalirVolver.TabIndex = 6;
            this.btnSalirVolver.Text = "Voy a volver";
            this.btnSalirVolver.UseVisualStyleBackColor = false;
            this.btnSalirVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Square721 BT", 13.8F);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHora.Location = new System.Drawing.Point(506, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(62, 28);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "hora";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Asis GONSAD V1.0";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 76);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Location = new System.Drawing.Point(269, 52);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(41, 20);
            this.lblAsistencia.TabIndex = 8;
            this.lblAsistencia.Text = "Asis";
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Location = new System.Drawing.Point(359, 52);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(75, 20);
            this.lblLlamada.TabIndex = 9;
            this.lblLlamada.Text = "Llamada";
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.Magenta;
            this.btnOcultar.Location = new System.Drawing.Point(501, 42);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(160, 40);
            this.btnOcultar.TabIndex = 10;
            this.btnOcultar.Text = "OCULTAR";
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 131);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.lblLlamada);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnSalirVolver);
            this.Controls.Add(this.btnSalirTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdpersonal);
            this.Controls.Add(this.lblNivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Datos_Load);
            this.SizeChanged += new System.EventHandler(this.Datos_SizeChanged);
            this.Resize += new System.EventHandler(this.Datos_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblIdpersonal;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalirTodo;
        private System.Windows.Forms.Button btnSalirVolver;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Timer HoraFecha;
        public System.Windows.Forms.Label lblAsistencia;
        public System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Button btnOcultar;
    }
}
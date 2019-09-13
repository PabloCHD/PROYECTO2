namespace Ventas
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimasReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sencillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huespedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosPorTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.huespedesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaToolStripMenuItem,
            this.ultimasReservacionesToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // crearNuevaToolStripMenuItem
            // 
            this.crearNuevaToolStripMenuItem.Name = "crearNuevaToolStripMenuItem";
            this.crearNuevaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.crearNuevaToolStripMenuItem.Text = "Nueva Reservacion";
            this.crearNuevaToolStripMenuItem.Click += new System.EventHandler(this.crearNuevaToolStripMenuItem_Click);
            // 
            // ultimasReservacionesToolStripMenuItem
            // 
            this.ultimasReservacionesToolStripMenuItem.Name = "ultimasReservacionesToolStripMenuItem";
            this.ultimasReservacionesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ultimasReservacionesToolStripMenuItem.Text = "Ultimas reservaciones";
            this.ultimasReservacionesToolStripMenuItem.Click += new System.EventHandler(this.ultimasReservacionesToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sencillasToolStripMenuItem,
            this.doblesToolStripMenuItem,
            this.triplesToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.habitacionesToolStripMenuItem.Text = "Sucursales";
            // 
            // sencillasToolStripMenuItem
            // 
            this.sencillasToolStripMenuItem.Name = "sencillasToolStripMenuItem";
            this.sencillasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sencillasToolStripMenuItem.Text = "San Pedro Sula";
            // 
            // doblesToolStripMenuItem
            // 
            this.doblesToolStripMenuItem.Name = "doblesToolStripMenuItem";
            this.doblesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doblesToolStripMenuItem.Text = "Tegucigalpa";
            // 
            // triplesToolStripMenuItem
            // 
            this.triplesToolStripMenuItem.Name = "triplesToolStripMenuItem";
            this.triplesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.triplesToolStripMenuItem.Text = "Santa Rosa";
            // 
            // huespedesToolStripMenuItem
            // 
            this.huespedesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIPToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.huespedesToolStripMenuItem.Name = "huespedesToolStripMenuItem";
            this.huespedesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.huespedesToolStripMenuItem.Text = "Huespedes";
            // 
            // vIPToolStripMenuItem
            // 
            this.vIPToolStripMenuItem.Name = "vIPToolStripMenuItem";
            this.vIPToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vIPToolStripMenuItem.Text = "Ejecutivos";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.normalToolStripMenuItem.Text = "VIP";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem1,
            this.movimientosPorTurnoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // habitacionesToolStripMenuItem1
            // 
            this.habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            this.habitacionesToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.habitacionesToolStripMenuItem1.Text = "Habitaciones";
            // 
            // movimientosPorTurnoToolStripMenuItem
            // 
            this.movimientosPorTurnoToolStripMenuItem.Name = "movimientosPorTurnoToolStripMenuItem";
            this.movimientosPorTurnoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.movimientosPorTurnoToolStripMenuItem.Text = "Movimientos por turno";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ventas.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sencillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huespedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimientosPorTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimasReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
    }
}
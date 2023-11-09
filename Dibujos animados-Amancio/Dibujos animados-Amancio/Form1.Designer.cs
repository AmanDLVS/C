namespace Dibujos_animados_Amancio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaminasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn4_activity = new System.Windows.Forms.Button();
            this.btn3_activity = new System.Windows.Forms.Button();
            this.btn2_activity = new System.Windows.Forms.Button();
            this.btn1_activity = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadToolStripMenuItem,
            this.buscaminasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.actividadToolStripMenuItem.Text = "Actividad";
            this.actividadToolStripMenuItem.Click += new System.EventHandler(this.actividadToolStripMenuItem_Click);
            // 
            // buscaminasToolStripMenuItem
            // 
            this.buscaminasToolStripMenuItem.Name = "buscaminasToolStripMenuItem";
            this.buscaminasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.buscaminasToolStripMenuItem.Text = "Juego";
            this.buscaminasToolStripMenuItem.Click += new System.EventHandler(this.buscaminasToolStripMenuItem_Click);
            // 
            // btn4_activity
            // 
            this.btn4_activity.Image = global::Dibujos_animados_Amancio.Properties.Resources.campominas;
            this.btn4_activity.Location = new System.Drawing.Point(278, 300);
            this.btn4_activity.Name = "btn4_activity";
            this.btn4_activity.Size = new System.Drawing.Size(200, 200);
            this.btn4_activity.TabIndex = 3;
            this.btn4_activity.Text = " ";
            this.btn4_activity.UseVisualStyleBackColor = true;
            this.btn4_activity.Visible = false;
            this.btn4_activity.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3_activity
            // 
            this.btn3_activity.Image = global::Dibujos_animados_Amancio.Properties.Resources.mina;
            this.btn3_activity.Location = new System.Drawing.Point(28, 300);
            this.btn3_activity.Name = "btn3_activity";
            this.btn3_activity.Size = new System.Drawing.Size(200, 200);
            this.btn3_activity.TabIndex = 2;
            this.btn3_activity.Text = " ";
            this.btn3_activity.UseVisualStyleBackColor = true;
            this.btn3_activity.Visible = false;
            this.btn3_activity.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2_activity
            // 
            this.btn2_activity.Image = global::Dibujos_animados_Amancio.Properties.Resources.buscar;
            this.btn2_activity.Location = new System.Drawing.Point(278, 50);
            this.btn2_activity.Name = "btn2_activity";
            this.btn2_activity.Size = new System.Drawing.Size(200, 200);
            this.btn2_activity.TabIndex = 1;
            this.btn2_activity.Text = " ";
            this.btn2_activity.UseVisualStyleBackColor = true;
            this.btn2_activity.Visible = false;
            this.btn2_activity.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1_activity
            // 
            this.btn1_activity.Image = global::Dibujos_animados_Amancio.Properties.Resources.lupa;
            this.btn1_activity.Location = new System.Drawing.Point(28, 50);
            this.btn1_activity.Name = "btn1_activity";
            this.btn1_activity.Size = new System.Drawing.Size(200, 200);
            this.btn1_activity.TabIndex = 0;
            this.btn1_activity.Text = " ";
            this.btn1_activity.UseVisualStyleBackColor = true;
            this.btn1_activity.Visible = false;
            this.btn1_activity.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 588);
            this.Controls.Add(this.btn4_activity);
            this.Controls.Add(this.btn3_activity);
            this.Controls.Add(this.btn2_activity);
            this.Controls.Add(this.btn1_activity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_activity;
        private System.Windows.Forms.Button btn2_activity;
        private System.Windows.Forms.Button btn3_activity;
        private System.Windows.Forms.Button btn4_activity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaminasToolStripMenuItem;
    }
}


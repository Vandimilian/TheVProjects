namespace Gamepoly
{
    partial class WelcomeScreen
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
            this.bttPlayVersus = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttPlayVersus
            // 
            this.bttPlayVersus.Location = new System.Drawing.Point(115, 201);
            this.bttPlayVersus.Name = "bttPlayVersus";
            this.bttPlayVersus.Size = new System.Drawing.Size(193, 63);
            this.bttPlayVersus.TabIndex = 0;
            this.bttPlayVersus.Text = "Play";
            this.bttPlayVersus.UseVisualStyleBackColor = true;
            this.bttPlayVersus.Click += new System.EventHandler(this.bttPlayVersus_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(115, 283);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(193, 62);
            this.bttExit.TabIndex = 1;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 406);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttPlayVersus);
            this.Name = "WelcomeScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttPlayVersus;
        private System.Windows.Forms.Button bttExit;
    }
}


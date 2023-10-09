namespace JuegoCoches
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
            this.components = new System.ComponentModel.Container();
            this.pcCarro = new System.Windows.Forms.PictureBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Obstaculo = new System.Windows.Forms.PictureBox();
            this.Obstaculo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcCarro
            // 
            this.pcCarro.BackColor = System.Drawing.Color.Transparent;
            this.pcCarro.BackgroundImage = global::JuegoCoches.Properties.Resources.CarroBlanco;
            this.pcCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcCarro.Location = new System.Drawing.Point(12, 486);
            this.pcCarro.Name = "pcCarro";
            this.pcCarro.Size = new System.Drawing.Size(71, 63);
            this.pcCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcCarro.TabIndex = 0;
            this.pcCarro.TabStop = false;
            this.pcCarro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.Red;
            this.lblPoints.Location = new System.Drawing.Point(12, 16);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(17, 19);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Obstaculo
            // 
            this.Obstaculo.BackgroundImage = global::JuegoCoches.Properties.Resources.Obstaculo1_1;
            this.Obstaculo.Location = new System.Drawing.Point(12, 77);
            this.Obstaculo.Name = "Obstaculo";
            this.Obstaculo.Size = new System.Drawing.Size(100, 50);
            this.Obstaculo.TabIndex = 2;
            this.Obstaculo.TabStop = false;
            // 
            // Obstaculo1
            // 
            this.Obstaculo1.BackgroundImage = global::JuegoCoches.Properties.Resources.Obstaculo1;
            this.Obstaculo1.Location = new System.Drawing.Point(122, 77);
            this.Obstaculo1.Name = "Obstaculo1";
            this.Obstaculo1.Size = new System.Drawing.Size(100, 50);
            this.Obstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstaculo1.TabIndex = 3;
            this.Obstaculo1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoCoches.Properties.Resources.Sin_título;
            this.ClientSize = new System.Drawing.Size(234, 561);
            this.Controls.Add(this.Obstaculo1);
            this.Controls.Add(this.Obstaculo);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.pcCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pcCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcCarro;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Obstaculo;
        private System.Windows.Forms.PictureBox Obstaculo1;
    }
}


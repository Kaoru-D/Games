namespace juego_flappy
{
    partial class frmjuegoflappy
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.tuboarriba = new System.Windows.Forms.PictureBox();
            this.tuboabajo = new System.Windows.Forms.PictureBox();
            this.piso = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboarriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::juego_flappy.Properties.Resources.kisspng_sprite_flappy_bird_video_game_clip_art_5b1875b723af68_9121844615283296551462;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(19, 225);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(83, 55);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // tuboarriba
            // 
            this.tuboarriba.BackColor = System.Drawing.Color.Transparent;
            this.tuboarriba.BackgroundImage = global::juego_flappy.Properties.Resources.c;
            this.tuboarriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tuboarriba.Location = new System.Drawing.Point(134, -173);
            this.tuboarriba.Name = "tuboarriba";
            this.tuboarriba.Size = new System.Drawing.Size(100, 371);
            this.tuboarriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tuboarriba.TabIndex = 2;
            this.tuboarriba.TabStop = false;
            // 
            // tuboabajo
            // 
            this.tuboabajo.BackColor = System.Drawing.Color.Transparent;
            this.tuboabajo.BackgroundImage = global::juego_flappy.Properties.Resources.d;
            this.tuboabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tuboabajo.Location = new System.Drawing.Point(134, 319);
            this.tuboabajo.Name = "tuboabajo";
            this.tuboabajo.Size = new System.Drawing.Size(100, 233);
            this.tuboabajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tuboabajo.TabIndex = 3;
            this.tuboabajo.TabStop = false;
            // 
            // piso
            // 
            this.piso.BackColor = System.Drawing.Color.Transparent;
            this.piso.BackgroundImage = global::juego_flappy.Properties.Resources.piso;
            this.piso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piso.Location = new System.Drawing.Point(-274, 443);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(779, 24);
            this.piso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piso.TabIndex = 4;
            this.piso.TabStop = false;
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
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.BackColor = System.Drawing.Color.Transparent;
            this.puntaje.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(52, 198);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(17, 18);
            this.puntaje.TabIndex = 5;
            this.puntaje.Text = "0";
            // 
            // frmjuegoflappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::juego_flappy.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(292, 465);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.tuboabajo);
            this.Controls.Add(this.tuboarriba);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmjuegoflappy";
            this.Text = "Juego Flappy";
            this.Load += new System.EventHandler(this.frmjuegoflappy_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmjuegoflappy_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboarriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox tuboarriba;
        private System.Windows.Forms.PictureBox tuboabajo;
        private System.Windows.Forms.PictureBox piso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label puntaje;
    }
}


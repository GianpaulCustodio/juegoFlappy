namespace Flap
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
            this.player = new System.Windows.Forms.PictureBox();
            this.tuboArriba = new System.Windows.Forms.PictureBox();
            this.tuboAbajo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboAbajo)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Flap.Properties.Resources.flappy;
            this.player.Location = new System.Drawing.Point(28, 212);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(98, 83);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // tuboArriba
            // 
            this.tuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.tuboArriba.Image = global::Flap.Properties.Resources.abajo;
            this.tuboArriba.Location = new System.Drawing.Point(306, -2);
            this.tuboArriba.Name = "tuboArriba";
            this.tuboArriba.Size = new System.Drawing.Size(100, 262);
            this.tuboArriba.TabIndex = 1;
            this.tuboArriba.TabStop = false;
            // 
            // tuboAbajo
            // 
            this.tuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.tuboAbajo.Image = global::Flap.Properties.Resources.arriba;
            this.tuboAbajo.Location = new System.Drawing.Point(306, 318);
            this.tuboAbajo.Name = "tuboAbajo";
            this.tuboAbajo.Size = new System.Drawing.Size(100, 193);
            this.tuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboAbajo.TabIndex = 2;
            this.tuboAbajo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
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
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.BackColor = System.Drawing.Color.Transparent;
            this.puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(51, 212);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(27, 29);
            this.puntaje.TabIndex = 3;
            this.puntaje.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flap.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(444, 510);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.tuboAbajo);
            this.Controls.Add(this.tuboArriba);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboAbajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox tuboArriba;
        private System.Windows.Forms.PictureBox tuboAbajo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label puntaje;
    }
}


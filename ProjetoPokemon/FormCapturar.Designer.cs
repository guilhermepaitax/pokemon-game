namespace ProjetoPokemon
{
    partial class FormCapturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapturar));
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoke = new System.Windows.Forms.PictureBox();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.timerY = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoke)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBall.BackgroundImage")));
            this.pictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBall.Location = new System.Drawing.Point(354, 416);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(74, 78);
            this.pictureBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBall.TabIndex = 2;
            this.pictureBoxBall.TabStop = false;
            // 
            // pictureBoxPoke
            // 
            this.pictureBoxPoke.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPoke.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoke.Image")));
            this.pictureBoxPoke.Location = new System.Drawing.Point(380, 140);
            this.pictureBoxPoke.Name = "pictureBoxPoke";
            this.pictureBoxPoke.Size = new System.Drawing.Size(48, 57);
            this.pictureBoxPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPoke.TabIndex = 3;
            this.pictureBoxPoke.TabStop = false;
            // 
            // timerX
            // 
            this.timerX.Enabled = true;
            this.timerX.Interval = 5;
            this.timerX.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerY
            // 
            this.timerY.Enabled = true;
            this.timerY.Interval = 5;
            this.timerY.Tick += new System.EventHandler(this.timerY_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pressione a tecla Enter para\r\n lançar a PokeBola";
            // 
            // FormCapturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBall);
            this.Controls.Add(this.pictureBoxPoke);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCapturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Pokemon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCapturar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.PictureBox pictureBoxPoke;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.Timer timerY;
        private System.Windows.Forms.Label label1;
    }
}
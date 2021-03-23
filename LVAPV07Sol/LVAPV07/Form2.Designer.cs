
namespace LVAPV07
{
    partial class Form2
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
            this.pctScorpion = new System.Windows.Forms.PictureBox();
            this.bttderecha = new System.Windows.Forms.Button();
            this.bttizquierda = new System.Windows.Forms.Button();
            this.bttAbajo = new System.Windows.Forms.Button();
            this.bttup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctScorpion)).BeginInit();
            this.SuspendLayout();
            // 
            // pctScorpion
            // 
            this.pctScorpion.Image = global::LVAPV07.Properties.Resources.scorpion;
            this.pctScorpion.Location = new System.Drawing.Point(281, 111);
            this.pctScorpion.Name = "pctScorpion";
            this.pctScorpion.Size = new System.Drawing.Size(82, 114);
            this.pctScorpion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctScorpion.TabIndex = 0;
            this.pctScorpion.TabStop = false;
            this.pctScorpion.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttderecha
            // 
            this.bttderecha.Location = new System.Drawing.Point(410, 316);
            this.bttderecha.Name = "bttderecha";
            this.bttderecha.Size = new System.Drawing.Size(123, 50);
            this.bttderecha.TabIndex = 1;
            this.bttderecha.Text = "Derecha ";
            this.bttderecha.UseVisualStyleBackColor = true;
            this.bttderecha.Click += new System.EventHandler(this.bttderecha_Click);
            // 
            // bttizquierda
            // 
            this.bttizquierda.Location = new System.Drawing.Point(665, 316);
            this.bttizquierda.Name = "bttizquierda";
            this.bttizquierda.Size = new System.Drawing.Size(123, 50);
            this.bttizquierda.TabIndex = 2;
            this.bttizquierda.Text = "Izquierda ";
            this.bttizquierda.UseVisualStyleBackColor = true;
            this.bttizquierda.Click += new System.EventHandler(this.bttizquierda_Click);
            // 
            // bttAbajo
            // 
            this.bttAbajo.Location = new System.Drawing.Point(539, 316);
            this.bttAbajo.Name = "bttAbajo";
            this.bttAbajo.Size = new System.Drawing.Size(123, 50);
            this.bttAbajo.TabIndex = 4;
            this.bttAbajo.Text = "Abajo";
            this.bttAbajo.UseVisualStyleBackColor = true;
            this.bttAbajo.Click += new System.EventHandler(this.bttAbajo_Click);
            // 
            // bttup
            // 
            this.bttup.Location = new System.Drawing.Point(539, 260);
            this.bttup.Name = "bttup";
            this.bttup.Size = new System.Drawing.Size(123, 50);
            this.bttup.TabIndex = 5;
            this.bttup.Text = "Arriba ";
            this.bttup.UseVisualStyleBackColor = true;
            this.bttup.Click += new System.EventHandler(this.bttup_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttup);
            this.Controls.Add(this.bttAbajo);
            this.Controls.Add(this.bttizquierda);
            this.Controls.Add(this.bttderecha);
            this.Controls.Add(this.pctScorpion);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pctScorpion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctScorpion;
        private System.Windows.Forms.Button bttderecha;
        private System.Windows.Forms.Button bttizquierda;
        private System.Windows.Forms.Button bttAbajo;
        private System.Windows.Forms.Button bttup;
    }
}
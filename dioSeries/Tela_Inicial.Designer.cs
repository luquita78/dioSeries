
namespace dioSeries
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarSeries = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarSeries
            // 
            this.btnCadastrarSeries.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrarSeries.Location = new System.Drawing.Point(12, 27);
            this.btnCadastrarSeries.Name = "btnCadastrarSeries";
            this.btnCadastrarSeries.Size = new System.Drawing.Size(212, 359);
            this.btnCadastrarSeries.TabIndex = 0;
            this.btnCadastrarSeries.Text = "CADASTRAR SERIES";
            this.btnCadastrarSeries.UseVisualStyleBackColor = false;
            this.btnCadastrarSeries.Click += new System.EventHandler(this.btnCadastrarSeries_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenero.Location = new System.Drawing.Point(576, 27);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(212, 359);
            this.btnGenero.TabIndex = 0;
            this.btnGenero.Text = "GENERO";
            this.btnGenero.UseVisualStyleBackColor = false;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dioSeries.Properties.Resources.logo_sm_white;
            this.pictureBox1.Location = new System.Drawing.Point(242, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 142);
            this.button1.TabIndex = 2;
            this.button1.Text = "VINCULAR SÉRIE COM GENERO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenero);
            this.Controls.Add(this.btnCadastrarSeries);
            this.Name = "Tela_Inicial";
            this.Text = "DIOSERIES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSeries;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}


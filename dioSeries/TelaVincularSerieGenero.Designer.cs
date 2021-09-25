
namespace dioSeries
{
    partial class TelaVincularSerieGenero
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
            this.dbseriesdioDataSet = new dioSeries.dbseriesdioDataSet();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new dioSeries.dbseriesdioDataSetTableAdapters.generoTableAdapter();
            this.dgvSerie = new System.Windows.Forms.DataGridView();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGeneroSerie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbseriesdioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneroSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // dbseriesdioDataSet
            // 
            this.dbseriesdioDataSet.DataSetName = "dbseriesdioDataSet";
            this.dbseriesdioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "genero";
            this.generoBindingSource.DataSource = this.dbseriesdioDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // dgvSerie
            // 
            this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerie.Location = new System.Drawing.Point(12, 38);
            this.dgvSerie.Name = "dgvSerie";
            this.dgvSerie.Size = new System.Drawing.Size(262, 126);
            this.dgvSerie.TabIndex = 0;
            // 
            // dgvGenero
            // 
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(526, 38);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.Size = new System.Drawing.Size(262, 126);
            this.dgvGenero.TabIndex = 0;
            this.dgvGenero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERIES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GENEROS: ";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(129, 227);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(671, 227);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 3;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(251, 348);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(306, 62);
            this.btnVincular.TabIndex = 4;
            this.btnVincular.Text = "VINCULAR";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira o código da Serie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insira o código do Genero: ";
            // 
            // dgvGeneroSerie
            // 
            this.dgvGeneroSerie.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvGeneroSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneroSerie.Location = new System.Drawing.Point(273, 188);
            this.dgvGeneroSerie.Name = "dgvGeneroSerie";
            this.dgvGeneroSerie.Size = new System.Drawing.Size(240, 118);
            this.dgvGeneroSerie.TabIndex = 6;
            // 
            // TelaVincularSerieGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGeneroSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.dgvSerie);
            this.Name = "TelaVincularSerieGenero";
            this.Text = "TelaVincularSerieGenero";
            this.Load += new System.EventHandler(this.TelaVincularSerieGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbseriesdioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneroSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbseriesdioDataSet dbseriesdioDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private dbseriesdioDataSetTableAdapters.generoTableAdapter generoTableAdapter;
        private System.Windows.Forms.DataGridView dgvSerie;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGeneroSerie;
    }
}
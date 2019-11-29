using System;
using System.Windows.Forms;

namespace Sistema.Apresentacao
{
    partial class BemVindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BemVindo));
            this.label1 = new System.Windows.Forms.Label();
            this.sistemaDataSet = new Sistema.SistemaDataSet();
            this.sistemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palavrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palavrasTableAdapter = new Sistema.SistemaDataSetTableAdapters.palavrasTableAdapter();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new Sistema.SistemaDataSetTableAdapters.loginsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palavrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.palavrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palavrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palavrasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavras agendadas";
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "SistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaDataSetBindingSource
            // 
            this.sistemaDataSetBindingSource.DataSource = this.sistemaDataSet;
            this.sistemaDataSetBindingSource.Position = 0;
            // 
            // palavrasBindingSource
            // 
            this.palavrasBindingSource.DataMember = "palavras";
            this.palavrasBindingSource.DataSource = this.sistemaDataSetBindingSource;
            // 
            // palavrasTableAdapter
            // 
            this.palavrasTableAdapter.ClearBeforeFill = true;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.sistemaDataSetBindingSource;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palavrasDataGridViewTextBoxColumn,
            this.traduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.palavrasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // palavrasBindingSource1
            // 
            this.palavrasBindingSource1.DataMember = "palavras";
            this.palavrasBindingSource1.DataSource = this.sistemaDataSetBindingSource;
            // 
            // palavrasDataGridViewTextBoxColumn
            // 
            this.palavrasDataGridViewTextBoxColumn.DataPropertyName = "Palavras";
            this.palavrasDataGridViewTextBoxColumn.HeaderText = "Palavras";
            this.palavrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.palavrasDataGridViewTextBoxColumn.Name = "palavrasDataGridViewTextBoxColumn";
            this.palavrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // traduDataGridViewTextBoxColumn
            // 
            this.traduDataGridViewTextBoxColumn.DataPropertyName = "Tradu";
            this.traduDataGridViewTextBoxColumn.HeaderText = "Tradu";
            this.traduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traduDataGridViewTextBoxColumn.Name = "traduDataGridViewTextBoxColumn";
            this.traduDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Palavras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(382, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BemVindo";
            this.Load += new System.EventHandler(this.BemVindo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palavrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palavrasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BindingSource sistemaDataSetBindingSource;
        private SistemaDataSet sistemaDataSet;
        private BindingSource palavrasBindingSource;
        private SistemaDataSetTableAdapters.palavrasTableAdapter palavrasTableAdapter;
        private BindingSource loginsBindingSource;
        private SistemaDataSetTableAdapters.loginsTableAdapter loginsTableAdapter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn palavrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn traduDataGridViewTextBoxColumn;
        private BindingSource palavrasBindingSource1;
        private Button button1;
        private Button button2;
    }
}
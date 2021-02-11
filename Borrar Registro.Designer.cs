namespace Empresa_SogDental
{
    partial class Borrar_Registro
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
            this.btnborrarregistro = new System.Windows.Forms.Button();
            this.txtborrar = new System.Windows.Forms.TextBox();
            this.dATOS_DEL_PACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIOSOGDENTALDataSet1 = new Empresa_SogDental.CONSULTORIOSOGDENTALDataSet1();
            this.dATOS_DEL_PACIENTETableAdapter = new Empresa_SogDental.CONSULTORIOSOGDENTALDataSet1TableAdapters.DATOS_DEL_PACIENTETableAdapter();
            this.tableAdapterManager = new Empresa_SogDental.CONSULTORIOSOGDENTALDataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dATOS_DEL_PACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIOSOGDENTALDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnborrarregistro
            // 
            this.btnborrarregistro.BackColor = System.Drawing.Color.White;
            this.btnborrarregistro.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrarregistro.Location = new System.Drawing.Point(69, 166);
            this.btnborrarregistro.Name = "btnborrarregistro";
            this.btnborrarregistro.Size = new System.Drawing.Size(485, 30);
            this.btnborrarregistro.TabIndex = 0;
            this.btnborrarregistro.Text = "Borrar Registro";
            this.btnborrarregistro.UseVisualStyleBackColor = false;
            this.btnborrarregistro.Click += new System.EventHandler(this.btnborrarregistro_Click);
            // 
            // txtborrar
            // 
            this.txtborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtborrar.Location = new System.Drawing.Point(242, 123);
            this.txtborrar.Name = "txtborrar";
            this.txtborrar.Size = new System.Drawing.Size(138, 20);
            this.txtborrar.TabIndex = 1;
            // 
            // dATOS_DEL_PACIENTEBindingSource
            // 
            this.dATOS_DEL_PACIENTEBindingSource.DataMember = "DATOS_DEL_PACIENTE";
            this.dATOS_DEL_PACIENTEBindingSource.DataSource = this.cONSULTORIOSOGDENTALDataSet1;
            // 
            // cONSULTORIOSOGDENTALDataSet1
            // 
            this.cONSULTORIOSOGDENTALDataSet1.DataSetName = "CONSULTORIOSOGDENTALDataSet1";
            this.cONSULTORIOSOGDENTALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATOS_DEL_PACIENTETableAdapter
            // 
            this.dATOS_DEL_PACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DATOS_DEL_PACIENTETableAdapter = this.dATOS_DEL_PACIENTETableAdapter;
            this.tableAdapterManager.UpdateOrder = Empresa_SogDental.CONSULTORIOSOGDENTALDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Empresa_SogDental.Properties.Resources._25101;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 360;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(596, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(26, 23);
            this.btncancelar.TabIndex = 361;
            this.btncancelar.Text = "X";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(564, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(26, 23);
            this.btnatras.TabIndex = 362;
            this.btnatras.Text = "<";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Empresa_SogDental.Properties.Resources.SOG_DENTAL;
            this.pictureBox2.Location = new System.Drawing.Point(242, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 363;
            this.pictureBox2.TabStop = false;
            // 
            // Borrar_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 275);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtborrar);
            this.Controls.Add(this.btnborrarregistro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrar_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar_Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dATOS_DEL_PACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIOSOGDENTALDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnborrarregistro;
        private System.Windows.Forms.TextBox txtborrar;
        private System.Windows.Forms.BindingSource dATOS_DEL_PACIENTEBindingSource;
        private CONSULTORIOSOGDENTALDataSet1 cONSULTORIOSOGDENTALDataSet1;
        private CONSULTORIOSOGDENTALDataSet1TableAdapters.DATOS_DEL_PACIENTETableAdapter dATOS_DEL_PACIENTETableAdapter;
        private CONSULTORIOSOGDENTALDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
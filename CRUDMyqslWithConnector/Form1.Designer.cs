namespace CRUDMyqslWithConnector
{
    partial class Form1
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
            this.dgv_dataKontak = new System.Windows.Forms.DataGridView();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_telepon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_alamatEdit = new System.Windows.Forms.TextBox();
            this.tb_namaEdit = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataKontak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dataKontak
            // 
            this.dgv_dataKontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataKontak.Location = new System.Drawing.Point(16, 206);
            this.dgv_dataKontak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_dataKontak.Name = "dgv_dataKontak";
            this.dgv_dataKontak.RowHeadersWidth = 51;
            this.dgv_dataKontak.Size = new System.Drawing.Size(913, 329);
            this.dgv_dataKontak.TabIndex = 0;
            this.dgv_dataKontak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataKontak_CellClick);
            this.dgv_dataKontak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataKontak_CellContentClick);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(137, 65);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(132, 22);
            this.tb_nama.TabIndex = 1;
            // 
            // tb_telepon
            // 
            this.tb_telepon.Location = new System.Drawing.Point(137, 124);
            this.tb_telepon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_telepon.Name = "tb_telepon";
            this.tb_telepon.Size = new System.Drawing.Size(132, 22);
            this.tb_telepon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telepon";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(279, 65);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 84);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "TAMBAH DATA";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(697, 65);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(131, 84);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "SIMPAN DATA";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama";
            // 
            // tb_alamatEdit
            // 
            this.tb_alamatEdit.Location = new System.Drawing.Point(556, 124);
            this.tb_alamatEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_alamatEdit.Name = "tb_alamatEdit";
            this.tb_alamatEdit.Size = new System.Drawing.Size(132, 22);
            this.tb_alamatEdit.TabIndex = 7;
            // 
            // tb_namaEdit
            // 
            this.tb_namaEdit.Location = new System.Drawing.Point(556, 92);
            this.tb_namaEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_namaEdit.Name = "tb_namaEdit";
            this.tb_namaEdit.Size = new System.Drawing.Size(132, 22);
            this.tb_namaEdit.TabIndex = 6;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(556, 60);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(132, 22);
            this.tb_id.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 549);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_alamatEdit);
            this.Controls.Add(this.tb_namaEdit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_telepon);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.dgv_dataKontak);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataKontak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataKontak;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_telepon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_alamatEdit;
        private System.Windows.Forms.TextBox tb_namaEdit;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label5;
    }
}


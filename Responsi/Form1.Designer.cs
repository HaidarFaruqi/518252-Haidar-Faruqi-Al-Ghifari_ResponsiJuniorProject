namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_dev = new TextBox();
            cb_proyek = new ComboBox();
            cb_kontrak = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_kinerja = new TextBox();
            tb_bug = new TextBox();
            label6 = new Label();
            label7 = new Label();
            bt_insert = new Button();
            bt_update = new Button();
            bt_delete = new Button();
            dg_performa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_performa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Junpro Yuhu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Developer";
            label2.Click += label2_Click;
            // 
            // tb_dev
            // 
            tb_dev.Location = new Point(194, 80);
            tb_dev.Name = "tb_dev";
            tb_dev.Size = new Size(100, 23);
            tb_dev.TabIndex = 2;
            tb_dev.TextChanged += textBox1_TextChanged;
            // 
            // cb_proyek
            // 
            cb_proyek.FormattingEnabled = true;
            cb_proyek.Location = new Point(194, 121);
            cb_proyek.Name = "cb_proyek";
            cb_proyek.Size = new Size(121, 23);
            cb_proyek.TabIndex = 3;
            // 
            // cb_kontrak
            // 
            cb_kontrak.FormattingEnabled = true;
            cb_kontrak.Location = new Point(194, 163);
            cb_kontrak.Name = "cb_kontrak";
            cb_kontrak.Size = new Size(121, 23);
            cb_kontrak.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 83);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Developer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 124);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Proyek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 171);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Status";
            // 
            // tb_kinerja
            // 
            tb_kinerja.Location = new Point(194, 222);
            tb_kinerja.Name = "tb_kinerja";
            tb_kinerja.Size = new Size(100, 23);
            tb_kinerja.TabIndex = 8;
            // 
            // tb_bug
            // 
            tb_bug.Location = new Point(194, 262);
            tb_bug.Name = "tb_bug";
            tb_bug.Size = new Size(100, 23);
            tb_bug.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 230);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "kinerja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 270);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "bug";
            // 
            // bt_insert
            // 
            bt_insert.Location = new Point(35, 318);
            bt_insert.Name = "bt_insert";
            bt_insert.Size = new Size(75, 23);
            bt_insert.TabIndex = 12;
            bt_insert.Text = "Insert";
            bt_insert.UseVisualStyleBackColor = true;
            bt_insert.Click += bt_insert_Click;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(194, 318);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(75, 23);
            bt_update.TabIndex = 13;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(326, 318);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 14;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // dg_performa
            // 
            dg_performa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_performa.Location = new Point(424, 54);
            dg_performa.Name = "dg_performa";
            dg_performa.RowTemplate.Height = 25;
            dg_performa.Size = new Size(324, 332);
            dg_performa.TabIndex = 16;
            dg_performa.CellContentClick += dg_performa_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dg_performa);
            Controls.Add(bt_delete);
            Controls.Add(bt_update);
            Controls.Add(bt_insert);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tb_bug);
            Controls.Add(tb_kinerja);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_kontrak);
            Controls.Add(cb_proyek);
            Controls.Add(tb_dev);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg_performa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_dev;
        private ComboBox cb_proyek;
        private ComboBox cb_kontrak;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_kinerja;
        private TextBox tb_bug;
        private Label label6;
        private Label label7;
        private Button bt_insert;
        private Button bt_update;
        private Button bt_delete;
        private DataGridView dg_performa;
    }
}
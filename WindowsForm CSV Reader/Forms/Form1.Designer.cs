namespace WindowsForm_CSV_Reader
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
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnGetFromDb = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ActiveCaption;
            btnLoad.Location = new Point(567, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(95, 39);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Otwórz Plik";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 369);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.Location = new Point(40, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj Do Bazy Danych";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetFromDb
            // 
            btnGetFromDb.BackColor = SystemColors.ActiveCaption;
            btnGetFromDb.Location = new Point(687, 12);
            btnGetFromDb.Name = "btnGetFromDb";
            btnGetFromDb.Size = new Size(101, 39);
            btnGetFromDb.TabIndex = 3;
            btnGetFromDb.Text = "Pokaż Wszystko";
            btnGetFromDb.UseVisualStyleBackColor = false;
            btnGetFromDb.Click += btnGetFromDb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(btnGetFromDb);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnGetFromDb;
    }
}
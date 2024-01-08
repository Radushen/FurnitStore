namespace FurnitSotre
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(88, 38);
            label1.Name = "label1";
            label1.Size = new Size(173, 39);
            label1.TabIndex = 7;
            label1.Text = "Доп. Элементы";
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(295, 34);
            button2.Name = "button2";
            button2.Size = new Size(99, 39);
            button2.TabIndex = 10;
            button2.Text = "Меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(50, 480);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 38;
            label4.Text = "Материал";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bahnschrift Condensed", 14.25F);
            textBox3.Location = new Point(146, 477);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 30);
            textBox3.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(50, 440);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 36;
            label3.Text = "Название";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bahnschrift Condensed", 14.25F);
            textBox2.Location = new Point(146, 438);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 30);
            textBox2.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(50, 400);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 34;
            label2.Text = "Номер";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Bahnschrift Condensed", 14.25F);
            textBox1.Location = new Point(146, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 30);
            textBox1.TabIndex = 33;
            // 
            // button4
            // 
            button4.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(267, 510);
            button4.Name = "button4";
            button4.Size = new Size(127, 39);
            button4.TabIndex = 32;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(267, 398);
            button3.Name = "button3";
            button3.Size = new Size(127, 39);
            button3.TabIndex = 31;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(267, 454);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 30;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(343, 303);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(445, 582);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FurnitStore";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
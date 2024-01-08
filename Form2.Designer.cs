namespace FurnitSotre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(66, 122);
            button1.Name = "button1";
            button1.Size = new Size(154, 39);
            button1.TabIndex = 7;
            button1.Text = "Доставка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(258, 245);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 6;
            label1.Text = "FurnitStore";
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(66, 181);
            button2.Name = "button2";
            button2.Size = new Size(154, 39);
            button2.TabIndex = 9;
            button2.Text = "Мебель";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(66, 240);
            button3.Name = "button3";
            button3.Size = new Size(154, 39);
            button3.TabIndex = 10;
            button3.Text = "Доп. Элементы";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(477, 400);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FurnitStore";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}
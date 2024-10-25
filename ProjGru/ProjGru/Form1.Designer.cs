namespace ProjGru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AlzaButton = new Button();
            ApplicaButton = new Button();
            label1 = new Label();
            label2 = new Label();
            AbbassaButton = new Button();
            ResetButton = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(461, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 654);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(940, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // AlzaButton
            // 
            AlzaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AlzaButton.Location = new Point(81, 490);
            AlzaButton.Name = "AlzaButton";
            AlzaButton.Size = new Size(100, 57);
            AlzaButton.TabIndex = 2;
            AlzaButton.Text = "ALZA";
            AlzaButton.UseVisualStyleBackColor = true;
            AlzaButton.MouseDown += Alza;
            AlzaButton.MouseUp += bottone_MouseUp;
            // 
            // ApplicaButton
            // 
            ApplicaButton.BackColor = Color.Lime;
            ApplicaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ApplicaButton.Location = new Point(232, 136);
            ApplicaButton.Name = "ApplicaButton";
            ApplicaButton.Size = new Size(108, 49);
            ApplicaButton.TabIndex = 4;
            ApplicaButton.Text = "APPLICA";
            ApplicaButton.UseVisualStyleBackColor = false;
            ApplicaButton.Click += ApplicaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 164);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 5;
            label1.Text = "Altezza Massima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 87);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 6;
            label2.Text = "Altezza Minima";
            // 
            // AbbassaButton
            // 
            AbbassaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AbbassaButton.Location = new Point(81, 591);
            AbbassaButton.Name = "AbbassaButton";
            AbbassaButton.Size = new Size(100, 57);
            AbbassaButton.TabIndex = 9;
            AbbassaButton.Text = "ABBASSA";
            AbbassaButton.UseVisualStyleBackColor = true;
            AbbassaButton.MouseDown += Abbassa;
            AbbassaButton.MouseUp += bottone_MouseUp;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Red;
            ResetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.ForeColor = Color.Black;
            ResetButton.Location = new Point(232, 535);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(100, 57);
            ResetButton.TabIndex = 10;
            ResetButton.Text = "RESET";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(56, 111);
            numericUpDown1.Maximum = new decimal(new int[] { 650, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 209, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(116, 29);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 209, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(56, 188);
            numericUpDown2.Maximum = new decimal(new int[] { 650, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 209, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(116, 29);
            numericUpDown2.TabIndex = 12;
            numericUpDown2.Value = new decimal(new int[] { 650, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(ResetButton);
            Controls.Add(AbbassaButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ApplicaButton);
            Controls.Add(AlzaButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button AlzaButton;
        private Button ApplicaButton;
        private Label label1;
        private Label label2;
        private Button AbbassaButton;
        private Button ResetButton;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}
namespace pwiz_lab6
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox80 = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox80).BeginInit();
            SuspendLayout();
            // 
            // pictureBox80
            // 
            pictureBox80.Location = new Point(-76, 713);
            pictureBox80.Name = "pictureBox80";
            pictureBox80.Size = new Size(50, 50);
            pictureBox80.TabIndex = 70;
            pictureBox80.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(27, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 608);
            panel1.TabIndex = 71;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "krokodyl.jpg");
            imageList1.Images.SetKeyName(1, "dydelf1.jpg");
            imageList1.Images.SetKeyName(2, "pusty.jpg");
            imageList1.Images.SetKeyName(3, "plytka.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 692);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 72;
            label1.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 727);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox80);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox80).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox80;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private Label label1;
    }
}
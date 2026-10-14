namespace Paintcooleee
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            gbCollors = new GroupBox();
            btnWhite = new Button();
            btnGrey = new Button();
            btnPink = new Button();
            btnBlack = new Button();
            btnOrange = new Button();
            btnBrown = new Button();
            btnGreen = new Button();
            bntBlue = new Button();
            btnRed = new Button();
            btnYellow = new Button();
            btnIndigo = new Button();
            btnCyan = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            gbCollors.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1114, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, печатьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(153, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(153, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(153, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(153, 22);
            печатьToolStripMenuItem.Text = "Печать";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(gbCollors);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 83);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(322, 19);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(434, 19);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(378, 19);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            // 
            // gbCollors
            // 
            gbCollors.Controls.Add(btnWhite);
            gbCollors.Controls.Add(btnGrey);
            gbCollors.Controls.Add(btnPink);
            gbCollors.Controls.Add(btnBlack);
            gbCollors.Controls.Add(btnOrange);
            gbCollors.Controls.Add(btnBrown);
            gbCollors.Controls.Add(btnGreen);
            gbCollors.Controls.Add(bntBlue);
            gbCollors.Controls.Add(btnRed);
            gbCollors.Controls.Add(btnYellow);
            gbCollors.Controls.Add(btnIndigo);
            gbCollors.Controls.Add(btnCyan);
            gbCollors.Font = new Font("Segoe UI", 9F);
            gbCollors.Location = new Point(839, 6);
            gbCollors.Name = "gbCollors";
            gbCollors.Size = new Size(256, 73);
            gbCollors.TabIndex = 2;
            gbCollors.TabStop = false;
            gbCollors.Text = "Colors";
            // 
            // btnWhite
            // 
            btnWhite.BackColor = Color.White;
            btnWhite.Location = new Point(18, 16);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(33, 23);
            btnWhite.TabIndex = 2;
            btnWhite.UseVisualStyleBackColor = false;
            btnWhite.Click += btnWhite_Click;
            // 
            // btnGrey
            // 
            btnGrey.BackColor = Color.Gray;
            btnGrey.Location = new Point(57, 16);
            btnGrey.Name = "btnGrey";
            btnGrey.Size = new Size(34, 23);
            btnGrey.TabIndex = 2;
            btnGrey.UseVisualStyleBackColor = false;
            // 
            // btnPink
            // 
            btnPink.BackColor = Color.Pink;
            btnPink.Location = new Point(217, 41);
            btnPink.Name = "btnPink";
            btnPink.Size = new Size(34, 23);
            btnPink.TabIndex = 11;
            btnPink.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.Location = new Point(18, 41);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(33, 23);
            btnBlack.TabIndex = 4;
            btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.Orange;
            btnOrange.Location = new Point(97, 41);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(34, 23);
            btnOrange.TabIndex = 6;
            btnOrange.UseVisualStyleBackColor = false;
            // 
            // btnBrown
            // 
            btnBrown.BackColor = Color.Brown;
            btnBrown.Location = new Point(57, 41);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new Size(34, 23);
            btnBrown.TabIndex = 2;
            btnBrown.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.Location = new Point(137, 41);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(34, 23);
            btnGreen.TabIndex = 7;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // bntBlue
            // 
            bntBlue.BackColor = Color.Blue;
            bntBlue.ForeColor = SystemColors.ControlLightLight;
            bntBlue.Location = new Point(177, 41);
            bntBlue.Name = "bntBlue";
            bntBlue.Size = new Size(34, 23);
            bntBlue.TabIndex = 8;
            bntBlue.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Location = new Point(97, 16);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(34, 23);
            btnRed.TabIndex = 5;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Location = new Point(137, 16);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(34, 23);
            btnYellow.TabIndex = 3;
            btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnIndigo
            // 
            btnIndigo.BackColor = Color.Indigo;
            btnIndigo.Location = new Point(217, 16);
            btnIndigo.Name = "btnIndigo";
            btnIndigo.Size = new Size(34, 23);
            btnIndigo.TabIndex = 10;
            btnIndigo.UseVisualStyleBackColor = false;
            // 
            // btnCyan
            // 
            btnCyan.BackColor = Color.Cyan;
            btnCyan.Location = new Point(177, 16);
            btnCyan.Name = "btnCyan";
            btnCyan.Size = new Size(34, 23);
            btnCyan.TabIndex = 9;
            btnCyan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(612, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 70);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Толщина";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Толщина: 1", "Толщина: 3", "Толщина: 5", "Толщина: 8" });
            comboBox1.Location = new Point(39, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(318, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 70);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Кисть";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button6);
            groupBox3.Location = new Point(121, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(170, 70);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Инструменты";
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(62, 14);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(114, 16);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 18;
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(6, 14);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 19;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-3, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1114, 492);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 598);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            gbCollors.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private Panel panel1;
        private Button btnOrange;
        private Button btnRed;
        private Button btnBlack;
        private Button btnYellow;
        private Button btnBrown;
        private Button btnWhite;
        private Button btnGrey;
        private Button bntBlue;
        private Button btnGreen;
        private Button btnIndigo;
        private Button btnCyan;
        private Button btnPink;
        private GroupBox gbCollors;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private GroupBox groupBox3;
        private Button button6;
        private GroupBox groupBox2;
    }
}

namespace Galua
{
    partial class Galua_Coursework
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            q_ = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            записьВФайлToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            m_ = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label_ax0 = new Label();
            a_x0 = new ComboBox();
            label_a = new Label();
            label_deg_a = new Label();
            a_x1 = new ComboBox();
            label_ax1 = new Label();
            a_x2 = new ComboBox();
            label_ax2 = new Label();
            a_x3 = new ComboBox();
            label_ax3 = new Label();
            a_x4 = new ComboBox();
            label_ax4 = new Label();
            a_x5 = new ComboBox();
            label_ax5 = new Label();
            button4 = new Button();
            button5 = new Button();
            b_x5 = new ComboBox();
            label_bx5 = new Label();
            b_x4 = new ComboBox();
            label_bx4 = new Label();
            b_x3 = new ComboBox();
            label_bx3 = new Label();
            b_x2 = new ComboBox();
            label_bx2 = new Label();
            b_x1 = new ComboBox();
            label_bx1 = new Label();
            label_deg_b = new Label();
            label_b = new Label();
            b_x0 = new ComboBox();
            label_bx0 = new Label();
            label19 = new Label();
            x_ = new NumericUpDown();
            enter_polynomial = new Button();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            deg_a = new ComboBox();
            deg_b = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            label_ax6 = new Label();
            a_x6 = new ComboBox();
            b_x6 = new ComboBox();
            label_bx6 = new Label();
            button6 = new Button();
            label3 = new Label();
            button7 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox5 = new ComboBox();
            label8 = new Label();
            comboBox6 = new ComboBox();
            label9 = new Label();
            comboBox7 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)q_).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m_).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x_).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // q_
            // 
            q_.Location = new Point(238, 56);
            q_.Name = "q_";
            q_.Size = new Size(120, 39);
            q_.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { записьВФайлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1537, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // записьВФайлToolStripMenuItem
            // 
            записьВФайлToolStripMenuItem.Name = "записьВФайлToolStripMenuItem";
            записьВФайлToolStripMenuItem.Size = new Size(192, 36);
            записьВФайлToolStripMenuItem.Text = "Запись в файл";
            записьВФайлToolStripMenuItem.Click += записьВФайлToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1151, 218);
            button1.Name = "button1";
            button1.Size = new Size(143, 57);
            button1.TabIndex = 2;
            button1.Text = "сложение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 32);
            label1.TabIndex = 3;
            label1.Text = "q = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 56);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 5;
            label2.Text = "m = ";
            // 
            // m_
            // 
            m_.Location = new Point(458, 56);
            m_.Name = "m_";
            m_.Size = new Size(120, 39);
            m_.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(1151, 281);
            button2.Name = "button2";
            button2.Size = new Size(143, 57);
            button2.TabIndex = 6;
            button2.Text = "вычитание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += subtract_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1301, 218);
            button3.Name = "button3";
            button3.Size = new Size(161, 57);
            button3.TabIndex = 7;
            button3.Text = "умножение";
            button3.UseVisualStyleBackColor = true;
            button3.Click += multiply_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Bottom;
            richTextBox1.Location = new Point(0, 505);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1537, 416);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label_ax0
            // 
            label_ax0.AutoSize = true;
            label_ax0.Location = new Point(13, 356);
            label_ax0.Name = "label_ax0";
            label_ax0.Size = new Size(84, 32);
            label_ax0.TabIndex = 10;
            label_ax0.Text = "x^0 = ";
            label_ax0.Visible = false;
            // 
            // a_x0
            // 
            a_x0.Enabled = false;
            a_x0.FormattingEnabled = true;
            a_x0.Location = new Point(90, 353);
            a_x0.Name = "a_x0";
            a_x0.Size = new Size(75, 40);
            a_x0.TabIndex = 11;
            a_x0.Visible = false;
            // 
            // label_a
            // 
            label_a.AutoSize = true;
            label_a.Location = new Point(13, 308);
            label_a.Name = "label_a";
            label_a.Size = new Size(158, 32);
            label_a.TabIndex = 12;
            label_a.Text = "полином a(x)";
            label_a.Visible = false;
            // 
            // label_deg_a
            // 
            label_deg_a.AutoSize = true;
            label_deg_a.Location = new Point(186, 308);
            label_deg_a.Name = "label_deg_a";
            label_deg_a.Size = new Size(101, 32);
            label_deg_a.TabIndex = 13;
            label_deg_a.Text = "степень";
            label_deg_a.Visible = false;
            // 
            // a_x1
            // 
            a_x1.Enabled = false;
            a_x1.FormattingEnabled = true;
            a_x1.Location = new Point(256, 353);
            a_x1.Name = "a_x1";
            a_x1.Size = new Size(75, 40);
            a_x1.TabIndex = 16;
            a_x1.Visible = false;
            // 
            // label_ax1
            // 
            label_ax1.AutoSize = true;
            label_ax1.Location = new Point(174, 356);
            label_ax1.Name = "label_ax1";
            label_ax1.Size = new Size(84, 32);
            label_ax1.TabIndex = 15;
            label_ax1.Text = "x^1 = ";
            label_ax1.Visible = false;
            // 
            // a_x2
            // 
            a_x2.Enabled = false;
            a_x2.FormattingEnabled = true;
            a_x2.Location = new Point(413, 356);
            a_x2.Name = "a_x2";
            a_x2.Size = new Size(75, 40);
            a_x2.TabIndex = 18;
            a_x2.Visible = false;
            // 
            // label_ax2
            // 
            label_ax2.AutoSize = true;
            label_ax2.Location = new Point(337, 356);
            label_ax2.Name = "label_ax2";
            label_ax2.Size = new Size(84, 32);
            label_ax2.TabIndex = 17;
            label_ax2.Text = "x^2 = ";
            label_ax2.Visible = false;
            // 
            // a_x3
            // 
            a_x3.Enabled = false;
            a_x3.FormattingEnabled = true;
            a_x3.Location = new Point(567, 353);
            a_x3.Name = "a_x3";
            a_x3.Size = new Size(75, 40);
            a_x3.TabIndex = 20;
            a_x3.Visible = false;
            // 
            // label_ax3
            // 
            label_ax3.AutoSize = true;
            label_ax3.Location = new Point(494, 356);
            label_ax3.Name = "label_ax3";
            label_ax3.Size = new Size(84, 32);
            label_ax3.TabIndex = 19;
            label_ax3.Text = "x^3 = ";
            label_ax3.Visible = false;
            // 
            // a_x4
            // 
            a_x4.Enabled = false;
            a_x4.FormattingEnabled = true;
            a_x4.Location = new Point(723, 356);
            a_x4.Name = "a_x4";
            a_x4.Size = new Size(75, 40);
            a_x4.TabIndex = 22;
            a_x4.Visible = false;
            // 
            // label_ax4
            // 
            label_ax4.AutoSize = true;
            label_ax4.Location = new Point(648, 359);
            label_ax4.Name = "label_ax4";
            label_ax4.Size = new Size(84, 32);
            label_ax4.TabIndex = 21;
            label_ax4.Text = "x^4 = ";
            label_ax4.Visible = false;
            // 
            // a_x5
            // 
            a_x5.Enabled = false;
            a_x5.FormattingEnabled = true;
            a_x5.Location = new Point(881, 356);
            a_x5.Name = "a_x5";
            a_x5.Size = new Size(75, 40);
            a_x5.TabIndex = 24;
            a_x5.Visible = false;
            // 
            // label_ax5
            // 
            label_ax5.AutoSize = true;
            label_ax5.Location = new Point(804, 359);
            label_ax5.Name = "label_ax5";
            label_ax5.Size = new Size(84, 32);
            label_ax5.TabIndex = 23;
            label_ax5.Text = "x^5 = ";
            label_ax5.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(1301, 281);
            button4.Name = "button4";
            button4.Size = new Size(161, 57);
            button4.TabIndex = 25;
            button4.Text = "деление";
            button4.UseVisualStyleBackColor = true;
            button4.Click += division_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1151, 113);
            button5.Name = "button5";
            button5.Size = new Size(248, 89);
            button5.TabIndex = 26;
            button5.Text = "значение полинома в точке x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += calc_value_polynomial_Click;
            // 
            // b_x5
            // 
            b_x5.Enabled = false;
            b_x5.FormattingEnabled = true;
            b_x5.Location = new Point(881, 452);
            b_x5.Name = "b_x5";
            b_x5.Size = new Size(75, 40);
            b_x5.TabIndex = 41;
            b_x5.Visible = false;
            // 
            // label_bx5
            // 
            label_bx5.AutoSize = true;
            label_bx5.Location = new Point(804, 455);
            label_bx5.Name = "label_bx5";
            label_bx5.Size = new Size(84, 32);
            label_bx5.TabIndex = 40;
            label_bx5.Text = "x^5 = ";
            label_bx5.Visible = false;
            // 
            // b_x4
            // 
            b_x4.Enabled = false;
            b_x4.FormattingEnabled = true;
            b_x4.Location = new Point(723, 452);
            b_x4.Name = "b_x4";
            b_x4.Size = new Size(75, 40);
            b_x4.TabIndex = 39;
            b_x4.Visible = false;
            // 
            // label_bx4
            // 
            label_bx4.AutoSize = true;
            label_bx4.Location = new Point(648, 455);
            label_bx4.Name = "label_bx4";
            label_bx4.Size = new Size(84, 32);
            label_bx4.TabIndex = 38;
            label_bx4.Text = "x^4 = ";
            label_bx4.Visible = false;
            // 
            // b_x3
            // 
            b_x3.Enabled = false;
            b_x3.FormattingEnabled = true;
            b_x3.Location = new Point(567, 449);
            b_x3.Name = "b_x3";
            b_x3.Size = new Size(75, 40);
            b_x3.TabIndex = 37;
            b_x3.Visible = false;
            // 
            // label_bx3
            // 
            label_bx3.AutoSize = true;
            label_bx3.Location = new Point(494, 452);
            label_bx3.Name = "label_bx3";
            label_bx3.Size = new Size(84, 32);
            label_bx3.TabIndex = 36;
            label_bx3.Text = "x^3 = ";
            label_bx3.Visible = false;
            // 
            // b_x2
            // 
            b_x2.Enabled = false;
            b_x2.FormattingEnabled = true;
            b_x2.Location = new Point(413, 449);
            b_x2.Name = "b_x2";
            b_x2.Size = new Size(75, 40);
            b_x2.TabIndex = 35;
            b_x2.Visible = false;
            // 
            // label_bx2
            // 
            label_bx2.AutoSize = true;
            label_bx2.Location = new Point(337, 452);
            label_bx2.Name = "label_bx2";
            label_bx2.Size = new Size(84, 32);
            label_bx2.TabIndex = 34;
            label_bx2.Text = "x^2 = ";
            label_bx2.Visible = false;
            // 
            // b_x1
            // 
            b_x1.Enabled = false;
            b_x1.FormattingEnabled = true;
            b_x1.Location = new Point(256, 449);
            b_x1.Name = "b_x1";
            b_x1.Size = new Size(75, 40);
            b_x1.TabIndex = 33;
            b_x1.Visible = false;
            // 
            // label_bx1
            // 
            label_bx1.AutoSize = true;
            label_bx1.Location = new Point(174, 452);
            label_bx1.Name = "label_bx1";
            label_bx1.Size = new Size(84, 32);
            label_bx1.TabIndex = 32;
            label_bx1.Text = "x^1 = ";
            label_bx1.Visible = false;
            // 
            // label_deg_b
            // 
            label_deg_b.AutoSize = true;
            label_deg_b.Location = new Point(180, 408);
            label_deg_b.Name = "label_deg_b";
            label_deg_b.Size = new Size(101, 32);
            label_deg_b.TabIndex = 30;
            label_deg_b.Text = "степень";
            label_deg_b.Visible = false;
            // 
            // label_b
            // 
            label_b.AutoSize = true;
            label_b.Location = new Point(7, 408);
            label_b.Name = "label_b";
            label_b.Size = new Size(160, 32);
            label_b.TabIndex = 29;
            label_b.Text = "полином b(x)";
            label_b.Visible = false;
            // 
            // b_x0
            // 
            b_x0.Enabled = false;
            b_x0.FormattingEnabled = true;
            b_x0.Location = new Point(93, 449);
            b_x0.Name = "b_x0";
            b_x0.Size = new Size(75, 40);
            b_x0.TabIndex = 28;
            b_x0.Visible = false;
            // 
            // label_bx0
            // 
            label_bx0.AutoSize = true;
            label_bx0.Location = new Point(13, 452);
            label_bx0.Name = "label_bx0";
            label_bx0.Size = new Size(84, 32);
            label_bx0.TabIndex = 27;
            label_bx0.Text = "x^0 = ";
            label_bx0.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(587, 56);
            label19.Name = "label19";
            label19.Size = new Size(55, 32);
            label19.TabIndex = 43;
            label19.Text = "x = ";
            // 
            // x_
            // 
            x_.Location = new Point(648, 56);
            x_.Name = "x_";
            x_.Size = new Size(120, 39);
            x_.TabIndex = 42;
            // 
            // enter_polynomial
            // 
            enter_polynomial.Location = new Point(671, 115);
            enter_polynomial.Name = "enter_polynomial";
            enter_polynomial.Size = new Size(217, 57);
            enter_polynomial.TabIndex = 44;
            enter_polynomial.Text = "ввести a(x) и b(x)";
            enter_polynomial.UseVisualStyleBackColor = true;
            enter_polynomial.Click += enter_polynomial_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(1405, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 89);
            panel1.TabIndex = 45;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 36);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "b(x)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 36);
            radioButton1.TabIndex = 48;
            radioButton1.TabStop = true;
            radioButton1.Text = "a(x)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // deg_a
            // 
            deg_a.Enabled = false;
            deg_a.FormattingEnabled = true;
            deg_a.Location = new Point(284, 305);
            deg_a.Name = "deg_a";
            deg_a.Size = new Size(75, 40);
            deg_a.TabIndex = 46;
            deg_a.Visible = false;
            deg_a.SelectedIndexChanged += deg_a_SelectedIndexChanged;
            // 
            // deg_b
            // 
            deg_b.Enabled = false;
            deg_b.FormattingEnabled = true;
            deg_b.Location = new Point(278, 405);
            deg_b.Name = "deg_b";
            deg_b.Size = new Size(75, 40);
            deg_b.TabIndex = 47;
            deg_b.Visible = false;
            deg_b.SelectedIndexChanged += deg_b_SelectedIndexChanged;
            // 
            // label_ax6
            // 
            label_ax6.AutoSize = true;
            label_ax6.Location = new Point(962, 359);
            label_ax6.Name = "label_ax6";
            label_ax6.Size = new Size(84, 32);
            label_ax6.TabIndex = 48;
            label_ax6.Text = "x^6 = ";
            label_ax6.Visible = false;
            // 
            // a_x6
            // 
            a_x6.Enabled = false;
            a_x6.FormattingEnabled = true;
            a_x6.Location = new Point(1039, 356);
            a_x6.Name = "a_x6";
            a_x6.Size = new Size(75, 40);
            a_x6.TabIndex = 49;
            a_x6.Visible = false;
            // 
            // b_x6
            // 
            b_x6.Enabled = false;
            b_x6.FormattingEnabled = true;
            b_x6.Location = new Point(1039, 452);
            b_x6.Name = "b_x6";
            b_x6.Size = new Size(75, 40);
            b_x6.TabIndex = 51;
            b_x6.Visible = false;
            // 
            // label_bx6
            // 
            label_bx6.AutoSize = true;
            label_bx6.Location = new Point(961, 455);
            label_bx6.Name = "label_bx6";
            label_bx6.Size = new Size(84, 32);
            label_bx6.TabIndex = 50;
            label_bx6.Text = "x^6 = ";
            label_bx6.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(13, 115);
            button6.Name = "button6";
            button6.Size = new Size(409, 57);
            button6.TabIndex = 52;
            button6.Text = "неприводимый многочлен";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 56);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 53;
            label3.Text = "GF(q^m) ";
            // 
            // button7
            // 
            button7.Location = new Point(441, 115);
            button7.Name = "button7";
            button7.Size = new Size(217, 57);
            button7.TabIndex = 54;
            button7.Text = "построить поле";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1039, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 40);
            comboBox1.TabIndex = 68;
            comboBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(962, 246);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 67;
            label4.Text = "x^6 = ";
            label4.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(881, 243);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(75, 40);
            comboBox2.TabIndex = 66;
            comboBox2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(804, 246);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 65;
            label5.Text = "x^5 = ";
            label5.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(723, 243);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(75, 40);
            comboBox3.TabIndex = 64;
            comboBox3.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(648, 246);
            label6.Name = "label6";
            label6.Size = new Size(84, 32);
            label6.TabIndex = 63;
            label6.Text = "x^4 = ";
            label6.Visible = false;
            // 
            // comboBox4
            // 
            comboBox4.Enabled = false;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(567, 240);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(75, 40);
            comboBox4.TabIndex = 62;
            comboBox4.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 243);
            label7.Name = "label7";
            label7.Size = new Size(84, 32);
            label7.TabIndex = 61;
            label7.Text = "x^3 = ";
            label7.Visible = false;
            // 
            // comboBox5
            // 
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(413, 243);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(75, 40);
            comboBox5.TabIndex = 60;
            comboBox5.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 243);
            label8.Name = "label8";
            label8.Size = new Size(84, 32);
            label8.TabIndex = 59;
            label8.Text = "x^2 = ";
            label8.Visible = false;
            // 
            // comboBox6
            // 
            comboBox6.Enabled = false;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(256, 240);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(75, 40);
            comboBox6.TabIndex = 58;
            comboBox6.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(174, 243);
            label9.Name = "label9";
            label9.Size = new Size(84, 32);
            label9.TabIndex = 57;
            label9.Text = "x^1 = ";
            label9.Visible = false;
            // 
            // comboBox7
            // 
            comboBox7.Enabled = false;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(90, 240);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(75, 40);
            comboBox7.TabIndex = 56;
            comboBox7.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 243);
            label10.Name = "label10";
            label10.Size = new Size(84, 32);
            label10.TabIndex = 55;
            label10.Text = "x^0 = ";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 192);
            label11.Name = "label11";
            label11.Size = new Size(314, 32);
            label11.TabIndex = 69;
            label11.Text = "неприводимый многочлен";
            label11.Visible = false;
            // 
            // Galua_Coursework
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1537, 921);
            Controls.Add(label11);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox5);
            Controls.Add(label8);
            Controls.Add(comboBox6);
            Controls.Add(label9);
            Controls.Add(comboBox7);
            Controls.Add(label10);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(b_x6);
            Controls.Add(label_bx6);
            Controls.Add(a_x6);
            Controls.Add(label_ax6);
            Controls.Add(deg_b);
            Controls.Add(deg_a);
            Controls.Add(panel1);
            Controls.Add(enter_polynomial);
            Controls.Add(label19);
            Controls.Add(x_);
            Controls.Add(b_x5);
            Controls.Add(label_bx5);
            Controls.Add(b_x4);
            Controls.Add(label_bx4);
            Controls.Add(b_x3);
            Controls.Add(label_bx3);
            Controls.Add(b_x2);
            Controls.Add(label_bx2);
            Controls.Add(b_x1);
            Controls.Add(label_bx1);
            Controls.Add(label_deg_b);
            Controls.Add(label_b);
            Controls.Add(b_x0);
            Controls.Add(label_bx0);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(a_x5);
            Controls.Add(label_ax5);
            Controls.Add(a_x4);
            Controls.Add(label_ax4);
            Controls.Add(a_x3);
            Controls.Add(label_ax3);
            Controls.Add(a_x2);
            Controls.Add(label_ax2);
            Controls.Add(a_x1);
            Controls.Add(label_ax1);
            Controls.Add(label_deg_a);
            Controls.Add(label_a);
            Controls.Add(a_x0);
            Controls.Add(label_ax0);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(m_);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(q_);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1337, 899);
            Name = "Galua_Coursework";
            Text = "Galua_Coursework";
            ((System.ComponentModel.ISupportInitialize)q_).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)m_).EndInit();
            ((System.ComponentModel.ISupportInitialize)x_).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown q_;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem записьВФайлToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown m_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_ax0;
        private System.Windows.Forms.ComboBox a_x0;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_deg_a;
        private System.Windows.Forms.ComboBox a_x1;
        private System.Windows.Forms.Label label_ax1;
        private System.Windows.Forms.ComboBox a_x2;
        private System.Windows.Forms.Label label_ax2;
        private System.Windows.Forms.ComboBox a_x3;
        private System.Windows.Forms.Label label_ax3;
        private System.Windows.Forms.ComboBox a_x4;
        private System.Windows.Forms.Label label_ax4;
        private System.Windows.Forms.ComboBox a_x5;
        private System.Windows.Forms.Label label_ax5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox b_x5;
        private System.Windows.Forms.Label label_bx5;
        private System.Windows.Forms.ComboBox b_x4;
        private System.Windows.Forms.Label label_bx4;
        private System.Windows.Forms.ComboBox b_x3;
        private System.Windows.Forms.Label label_bx3;
        private System.Windows.Forms.ComboBox b_x2;
        private System.Windows.Forms.Label label_bx2;
        private System.Windows.Forms.ComboBox b_x1;
        private System.Windows.Forms.Label label_bx1;
        private System.Windows.Forms.Label label_deg_b;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.ComboBox b_x0;
        private System.Windows.Forms.Label label_bx0;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown x_;
        private System.Windows.Forms.Button enter_polynomial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox deg_a;
        private System.Windows.Forms.ComboBox deg_b;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_ax6;
        private System.Windows.Forms.ComboBox a_x6;
        private System.Windows.Forms.ComboBox b_x6;
        private System.Windows.Forms.Label label_bx6;
        private Button button6;
        private Label label3;
        private Button button7;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private Label label7;
        private ComboBox comboBox5;
        private Label label8;
        private ComboBox comboBox6;
        private Label label9;
        private ComboBox comboBox7;
        private Label label10;
        private Label label11;
    }
}


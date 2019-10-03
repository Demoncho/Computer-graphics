namespace CG_lab4
{
    partial class Form1
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
            this.group_choice = new System.Windows.Forms.GroupBox();
            this.radioButton_square = new System.Windows.Forms.RadioButton();
            this.radioButton_line = new System.Windows.Forms.RadioButton();
            this.radioButton_dot = new System.Windows.Forms.RadioButton();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.comboBox_actions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dX = new System.Windows.Forms.TextBox();
            this.textBox_dY = new System.Windows.Forms.TextBox();
            this.button_make_convert = new System.Windows.Forms.Button();
            this.radioButton_polygon = new System.Windows.Forms.RadioButton();
            this.label_dX = new System.Windows.Forms.Label();
            this.label_dY = new System.Windows.Forms.Label();
            this.label_angle = new System.Windows.Forms.Label();
            this.textBox_angle = new System.Windows.Forms.TextBox();
            this.label_location_random_point = new System.Windows.Forms.Label();
            this.comboBox_actions_line = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // group_choice
            // 
            this.group_choice.Controls.Add(this.radioButton_polygon);
            this.group_choice.Controls.Add(this.radioButton_square);
            this.group_choice.Controls.Add(this.radioButton_line);
            this.group_choice.Controls.Add(this.radioButton_dot);
            this.group_choice.Location = new System.Drawing.Point(12, 12);
            this.group_choice.Name = "group_choice";
            this.group_choice.Size = new System.Drawing.Size(136, 118);
            this.group_choice.TabIndex = 3;
            this.group_choice.TabStop = false;
            this.group_choice.Text = "Выберите примитив:";
            // 
            // radioButton_square
            // 
            this.radioButton_square.AutoSize = true;
            this.radioButton_square.Location = new System.Drawing.Point(6, 67);
            this.radioButton_square.Name = "radioButton_square";
            this.radioButton_square.Size = new System.Drawing.Size(105, 17);
            this.radioButton_square.TabIndex = 2;
            this.radioButton_square.TabStop = true;
            this.radioButton_square.Text = "Прямоугольник";
            this.radioButton_square.UseVisualStyleBackColor = true;
            // 
            // radioButton_line
            // 
            this.radioButton_line.AutoSize = true;
            this.radioButton_line.Location = new System.Drawing.Point(7, 44);
            this.radioButton_line.Name = "radioButton_line";
            this.radioButton_line.Size = new System.Drawing.Size(56, 17);
            this.radioButton_line.TabIndex = 1;
            this.radioButton_line.TabStop = true;
            this.radioButton_line.Text = "Ребро";
            this.radioButton_line.UseVisualStyleBackColor = true;
            // 
            // radioButton_dot
            // 
            this.radioButton_dot.AutoSize = true;
            this.radioButton_dot.Location = new System.Drawing.Point(7, 20);
            this.radioButton_dot.Name = "radioButton_dot";
            this.radioButton_dot.Size = new System.Drawing.Size(55, 17);
            this.radioButton_dot.TabIndex = 0;
            this.radioButton_dot.TabStop = true;
            this.radioButton_dot.Text = "Точка";
            this.radioButton_dot.UseVisualStyleBackColor = true;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(189, 31);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(599, 407);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(217, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(130, 23);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Очистить поле";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clear_canvas);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Location = new System.Drawing.Point(385, 9);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(35, 13);
            this.label_help.TabIndex = 6;
            this.label_help.Text = "label1";
            this.label_help.Visible = false;
            // 
            // comboBox_actions
            // 
            this.comboBox_actions.DropDownWidth = 220;
            this.comboBox_actions.FormattingEnabled = true;
            this.comboBox_actions.Location = new System.Drawing.Point(4, 167);
            this.comboBox_actions.Name = "comboBox_actions";
            this.comboBox_actions.Size = new System.Drawing.Size(179, 21);
            this.comboBox_actions.TabIndex = 7;
            this.comboBox_actions.SelectedIndexChanged += new System.EventHandler(this.comboBox_actions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Действия с полигоном";
            // 
            // textBox_dX
            // 
            this.textBox_dX.Location = new System.Drawing.Point(43, 217);
            this.textBox_dX.Name = "textBox_dX";
            this.textBox_dX.Size = new System.Drawing.Size(32, 20);
            this.textBox_dX.TabIndex = 9;
            this.textBox_dX.Visible = false;
            // 
            // textBox_dY
            // 
            this.textBox_dY.Location = new System.Drawing.Point(116, 217);
            this.textBox_dY.Name = "textBox_dY";
            this.textBox_dY.Size = new System.Drawing.Size(32, 20);
            this.textBox_dY.TabIndex = 10;
            this.textBox_dY.Visible = false;
            // 
            // button_make_convert
            // 
            this.button_make_convert.Location = new System.Drawing.Point(8, 415);
            this.button_make_convert.Name = "button_make_convert";
            this.button_make_convert.Size = new System.Drawing.Size(175, 23);
            this.button_make_convert.TabIndex = 11;
            this.button_make_convert.Text = "Выполнить преобразование";
            this.button_make_convert.UseVisualStyleBackColor = true;
            this.button_make_convert.Visible = false;
            this.button_make_convert.Click += new System.EventHandler(this.button_make_convert_Click);
            // 
            // radioButton_polygon
            // 
            this.radioButton_polygon.AutoSize = true;
            this.radioButton_polygon.Location = new System.Drawing.Point(6, 90);
            this.radioButton_polygon.Name = "radioButton_polygon";
            this.radioButton_polygon.Size = new System.Drawing.Size(103, 17);
            this.radioButton_polygon.TabIndex = 3;
            this.radioButton_polygon.TabStop = true;
            this.radioButton_polygon.Text = "Многоугольник";
            this.radioButton_polygon.UseVisualStyleBackColor = true;
            // 
            // label_dX
            // 
            this.label_dX.AutoSize = true;
            this.label_dX.Location = new System.Drawing.Point(24, 194);
            this.label_dX.Name = "label_dX";
            this.label_dX.Size = new System.Drawing.Size(64, 13);
            this.label_dX.TabIndex = 12;
            this.label_dX.Text = "Сдвинуть X";
            this.label_dX.Visible = false;
            // 
            // label_dY
            // 
            this.label_dY.AutoSize = true;
            this.label_dY.Location = new System.Drawing.Point(103, 194);
            this.label_dY.Name = "label_dY";
            this.label_dY.Size = new System.Drawing.Size(64, 13);
            this.label_dY.TabIndex = 13;
            this.label_dY.Text = "Сдвинуть Y";
            this.label_dY.Visible = false;
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(57, 240);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(82, 13);
            this.label_angle.TabIndex = 14;
            this.label_angle.Text = "Угол поворота";
            this.label_angle.Visible = false;
            // 
            // textBox_angle
            // 
            this.textBox_angle.Location = new System.Drawing.Point(78, 256);
            this.textBox_angle.Name = "textBox_angle";
            this.textBox_angle.Size = new System.Drawing.Size(32, 20);
            this.textBox_angle.TabIndex = 15;
            this.textBox_angle.Visible = false;
            // 
            // label_location_random_point
            // 
            this.label_location_random_point.AutoSize = true;
            this.label_location_random_point.Location = new System.Drawing.Point(624, 12);
            this.label_location_random_point.Name = "label_location_random_point";
            this.label_location_random_point.Size = new System.Drawing.Size(35, 13);
            this.label_location_random_point.TabIndex = 16;
            this.label_location_random_point.Text = "label2";
            this.label_location_random_point.Visible = false;
            // 
            // comboBox_actions_line
            // 
            this.comboBox_actions_line.FormattingEnabled = true;
            this.comboBox_actions_line.Location = new System.Drawing.Point(4, 314);
            this.comboBox_actions_line.Name = "comboBox_actions_line";
            this.comboBox_actions_line.Size = new System.Drawing.Size(179, 21);
            this.comboBox_actions_line.TabIndex = 17;
            this.comboBox_actions_line.SelectedIndexChanged += new System.EventHandler(this.comboBox_ations_line_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Действия с ребром";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_actions_line);
            this.Controls.Add(this.label_location_random_point);
            this.Controls.Add(this.textBox_angle);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.label_dY);
            this.Controls.Add(this.label_dX);
            this.Controls.Add(this.button_make_convert);
            this.Controls.Add(this.textBox_dY);
            this.Controls.Add(this.textBox_dX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_actions);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.group_choice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_choice.ResumeLayout(false);
            this.group_choice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox group_choice;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.RadioButton radioButton_square;
        private System.Windows.Forms.RadioButton radioButton_line;
        private System.Windows.Forms.RadioButton radioButton_dot;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.ComboBox comboBox_actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dX;
        private System.Windows.Forms.TextBox textBox_dY;
        private System.Windows.Forms.Button button_make_convert;
        private System.Windows.Forms.RadioButton radioButton_polygon;
        private System.Windows.Forms.Label label_dX;
        private System.Windows.Forms.Label label_dY;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.TextBox textBox_angle;
        private System.Windows.Forms.Label label_location_random_point;
        private System.Windows.Forms.ComboBox comboBox_actions_line;
        private System.Windows.Forms.Label label2;
    }
}


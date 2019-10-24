namespace CG_lab6
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
            this.pictureBox_3d_picture = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add_tetrahedron = new System.Windows.Forms.Button();
            this.comboBox_action = new System.Windows.Forms.ComboBox();
            this.label_action = new System.Windows.Forms.Label();
            this.textBox_coordinate_length = new System.Windows.Forms.TextBox();
            this.textBox_coordinate_Z = new System.Windows.Forms.TextBox();
            this.textBox_coordinate_Y = new System.Windows.Forms.TextBox();
            this.textBox_coordinate_X = new System.Windows.Forms.TextBox();
            this.label_coodrinates = new System.Windows.Forms.Label();
            this.label_coordinate_X = new System.Windows.Forms.Label();
            this.label_coordinate_Y = new System.Windows.Forms.Label();
            this.label_coordinate_Z = new System.Windows.Forms.Label();
            this.label_coordinate_length = new System.Windows.Forms.Label();
            this.textBox_delta_X = new System.Windows.Forms.TextBox();
            this.textBox_delta_Y = new System.Windows.Forms.TextBox();
            this.textBox_delta_Z = new System.Windows.Forms.TextBox();
            this.label_delta_X = new System.Windows.Forms.Label();
            this.label_delta_Y = new System.Windows.Forms.Label();
            this.label_delta_Z = new System.Windows.Forms.Label();
            this.button_action = new System.Windows.Forms.Button();
            this.label_axis = new System.Windows.Forms.Label();
            this.label_angle = new System.Windows.Forms.Label();
            this.textBox_axis = new System.Windows.Forms.TextBox();
            this.textBox_angle = new System.Windows.Forms.TextBox();
            this.label_x1_line = new System.Windows.Forms.Label();
            this.label_y1_line = new System.Windows.Forms.Label();
            this.label_z1_line = new System.Windows.Forms.Label();
            this.textBox_x1_line = new System.Windows.Forms.TextBox();
            this.textBox_y1_line = new System.Windows.Forms.TextBox();
            this.textBox_z1_line = new System.Windows.Forms.TextBox();
            this.label_x2_line = new System.Windows.Forms.Label();
            this.label_y2_line = new System.Windows.Forms.Label();
            this.label_z2_line = new System.Windows.Forms.Label();
            this.textBox_x2_line = new System.Windows.Forms.TextBox();
            this.textBox_y2_line = new System.Windows.Forms.TextBox();
            this.textBox_z2_line = new System.Windows.Forms.TextBox();
            this.button_draw_line = new System.Windows.Forms.Button();
            this.radioButton_perspect = new System.Windows.Forms.RadioButton();
            this.radioButton_ortogr = new System.Windows.Forms.RadioButton();
            this.textBox_proect_axis = new System.Windows.Forms.TextBox();
            this.label_proect_axis = new System.Windows.Forms.Label();
            this.button_project = new System.Windows.Forms.Button();
            this.button_apply_and_projection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3d_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_3d_picture
            // 
            this.pictureBox_3d_picture.Location = new System.Drawing.Point(239, 12);
            this.pictureBox_3d_picture.Name = "pictureBox_3d_picture";
            this.pictureBox_3d_picture.Size = new System.Drawing.Size(550, 550);
            this.pictureBox_3d_picture.TabIndex = 0;
            this.pictureBox_3d_picture.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 13);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(221, 45);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add_tetrahedron
            // 
            this.button_add_tetrahedron.Location = new System.Drawing.Point(12, 77);
            this.button_add_tetrahedron.Name = "button_add_tetrahedron";
            this.button_add_tetrahedron.Size = new System.Drawing.Size(220, 23);
            this.button_add_tetrahedron.TabIndex = 2;
            this.button_add_tetrahedron.Text = "Добавить тетраэдр";
            this.button_add_tetrahedron.UseVisualStyleBackColor = true;
            this.button_add_tetrahedron.Click += new System.EventHandler(this.button_add_tetrahedron_Click);
            // 
            // comboBox_action
            // 
            this.comboBox_action.FormattingEnabled = true;
            this.comboBox_action.Location = new System.Drawing.Point(5, 200);
            this.comboBox_action.Name = "comboBox_action";
            this.comboBox_action.Size = new System.Drawing.Size(229, 21);
            this.comboBox_action.TabIndex = 3;
            this.comboBox_action.SelectedIndexChanged += new System.EventHandler(this.comboBox_action_SelectedIndexChanged);
            // 
            // label_action
            // 
            this.label_action.AutoSize = true;
            this.label_action.Location = new System.Drawing.Point(82, 184);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(57, 13);
            this.label_action.TabIndex = 4;
            this.label_action.Text = "Действие";
            // 
            // textBox_coordinate_length
            // 
            this.textBox_coordinate_length.Location = new System.Drawing.Point(180, 161);
            this.textBox_coordinate_length.Name = "textBox_coordinate_length";
            this.textBox_coordinate_length.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_length.TabIndex = 5;
            // 
            // textBox_coordinate_Z
            // 
            this.textBox_coordinate_Z.Location = new System.Drawing.Point(124, 161);
            this.textBox_coordinate_Z.Name = "textBox_coordinate_Z";
            this.textBox_coordinate_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Z.TabIndex = 6;
            // 
            // textBox_coordinate_Y
            // 
            this.textBox_coordinate_Y.Location = new System.Drawing.Point(68, 161);
            this.textBox_coordinate_Y.Name = "textBox_coordinate_Y";
            this.textBox_coordinate_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Y.TabIndex = 7;
            // 
            // textBox_coordinate_X
            // 
            this.textBox_coordinate_X.Location = new System.Drawing.Point(12, 161);
            this.textBox_coordinate_X.Name = "textBox_coordinate_X";
            this.textBox_coordinate_X.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_X.TabIndex = 8;
            // 
            // label_coodrinates
            // 
            this.label_coodrinates.AutoSize = true;
            this.label_coodrinates.Location = new System.Drawing.Point(39, 121);
            this.label_coodrinates.Name = "label_coodrinates";
            this.label_coodrinates.Size = new System.Drawing.Size(171, 13);
            this.label_coodrinates.TabIndex = 9;
            this.label_coodrinates.Text = "Введите начальные координаты";
            // 
            // label_coordinate_X
            // 
            this.label_coordinate_X.AutoSize = true;
            this.label_coordinate_X.Location = new System.Drawing.Point(29, 145);
            this.label_coordinate_X.Name = "label_coordinate_X";
            this.label_coordinate_X.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_X.TabIndex = 10;
            this.label_coordinate_X.Text = "X";
            // 
            // label_coordinate_Y
            // 
            this.label_coordinate_Y.AutoSize = true;
            this.label_coordinate_Y.Location = new System.Drawing.Point(82, 145);
            this.label_coordinate_Y.Name = "label_coordinate_Y";
            this.label_coordinate_Y.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_Y.TabIndex = 11;
            this.label_coordinate_Y.Text = "Y";
            // 
            // label_coordinate_Z
            // 
            this.label_coordinate_Z.AutoSize = true;
            this.label_coordinate_Z.Location = new System.Drawing.Point(130, 145);
            this.label_coordinate_Z.Name = "label_coordinate_Z";
            this.label_coordinate_Z.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_Z.TabIndex = 12;
            this.label_coordinate_Z.Text = "Z";
            // 
            // label_coordinate_length
            // 
            this.label_coordinate_length.AutoSize = true;
            this.label_coordinate_length.Location = new System.Drawing.Point(177, 145);
            this.label_coordinate_length.Name = "label_coordinate_length";
            this.label_coordinate_length.Size = new System.Drawing.Size(40, 13);
            this.label_coordinate_length.TabIndex = 13;
            this.label_coordinate_length.Text = "Длина";
            // 
            // textBox_delta_X
            // 
            this.textBox_delta_X.Location = new System.Drawing.Point(8, 294);
            this.textBox_delta_X.Name = "textBox_delta_X";
            this.textBox_delta_X.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_X.TabIndex = 14;
            this.textBox_delta_X.Visible = false;
            // 
            // textBox_delta_Y
            // 
            this.textBox_delta_Y.Location = new System.Drawing.Point(97, 294);
            this.textBox_delta_Y.Name = "textBox_delta_Y";
            this.textBox_delta_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_Y.TabIndex = 15;
            this.textBox_delta_Y.Visible = false;
            // 
            // textBox_delta_Z
            // 
            this.textBox_delta_Z.Location = new System.Drawing.Point(183, 294);
            this.textBox_delta_Z.Name = "textBox_delta_Z";
            this.textBox_delta_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_Z.TabIndex = 16;
            this.textBox_delta_Z.Visible = false;
            // 
            // label_delta_X
            // 
            this.label_delta_X.AutoSize = true;
            this.label_delta_X.Location = new System.Drawing.Point(12, 278);
            this.label_delta_X.Name = "label_delta_X";
            this.label_delta_X.Size = new System.Drawing.Size(40, 13);
            this.label_delta_X.TabIndex = 17;
            this.label_delta_X.Text = "delta X";
            this.label_delta_X.Visible = false;
            // 
            // label_delta_Y
            // 
            this.label_delta_Y.AutoSize = true;
            this.label_delta_Y.Location = new System.Drawing.Point(99, 278);
            this.label_delta_Y.Name = "label_delta_Y";
            this.label_delta_Y.Size = new System.Drawing.Size(40, 13);
            this.label_delta_Y.TabIndex = 18;
            this.label_delta_Y.Text = "delta Y";
            this.label_delta_Y.Visible = false;
            // 
            // label_delta_Z
            // 
            this.label_delta_Z.AutoSize = true;
            this.label_delta_Z.Location = new System.Drawing.Point(190, 278);
            this.label_delta_Z.Name = "label_delta_Z";
            this.label_delta_Z.Size = new System.Drawing.Size(40, 13);
            this.label_delta_Z.TabIndex = 19;
            this.label_delta_Z.Text = "delta Z";
            this.label_delta_Z.Visible = false;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(5, 223);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(227, 23);
            this.button_action.TabIndex = 20;
            this.button_action.Text = "Применить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label_axis
            // 
            this.label_axis.AutoSize = true;
            this.label_axis.Location = new System.Drawing.Point(38, 317);
            this.label_axis.Name = "label_axis";
            this.label_axis.Size = new System.Drawing.Size(27, 13);
            this.label_axis.TabIndex = 21;
            this.label_axis.Text = "Ось";
            this.label_axis.Visible = false;
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(156, 317);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(32, 13);
            this.label_angle.TabIndex = 22;
            this.label_angle.Text = "Угол";
            this.label_angle.Visible = false;
            // 
            // textBox_axis
            // 
            this.textBox_axis.Location = new System.Drawing.Point(6, 333);
            this.textBox_axis.Name = "textBox_axis";
            this.textBox_axis.Size = new System.Drawing.Size(100, 20);
            this.textBox_axis.TabIndex = 23;
            this.textBox_axis.Visible = false;
            // 
            // textBox_angle
            // 
            this.textBox_angle.Location = new System.Drawing.Point(133, 333);
            this.textBox_angle.Name = "textBox_angle";
            this.textBox_angle.Size = new System.Drawing.Size(100, 20);
            this.textBox_angle.TabIndex = 24;
            this.textBox_angle.Visible = false;
            // 
            // label_x1_line
            // 
            this.label_x1_line.AutoSize = true;
            this.label_x1_line.Location = new System.Drawing.Point(15, 356);
            this.label_x1_line.Name = "label_x1_line";
            this.label_x1_line.Size = new System.Drawing.Size(20, 13);
            this.label_x1_line.TabIndex = 25;
            this.label_x1_line.Text = "X1";
            this.label_x1_line.Visible = false;
            // 
            // label_y1_line
            // 
            this.label_y1_line.AutoSize = true;
            this.label_y1_line.Location = new System.Drawing.Point(101, 356);
            this.label_y1_line.Name = "label_y1_line";
            this.label_y1_line.Size = new System.Drawing.Size(20, 13);
            this.label_y1_line.TabIndex = 26;
            this.label_y1_line.Text = "Y1";
            this.label_y1_line.Visible = false;
            // 
            // label_z1_line
            // 
            this.label_z1_line.AutoSize = true;
            this.label_z1_line.Location = new System.Drawing.Point(193, 356);
            this.label_z1_line.Name = "label_z1_line";
            this.label_z1_line.Size = new System.Drawing.Size(20, 13);
            this.label_z1_line.TabIndex = 27;
            this.label_z1_line.Text = "Z1";
            this.label_z1_line.Visible = false;
            // 
            // textBox_x1_line
            // 
            this.textBox_x1_line.Location = new System.Drawing.Point(5, 372);
            this.textBox_x1_line.Name = "textBox_x1_line";
            this.textBox_x1_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_x1_line.TabIndex = 28;
            this.textBox_x1_line.Visible = false;
            // 
            // textBox_y1_line
            // 
            this.textBox_y1_line.Location = new System.Drawing.Point(88, 372);
            this.textBox_y1_line.Name = "textBox_y1_line";
            this.textBox_y1_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_y1_line.TabIndex = 29;
            this.textBox_y1_line.Visible = false;
            // 
            // textBox_z1_line
            // 
            this.textBox_z1_line.Location = new System.Drawing.Point(183, 372);
            this.textBox_z1_line.Name = "textBox_z1_line";
            this.textBox_z1_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_z1_line.TabIndex = 30;
            this.textBox_z1_line.Visible = false;
            // 
            // label_x2_line
            // 
            this.label_x2_line.AutoSize = true;
            this.label_x2_line.Location = new System.Drawing.Point(15, 404);
            this.label_x2_line.Name = "label_x2_line";
            this.label_x2_line.Size = new System.Drawing.Size(20, 13);
            this.label_x2_line.TabIndex = 31;
            this.label_x2_line.Text = "X2";
            this.label_x2_line.Visible = false;
            // 
            // label_y2_line
            // 
            this.label_y2_line.AutoSize = true;
            this.label_y2_line.Location = new System.Drawing.Point(102, 404);
            this.label_y2_line.Name = "label_y2_line";
            this.label_y2_line.Size = new System.Drawing.Size(20, 13);
            this.label_y2_line.TabIndex = 32;
            this.label_y2_line.Text = "Y2";
            this.label_y2_line.Visible = false;
            // 
            // label_z2_line
            // 
            this.label_z2_line.AutoSize = true;
            this.label_z2_line.Location = new System.Drawing.Point(193, 404);
            this.label_z2_line.Name = "label_z2_line";
            this.label_z2_line.Size = new System.Drawing.Size(20, 13);
            this.label_z2_line.TabIndex = 33;
            this.label_z2_line.Text = "Z2";
            this.label_z2_line.Visible = false;
            // 
            // textBox_x2_line
            // 
            this.textBox_x2_line.Location = new System.Drawing.Point(8, 420);
            this.textBox_x2_line.Name = "textBox_x2_line";
            this.textBox_x2_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_x2_line.TabIndex = 34;
            this.textBox_x2_line.Visible = false;
            // 
            // textBox_y2_line
            // 
            this.textBox_y2_line.Location = new System.Drawing.Point(88, 420);
            this.textBox_y2_line.Name = "textBox_y2_line";
            this.textBox_y2_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_y2_line.TabIndex = 35;
            this.textBox_y2_line.Visible = false;
            // 
            // textBox_z2_line
            // 
            this.textBox_z2_line.Location = new System.Drawing.Point(183, 420);
            this.textBox_z2_line.Name = "textBox_z2_line";
            this.textBox_z2_line.Size = new System.Drawing.Size(50, 20);
            this.textBox_z2_line.TabIndex = 36;
            this.textBox_z2_line.Visible = false;
            // 
            // button_draw_line
            // 
            this.button_draw_line.Location = new System.Drawing.Point(61, 446);
            this.button_draw_line.Name = "button_draw_line";
            this.button_draw_line.Size = new System.Drawing.Size(97, 23);
            this.button_draw_line.TabIndex = 37;
            this.button_draw_line.Text = "Нарисовать";
            this.button_draw_line.UseVisualStyleBackColor = true;
            this.button_draw_line.Visible = false;
            this.button_draw_line.Click += new System.EventHandler(this.button_draw_line_Click);
            // 
            // radioButton_perspect
            // 
            this.radioButton_perspect.AutoSize = true;
            this.radioButton_perspect.Location = new System.Drawing.Point(15, 471);
            this.radioButton_perspect.Name = "radioButton_perspect";
            this.radioButton_perspect.Size = new System.Drawing.Size(104, 17);
            this.radioButton_perspect.TabIndex = 38;
            this.radioButton_perspect.TabStop = true;
            this.radioButton_perspect.Text = "Перспективная";
            this.radioButton_perspect.UseVisualStyleBackColor = true;
            // 
            // radioButton_ortogr
            // 
            this.radioButton_ortogr.AutoSize = true;
            this.radioButton_ortogr.Location = new System.Drawing.Point(15, 494);
            this.radioButton_ortogr.Name = "radioButton_ortogr";
            this.radioButton_ortogr.Size = new System.Drawing.Size(119, 17);
            this.radioButton_ortogr.TabIndex = 40;
            this.radioButton_ortogr.TabStop = true;
            this.radioButton_ortogr.Text = "Ортографическая ";
            this.radioButton_ortogr.UseVisualStyleBackColor = true;
            // 
            // textBox_proect_axis
            // 
            this.textBox_proect_axis.Location = new System.Drawing.Point(149, 493);
            this.textBox_proect_axis.Name = "textBox_proect_axis";
            this.textBox_proect_axis.Size = new System.Drawing.Size(61, 20);
            this.textBox_proect_axis.TabIndex = 41;
            // 
            // label_proect_axis
            // 
            this.label_proect_axis.AutoSize = true;
            this.label_proect_axis.Location = new System.Drawing.Point(158, 475);
            this.label_proect_axis.Name = "label_proect_axis";
            this.label_proect_axis.Size = new System.Drawing.Size(27, 13);
            this.label_proect_axis.TabIndex = 42;
            this.label_proect_axis.Text = "Ось";
            // 
            // button_project
            // 
            this.button_project.Location = new System.Drawing.Point(61, 519);
            this.button_project.Name = "button_project";
            this.button_project.Size = new System.Drawing.Size(104, 23);
            this.button_project.TabIndex = 43;
            this.button_project.Text = "Спроецировать";
            this.button_project.UseVisualStyleBackColor = true;
            this.button_project.Click += new System.EventHandler(this.button_project_Click);
            // 
            // button_apply_and_projection
            // 
            this.button_apply_and_projection.Location = new System.Drawing.Point(42, 252);
            this.button_apply_and_projection.Name = "button_apply_and_projection";
            this.button_apply_and_projection.Size = new System.Drawing.Size(162, 23);
            this.button_apply_and_projection.TabIndex = 44;
            this.button_apply_and_projection.Text = "Применить и спроецировать";
            this.button_apply_and_projection.UseVisualStyleBackColor = true;
            this.button_apply_and_projection.Click += new System.EventHandler(this.button_apply_and_projection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.button_apply_and_projection);
            this.Controls.Add(this.button_project);
            this.Controls.Add(this.label_proect_axis);
            this.Controls.Add(this.textBox_proect_axis);
            this.Controls.Add(this.radioButton_ortogr);
            this.Controls.Add(this.radioButton_perspect);
            this.Controls.Add(this.button_draw_line);
            this.Controls.Add(this.textBox_z2_line);
            this.Controls.Add(this.textBox_y2_line);
            this.Controls.Add(this.textBox_x2_line);
            this.Controls.Add(this.label_z2_line);
            this.Controls.Add(this.label_y2_line);
            this.Controls.Add(this.label_x2_line);
            this.Controls.Add(this.textBox_z1_line);
            this.Controls.Add(this.textBox_y1_line);
            this.Controls.Add(this.textBox_x1_line);
            this.Controls.Add(this.label_z1_line);
            this.Controls.Add(this.label_y1_line);
            this.Controls.Add(this.label_x1_line);
            this.Controls.Add(this.textBox_angle);
            this.Controls.Add(this.textBox_axis);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.label_axis);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.label_delta_Z);
            this.Controls.Add(this.label_delta_Y);
            this.Controls.Add(this.label_delta_X);
            this.Controls.Add(this.textBox_delta_Z);
            this.Controls.Add(this.textBox_delta_Y);
            this.Controls.Add(this.textBox_delta_X);
            this.Controls.Add(this.label_coordinate_length);
            this.Controls.Add(this.label_coordinate_Z);
            this.Controls.Add(this.label_coordinate_Y);
            this.Controls.Add(this.label_coordinate_X);
            this.Controls.Add(this.label_coodrinates);
            this.Controls.Add(this.textBox_coordinate_X);
            this.Controls.Add(this.textBox_coordinate_Y);
            this.Controls.Add(this.textBox_coordinate_Z);
            this.Controls.Add(this.textBox_coordinate_length);
            this.Controls.Add(this.label_action);
            this.Controls.Add(this.comboBox_action);
            this.Controls.Add(this.button_add_tetrahedron);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pictureBox_3d_picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3d_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_3d_picture;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_add_tetrahedron;
        private System.Windows.Forms.ComboBox comboBox_action;
        private System.Windows.Forms.Label label_action;
        private System.Windows.Forms.TextBox textBox_coordinate_length;
        private System.Windows.Forms.TextBox textBox_coordinate_Z;
        private System.Windows.Forms.TextBox textBox_coordinate_Y;
        private System.Windows.Forms.TextBox textBox_coordinate_X;
        private System.Windows.Forms.Label label_coodrinates;
        private System.Windows.Forms.Label label_coordinate_X;
        private System.Windows.Forms.Label label_coordinate_Y;
        private System.Windows.Forms.Label label_coordinate_Z;
        private System.Windows.Forms.Label label_coordinate_length;
        private System.Windows.Forms.TextBox textBox_delta_X;
        private System.Windows.Forms.TextBox textBox_delta_Y;
        private System.Windows.Forms.TextBox textBox_delta_Z;
        private System.Windows.Forms.Label label_delta_X;
        private System.Windows.Forms.Label label_delta_Y;
        private System.Windows.Forms.Label label_delta_Z;
        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Label label_axis;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.TextBox textBox_axis;
        private System.Windows.Forms.TextBox textBox_angle;
        private System.Windows.Forms.Label label_x1_line;
        private System.Windows.Forms.Label label_y1_line;
        private System.Windows.Forms.Label label_z1_line;
        private System.Windows.Forms.TextBox textBox_x1_line;
        private System.Windows.Forms.TextBox textBox_y1_line;
        private System.Windows.Forms.TextBox textBox_z1_line;
        private System.Windows.Forms.Label label_x2_line;
        private System.Windows.Forms.Label label_y2_line;
        private System.Windows.Forms.Label label_z2_line;
        private System.Windows.Forms.TextBox textBox_x2_line;
        private System.Windows.Forms.TextBox textBox_y2_line;
        private System.Windows.Forms.TextBox textBox_z2_line;
        private System.Windows.Forms.Button button_draw_line;
        private System.Windows.Forms.RadioButton radioButton_perspect;
        private System.Windows.Forms.RadioButton radioButton_ortogr;
        private System.Windows.Forms.TextBox textBox_proect_axis;
        private System.Windows.Forms.Label label_proect_axis;
        private System.Windows.Forms.Button button_project;
        private System.Windows.Forms.Button button_apply_and_projection;
    }
}


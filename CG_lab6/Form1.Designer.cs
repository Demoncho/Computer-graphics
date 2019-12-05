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
            this.radioButton_izom = new System.Windows.Forms.RadioButton();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_rotation_figure = new System.Windows.Forms.Button();
            this.draw_segment = new System.Windows.Forms.Button();
            this.segment_x0 = new System.Windows.Forms.TextBox();
            this.segment_x1 = new System.Windows.Forms.TextBox();
            this.segment_range = new System.Windows.Forms.TextBox();
            this.button_add_cube = new System.Windows.Forms.Button();
            this.label_view = new System.Windows.Forms.Label();
            this.groupBox_from = new System.Windows.Forms.GroupBox();
            this.textBox_z1_from = new System.Windows.Forms.TextBox();
            this.textBox_y1_from = new System.Windows.Forms.TextBox();
            this.textBox_x1_from = new System.Windows.Forms.TextBox();
            this.groupBox_to = new System.Windows.Forms.GroupBox();
            this.textBox_z2_to = new System.Windows.Forms.TextBox();
            this.textBox_y2_to = new System.Windows.Forms.TextBox();
            this.textBox_x2_to = new System.Windows.Forms.TextBox();
            this.button_draw_view = new System.Windows.Forms.Button();
            this.button_delete_polygons = new System.Windows.Forms.Button();
            this.button_camera = new System.Windows.Forms.Button();
            this.z_bufer = new System.Windows.Forms.Button();
            this.add_cube_2 = new System.Windows.Forms.Button();
            this.button_add_light = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTexture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3d_picture)).BeginInit();
            this.groupBox_from.SuspendLayout();
            this.groupBox_to.SuspendLayout();
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
            this.button_add_tetrahedron.Location = new System.Drawing.Point(12, 66);
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
            this.textBox_coordinate_length.Text = "100";
            // 
            // textBox_coordinate_Z
            // 
            this.textBox_coordinate_Z.Location = new System.Drawing.Point(124, 161);
            this.textBox_coordinate_Z.Name = "textBox_coordinate_Z";
            this.textBox_coordinate_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Z.TabIndex = 6;
            this.textBox_coordinate_Z.Text = "-50";
            // 
            // textBox_coordinate_Y
            // 
            this.textBox_coordinate_Y.Location = new System.Drawing.Point(68, 161);
            this.textBox_coordinate_Y.Name = "textBox_coordinate_Y";
            this.textBox_coordinate_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Y.TabIndex = 7;
            this.textBox_coordinate_Y.Text = "-50";
            // 
            // textBox_coordinate_X
            // 
            this.textBox_coordinate_X.Location = new System.Drawing.Point(12, 161);
            this.textBox_coordinate_X.Name = "textBox_coordinate_X";
            this.textBox_coordinate_X.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_X.TabIndex = 8;
            this.textBox_coordinate_X.Text = "-50";
            // 
            // label_coodrinates
            // 
            this.label_coodrinates.AutoSize = true;
            this.label_coodrinates.Location = new System.Drawing.Point(38, 121);
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
            this.radioButton_perspect.Size = new System.Drawing.Size(111, 17);
            this.radioButton_perspect.TabIndex = 38;
            this.radioButton_perspect.TabStop = true;
            this.radioButton_perspect.Text = "Изометрическая";
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
            this.button_project.Location = new System.Drawing.Point(8, 539);
            this.button_project.Name = "button_project";
            this.button_project.Size = new System.Drawing.Size(100, 23);
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
            // radioButton_izom
            // 
            this.radioButton_izom.AutoSize = true;
            this.radioButton_izom.Location = new System.Drawing.Point(15, 517);
            this.radioButton_izom.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_izom.Name = "radioButton_izom";
            this.radioButton_izom.Size = new System.Drawing.Size(104, 17);
            this.radioButton_izom.TabIndex = 45;
            this.radioButton_izom.TabStop = true;
            this.radioButton_izom.Text = "Перспективная";
            this.radioButton_izom.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(266, 568);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 46;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(362, 568);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 47;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_rotation_figure
            // 
            this.button_rotation_figure.Location = new System.Drawing.Point(463, 568);
            this.button_rotation_figure.Name = "button_rotation_figure";
            this.button_rotation_figure.Size = new System.Drawing.Size(110, 23);
            this.button_rotation_figure.TabIndex = 48;
            this.button_rotation_figure.Text = "Фигура вращения";
            this.button_rotation_figure.UseVisualStyleBackColor = true;
            this.button_rotation_figure.Click += new System.EventHandler(this.button_rotation_figure_Click);
            // 
            // draw_segment
            // 
            this.draw_segment.Location = new System.Drawing.Point(631, 595);
            this.draw_segment.Name = "draw_segment";
            this.draw_segment.Size = new System.Drawing.Size(117, 35);
            this.draw_segment.TabIndex = 49;
            this.draw_segment.Text = "Нарисовать график 2 переменных";
            this.draw_segment.UseVisualStyleBackColor = true;
            this.draw_segment.Click += new System.EventHandler(this.draw_segment_Click);
            // 
            // segment_x0
            // 
            this.segment_x0.Location = new System.Drawing.Point(601, 568);
            this.segment_x0.Name = "segment_x0";
            this.segment_x0.Size = new System.Drawing.Size(54, 20);
            this.segment_x0.TabIndex = 50;
            // 
            // segment_x1
            // 
            this.segment_x1.Location = new System.Drawing.Point(661, 568);
            this.segment_x1.Name = "segment_x1";
            this.segment_x1.Size = new System.Drawing.Size(52, 20);
            this.segment_x1.TabIndex = 51;
            // 
            // segment_range
            // 
            this.segment_range.Location = new System.Drawing.Point(719, 568);
            this.segment_range.Name = "segment_range";
            this.segment_range.Size = new System.Drawing.Size(49, 20);
            this.segment_range.TabIndex = 52;
            // 
            // button_add_cube
            // 
            this.button_add_cube.Location = new System.Drawing.Point(12, 95);
            this.button_add_cube.Name = "button_add_cube";
            this.button_add_cube.Size = new System.Drawing.Size(220, 23);
            this.button_add_cube.TabIndex = 53;
            this.button_add_cube.Text = "Добавить куб";
            this.button_add_cube.UseVisualStyleBackColor = true;
            this.button_add_cube.Click += new System.EventHandler(this.button_add_cube_Click);
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.Location = new System.Drawing.Point(256, 619);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(82, 13);
            this.label_view.TabIndex = 54;
            this.label_view.Text = "Вектор обзора";
            // 
            // groupBox_from
            // 
            this.groupBox_from.Controls.Add(this.textBox_z1_from);
            this.groupBox_from.Controls.Add(this.textBox_y1_from);
            this.groupBox_from.Controls.Add(this.textBox_x1_from);
            this.groupBox_from.Location = new System.Drawing.Point(342, 597);
            this.groupBox_from.Name = "groupBox_from";
            this.groupBox_from.Size = new System.Drawing.Size(117, 44);
            this.groupBox_from.TabIndex = 55;
            this.groupBox_from.TabStop = false;
            this.groupBox_from.Text = "Начало";
            // 
            // textBox_z1_from
            // 
            this.textBox_z1_from.Location = new System.Drawing.Point(79, 19);
            this.textBox_z1_from.Name = "textBox_z1_from";
            this.textBox_z1_from.Size = new System.Drawing.Size(35, 20);
            this.textBox_z1_from.TabIndex = 2;
            // 
            // textBox_y1_from
            // 
            this.textBox_y1_from.Location = new System.Drawing.Point(41, 19);
            this.textBox_y1_from.Name = "textBox_y1_from";
            this.textBox_y1_from.Size = new System.Drawing.Size(35, 20);
            this.textBox_y1_from.TabIndex = 1;
            // 
            // textBox_x1_from
            // 
            this.textBox_x1_from.Location = new System.Drawing.Point(2, 19);
            this.textBox_x1_from.Name = "textBox_x1_from";
            this.textBox_x1_from.Size = new System.Drawing.Size(35, 20);
            this.textBox_x1_from.TabIndex = 0;
            // 
            // groupBox_to
            // 
            this.groupBox_to.Controls.Add(this.textBox_z2_to);
            this.groupBox_to.Controls.Add(this.textBox_y2_to);
            this.groupBox_to.Controls.Add(this.textBox_x2_to);
            this.groupBox_to.Location = new System.Drawing.Point(463, 597);
            this.groupBox_to.Name = "groupBox_to";
            this.groupBox_to.Size = new System.Drawing.Size(117, 44);
            this.groupBox_to.TabIndex = 56;
            this.groupBox_to.TabStop = false;
            this.groupBox_to.Text = "Конец";
            // 
            // textBox_z2_to
            // 
            this.textBox_z2_to.Location = new System.Drawing.Point(79, 19);
            this.textBox_z2_to.Name = "textBox_z2_to";
            this.textBox_z2_to.Size = new System.Drawing.Size(35, 20);
            this.textBox_z2_to.TabIndex = 2;
            // 
            // textBox_y2_to
            // 
            this.textBox_y2_to.Location = new System.Drawing.Point(41, 19);
            this.textBox_y2_to.Name = "textBox_y2_to";
            this.textBox_y2_to.Size = new System.Drawing.Size(35, 20);
            this.textBox_y2_to.TabIndex = 1;
            // 
            // textBox_x2_to
            // 
            this.textBox_x2_to.Location = new System.Drawing.Point(2, 19);
            this.textBox_x2_to.Name = "textBox_x2_to";
            this.textBox_x2_to.Size = new System.Drawing.Size(35, 20);
            this.textBox_x2_to.TabIndex = 0;
            // 
            // button_draw_view
            // 
            this.button_draw_view.Location = new System.Drawing.Point(344, 642);
            this.button_draw_view.Name = "button_draw_view";
            this.button_draw_view.Size = new System.Drawing.Size(112, 23);
            this.button_draw_view.TabIndex = 57;
            this.button_draw_view.Text = "Нарисовать обзор";
            this.button_draw_view.UseVisualStyleBackColor = true;
            this.button_draw_view.Click += new System.EventHandler(this.button_draw_view_Click);
            // 
            // button_delete_polygons
            // 
            this.button_delete_polygons.Location = new System.Drawing.Point(465, 642);
            this.button_delete_polygons.Name = "button_delete_polygons";
            this.button_delete_polygons.Size = new System.Drawing.Size(112, 23);
            this.button_delete_polygons.TabIndex = 58;
            this.button_delete_polygons.Text = "Убрать грани";
            this.button_delete_polygons.UseVisualStyleBackColor = true;
            this.button_delete_polygons.Click += new System.EventHandler(this.button_delete_polygons_Click);
            // 
            // button_camera
            // 
            this.button_camera.Location = new System.Drawing.Point(8, 565);
            this.button_camera.Name = "button_camera";
            this.button_camera.Size = new System.Drawing.Size(100, 23);
            this.button_camera.TabIndex = 59;
            this.button_camera.Text = "Задать камеру";
            this.button_camera.UseVisualStyleBackColor = true;
            this.button_camera.Click += new System.EventHandler(this.button_camera_Click);
            // 
            // z_bufer
            // 
            this.z_bufer.Location = new System.Drawing.Point(8, 623);
            this.z_bufer.Name = "z_bufer";
            this.z_bufer.Size = new System.Drawing.Size(100, 23);
            this.z_bufer.TabIndex = 59;
            this.z_bufer.Text = "Z-buffer";
            this.z_bufer.UseVisualStyleBackColor = true;
            this.z_bufer.Click += new System.EventHandler(this.z_bufer_Click);
            // 
            // add_cube_2
            // 
            this.add_cube_2.Location = new System.Drawing.Point(8, 594);
            this.add_cube_2.Name = "add_cube_2";
            this.add_cube_2.Size = new System.Drawing.Size(100, 23);
            this.add_cube_2.TabIndex = 60;
            this.add_cube_2.Text = "Добавить куб 2";
            this.add_cube_2.UseVisualStyleBackColor = true;
            this.add_cube_2.Click += new System.EventHandler(this.add_cube_2_Click);
            // 
            // button_add_light
            // 
            this.button_add_light.Location = new System.Drawing.Point(8, 652);
            this.button_add_light.Name = "button_add_light";
            this.button_add_light.Size = new System.Drawing.Size(100, 23);
            this.button_add_light.TabIndex = 61;
            this.button_add_light.Text = "Источник света";
            this.button_add_light.UseVisualStyleBackColor = true;
            this.button_add_light.Click += new System.EventHandler(this.button_add_light_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Горизонт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTexture
            // 
            this.buttonTexture.Location = new System.Drawing.Point(114, 539);
            this.buttonTexture.Name = "buttonTexture";
            this.buttonTexture.Size = new System.Drawing.Size(100, 23);
            this.buttonTexture.TabIndex = 63;
            this.buttonTexture.Text = "Текстура";
            this.buttonTexture.UseVisualStyleBackColor = true;
            this.buttonTexture.Click += new System.EventHandler(this.buttonTexture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 677);
            this.Controls.Add(this.buttonTexture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add_light);
            this.Controls.Add(this.button_camera);
            this.Controls.Add(this.add_cube_2);
            this.Controls.Add(this.z_bufer);
            this.Controls.Add(this.button_delete_polygons);
            this.Controls.Add(this.button_draw_view);
            this.Controls.Add(this.groupBox_to);
            this.Controls.Add(this.groupBox_from);
            this.Controls.Add(this.label_view);
            this.Controls.Add(this.button_add_cube);
            this.Controls.Add(this.segment_range);
            this.Controls.Add(this.segment_x1);
            this.Controls.Add(this.segment_x0);
            this.Controls.Add(this.draw_segment);
            this.Controls.Add(this.button_rotation_figure);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.radioButton_izom);
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
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3d_picture)).EndInit();
            this.groupBox_from.ResumeLayout(false);
            this.groupBox_from.PerformLayout();
            this.groupBox_to.ResumeLayout(false);
            this.groupBox_to.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton_izom;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_rotation_figure;
        private System.Windows.Forms.Button draw_segment;
        private System.Windows.Forms.TextBox segment_x0;
        private System.Windows.Forms.TextBox segment_x1;
        private System.Windows.Forms.TextBox segment_range;
        private System.Windows.Forms.Button button_add_cube;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.GroupBox groupBox_from;
        private System.Windows.Forms.TextBox textBox_z1_from;
        private System.Windows.Forms.TextBox textBox_y1_from;
        private System.Windows.Forms.TextBox textBox_x1_from;
        private System.Windows.Forms.GroupBox groupBox_to;
        private System.Windows.Forms.TextBox textBox_z2_to;
        private System.Windows.Forms.TextBox textBox_y2_to;
        private System.Windows.Forms.TextBox textBox_x2_to;
        private System.Windows.Forms.Button button_draw_view;
        private System.Windows.Forms.Button button_delete_polygons;
        private System.Windows.Forms.Button button_camera;
        private System.Windows.Forms.Button z_bufer;
        private System.Windows.Forms.Button add_cube_2;
        private System.Windows.Forms.Button button_add_light;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTexture;
    }
}


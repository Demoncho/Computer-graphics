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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3d_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_3d_picture
            // 
            this.pictureBox_3d_picture.Location = new System.Drawing.Point(239, 12);
            this.pictureBox_3d_picture.Name = "pictureBox_3d_picture";
            this.pictureBox_3d_picture.Size = new System.Drawing.Size(537, 540);
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
            this.comboBox_action.Location = new System.Drawing.Point(3, 229);
            this.comboBox_action.Name = "comboBox_action";
            this.comboBox_action.Size = new System.Drawing.Size(229, 21);
            this.comboBox_action.TabIndex = 3;
            this.comboBox_action.SelectedIndexChanged += new System.EventHandler(this.comboBox_action_SelectedIndexChanged);
            // 
            // label_action
            // 
            this.label_action.AutoSize = true;
            this.label_action.Location = new System.Drawing.Point(82, 213);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(57, 13);
            this.label_action.TabIndex = 4;
            this.label_action.Text = "Действие";
            // 
            // textBox_coordinate_length
            // 
            this.textBox_coordinate_length.Location = new System.Drawing.Point(180, 180);
            this.textBox_coordinate_length.Name = "textBox_coordinate_length";
            this.textBox_coordinate_length.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_length.TabIndex = 5;
            // 
            // textBox_coordinate_Z
            // 
            this.textBox_coordinate_Z.Location = new System.Drawing.Point(124, 180);
            this.textBox_coordinate_Z.Name = "textBox_coordinate_Z";
            this.textBox_coordinate_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Z.TabIndex = 6;
            // 
            // textBox_coordinate_Y
            // 
            this.textBox_coordinate_Y.Location = new System.Drawing.Point(68, 180);
            this.textBox_coordinate_Y.Name = "textBox_coordinate_Y";
            this.textBox_coordinate_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_coordinate_Y.TabIndex = 7;
            // 
            // textBox_coordinate_X
            // 
            this.textBox_coordinate_X.Location = new System.Drawing.Point(12, 180);
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
            this.label_coordinate_X.Location = new System.Drawing.Point(29, 161);
            this.label_coordinate_X.Name = "label_coordinate_X";
            this.label_coordinate_X.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_X.TabIndex = 10;
            this.label_coordinate_X.Text = "X";
            // 
            // label_coordinate_Y
            // 
            this.label_coordinate_Y.AutoSize = true;
            this.label_coordinate_Y.Location = new System.Drawing.Point(82, 161);
            this.label_coordinate_Y.Name = "label_coordinate_Y";
            this.label_coordinate_Y.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_Y.TabIndex = 11;
            this.label_coordinate_Y.Text = "Y";
            // 
            // label_coordinate_Z
            // 
            this.label_coordinate_Z.AutoSize = true;
            this.label_coordinate_Z.Location = new System.Drawing.Point(138, 161);
            this.label_coordinate_Z.Name = "label_coordinate_Z";
            this.label_coordinate_Z.Size = new System.Drawing.Size(14, 13);
            this.label_coordinate_Z.TabIndex = 12;
            this.label_coordinate_Z.Text = "Z";
            // 
            // label_coordinate_length
            // 
            this.label_coordinate_length.AutoSize = true;
            this.label_coordinate_length.Location = new System.Drawing.Point(177, 161);
            this.label_coordinate_length.Name = "label_coordinate_length";
            this.label_coordinate_length.Size = new System.Drawing.Size(40, 13);
            this.label_coordinate_length.TabIndex = 13;
            this.label_coordinate_length.Text = "Длина";
            // 
            // textBox_delta_X
            // 
            this.textBox_delta_X.Location = new System.Drawing.Point(3, 308);
            this.textBox_delta_X.Name = "textBox_delta_X";
            this.textBox_delta_X.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_X.TabIndex = 14;
            this.textBox_delta_X.Visible = false;
            // 
            // textBox_delta_Y
            // 
            this.textBox_delta_Y.Location = new System.Drawing.Point(89, 308);
            this.textBox_delta_Y.Name = "textBox_delta_Y";
            this.textBox_delta_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_Y.TabIndex = 15;
            this.textBox_delta_Y.Visible = false;
            // 
            // textBox_delta_Z
            // 
            this.textBox_delta_Z.Location = new System.Drawing.Point(180, 308);
            this.textBox_delta_Z.Name = "textBox_delta_Z";
            this.textBox_delta_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_delta_Z.TabIndex = 16;
            this.textBox_delta_Z.Visible = false;
            // 
            // label_delta_X
            // 
            this.label_delta_X.AutoSize = true;
            this.label_delta_X.Location = new System.Drawing.Point(13, 289);
            this.label_delta_X.Name = "label_delta_X";
            this.label_delta_X.Size = new System.Drawing.Size(40, 13);
            this.label_delta_X.TabIndex = 17;
            this.label_delta_X.Text = "delta X";
            this.label_delta_X.Visible = false;
            // 
            // label_delta_Y
            // 
            this.label_delta_Y.AutoSize = true;
            this.label_delta_Y.Location = new System.Drawing.Point(95, 289);
            this.label_delta_Y.Name = "label_delta_Y";
            this.label_delta_Y.Size = new System.Drawing.Size(40, 13);
            this.label_delta_Y.TabIndex = 18;
            this.label_delta_Y.Text = "delta Y";
            this.label_delta_Y.Visible = false;
            // 
            // label_delta_Z
            // 
            this.label_delta_Z.AutoSize = true;
            this.label_delta_Z.Location = new System.Drawing.Point(190, 289);
            this.label_delta_Z.Name = "label_delta_Z";
            this.label_delta_Z.Size = new System.Drawing.Size(40, 13);
            this.label_delta_Z.TabIndex = 19;
            this.label_delta_Z.Text = "delta Z";
            this.label_delta_Z.Visible = false;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(3, 263);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(227, 23);
            this.button_action.TabIndex = 20;
            this.button_action.Text = "Применить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 564);
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
    }
}


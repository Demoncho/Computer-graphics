namespace CG_lab6
{
    partial class Rotation_figure
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
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_points_list = new System.Windows.Forms.Label();
            this.label_axis = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.textBox_axis = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(32, 26);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(14, 13);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(85, 26);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 1;
            this.label_Y.Text = "Y";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(140, 26);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 2;
            this.label_Z.Text = "Z";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(12, 42);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(50, 20);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.Text = "0";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(68, 42);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(50, 20);
            this.textBox_Y.TabIndex = 4;
            this.textBox_Y.Text = "0";
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(124, 42);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(50, 20);
            this.textBox_Z.TabIndex = 5;
            this.textBox_Z.Text = "0";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 68);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить точку";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_points_list
            // 
            this.label_points_list.Location = new System.Drawing.Point(248, 9);
            this.label_points_list.Name = "label_points_list";
            this.label_points_list.Size = new System.Drawing.Size(117, 130);
            this.label_points_list.TabIndex = 7;
            // 
            // label_axis
            // 
            this.label_axis.AutoSize = true;
            this.label_axis.Location = new System.Drawing.Point(25, 107);
            this.label_axis.Name = "label_axis";
            this.label_axis.Size = new System.Drawing.Size(27, 13);
            this.label_axis.TabIndex = 8;
            this.label_axis.Text = "Ось";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(65, 107);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(62, 13);
            this.label_count.TabIndex = 9;
            this.label_count.Text = "Разбиений";
            // 
            // textBox_axis
            // 
            this.textBox_axis.Location = new System.Drawing.Point(12, 123);
            this.textBox_axis.Name = "textBox_axis";
            this.textBox_axis.Size = new System.Drawing.Size(50, 20);
            this.textBox_axis.TabIndex = 10;
            this.textBox_axis.Text = "X";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(74, 123);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(50, 20);
            this.textBox_count.TabIndex = 11;
            this.textBox_count.Text = "1";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(143, 116);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 12;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Rotation_figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 151);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_axis);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_axis);
            this.Controls.Add(this.label_points_list);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Name = "Rotation_figure";
            this.Text = "rotation_figure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_points_list;
        private System.Windows.Forms.Label label_axis;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox textBox_axis;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_create;
    }
}
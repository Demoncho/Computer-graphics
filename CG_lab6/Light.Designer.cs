namespace CG_lab6
{
    partial class Light
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_position = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.button_color = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(33, 13);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(152, 13);
            this.label_position.TabIndex = 0;
            this.label_position.Text = "Положение источника света";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(2, 35);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(50, 20);
            this.textBox_x.TabIndex = 1;
            this.textBox_x.Text = "0";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(58, 35);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(50, 20);
            this.textBox_y.TabIndex = 2;
            this.textBox_y.Text = "0";
            // 
            // textBox_z
            // 
            this.textBox_z.Location = new System.Drawing.Point(114, 35);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(50, 20);
            this.textBox_z.TabIndex = 3;
            this.textBox_z.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цвет объекта";
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(8, 98);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(100, 20);
            this.textBox_color.TabIndex = 5;
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(114, 98);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(75, 23);
            this.button_color.TabIndex = 6;
            this.button_color.Text = "Цвет";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(228, 72);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 7;
            this.button_create.Text = "Задать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 152);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.textBox_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_position);
            this.Name = "Light";
            this.Text = "Light";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_create;
    }
}
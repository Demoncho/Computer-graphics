namespace CG_lab6
{
    partial class Camera
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.z1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.z2 = new System.Windows.Forms.TextBox();
            this.button_create_camera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(12, 25);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(50, 20);
            this.x1.TabIndex = 0;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(68, 25);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(50, 20);
            this.y1.TabIndex = 1;
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(124, 25);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(50, 20);
            this.z1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Положение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Направление обзора";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(12, 64);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(50, 20);
            this.x2.TabIndex = 5;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(68, 64);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(50, 20);
            this.y2.TabIndex = 6;
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(124, 64);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(50, 20);
            this.z2.TabIndex = 7;
            // 
            // button_create_camera
            // 
            this.button_create_camera.Location = new System.Drawing.Point(56, 104);
            this.button_create_camera.Name = "button_create_camera";
            this.button_create_camera.Size = new System.Drawing.Size(75, 23);
            this.button_create_camera.TabIndex = 8;
            this.button_create_camera.Text = "Создать";
            this.button_create_camera.UseVisualStyleBackColor = true;
            this.button_create_camera.Click += new System.EventHandler(this.button_create_camera_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 162);
            this.Controls.Add(this.button_create_camera);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Name = "Camera";
            this.Text = "Camera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.Button button_create_camera;
    }
}
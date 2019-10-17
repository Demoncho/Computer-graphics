namespace CG_lab5
{
    partial class L_systems
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
            this.pictureBox_fractal = new System.Windows.Forms.PictureBox();
            this.button_choose_template = new System.Windows.Forms.Button();
            this.numericUpDown_generation = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fractal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_fractal
            // 
            this.pictureBox_fractal.Location = new System.Drawing.Point(12, 42);
            this.pictureBox_fractal.Name = "pictureBox_fractal";
            this.pictureBox_fractal.Size = new System.Drawing.Size(500, 515);
            this.pictureBox_fractal.TabIndex = 0;
            this.pictureBox_fractal.TabStop = false;
            // 
            // button_choose_template
            // 
            this.button_choose_template.Location = new System.Drawing.Point(13, 13);
            this.button_choose_template.Name = "button_choose_template";
            this.button_choose_template.Size = new System.Drawing.Size(110, 23);
            this.button_choose_template.TabIndex = 1;
            this.button_choose_template.Text = "Выбрать шаблон";
            this.button_choose_template.UseVisualStyleBackColor = true;
            this.button_choose_template.Click += new System.EventHandler(this.button_choose_template_Click);
            // 
            // numericUpDown_generation
            // 
            this.numericUpDown_generation.Location = new System.Drawing.Point(223, 16);
            this.numericUpDown_generation.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_generation.Name = "numericUpDown_generation";
            this.numericUpDown_generation.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown_generation.TabIndex = 2;
            this.numericUpDown_generation.ValueChanged += new System.EventHandler(this.numericUpDown_generation_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поколение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Location = new System.Drawing.Point(301, 18);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(74, 13);
            this.label_filename.TabIndex = 4;
            this.label_filename.Text = "label_filename";
            this.label_filename.Visible = false;
            // 
            // L_systems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 561);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_generation);
            this.Controls.Add(this.button_choose_template);
            this.Controls.Add(this.pictureBox_fractal);
            this.Name = "L_systems";
            this.Text = "L_systems";
            this.Load += new System.EventHandler(this.L_systems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fractal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_fractal;
        private System.Windows.Forms.Button button_choose_template;
        private System.Windows.Forms.NumericUpDown numericUpDown_generation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_filename;
    }
}
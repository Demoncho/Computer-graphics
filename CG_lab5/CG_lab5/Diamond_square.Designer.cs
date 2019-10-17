namespace CG_lab5
{
    partial class Diamond_square
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
            this.pictureBox_diamond = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_roughness = new System.Windows.Forms.TextBox();
            this.button_diamond_alg = new System.Windows.Forms.Button();
            this.button_clear_diamond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diamond)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_diamond
            // 
            this.pictureBox_diamond.Location = new System.Drawing.Point(12, 40);
            this.pictureBox_diamond.Name = "pictureBox_diamond";
            this.pictureBox_diamond.Size = new System.Drawing.Size(697, 508);
            this.pictureBox_diamond.TabIndex = 0;
            this.pictureBox_diamond.TabStop = false;
            this.pictureBox_diamond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_diamond_MouseDown);
            this.pictureBox_diamond.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_diamond_MouseMove);
            this.pictureBox_diamond.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_diamond_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шероховатость";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_roughness
            // 
            this.textBox_roughness.Location = new System.Drawing.Point(103, 14);
            this.textBox_roughness.Name = "textBox_roughness";
            this.textBox_roughness.Size = new System.Drawing.Size(100, 20);
            this.textBox_roughness.TabIndex = 2;
            // 
            // button_diamond_alg
            // 
            this.button_diamond_alg.Location = new System.Drawing.Point(245, 10);
            this.button_diamond_alg.Name = "button_diamond_alg";
            this.button_diamond_alg.Size = new System.Drawing.Size(75, 23);
            this.button_diamond_alg.TabIndex = 3;
            this.button_diamond_alg.Text = "Применить";
            this.button_diamond_alg.UseVisualStyleBackColor = true;
            this.button_diamond_alg.Click += new System.EventHandler(this.button_diamond_alg_Click);
            // 
            // button_clear_diamond
            // 
            this.button_clear_diamond.Location = new System.Drawing.Point(345, 10);
            this.button_clear_diamond.Name = "button_clear_diamond";
            this.button_clear_diamond.Size = new System.Drawing.Size(75, 23);
            this.button_clear_diamond.TabIndex = 4;
            this.button_clear_diamond.Text = "Очистить";
            this.button_clear_diamond.UseVisualStyleBackColor = true;
            this.button_clear_diamond.Click += new System.EventHandler(this.button_clear_diamond_Click);
            // 
            // Diamond_square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 560);
            this.Controls.Add(this.button_clear_diamond);
            this.Controls.Add(this.button_diamond_alg);
            this.Controls.Add(this.textBox_roughness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_diamond);
            this.Name = "Diamond_square";
            this.Text = "Diamond_square";
            this.Load += new System.EventHandler(this.Diamond_square_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_diamond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_diamond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_roughness;
        private System.Windows.Forms.Button button_diamond_alg;
        private System.Windows.Forms.Button button_clear_diamond;
    }
}
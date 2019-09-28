//namespace WindowsFormsApp2
namespace WindowsFormsApp2
{
    partial class Task1b
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
            this.image_for_filling = new System.Windows.Forms.PictureBox();
            this.choice_box = new System.Windows.Forms.GroupBox();
            this.draw_radioButton = new System.Windows.Forms.RadioButton();
            this.fill_radioButton = new System.Windows.Forms.RadioButton();
            this.image_to_draw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_for_filling)).BeginInit();
            this.choice_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_to_draw)).BeginInit();
            this.SuspendLayout();
            // 
            // image_for_filling
            // 
            this.image_for_filling.Location = new System.Drawing.Point(21, 142);
            this.image_for_filling.Margin = new System.Windows.Forms.Padding(2);
            this.image_for_filling.Name = "image_for_filling";
            this.image_for_filling.Size = new System.Drawing.Size(128, 107);
            this.image_for_filling.TabIndex = 3;
            this.image_for_filling.TabStop = false;
            this.image_for_filling.Visible = false;
            // 
            // choice_box
            // 
            this.choice_box.Controls.Add(this.draw_radioButton);
            this.choice_box.Controls.Add(this.fill_radioButton);
            this.choice_box.Location = new System.Drawing.Point(16, 295);
            this.choice_box.Margin = new System.Windows.Forms.Padding(2);
            this.choice_box.Name = "choice_box";
            this.choice_box.Padding = new System.Windows.Forms.Padding(2);
            this.choice_box.Size = new System.Drawing.Size(133, 65);
            this.choice_box.TabIndex = 6;
            this.choice_box.TabStop = false;
            this.choice_box.Visible = false;
            // 
            // draw_radioButton
            // 
            this.draw_radioButton.AutoSize = true;
            this.draw_radioButton.Checked = true;
            this.draw_radioButton.Location = new System.Drawing.Point(15, 36);
            this.draw_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.draw_radioButton.Name = "draw_radioButton";
            this.draw_radioButton.Size = new System.Drawing.Size(79, 17);
            this.draw_radioButton.TabIndex = 1;
            this.draw_radioButton.TabStop = true;
            this.draw_radioButton.Text = "Draw/Clear";
            this.draw_radioButton.UseVisualStyleBackColor = true;
            this.draw_radioButton.CheckedChanged += new System.EventHandler(this.draw_radioButton_check);
            // 
            // fill_radioButton
            // 
            this.fill_radioButton.AutoSize = true;
            this.fill_radioButton.Location = new System.Drawing.Point(15, 16);
            this.fill_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.fill_radioButton.Name = "fill_radioButton";
            this.fill_radioButton.Size = new System.Drawing.Size(37, 17);
            this.fill_radioButton.TabIndex = 0;
            this.fill_radioButton.Text = "Fill";
            this.fill_radioButton.UseVisualStyleBackColor = true;
            // 
            // image_to_draw
            // 
            this.image_to_draw.Location = new System.Drawing.Point(153, 0);
            this.image_to_draw.Margin = new System.Windows.Forms.Padding(2);
            this.image_to_draw.Name = "image_to_draw";
            this.image_to_draw.Size = new System.Drawing.Size(572, 481);
            this.image_to_draw.TabIndex = 7;
            this.image_to_draw.TabStop = false;
            this.image_to_draw.Click += new System.EventHandler(this.image_to_draw_Click);
            this.image_to_draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_to_draw_MouseClick);
            this.image_to_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_to_draw_MouseDown);
            this.image_to_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_to_draw_MouseMove);
            this.image_to_draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image_to_draw_MouseUp);
            // 
            // Task1b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 482);
            this.Controls.Add(this.image_to_draw);
            this.Controls.Add(this.choice_box);
            this.Controls.Add(this.image_for_filling);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Task1b";
            this.Text = "CG_lab3_1b";
            ((System.ComponentModel.ISupportInitialize)(this.image_for_filling)).EndInit();
            this.choice_box.ResumeLayout(false);
            this.choice_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_to_draw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox image_for_filling;
        private System.Windows.Forms.GroupBox choice_box;
        private System.Windows.Forms.RadioButton fill_radioButton;
        private System.Windows.Forms.RadioButton draw_radioButton;
        private System.Windows.Forms.PictureBox image_to_draw;
    }
}

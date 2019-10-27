namespace Fractals
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.render = new System.Windows.Forms.Button();
            this.ReBox = new System.Windows.Forms.TextBox();
            this.ImBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mandelSwitch = new System.Windows.Forms.RadioButton();
            this.juliaSwitch = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.zBox = new System.Windows.Forms.TextBox();
            this.randomBtn = new System.Windows.Forms.Button();
            this.defaultBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 479);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(375, 12);
            this.render.Name = "render";
            this.render.Size = new System.Drawing.Size(75, 49);
            this.render.TabIndex = 1;
            this.render.Text = "Render";
            this.render.UseVisualStyleBackColor = true;
            this.render.Click += new System.EventHandler(this.render_Click);
            // 
            // ReBox
            // 
            this.ReBox.Location = new System.Drawing.Point(551, 22);
            this.ReBox.Name = "ReBox";
            this.ReBox.ReadOnly = true;
            this.ReBox.Size = new System.Drawing.Size(69, 22);
            this.ReBox.TabIndex = 2;
            // 
            // ImBox
            // 
            this.ImBox.Location = new System.Drawing.Point(655, 22);
            this.ImBox.Name = "ImBox";
            this.ImBox.ReadOnly = true;
            this.ImBox.Size = new System.Drawing.Size(69, 22);
            this.ImBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "C=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "+ i";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(286, 25);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(69, 22);
            this.nBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "N=";
            // 
            // mandelSwitch
            // 
            this.mandelSwitch.AutoSize = true;
            this.mandelSwitch.Checked = true;
            this.mandelSwitch.Location = new System.Drawing.Point(12, 12);
            this.mandelSwitch.Name = "mandelSwitch";
            this.mandelSwitch.Size = new System.Drawing.Size(100, 21);
            this.mandelSwitch.TabIndex = 8;
            this.mandelSwitch.TabStop = true;
            this.mandelSwitch.Text = "Mandelbrot";
            this.mandelSwitch.UseVisualStyleBackColor = true;
            this.mandelSwitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mandelSwitch_MouseDown);
            // 
            // juliaSwitch
            // 
            this.juliaSwitch.AutoSize = true;
            this.juliaSwitch.Location = new System.Drawing.Point(12, 40);
            this.juliaSwitch.Name = "juliaSwitch";
            this.juliaSwitch.Size = new System.Drawing.Size(58, 21);
            this.juliaSwitch.TabIndex = 9;
            this.juliaSwitch.Text = "Julia";
            this.juliaSwitch.UseVisualStyleBackColor = true;
            this.juliaSwitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.juliaSwitch_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(147, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Z^";
            // 
            // zBox
            // 
            this.zBox.Location = new System.Drawing.Point(165, 12);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(32, 22);
            this.zBox.TabIndex = 10;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(737, 67);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 49);
            this.randomBtn.TabIndex = 12;
            this.randomBtn.Text = "Random C";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Visible = false;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // defaultBtn
            // 
            this.defaultBtn.Location = new System.Drawing.Point(737, 122);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(75, 49);
            this.defaultBtn.TabIndex = 13;
            this.defaultBtn.Text = "Default  C";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Visible = false;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 548);
            this.Controls.Add(this.defaultBtn);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.juliaSwitch);
            this.Controls.Add(this.mandelSwitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImBox);
            this.Controls.Add(this.ReBox);
            this.Controls.Add(this.render);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button render;
        private System.Windows.Forms.TextBox ReBox;
        private System.Windows.Forms.TextBox ImBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mandelSwitch;
        private System.Windows.Forms.RadioButton juliaSwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button defaultBtn;
    }
}


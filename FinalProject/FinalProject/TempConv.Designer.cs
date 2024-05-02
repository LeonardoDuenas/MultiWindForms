namespace FinalProject
{
    partial class TempConv
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
            this.btn_Cel_to_Far = new System.Windows.Forms.RadioButton();
            this.btn_Far_to_Cel = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cel_to_Far
            // 
            this.btn_Cel_to_Far.AutoSize = true;
            this.btn_Cel_to_Far.Location = new System.Drawing.Point(196, 31);
            this.btn_Cel_to_Far.Name = "btn_Cel_to_Far";
            this.btn_Cel_to_Far.Size = new System.Drawing.Size(104, 20);
            this.btn_Cel_to_Far.TabIndex = 0;
            this.btn_Cel_to_Far.TabStop = true;
            this.btn_Cel_to_Far.Text = "From C° to F°";
            this.btn_Cel_to_Far.UseVisualStyleBackColor = true;
            this.btn_Cel_to_Far.CheckedChanged += new System.EventHandler(this.btn_Cel_to_Far_CheckedChanged);
            // 
            // btn_Far_to_Cel
            // 
            this.btn_Far_to_Cel.AutoSize = true;
            this.btn_Far_to_Cel.Location = new System.Drawing.Point(196, 68);
            this.btn_Far_to_Cel.Name = "btn_Far_to_Cel";
            this.btn_Far_to_Cel.Size = new System.Drawing.Size(104, 20);
            this.btn_Far_to_Cel.TabIndex = 1;
            this.btn_Far_to_Cel.TabStop = true;
            this.btn_Far_to_Cel.Text = "From F° to C°";
            this.btn_Far_to_Cel.UseVisualStyleBackColor = true;
            this.btn_Far_to_Cel.CheckedChanged += new System.EventHandler(this.btn_Far_to_Cel_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // label_left
            // 
            this.label_left.AutoSize = true;
            this.label_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_left.Location = new System.Drawing.Point(104, 175);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(40, 29);
            this.label_left.TabIndex = 5;
            this.label_left.Text = "C°";
            // 
            // label_right
            // 
            this.label_right.AutoSize = true;
            this.label_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_right.Location = new System.Drawing.Point(349, 175);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(38, 29);
            this.label_right.TabIndex = 6;
            this.label_right.Text = "F°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(411, 22);
            this.textBox3.TabIndex = 8;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(40, 348);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(104, 35);
            this.btn_Convert.TabIndex = 9;
            this.btn_Convert.Text = "&Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(196, 348);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(104, 35);
            this.btn_Read.TabIndex = 10;
            this.btn_Read.Text = "&Read File";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(351, 348);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 35);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // TempConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 419);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Far_to_Cel);
            this.Controls.Add(this.btn_Cel_to_Far);
            this.Name = "TempConv";
            this.Text = "TempConv";
            this.Load += new System.EventHandler(this.TempConv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btn_Cel_to_Far;
        private System.Windows.Forms.RadioButton btn_Far_to_Cel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Exit;
    }
}
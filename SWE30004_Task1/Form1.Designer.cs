namespace SWE30004_Task1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_author = new System.Windows.Forms.Button();
            this.btn_intro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtbox_calc1 = new System.Windows.Forms.TextBox();
            this.txtbox_calc2 = new System.Windows.Forms.TextBox();
            this.btn_calc_add = new System.Windows.Forms.Button();
            this.btn_calc_sub = new System.Windows.Forms.Button();
            this.btn_calc_times = new System.Windows.Forms.Button();
            this.btn_calc_divide = new System.Windows.Forms.Button();
            this.btn_tqbf = new System.Windows.Forms.Button();
            this.txtbox_calc_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SWE30004 - Software Deployment and Evolution Task 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_author
            // 
            this.btn_author.Location = new System.Drawing.Point(373, 121);
            this.btn_author.Name = "btn_author";
            this.btn_author.Size = new System.Drawing.Size(75, 23);
            this.btn_author.TabIndex = 1;
            this.btn_author.Text = "Author";
            this.btn_author.UseVisualStyleBackColor = true;
            this.btn_author.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_intro
            // 
            this.btn_intro.Location = new System.Drawing.Point(63, 121);
            this.btn_intro.Name = "btn_intro";
            this.btn_intro.Size = new System.Drawing.Size(75, 23);
            this.btn_intro.TabIndex = 2;
            this.btn_intro.Text = "Introduction";
            this.btn_intro.UseVisualStyleBackColor = true;
            this.btn_intro.Click += new System.EventHandler(this.btn_intro_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(703, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Welcome to a very basic application made in C#. Click on the buttons below!";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(610, 121);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Click Count";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(691, 121);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 183);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(281, 25);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "The below requires DLLs.";
            // 
            // txtbox_calc1
            // 
            this.txtbox_calc1.Location = new System.Drawing.Point(279, 228);
            this.txtbox_calc1.Name = "txtbox_calc1";
            this.txtbox_calc1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_calc1.TabIndex = 7;
            // 
            // txtbox_calc2
            // 
            this.txtbox_calc2.Location = new System.Drawing.Point(432, 228);
            this.txtbox_calc2.Name = "txtbox_calc2";
            this.txtbox_calc2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_calc2.TabIndex = 8;
            // 
            // btn_calc_add
            // 
            this.btn_calc_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_add.Location = new System.Drawing.Point(242, 266);
            this.btn_calc_add.Name = "btn_calc_add";
            this.btn_calc_add.Size = new System.Drawing.Size(75, 23);
            this.btn_calc_add.TabIndex = 9;
            this.btn_calc_add.Text = "+";
            this.btn_calc_add.UseVisualStyleBackColor = true;
            this.btn_calc_add.Click += new System.EventHandler(this.btn_calc_add_Click);
            // 
            // btn_calc_sub
            // 
            this.btn_calc_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_sub.Location = new System.Drawing.Point(323, 266);
            this.btn_calc_sub.Name = "btn_calc_sub";
            this.btn_calc_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_calc_sub.TabIndex = 10;
            this.btn_calc_sub.Text = "-";
            this.btn_calc_sub.UseVisualStyleBackColor = true;
            this.btn_calc_sub.Click += new System.EventHandler(this.btn_calc_sub_Click);
            // 
            // btn_calc_times
            // 
            this.btn_calc_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_times.Location = new System.Drawing.Point(404, 266);
            this.btn_calc_times.Name = "btn_calc_times";
            this.btn_calc_times.Size = new System.Drawing.Size(75, 23);
            this.btn_calc_times.TabIndex = 11;
            this.btn_calc_times.Text = "X";
            this.btn_calc_times.UseVisualStyleBackColor = true;
            this.btn_calc_times.Click += new System.EventHandler(this.btn_calc_times_Click);
            // 
            // btn_calc_divide
            // 
            this.btn_calc_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_divide.Location = new System.Drawing.Point(485, 266);
            this.btn_calc_divide.Name = "btn_calc_divide";
            this.btn_calc_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_calc_divide.TabIndex = 12;
            this.btn_calc_divide.Text = "/";
            this.btn_calc_divide.UseVisualStyleBackColor = true;
            this.btn_calc_divide.Click += new System.EventHandler(this.btn_calc_divide_Click);
            // 
            // btn_tqbf
            // 
            this.btn_tqbf.Location = new System.Drawing.Point(373, 366);
            this.btn_tqbf.Name = "btn_tqbf";
            this.btn_tqbf.Size = new System.Drawing.Size(75, 23);
            this.btn_tqbf.TabIndex = 13;
            this.btn_tqbf.Text = "TQBF";
            this.btn_tqbf.UseVisualStyleBackColor = true;
            this.btn_tqbf.Click += new System.EventHandler(this.btn_tqbf_Click);
            // 
            // txtbox_calc_result
            // 
            this.txtbox_calc_result.Location = new System.Drawing.Point(63, 295);
            this.txtbox_calc_result.Multiline = true;
            this.txtbox_calc_result.Name = "txtbox_calc_result";
            this.txtbox_calc_result.ReadOnly = true;
            this.txtbox_calc_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_calc_result.Size = new System.Drawing.Size(703, 65);
            this.txtbox_calc_result.TabIndex = 14;
            this.txtbox_calc_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 401);
            this.Controls.Add(this.txtbox_calc_result);
            this.Controls.Add(this.btn_tqbf);
            this.Controls.Add(this.btn_calc_divide);
            this.Controls.Add(this.btn_calc_times);
            this.Controls.Add(this.btn_calc_sub);
            this.Controls.Add(this.btn_calc_add);
            this.Controls.Add(this.txtbox_calc2);
            this.Controls.Add(this.txtbox_calc1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_intro);
            this.Controls.Add(this.btn_author);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_author;
        private System.Windows.Forms.Button btn_intro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtbox_calc1;
        private System.Windows.Forms.TextBox txtbox_calc2;
        private System.Windows.Forms.Button btn_calc_add;
        private System.Windows.Forms.Button btn_calc_sub;
        private System.Windows.Forms.Button btn_calc_times;
        private System.Windows.Forms.Button btn_calc_divide;
        private System.Windows.Forms.Button btn_tqbf;
        private System.Windows.Forms.TextBox txtbox_calc_result;
    }
}



namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.board_picture = new System.Windows.Forms.PictureBox();
            this.X_A1 = new System.Windows.Forms.PictureBox();
            this.O_A1 = new System.Windows.Forms.PictureBox();
            this.X_A2 = new System.Windows.Forms.PictureBox();
            this.X_A3 = new System.Windows.Forms.PictureBox();
            this.X_B3 = new System.Windows.Forms.PictureBox();
            this.X_B2 = new System.Windows.Forms.PictureBox();
            this.X_B1 = new System.Windows.Forms.PictureBox();
            this.X_C1 = new System.Windows.Forms.PictureBox();
            this.X_C2 = new System.Windows.Forms.PictureBox();
            this.X_C3 = new System.Windows.Forms.PictureBox();
            this.O_A3 = new System.Windows.Forms.PictureBox();
            this.O_A2 = new System.Windows.Forms.PictureBox();
            this.O_B3 = new System.Windows.Forms.PictureBox();
            this.O_B2 = new System.Windows.Forms.PictureBox();
            this.O_B1 = new System.Windows.Forms.PictureBox();
            this.O_C1 = new System.Windows.Forms.PictureBox();
            this.O_C2 = new System.Windows.Forms.PictureBox();
            this.O_C3 = new System.Windows.Forms.PictureBox();
            this.turn_label = new System.Windows.Forms.Label();
            this.set_A3 = new System.Windows.Forms.Label();
            this.set_B3 = new System.Windows.Forms.Label();
            this.set_B2 = new System.Windows.Forms.Label();
            this.set_A2 = new System.Windows.Forms.Label();
            this.set_A1 = new System.Windows.Forms.Label();
            this.set_B1 = new System.Windows.Forms.Label();
            this.set_C1 = new System.Windows.Forms.Label();
            this.set_C2 = new System.Windows.Forms.Label();
            this.set_C3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset_button);
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Location = new System.Drawing.Point(1056, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(6, 72);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(126, 41);
            this.reset_button.TabIndex = 1;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(6, 22);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(126, 44);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // board_picture
            // 
            this.board_picture.Image = ((System.Drawing.Image)(resources.GetObject("board_picture.Image")));
            this.board_picture.Location = new System.Drawing.Point(85, 34);
            this.board_picture.Name = "board_picture";
            this.board_picture.Size = new System.Drawing.Size(756, 657);
            this.board_picture.TabIndex = 1;
            this.board_picture.TabStop = false;
            this.board_picture.Visible = false;
            // 
            // X_A1
            // 
            this.X_A1.Image = ((System.Drawing.Image)(resources.GetObject("X_A1.Image")));
            this.X_A1.Location = new System.Drawing.Point(174, 103);
            this.X_A1.Name = "X_A1";
            this.X_A1.Size = new System.Drawing.Size(98, 81);
            this.X_A1.TabIndex = 2;
            this.X_A1.TabStop = false;
            this.X_A1.Visible = false;
            // 
            // O_A1
            // 
            this.O_A1.Image = ((System.Drawing.Image)(resources.GetObject("O_A1.Image")));
            this.O_A1.Location = new System.Drawing.Point(161, 100);
            this.O_A1.Name = "O_A1";
            this.O_A1.Size = new System.Drawing.Size(134, 114);
            this.O_A1.TabIndex = 3;
            this.O_A1.TabStop = false;
            this.O_A1.Visible = false;
            // 
            // X_A2
            // 
            this.X_A2.Image = ((System.Drawing.Image)(resources.GetObject("X_A2.Image")));
            this.X_A2.Location = new System.Drawing.Point(428, 112);
            this.X_A2.Name = "X_A2";
            this.X_A2.Size = new System.Drawing.Size(98, 81);
            this.X_A2.TabIndex = 4;
            this.X_A2.TabStop = false;
            this.X_A2.Visible = false;
            // 
            // X_A3
            // 
            this.X_A3.Image = ((System.Drawing.Image)(resources.GetObject("X_A3.Image")));
            this.X_A3.Location = new System.Drawing.Point(668, 133);
            this.X_A3.Name = "X_A3";
            this.X_A3.Size = new System.Drawing.Size(98, 81);
            this.X_A3.TabIndex = 5;
            this.X_A3.TabStop = false;
            this.X_A3.Visible = false;
            // 
            // X_B3
            // 
            this.X_B3.Image = ((System.Drawing.Image)(resources.GetObject("X_B3.Image")));
            this.X_B3.Location = new System.Drawing.Point(668, 354);
            this.X_B3.Name = "X_B3";
            this.X_B3.Size = new System.Drawing.Size(98, 81);
            this.X_B3.TabIndex = 6;
            this.X_B3.TabStop = false;
            this.X_B3.Visible = false;
            // 
            // X_B2
            // 
            this.X_B2.Image = ((System.Drawing.Image)(resources.GetObject("X_B2.Image")));
            this.X_B2.Location = new System.Drawing.Point(439, 341);
            this.X_B2.Name = "X_B2";
            this.X_B2.Size = new System.Drawing.Size(98, 81);
            this.X_B2.TabIndex = 7;
            this.X_B2.TabStop = false;
            this.X_B2.Visible = false;
            // 
            // X_B1
            // 
            this.X_B1.Image = ((System.Drawing.Image)(resources.GetObject("X_B1.Image")));
            this.X_B1.Location = new System.Drawing.Point(174, 332);
            this.X_B1.Name = "X_B1";
            this.X_B1.Size = new System.Drawing.Size(98, 81);
            this.X_B1.TabIndex = 8;
            this.X_B1.TabStop = false;
            this.X_B1.Visible = false;
            // 
            // X_C1
            // 
            this.X_C1.Image = ((System.Drawing.Image)(resources.GetObject("X_C1.Image")));
            this.X_C1.Location = new System.Drawing.Point(184, 546);
            this.X_C1.Name = "X_C1";
            this.X_C1.Size = new System.Drawing.Size(98, 81);
            this.X_C1.TabIndex = 9;
            this.X_C1.TabStop = false;
            this.X_C1.Visible = false;
            // 
            // X_C2
            // 
            this.X_C2.Image = ((System.Drawing.Image)(resources.GetObject("X_C2.Image")));
            this.X_C2.Location = new System.Drawing.Point(428, 546);
            this.X_C2.Name = "X_C2";
            this.X_C2.Size = new System.Drawing.Size(98, 81);
            this.X_C2.TabIndex = 10;
            this.X_C2.TabStop = false;
            this.X_C2.Visible = false;
            // 
            // X_C3
            // 
            this.X_C3.Image = ((System.Drawing.Image)(resources.GetObject("X_C3.Image")));
            this.X_C3.Location = new System.Drawing.Point(632, 546);
            this.X_C3.Name = "X_C3";
            this.X_C3.Size = new System.Drawing.Size(98, 81);
            this.X_C3.TabIndex = 11;
            this.X_C3.TabStop = false;
            this.X_C3.Visible = false;
            // 
            // O_A3
            // 
            this.O_A3.Image = ((System.Drawing.Image)(resources.GetObject("O_A3.Image")));
            this.O_A3.Location = new System.Drawing.Point(632, 100);
            this.O_A3.Name = "O_A3";
            this.O_A3.Size = new System.Drawing.Size(134, 114);
            this.O_A3.TabIndex = 12;
            this.O_A3.TabStop = false;
            this.O_A3.Visible = false;
            // 
            // O_A2
            // 
            this.O_A2.Image = ((System.Drawing.Image)(resources.GetObject("O_A2.Image")));
            this.O_A2.Location = new System.Drawing.Point(403, 100);
            this.O_A2.Name = "O_A2";
            this.O_A2.Size = new System.Drawing.Size(134, 114);
            this.O_A2.TabIndex = 13;
            this.O_A2.TabStop = false;
            this.O_A2.Visible = false;
            // 
            // O_B3
            // 
            this.O_B3.Image = ((System.Drawing.Image)(resources.GetObject("O_B3.Image")));
            this.O_B3.Location = new System.Drawing.Point(632, 321);
            this.O_B3.Name = "O_B3";
            this.O_B3.Size = new System.Drawing.Size(134, 114);
            this.O_B3.TabIndex = 14;
            this.O_B3.TabStop = false;
            this.O_B3.Visible = false;
            // 
            // O_B2
            // 
            this.O_B2.Image = ((System.Drawing.Image)(resources.GetObject("O_B2.Image")));
            this.O_B2.Location = new System.Drawing.Point(403, 321);
            this.O_B2.Name = "O_B2";
            this.O_B2.Size = new System.Drawing.Size(134, 114);
            this.O_B2.TabIndex = 15;
            this.O_B2.TabStop = false;
            this.O_B2.Visible = false;
            // 
            // O_B1
            // 
            this.O_B1.Image = ((System.Drawing.Image)(resources.GetObject("O_B1.Image")));
            this.O_B1.Location = new System.Drawing.Point(161, 321);
            this.O_B1.Name = "O_B1";
            this.O_B1.Size = new System.Drawing.Size(134, 114);
            this.O_B1.TabIndex = 16;
            this.O_B1.TabStop = false;
            this.O_B1.Visible = false;
            // 
            // O_C1
            // 
            this.O_C1.Image = ((System.Drawing.Image)(resources.GetObject("O_C1.Image")));
            this.O_C1.Location = new System.Drawing.Point(161, 530);
            this.O_C1.Name = "O_C1";
            this.O_C1.Size = new System.Drawing.Size(134, 114);
            this.O_C1.TabIndex = 17;
            this.O_C1.TabStop = false;
            this.O_C1.Visible = false;
            // 
            // O_C2
            // 
            this.O_C2.Image = ((System.Drawing.Image)(resources.GetObject("O_C2.Image")));
            this.O_C2.Location = new System.Drawing.Point(403, 530);
            this.O_C2.Name = "O_C2";
            this.O_C2.Size = new System.Drawing.Size(134, 114);
            this.O_C2.TabIndex = 18;
            this.O_C2.TabStop = false;
            this.O_C2.Visible = false;
            // 
            // O_C3
            // 
            this.O_C3.Image = ((System.Drawing.Image)(resources.GetObject("O_C3.Image")));
            this.O_C3.Location = new System.Drawing.Point(632, 530);
            this.O_C3.Name = "O_C3";
            this.O_C3.Size = new System.Drawing.Size(134, 114);
            this.O_C3.TabIndex = 19;
            this.O_C3.TabStop = false;
            this.O_C3.Visible = false;
            // 
            // turn_label
            // 
            this.turn_label.AutoSize = true;
            this.turn_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.turn_label.ForeColor = System.Drawing.Color.Red;
            this.turn_label.Location = new System.Drawing.Point(934, 233);
            this.turn_label.Name = "turn_label";
            this.turn_label.Size = new System.Drawing.Size(112, 32);
            this.turn_label.TabIndex = 20;
            this.turn_label.Text = "Turn of: ";
            this.turn_label.Visible = false;
            // 
            // set_A3
            // 
            this.set_A3.AutoSize = true;
            this.set_A3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_A3.ForeColor = System.Drawing.Color.Blue;
            this.set_A3.Location = new System.Drawing.Point(632, 57);
            this.set_A3.Name = "set_A3";
            this.set_A3.Size = new System.Drawing.Size(74, 21);
            this.set_A3.TabIndex = 21;
            this.set_A3.Text = "Set Here";
            this.set_A3.Visible = false;
            this.set_A3.Click += new System.EventHandler(this.set_A3_Click);
            // 
            // set_B3
            // 
            this.set_B3.AutoSize = true;
            this.set_B3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_B3.ForeColor = System.Drawing.Color.Blue;
            this.set_B3.Location = new System.Drawing.Point(632, 274);
            this.set_B3.Name = "set_B3";
            this.set_B3.Size = new System.Drawing.Size(74, 21);
            this.set_B3.TabIndex = 22;
            this.set_B3.Text = "Set Here";
            this.set_B3.Visible = false;
            this.set_B3.Click += new System.EventHandler(this.set_B3_Click);
            // 
            // set_B2
            // 
            this.set_B2.AutoSize = true;
            this.set_B2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_B2.ForeColor = System.Drawing.Color.Blue;
            this.set_B2.Location = new System.Drawing.Point(392, 274);
            this.set_B2.Name = "set_B2";
            this.set_B2.Size = new System.Drawing.Size(74, 21);
            this.set_B2.TabIndex = 23;
            this.set_B2.Text = "Set Here";
            this.set_B2.Visible = false;
            this.set_B2.Click += new System.EventHandler(this.set_B2_Click);
            // 
            // set_A2
            // 
            this.set_A2.AutoSize = true;
            this.set_A2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_A2.ForeColor = System.Drawing.Color.Blue;
            this.set_A2.Location = new System.Drawing.Point(392, 57);
            this.set_A2.Name = "set_A2";
            this.set_A2.Size = new System.Drawing.Size(74, 21);
            this.set_A2.TabIndex = 24;
            this.set_A2.Text = "Set Here";
            this.set_A2.Visible = false;
            this.set_A2.Click += new System.EventHandler(this.set_A2_Click);
            // 
            // set_A1
            // 
            this.set_A1.AutoSize = true;
            this.set_A1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_A1.ForeColor = System.Drawing.Color.Blue;
            this.set_A1.Location = new System.Drawing.Point(108, 57);
            this.set_A1.Name = "set_A1";
            this.set_A1.Size = new System.Drawing.Size(74, 21);
            this.set_A1.TabIndex = 25;
            this.set_A1.Text = "Set Here";
            this.set_A1.Visible = false;
            this.set_A1.Click += new System.EventHandler(this.set_A1_Click);
            // 
            // set_B1
            // 
            this.set_B1.AutoSize = true;
            this.set_B1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_B1.ForeColor = System.Drawing.Color.Blue;
            this.set_B1.Location = new System.Drawing.Point(108, 274);
            this.set_B1.Name = "set_B1";
            this.set_B1.Size = new System.Drawing.Size(74, 21);
            this.set_B1.TabIndex = 26;
            this.set_B1.Text = "Set Here";
            this.set_B1.Visible = false;
            this.set_B1.Click += new System.EventHandler(this.set_B1_Click);
            // 
            // set_C1
            // 
            this.set_C1.AutoSize = true;
            this.set_C1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_C1.ForeColor = System.Drawing.Color.Blue;
            this.set_C1.Location = new System.Drawing.Point(108, 497);
            this.set_C1.Name = "set_C1";
            this.set_C1.Size = new System.Drawing.Size(74, 21);
            this.set_C1.TabIndex = 27;
            this.set_C1.Text = "Set Here";
            this.set_C1.Visible = false;
            this.set_C1.Click += new System.EventHandler(this.set_C1_Click);
            // 
            // set_C2
            // 
            this.set_C2.AutoSize = true;
            this.set_C2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_C2.ForeColor = System.Drawing.Color.Blue;
            this.set_C2.Location = new System.Drawing.Point(392, 497);
            this.set_C2.Name = "set_C2";
            this.set_C2.Size = new System.Drawing.Size(74, 21);
            this.set_C2.TabIndex = 28;
            this.set_C2.Text = "Set Here";
            this.set_C2.Visible = false;
            this.set_C2.Click += new System.EventHandler(this.set_C2_Click);
            // 
            // set_C3
            // 
            this.set_C3.AutoSize = true;
            this.set_C3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_C3.ForeColor = System.Drawing.Color.Blue;
            this.set_C3.Location = new System.Drawing.Point(632, 497);
            this.set_C3.Name = "set_C3";
            this.set_C3.Size = new System.Drawing.Size(74, 21);
            this.set_C3.TabIndex = 29;
            this.set_C3.Text = "Set Here";
            this.set_C3.Visible = false;
            this.set_C3.Click += new System.EventHandler(this.set_C3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1210, 788);
            this.Controls.Add(this.set_C3);
            this.Controls.Add(this.set_C2);
            this.Controls.Add(this.set_C1);
            this.Controls.Add(this.set_B1);
            this.Controls.Add(this.set_A1);
            this.Controls.Add(this.set_A2);
            this.Controls.Add(this.set_B2);
            this.Controls.Add(this.set_B3);
            this.Controls.Add(this.set_A3);
            this.Controls.Add(this.turn_label);
            this.Controls.Add(this.O_C3);
            this.Controls.Add(this.O_C2);
            this.Controls.Add(this.O_C1);
            this.Controls.Add(this.O_B1);
            this.Controls.Add(this.O_B2);
            this.Controls.Add(this.O_B3);
            this.Controls.Add(this.O_A2);
            this.Controls.Add(this.O_A3);
            this.Controls.Add(this.X_C3);
            this.Controls.Add(this.X_C2);
            this.Controls.Add(this.X_C1);
            this.Controls.Add(this.X_B1);
            this.Controls.Add(this.X_B2);
            this.Controls.Add(this.X_B3);
            this.Controls.Add(this.X_A3);
            this.Controls.Add(this.X_A2);
            this.Controls.Add(this.O_A1);
            this.Controls.Add(this.X_A1);
            this.Controls.Add(this.board_picture);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.board_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_C3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox board_picture;
        private System.Windows.Forms.PictureBox X_A1;
        private System.Windows.Forms.PictureBox O_A1;
        private System.Windows.Forms.PictureBox X_A2;
        private System.Windows.Forms.PictureBox X_A3;
        private System.Windows.Forms.PictureBox X_B3;
        private System.Windows.Forms.PictureBox X_B2;
        private System.Windows.Forms.PictureBox X_B1;
        private System.Windows.Forms.PictureBox X_C1;
        private System.Windows.Forms.PictureBox X_C2;
        private System.Windows.Forms.PictureBox X_C3;
        private System.Windows.Forms.PictureBox O_A3;
        private System.Windows.Forms.PictureBox O_A2;
        private System.Windows.Forms.PictureBox O_B3;
        private System.Windows.Forms.PictureBox O_B2;
        private System.Windows.Forms.PictureBox O_B1;
        private System.Windows.Forms.PictureBox O_C1;
        private System.Windows.Forms.PictureBox O_C2;
        private System.Windows.Forms.PictureBox O_C3;
        private System.Windows.Forms.Label turn_label;
        private System.Windows.Forms.Label set_A3;
        private System.Windows.Forms.Label set_B3;
        private System.Windows.Forms.Label set_B2;
        private System.Windows.Forms.Label set_A2;
        private System.Windows.Forms.Label set_A1;
        private System.Windows.Forms.Label set_B1;
        private System.Windows.Forms.Label set_C1;
        private System.Windows.Forms.Label set_C2;
        private System.Windows.Forms.Label set_C3;
    }
}


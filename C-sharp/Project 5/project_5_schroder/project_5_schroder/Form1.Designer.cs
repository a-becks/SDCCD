namespace project_5_schroder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnW = new System.Windows.Forms.Button();
            this.coordLabel = new System.Windows.Forms.Label();
            this.btnE = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(67, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wingdings", 8.25F);
            this.label1.Location = new System.Drawing.Point(80, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "F";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(181, 385);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(30, 28);
            this.btnW.TabIndex = 2;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // coordLabel
            // 
            this.coordLabel.AutoSize = true;
            this.coordLabel.Location = new System.Drawing.Point(93, 28);
            this.coordLabel.Name = "coordLabel";
            this.coordLabel.Size = new System.Drawing.Size(42, 17);
            this.coordLabel.TabIndex = 3;
            this.coordLabel.Text = "{0, 0}";
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(249, 385);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(30, 28);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(217, 351);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(30, 28);
            this.btnN.TabIndex = 5;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(217, 419);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(30, 28);
            this.btnS.TabIndex = 6;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(64, 379);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 7;
            this.btnOne.Text = "Go 1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(330, 379);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 8;
            this.btnTen.Text = "Go 10";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.coordLabel);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Robot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Label coordLabel;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnExit;
    }
}


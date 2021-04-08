namespace WindowsFormsApplication3
{
    partial class FormLevel2
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFINISH = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelDoor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelBlink1 = new System.Windows.Forms.Label();
            this.labelBlink2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(243, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(16, 357);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(507, -4);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(13, 452);
            this.label4.TabIndex = 10;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(-4, -3);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(524, 11);
            this.label3.TabIndex = 9;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(-4, -4);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(10, 452);
            this.label2.TabIndex = 8;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(-4, 435);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(524, 13);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // labelFINISH
            // 
            this.labelFINISH.BackColor = System.Drawing.Color.Firebrick;
            this.labelFINISH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFINISH.Location = new System.Drawing.Point(385, 41);
            this.labelFINISH.Name = "labelFINISH";
            this.labelFINISH.Size = new System.Drawing.Size(116, 45);
            this.labelFINISH.TabIndex = 13;
            this.labelFINISH.Text = "FINISH";
            this.labelFINISH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFINISH.Click += new System.EventHandler(this.labelFINISH_Click);
            this.labelFINISH.MouseEnter += new System.EventHandler(this.labelFINISH_MouseEnter);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.LightCoral;
            this.labelStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(12, 26);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(157, 45);
            this.labelStart.TabIndex = 12;
            this.labelStart.Text = "START";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // labelKey
            // 
            this.labelKey.BackColor = System.Drawing.Color.Gold;
            this.labelKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(282, 32);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(60, 32);
            this.labelKey.TabIndex = 14;
            this.labelKey.Text = "Ключ";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKey.Click += new System.EventHandler(this.labelKey_Click);
            this.labelKey.MouseEnter += new System.EventHandler(this.labelKey_MouseEnter);
            // 
            // labelDoor
            // 
            this.labelDoor.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoor.Location = new System.Drawing.Point(388, 326);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(113, 39);
            this.labelDoor.TabIndex = 15;
            this.labelDoor.Text = "Дверь";
            this.labelDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDoor.Click += new System.EventHandler(this.labelDoor_Click);
            this.labelDoor.MouseEnter += new System.EventHandler(this.labelDoor_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(363, 8);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(16, 357);
            this.label6.TabIndex = 16;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // labelBlink1
            // 
            this.labelBlink1.BackColor = System.Drawing.Color.Red;
            this.labelBlink1.Location = new System.Drawing.Point(232, 367);
            this.labelBlink1.Name = "labelBlink1";
            this.labelBlink1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBlink1.Size = new System.Drawing.Size(39, 74);
            this.labelBlink1.TabIndex = 17;
            this.labelBlink1.Click += new System.EventHandler(this.labelBlink1_Click);
            this.labelBlink1.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // labelBlink2
            // 
            this.labelBlink2.BackColor = System.Drawing.Color.Red;
            this.labelBlink2.Location = new System.Drawing.Point(277, 367);
            this.labelBlink2.Name = "labelBlink2";
            this.labelBlink2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBlink2.Size = new System.Drawing.Size(222, 26);
            this.labelBlink2.TabIndex = 18;
            this.labelBlink2.Click += new System.EventHandler(this.labelBlink2_Click);
            this.labelBlink2.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.labelBlink2);
            this.Controls.Add(this.labelBlink1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDoor);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelFINISH);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.Load += new System.EventHandler(this.FormLevel2_Load);
            this.Shown += new System.EventHandler(this.FormLevel2_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFINISH;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBlink1;
        private System.Windows.Forms.Label labelBlink2;
    }
}
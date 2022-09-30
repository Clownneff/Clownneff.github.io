namespace GiaoDien
{
    partial class GiaoDien
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
            this.pnl_red = new System.Windows.Forms.Panel();
            this.pnl_yellow = new System.Windows.Forms.Panel();
            this.pnl_green = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_pillar = new System.Windows.Forms.Panel();
            this.pnl_setup = new System.Windows.Forms.Panel();
            this.lbl_setting = new System.Windows.Forms.Label();
            this.pnl_pillar.SuspendLayout();
            this.pnl_setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_red
            // 
            this.pnl_red.BackColor = System.Drawing.Color.Red;
            this.pnl_red.Location = new System.Drawing.Point(28, 9);
            this.pnl_red.Name = "pnl_red";
            this.pnl_red.Size = new System.Drawing.Size(94, 85);
            this.pnl_red.TabIndex = 0;
            // 
            // pnl_yellow
            // 
            this.pnl_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pnl_yellow.Location = new System.Drawing.Point(28, 112);
            this.pnl_yellow.Name = "pnl_yellow";
            this.pnl_yellow.Size = new System.Drawing.Size(94, 85);
            this.pnl_yellow.TabIndex = 1;
            // 
            // pnl_green
            // 
            this.pnl_green.BackColor = System.Drawing.Color.Lime;
            this.pnl_green.Location = new System.Drawing.Point(28, 221);
            this.pnl_green.Name = "pnl_green";
            this.pnl_green.Size = new System.Drawing.Size(94, 85);
            this.pnl_green.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(45, 116);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 37);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(45, 188);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 37);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(44, 282);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(91, 37);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // pnl_pillar
            // 
            this.pnl_pillar.BackColor = System.Drawing.Color.Black;
            this.pnl_pillar.Controls.Add(this.pnl_red);
            this.pnl_pillar.Controls.Add(this.pnl_yellow);
            this.pnl_pillar.Controls.Add(this.pnl_green);
            this.pnl_pillar.Location = new System.Drawing.Point(361, 28);
            this.pnl_pillar.Name = "pnl_pillar";
            this.pnl_pillar.Size = new System.Drawing.Size(154, 327);
            this.pnl_pillar.TabIndex = 5;
            // 
            // pnl_setup
            // 
            this.pnl_setup.Controls.Add(this.lbl_setting);
            this.pnl_setup.Controls.Add(this.btn_start);
            this.pnl_setup.Controls.Add(this.btn_reset);
            this.pnl_setup.Controls.Add(this.btn_stop);
            this.pnl_setup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_setup.Location = new System.Drawing.Point(0, 0);
            this.pnl_setup.Name = "pnl_setup";
            this.pnl_setup.Size = new System.Drawing.Size(190, 494);
            this.pnl_setup.TabIndex = 6;
            // 
            // lbl_setting
            // 
            this.lbl_setting.AutoSize = true;
            this.lbl_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setting.Location = new System.Drawing.Point(39, 49);
            this.lbl_setting.Name = "lbl_setting";
            this.lbl_setting.Size = new System.Drawing.Size(112, 25);
            this.lbl_setting.TabIndex = 0;
            this.lbl_setting.Text = "Tuỳ Chỉnh";
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 494);
            this.Controls.Add(this.pnl_setup);
            this.Controls.Add(this.pnl_pillar);
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.pnl_pillar.ResumeLayout(false);
            this.pnl_setup.ResumeLayout(false);
            this.pnl_setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_red;
        private System.Windows.Forms.Panel pnl_yellow;
        private System.Windows.Forms.Panel pnl_green;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel pnl_pillar;
        private System.Windows.Forms.Panel pnl_setup;
        private System.Windows.Forms.Label lbl_setting;
    }
}


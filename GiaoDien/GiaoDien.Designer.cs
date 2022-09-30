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
            this.pnl_pillar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_red
            // 
            this.pnl_red.BackColor = System.Drawing.Color.Red;
            this.pnl_red.Location = new System.Drawing.Point(28, 26);
            this.pnl_red.Name = "pnl_red";
            this.pnl_red.Size = new System.Drawing.Size(94, 85);
            this.pnl_red.TabIndex = 0;
            // 
            // pnl_yellow
            // 
            this.pnl_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pnl_yellow.Location = new System.Drawing.Point(28, 141);
            this.pnl_yellow.Name = "pnl_yellow";
            this.pnl_yellow.Size = new System.Drawing.Size(94, 85);
            this.pnl_yellow.TabIndex = 1;
            // 
            // pnl_green
            // 
            this.pnl_green.BackColor = System.Drawing.Color.Lime;
            this.pnl_green.Location = new System.Drawing.Point(28, 260);
            this.pnl_green.Name = "pnl_green";
            this.pnl_green.Size = new System.Drawing.Size(94, 85);
            this.pnl_green.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(511, 61);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 37);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(512, 201);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 37);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(512, 391);
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
            this.pnl_pillar.Location = new System.Drawing.Point(93, 12);
            this.pnl_pillar.Name = "pnl_pillar";
            this.pnl_pillar.Size = new System.Drawing.Size(151, 368);
            this.pnl_pillar.TabIndex = 5;
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 494);
            this.Controls.Add(this.pnl_pillar);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.pnl_pillar.ResumeLayout(false);
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
    }
}


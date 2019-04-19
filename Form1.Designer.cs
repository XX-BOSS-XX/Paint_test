namespace Paint_quest_test
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_my_color = new System.Windows.Forms.Panel();
            this.btn_paint_color = new System.Windows.Forms.Button();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_step = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pos = new System.Windows.Forms.Label();
            this.lb_width = new System.Windows.Forms.Label();
            this.lb_step = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.pb_canvas = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.panel_my_color);
            this.panel_main.Controls.Add(this.btn_paint_color);
            this.panel_main.Controls.Add(this.tb_pos);
            this.panel_main.Controls.Add(this.tb_width);
            this.panel_main.Controls.Add(this.tb_step);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.lb_pos);
            this.panel_main.Controls.Add(this.lb_width);
            this.panel_main.Controls.Add(this.lb_step);
            this.panel_main.Controls.Add(this.btn_clean);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(200, 450);
            this.panel_main.TabIndex = 0;
            // 
            // panel_my_color
            // 
            this.panel_my_color.Location = new System.Drawing.Point(92, 138);
            this.panel_my_color.Name = "panel_my_color";
            this.panel_my_color.Size = new System.Drawing.Size(20, 20);
            this.panel_my_color.TabIndex = 5;
            // 
            // btn_paint_color
            // 
            this.btn_paint_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_paint_color.Location = new System.Drawing.Point(120, 137);
            this.btn_paint_color.Name = "btn_paint_color";
            this.btn_paint_color.Size = new System.Drawing.Size(70, 25);
            this.btn_paint_color.TabIndex = 4;
            this.btn_paint_color.Text = "Choose";
            this.btn_paint_color.UseVisualStyleBackColor = true;
            this.btn_paint_color.Click += new System.EventHandler(this.btn_paint_color_Click);
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(60, 112);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.ReadOnly = true;
            this.tb_pos.Size = new System.Drawing.Size(75, 20);
            this.tb_pos.TabIndex = 3;
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(60, 86);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(75, 20);
            this.tb_width.TabIndex = 2;
            // 
            // tb_step
            // 
            this.tb_step.Location = new System.Drawing.Point(60, 60);
            this.tb_step.MaxLength = 50;
            this.tb_step.Name = "tb_step";
            this.tb_step.Size = new System.Drawing.Size(75, 20);
            this.tb_step.TabIndex = 2;
            this.tb_step.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_step_KeyDown);
            this.tb_step.Validated += new System.EventHandler(this.tb_step_Validated);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paint color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_pos
            // 
            this.lb_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pos.Location = new System.Drawing.Point(9, 110);
            this.lb_pos.Name = "lb_pos";
            this.lb_pos.Size = new System.Drawing.Size(45, 23);
            this.lb_pos.TabIndex = 1;
            this.lb_pos.Text = "Pos:";
            this.lb_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_width
            // 
            this.lb_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_width.Location = new System.Drawing.Point(9, 84);
            this.lb_width.Name = "lb_width";
            this.lb_width.Size = new System.Drawing.Size(45, 23);
            this.lb_width.TabIndex = 1;
            this.lb_width.Text = "Width:";
            this.lb_width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_step
            // 
            this.lb_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_step.Location = new System.Drawing.Point(9, 58);
            this.lb_step.Name = "lb_step";
            this.lb_step.Size = new System.Drawing.Size(45, 23);
            this.lb_step.TabIndex = 1;
            this.lb_step.Text = "Step:";
            this.lb_step.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clean.Location = new System.Drawing.Point(12, 12);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(178, 30);
            this.btn_clean.TabIndex = 0;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // pb_canvas
            // 
            this.pb_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_canvas.Location = new System.Drawing.Point(218, 12);
            this.pb_canvas.Name = "pb_canvas";
            this.pb_canvas.Size = new System.Drawing.Size(500, 450);
            this.pb_canvas.TabIndex = 1;
            this.pb_canvas.TabStop = false;
            this.pb_canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_canvas_MouseClick);
            this.pb_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_canvas_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 474);
            this.Controls.Add(this.pb_canvas);
            this.Controls.Add(this.panel_main);
            this.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.MinimumSize = new System.Drawing.Size(750, 513);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pb_canvas;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_step;
        private System.Windows.Forms.Label lb_width;
        private System.Windows.Forms.Label lb_step;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.Label lb_pos;
        private System.Windows.Forms.Panel panel_my_color;
        private System.Windows.Forms.Button btn_paint_color;
        private System.Windows.Forms.Label label1;
    }
}


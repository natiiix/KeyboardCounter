namespace KeyboardCounter
{
    partial class FormMain
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
            this.labelCounter = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCounter.Font = new System.Drawing.Font("DejaVu Sans Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.ForeColor = System.Drawing.Color.Lime;
            this.labelCounter.Location = new System.Drawing.Point(0, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(240, 80);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "0";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseDown);
            this.labelCounter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseMove);
            this.labelCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseUp);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 500;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 80);
            this.Controls.Add(this.labelCounter);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Keyboard Counter";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelCounter_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Timer timerRefresh;
    }
}


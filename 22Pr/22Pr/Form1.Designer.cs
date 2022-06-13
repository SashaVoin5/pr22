
namespace _22Pr
{
    partial class Form_Moving
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
            this.pictureBox_Moving = new System.Windows.Forms.PictureBox();
            this.label_Define = new System.Windows.Forms.Label();
            this.label_Changing = new System.Windows.Forms.Label();
            this.label_Showing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Moving)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Moving
            // 
            this.pictureBox_Moving.Location = new System.Drawing.Point(1, 2);
            this.pictureBox_Moving.Name = "pictureBox_Moving";
            this.pictureBox_Moving.Size = new System.Drawing.Size(799, 447);
            this.pictureBox_Moving.TabIndex = 0;
            this.pictureBox_Moving.TabStop = false;
            this.pictureBox_Moving.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Moving_Paint);
            this.pictureBox_Moving.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Moving_MouseDown);
            this.pictureBox_Moving.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Moving_MouseMove);
            this.pictureBox_Moving.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Moving_MouseUp);
            // 
            // label_Define
            // 
            this.label_Define.AutoSize = true;
            this.label_Define.Location = new System.Drawing.Point(27, 401);
            this.label_Define.Name = "label_Define";
            this.label_Define.Size = new System.Drawing.Size(116, 15);
            this.label_Define.TabIndex = 1;
            this.label_Define.Text = "Узнать фигуру, цвет";
            // 
            // label_Changing
            // 
            this.label_Changing.AutoSize = true;
            this.label_Changing.Location = new System.Drawing.Point(352, 401);
            this.label_Changing.Name = "label_Changing";
            this.label_Changing.Size = new System.Drawing.Size(105, 15);
            this.label_Changing.TabIndex = 2;
            this.label_Changing.Text = "Поменять фигуру";
            // 
            // label_Showing
            // 
            this.label_Showing.AutoSize = true;
            this.label_Showing.Location = new System.Drawing.Point(630, 401);
            this.label_Showing.Name = "label_Showing";
            this.label_Showing.Size = new System.Drawing.Size(60, 15);
            this.label_Showing.TabIndex = 3;
            this.label_Showing.Text = "Результат";
            // 
            // Form_Moving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Showing);
            this.Controls.Add(this.label_Changing);
            this.Controls.Add(this.label_Define);
            this.Controls.Add(this.pictureBox_Moving);
            this.Name = "Form_Moving";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Moving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Moving;
        private System.Windows.Forms.Label label_Define;
        private System.Windows.Forms.Label label_Changing;
        private System.Windows.Forms.Label label_Showing;
    }
}


namespace WindowsFormsApplication1
{
    partial class AddTriangle
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
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSide3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.Location = new System.Drawing.Point(89, 44);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(64, 20);
            this.textBoxSide2.TabIndex = 13;
            this.textBoxSide2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Side 2";
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.Location = new System.Drawing.Point(89, 18);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(64, 20);
            this.textBoxSide1.TabIndex = 11;
            this.textBoxSide1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide1_KeyPress);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(46, 105);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(107, 23);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Side 1";
            // 
            // textBoxSide3
            // 
            this.textBoxSide3.Location = new System.Drawing.Point(89, 70);
            this.textBoxSide3.Name = "textBoxSide3";
            this.textBoxSide3.Size = new System.Drawing.Size(64, 20);
            this.textBoxSide3.TabIndex = 15;
            this.textBoxSide3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSide3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Side 3";
            // 
            // AddTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 140);
            this.Controls.Add(this.textBoxSide3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSide1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label1);
            this.Name = "AddTriangle";
            this.Text = "AddTriangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSide1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSide3;
        private System.Windows.Forms.Label label3;
    }
}
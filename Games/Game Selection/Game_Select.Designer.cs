namespace Game_Selection
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
            this.tictactoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tictactoe
            // 
            this.tictactoe.Location = new System.Drawing.Point(64, 93);
            this.tictactoe.Name = "tictactoe";
            this.tictactoe.Size = new System.Drawing.Size(200, 50);
            this.tictactoe.TabIndex = 0;
            this.tictactoe.Text = "Tic Tac Toe";
            this.tictactoe.UseVisualStyleBackColor = true;
            this.tictactoe.Click += new System.EventHandler(this.tictactoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tictactoe);
            this.Name = "Form1";
            this.Text = "Game Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tictactoe;
    }
}


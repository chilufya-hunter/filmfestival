
namespace Filmfestival.views
{
    partial class guestsigninview
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jurypasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.juryusernametextBox1 = new System.Windows.Forms.TextBox();
            this.cancelbutton2 = new System.Windows.Forms.Button();
            this.jurysigninbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "username";
            // 
            // jurypasswordtextBox2
            // 
            this.jurypasswordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurypasswordtextBox2.Location = new System.Drawing.Point(366, 187);
            this.jurypasswordtextBox2.Name = "jurypasswordtextBox2";
            this.jurypasswordtextBox2.Size = new System.Drawing.Size(100, 24);
            this.jurypasswordtextBox2.TabIndex = 10;
            // 
            // juryusernametextBox1
            // 
            this.juryusernametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juryusernametextBox1.Location = new System.Drawing.Point(366, 110);
            this.juryusernametextBox1.Name = "juryusernametextBox1";
            this.juryusernametextBox1.Size = new System.Drawing.Size(100, 24);
            this.juryusernametextBox1.TabIndex = 9;
            // 
            // cancelbutton2
            // 
            this.cancelbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton2.Location = new System.Drawing.Point(424, 298);
            this.cancelbutton2.Name = "cancelbutton2";
            this.cancelbutton2.Size = new System.Drawing.Size(113, 43);
            this.cancelbutton2.TabIndex = 8;
            this.cancelbutton2.Text = "cancel";
            this.cancelbutton2.UseVisualStyleBackColor = true;
            // 
            // jurysigninbutton1
            // 
            this.jurysigninbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurysigninbutton1.Location = new System.Drawing.Point(267, 298);
            this.jurysigninbutton1.Name = "jurysigninbutton1";
            this.jurysigninbutton1.Size = new System.Drawing.Size(102, 43);
            this.jurysigninbutton1.TabIndex = 7;
            this.jurysigninbutton1.Text = "signin";
            this.jurysigninbutton1.UseVisualStyleBackColor = true;
            // 
            // guestsigninview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jurypasswordtextBox2);
            this.Controls.Add(this.juryusernametextBox1);
            this.Controls.Add(this.cancelbutton2);
            this.Controls.Add(this.jurysigninbutton1);
            this.Name = "guestsigninview";
            this.Text = "guestsignin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jurypasswordtextBox2;
        private System.Windows.Forms.TextBox juryusernametextBox1;
        private System.Windows.Forms.Button cancelbutton2;
        private System.Windows.Forms.Button jurysigninbutton1;
    }
}
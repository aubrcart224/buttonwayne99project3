
namespace buttonwayne99project3
{
    partial class variablepractice
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
            this.hockey = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.carpet = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockey
            // 
            this.hockey.Location = new System.Drawing.Point(2, 12);
            this.hockey.Name = "hockey";
            this.hockey.Size = new System.Drawing.Size(75, 59);
            this.hockey.TabIndex = 0;
            this.hockey.Text = "Hockey";
            this.hockey.UseVisualStyleBackColor = true;
            this.hockey.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(2, 100);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(75, 68);
            this.Area.TabIndex = 1;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // carpet
            // 
            this.carpet.Location = new System.Drawing.Point(2, 201);
            this.carpet.Name = "carpet";
            this.carpet.Size = new System.Drawing.Size(75, 63);
            this.carpet.TabIndex = 2;
            this.carpet.Text = "Carpet";
            this.carpet.UseVisualStyleBackColor = true;
            this.carpet.Click += new System.EventHandler(this.carpet_Click);
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(2, 312);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(75, 73);
            this.bill.TabIndex = 3;
            this.bill.Text = "Bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label.Location = new System.Drawing.Point(152, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(389, 380);
            this.label.TabIndex = 4;
            // 
            // variablepractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.carpet);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.hockey);
            this.Name = "variablepractice";
            this.Text = "Variables Pratice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockey;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button carpet;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Label label;
    }
}


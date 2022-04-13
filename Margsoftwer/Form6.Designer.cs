namespace Margsoftwer
{
    partial class Form6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Rameshaver medical agency",
            "Krishana medical agency",
            "Vivek pharma",
            "Yogi pharma",
            "Amrut medical store",
            "Deep medical agency ",
            "Om medical agency",
            "Mihir pharma",
            "Aman medical store",
            "Bhavin pharma",
            "Dr K.P markande",
            "Dr Aman Dodera",
            "Dr Bhavin Gungariya",
            "Dr Mihir Kuvaradiya",
            "Dr Ankit Patel",
            "Dr Dhaval Chauhan",
            "Dr Viraj Chauhan",
            "Dr Manav Patel",
            "Dr Parth Tank",
            "Dr Priyank Chavala",
            "Dr Pratik Parmar",
            "Dr Vivek Jotangiya",
            "Dr JD Goswami",
            "Dr Deep Kanada",
            "Dr Vatsal Adhiyad",
            "Dr Vicky Sodha"});
            this.listBox1.Location = new System.Drawing.Point(144, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(832, 424);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 504);
            this.Controls.Add(this.listBox1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.SizeChanged += new System.EventHandler(this.Form6_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;



    }
}
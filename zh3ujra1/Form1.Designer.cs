namespace zh3ujra1
{
    partial class Form1
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
            panel1=new Panel();
            label2=new Label();
            label1=new Label();
            ügyfelekbttn=new Button();
            tudnivalókbttn=new Button();
            excelbttn=new Button();
            csomagokbttn=new Button();
            üzletbttn=new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ügyfelekbttn);
            panel1.Controls.Add(tudnivalókbttn);
            panel1.Controls.Add(excelbttn);
            panel1.Controls.Add(csomagokbttn);
            panel1.Controls.Add(üzletbttn);
            panel1.Dock=DockStyle.Fill;
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(846, 466);
            panel1.TabIndex=0;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 244);
            label2.Name="label2";
            label2.Size=new Size(78, 25);
            label2.TabIndex=6;
            label2.Text="Formok:";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 63);
            label1.Name="label1";
            label1.Size=new Size(130, 25);
            label1.TabIndex=5;
            label1.Text="UserControlok:";
            // 
            // ügyfelekbttn
            // 
            ügyfelekbttn.Location=new Point(12, 312);
            ügyfelekbttn.Name="ügyfelekbttn";
            ügyfelekbttn.Size=new Size(112, 34);
            ügyfelekbttn.TabIndex=4;
            ügyfelekbttn.Text="Ügyfelek";
            ügyfelekbttn.UseVisualStyleBackColor=true;
            ügyfelekbttn.Click+=ügyfelekbttn_Click;
            // 
            // tudnivalókbttn
            // 
            tudnivalókbttn.Location=new Point(12, 272);
            tudnivalókbttn.Name="tudnivalókbttn";
            tudnivalókbttn.Size=new Size(112, 34);
            tudnivalókbttn.TabIndex=3;
            tudnivalókbttn.Text="Tudnivalók";
            tudnivalókbttn.UseVisualStyleBackColor=true;
            tudnivalókbttn.Click+=tudnivalókbttn_Click;
            // 
            // excelbttn
            // 
            excelbttn.Location=new Point(12, 171);
            excelbttn.Name="excelbttn";
            excelbttn.Size=new Size(112, 34);
            excelbttn.TabIndex=2;
            excelbttn.Text="Excel";
            excelbttn.UseVisualStyleBackColor=true;
            excelbttn.Click+=excelbttn_Click;
            // 
            // csomagokbttn
            // 
            csomagokbttn.Location=new Point(12, 131);
            csomagokbttn.Name="csomagokbttn";
            csomagokbttn.Size=new Size(112, 34);
            csomagokbttn.TabIndex=1;
            csomagokbttn.Text="Csomagok";
            csomagokbttn.UseVisualStyleBackColor=true;
            csomagokbttn.Click+=csomagokbttn_Click;
            // 
            // üzletbttn
            // 
            üzletbttn.Location=new Point(12, 91);
            üzletbttn.Name="üzletbttn";
            üzletbttn.Size=new Size(112, 34);
            üzletbttn.TabIndex=0;
            üzletbttn.Text="Üzletek";
            üzletbttn.UseVisualStyleBackColor=true;
            üzletbttn.Click+=üzletbttn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(846, 466);
            Controls.Add(panel1);
            Name="Form1";
            Text="Form1";
            FormClosing+=Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button ügyfelekbttn;
        private Button tudnivalókbttn;
        private Button excelbttn;
        private Button csomagokbttn;
        private Button üzletbttn;
    }
}
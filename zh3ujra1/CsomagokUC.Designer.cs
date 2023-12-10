namespace zh3ujra1
{
    partial class CsomagokUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            csomaglistb=new ListBox();
            ártxtb=new TextBox();
            időttxtb=new TextBox();
            fizütxtb=new TextBox();
            csomagtxtb=new TextBox();
            SuspendLayout();
            // 
            // csomaglistb
            // 
            csomaglistb.FormattingEnabled=true;
            csomaglistb.ItemHeight=25;
            csomaglistb.Location=new Point(404, 99);
            csomaglistb.Name="csomaglistb";
            csomaglistb.Size=new Size(180, 129);
            csomaglistb.TabIndex=0;
            csomaglistb.SelectedIndexChanged+=csomaglistb_SelectedIndexChanged;
            // 
            // ártxtb
            // 
            ártxtb.Location=new Point(240, 99);
            ártxtb.Name="ártxtb";
            ártxtb.Size=new Size(150, 31);
            ártxtb.TabIndex=1;
            // 
            // időttxtb
            // 
            időttxtb.Location=new Point(240, 197);
            időttxtb.Name="időttxtb";
            időttxtb.Size=new Size(150, 31);
            időttxtb.TabIndex=2;
            // 
            // fizütxtb
            // 
            fizütxtb.Location=new Point(240, 147);
            fizütxtb.Name="fizütxtb";
            fizütxtb.Size=new Size(150, 31);
            fizütxtb.TabIndex=3;
            // 
            // csomagtxtb
            // 
            csomagtxtb.Location=new Point(404, 62);
            csomagtxtb.Name="csomagtxtb";
            csomagtxtb.Size=new Size(150, 31);
            csomagtxtb.TabIndex=4;
            csomagtxtb.TextChanged+=csomagtxtb_TextChanged;
            // 
            // CsomagokUC
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(csomagtxtb);
            Controls.Add(fizütxtb);
            Controls.Add(időttxtb);
            Controls.Add(ártxtb);
            Controls.Add(csomaglistb);
            Name="CsomagokUC";
            Size=new Size(630, 436);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomaglistb;
        private TextBox ártxtb;
        private TextBox időttxtb;
        private TextBox fizütxtb;
        private TextBox csomagtxtb;
    }
}

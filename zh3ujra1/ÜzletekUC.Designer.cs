namespace zh3ujra1
{
    partial class ÜzletekUC
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
            uzletlistb=new ListBox();
            uzlettxtb=new TextBox();
            helytxtb=new TextBox();
            tavalyivtxtb=new TextBox();
            mérettxtb=new TextBox();
            SuspendLayout();
            // 
            // uzletlistb
            // 
            uzletlistb.FormattingEnabled=true;
            uzletlistb.ItemHeight=25;
            uzletlistb.Location=new Point(537, 83);
            uzletlistb.Name="uzletlistb";
            uzletlistb.Size=new Size(180, 304);
            uzletlistb.TabIndex=0;
            uzletlistb.SelectedIndexChanged+=uzletlistb_SelectedIndexChanged;
            // 
            // uzlettxtb
            // 
            uzlettxtb.Location=new Point(537, 402);
            uzlettxtb.Name="uzlettxtb";
            uzlettxtb.Size=new Size(150, 31);
            uzlettxtb.TabIndex=1;
            uzlettxtb.TextChanged+=uzlettxtb_TextChanged;
            // 
            // helytxtb
            // 
            helytxtb.Location=new Point(347, 83);
            helytxtb.Name="helytxtb";
            helytxtb.Size=new Size(150, 31);
            helytxtb.TabIndex=2;
            // 
            // tavalyivtxtb
            // 
            tavalyivtxtb.Location=new Point(347, 229);
            tavalyivtxtb.Name="tavalyivtxtb";
            tavalyivtxtb.Size=new Size(150, 31);
            tavalyivtxtb.TabIndex=3;
            // 
            // mérettxtb
            // 
            mérettxtb.Location=new Point(347, 157);
            mérettxtb.Name="mérettxtb";
            mérettxtb.Size=new Size(150, 31);
            mérettxtb.TabIndex=4;
            // 
            // ÜzletekUC
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(mérettxtb);
            Controls.Add(tavalyivtxtb);
            Controls.Add(helytxtb);
            Controls.Add(uzlettxtb);
            Controls.Add(uzletlistb);
            Name="ÜzletekUC";
            Size=new Size(769, 490);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox uzletlistb;
        private TextBox uzlettxtb;
        private TextBox helytxtb;
        private TextBox tavalyivtxtb;
        private TextBox mérettxtb;
    }
}

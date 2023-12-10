namespace zh3ujra1
{
    partial class ExcelUC
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
            excelbttn=new Button();
            diagrambttn=new Button();
            SuspendLayout();
            // 
            // excelbttn
            // 
            excelbttn.Location=new Point(212, 184);
            excelbttn.Name="excelbttn";
            excelbttn.Size=new Size(171, 117);
            excelbttn.TabIndex=0;
            excelbttn.Text="Excel Gen.";
            excelbttn.UseVisualStyleBackColor=true;
            excelbttn.Click+=excelbttn_Click;
            // 
            // diagrambttn
            // 
            diagrambttn.Location=new Point(414, 184);
            diagrambttn.Name="diagrambttn";
            diagrambttn.Size=new Size(171, 117);
            diagrambttn.TabIndex=1;
            diagrambttn.Text="Diagram Gen.";
            diagrambttn.UseVisualStyleBackColor=true;
            diagrambttn.Click+=diagrambttn_Click;
            // 
            // ExcelUC
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(diagrambttn);
            Controls.Add(excelbttn);
            Name="ExcelUC";
            Size=new Size(683, 438);
            ResumeLayout(false);
        }

        #endregion

        private Button excelbttn;
        private Button diagrambttn;
    }
}

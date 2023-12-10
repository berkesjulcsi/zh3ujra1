namespace zh3ujra1
{
    partial class ÜgyfelekForm
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
            components=new System.ComponentModel.Container();
            csomaglistb=new ListBox();
            ügyféllistb=new ListBox();
            csomagtxtb=new TextBox();
            hozzáadtxtb=new TextBox();
            hozzáadbttn=new Button();
            törléstxtb=new Button();
            dataGridView1=new DataGridView();
            errorProvider1=new ErrorProvider(components);
            dataJelenBindingSource=new BindingSource(components);
            ügyfélIdDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            névDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            szülIdőDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            telSzámDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            bővíthetőeDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            percDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).BeginInit();
            SuspendLayout();
            // 
            // csomaglistb
            // 
            csomaglistb.FormattingEnabled=true;
            csomaglistb.ItemHeight=25;
            csomaglistb.Location=new Point(12, 71);
            csomaglistb.Name="csomaglistb";
            csomaglistb.Size=new Size(180, 379);
            csomaglistb.TabIndex=0;
            csomaglistb.SelectedIndexChanged+=csomaglistb_SelectedIndexChanged;
            // 
            // ügyféllistb
            // 
            ügyféllistb.FormattingEnabled=true;
            ügyféllistb.ItemHeight=25;
            ügyféllistb.Location=new Point(198, 71);
            ügyféllistb.Name="ügyféllistb";
            ügyféllistb.Size=new Size(180, 379);
            ügyféllistb.TabIndex=1;
            ügyféllistb.SelectedIndexChanged+=ügyféllistb_SelectedIndexChanged;
            // 
            // csomagtxtb
            // 
            csomagtxtb.Location=new Point(12, 34);
            csomagtxtb.Name="csomagtxtb";
            csomagtxtb.Size=new Size(150, 31);
            csomagtxtb.TabIndex=2;
            csomagtxtb.TextChanged+=csomagtxtb_TextChanged;
            // 
            // hozzáadtxtb
            // 
            hozzáadtxtb.Location=new Point(228, 456);
            hozzáadtxtb.Name="hozzáadtxtb";
            hozzáadtxtb.Size=new Size(150, 31);
            hozzáadtxtb.TabIndex=3;
            hozzáadtxtb.Validating+=hozzáadtxtb_Validating;
            hozzáadtxtb.Validated+=hozzáadtxtb_Validated;
            // 
            // hozzáadbttn
            // 
            hozzáadbttn.Location=new Point(80, 456);
            hozzáadbttn.Name="hozzáadbttn";
            hozzáadbttn.Size=new Size(112, 34);
            hozzáadbttn.TabIndex=4;
            hozzáadbttn.Text="+";
            hozzáadbttn.UseVisualStyleBackColor=true;
            hozzáadbttn.Click+=hozzáadbttn_Click;
            // 
            // törléstxtb
            // 
            törléstxtb.Location=new Point(384, 31);
            törléstxtb.Name="törléstxtb";
            törléstxtb.Size=new Size(112, 34);
            törléstxtb.TabIndex=5;
            törléstxtb.Text="-";
            törléstxtb.UseVisualStyleBackColor=true;
            törléstxtb.Click+=törléstxtb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns=false;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ügyfélIdDataGridViewTextBoxColumn, névDataGridViewTextBoxColumn, szülIdőDataGridViewTextBoxColumn, telSzámDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, bővíthetőeDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn, percDataGridViewTextBoxColumn });
            dataGridView1.DataSource=dataJelenBindingSource;
            dataGridView1.Location=new Point(384, 71);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=62;
            dataGridView1.RowTemplate.Height=33;
            dataGridView1.Size=new Size(490, 379);
            dataGridView1.TabIndex=6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl=this;
            // 
            // dataJelenBindingSource
            // 
            dataJelenBindingSource.DataSource=typeof(DataJelen);
            // 
            // ügyfélIdDataGridViewTextBoxColumn
            // 
            ügyfélIdDataGridViewTextBoxColumn.DataPropertyName="ÜgyfélId";
            ügyfélIdDataGridViewTextBoxColumn.HeaderText="ÜgyfélId";
            ügyfélIdDataGridViewTextBoxColumn.MinimumWidth=8;
            ügyfélIdDataGridViewTextBoxColumn.Name="ügyfélIdDataGridViewTextBoxColumn";
            ügyfélIdDataGridViewTextBoxColumn.Width=150;
            // 
            // névDataGridViewTextBoxColumn
            // 
            névDataGridViewTextBoxColumn.DataPropertyName="Név";
            névDataGridViewTextBoxColumn.HeaderText="Név";
            névDataGridViewTextBoxColumn.MinimumWidth=8;
            névDataGridViewTextBoxColumn.Name="névDataGridViewTextBoxColumn";
            névDataGridViewTextBoxColumn.Width=150;
            // 
            // szülIdőDataGridViewTextBoxColumn
            // 
            szülIdőDataGridViewTextBoxColumn.DataPropertyName="SzülIdő";
            szülIdőDataGridViewTextBoxColumn.HeaderText="SzülIdő";
            szülIdőDataGridViewTextBoxColumn.MinimumWidth=8;
            szülIdőDataGridViewTextBoxColumn.Name="szülIdőDataGridViewTextBoxColumn";
            szülIdőDataGridViewTextBoxColumn.Width=150;
            // 
            // telSzámDataGridViewTextBoxColumn
            // 
            telSzámDataGridViewTextBoxColumn.DataPropertyName="TelSzám";
            telSzámDataGridViewTextBoxColumn.HeaderText="TelSzám";
            telSzámDataGridViewTextBoxColumn.MinimumWidth=8;
            telSzámDataGridViewTextBoxColumn.Name="telSzámDataGridViewTextBoxColumn";
            telSzámDataGridViewTextBoxColumn.Width=150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName="Email";
            emailDataGridViewTextBoxColumn.HeaderText="Email";
            emailDataGridViewTextBoxColumn.MinimumWidth=8;
            emailDataGridViewTextBoxColumn.Name="emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width=150;
            // 
            // bővíthetőeDataGridViewTextBoxColumn
            // 
            bővíthetőeDataGridViewTextBoxColumn.DataPropertyName="Bővíthetőe";
            bővíthetőeDataGridViewTextBoxColumn.HeaderText="Bővíthetőe";
            bővíthetőeDataGridViewTextBoxColumn.MinimumWidth=8;
            bővíthetőeDataGridViewTextBoxColumn.Name="bővíthetőeDataGridViewTextBoxColumn";
            bővíthetőeDataGridViewTextBoxColumn.Width=150;
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName="Ár";
            árDataGridViewTextBoxColumn.HeaderText="Ár";
            árDataGridViewTextBoxColumn.MinimumWidth=8;
            árDataGridViewTextBoxColumn.Name="árDataGridViewTextBoxColumn";
            árDataGridViewTextBoxColumn.Width=150;
            // 
            // percDataGridViewTextBoxColumn
            // 
            percDataGridViewTextBoxColumn.DataPropertyName="Perc";
            percDataGridViewTextBoxColumn.HeaderText="Perc";
            percDataGridViewTextBoxColumn.MinimumWidth=8;
            percDataGridViewTextBoxColumn.Name="percDataGridViewTextBoxColumn";
            percDataGridViewTextBoxColumn.Width=150;
            // 
            // ÜgyfelekForm
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(886, 533);
            Controls.Add(dataGridView1);
            Controls.Add(törléstxtb);
            Controls.Add(hozzáadbttn);
            Controls.Add(hozzáadtxtb);
            Controls.Add(csomagtxtb);
            Controls.Add(ügyféllistb);
            Controls.Add(csomaglistb);
            Name="ÜgyfelekForm";
            Text="ÜgyfelekForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomaglistb;
        private ListBox ügyféllistb;
        private TextBox csomagtxtb;
        private TextBox hozzáadtxtb;
        private Button hozzáadbttn;
        private Button törléstxtb;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn ügyfélIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szülIdőDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telSzámDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bővíthetőeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percDataGridViewTextBoxColumn;
        private BindingSource dataJelenBindingSource;
    }
}
namespace TransportApp
{
    partial class TransportAppMainForm
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
            this.InputGbx = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StartStationLbl = new System.Windows.Forms.Label();
            this.StartStationTxt = new System.Windows.Forms.TextBox();
            this.EndStationLbl = new System.Windows.Forms.Label();
            this.EndStationTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConnactionsLbl = new System.Windows.Forms.Label();
            this.InputGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputGbx
            // 
            this.InputGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputGbx.Controls.Add(this.EndStationTxt);
            this.InputGbx.Controls.Add(this.EndStationLbl);
            this.InputGbx.Controls.Add(this.StartStationTxt);
            this.InputGbx.Controls.Add(this.StartStationLbl);
            this.InputGbx.Controls.Add(this.SearchBtn);
            this.InputGbx.Location = new System.Drawing.Point(12, 12);
            this.InputGbx.Name = "InputGbx";
            this.InputGbx.Size = new System.Drawing.Size(549, 51);
            this.InputGbx.TabIndex = 0;
            this.InputGbx.TabStop = false;
            this.InputGbx.Text = "Eingabe der Bedinungen:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(430, 22);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // StartStationLbl
            // 
            this.StartStationLbl.AutoSize = true;
            this.StartStationLbl.Location = new System.Drawing.Point(6, 26);
            this.StartStationLbl.Name = "StartStationLbl";
            this.StartStationLbl.Size = new System.Drawing.Size(70, 15);
            this.StartStationLbl.TabIndex = 1;
            this.StartStationLbl.Text = "Startstation:";
            // 
            // StartStationTxt
            // 
            this.StartStationTxt.Location = new System.Drawing.Point(82, 22);
            this.StartStationTxt.Name = "StartStationTxt";
            this.StartStationTxt.Size = new System.Drawing.Size(100, 23);
            this.StartStationTxt.TabIndex = 2;
            // 
            // EndStationLbl
            // 
            this.EndStationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndStationLbl.AutoSize = true;
            this.EndStationLbl.Location = new System.Drawing.Point(215, 26);
            this.EndStationLbl.Name = "EndStationLbl";
            this.EndStationLbl.Size = new System.Drawing.Size(66, 15);
            this.EndStationLbl.TabIndex = 3;
            this.EndStationLbl.Text = "Endstation:";
            // 
            // EndStationTxt
            // 
            this.EndStationTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndStationTxt.Location = new System.Drawing.Point(287, 22);
            this.EndStationTxt.Name = "EndStationTxt";
            this.EndStationTxt.Size = new System.Drawing.Size(100, 23);
            this.EndStationTxt.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(549, 348);
            this.dataGridView1.TabIndex = 1;
            // 
            // ConnactionsLbl
            // 
            this.ConnactionsLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConnactionsLbl.AutoSize = true;
            this.ConnactionsLbl.Location = new System.Drawing.Point(15, 72);
            this.ConnactionsLbl.Name = "ConnactionsLbl";
            this.ConnactionsLbl.Size = new System.Drawing.Size(84, 15);
            this.ConnactionsLbl.TabIndex = 2;
            this.ConnactionsLbl.Text = "Verbindungen:";
            // 
            // TransportAppMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.ConnactionsLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InputGbx);
            this.Name = "TransportAppMainForm";
            this.Text = "Transport App";
            this.InputGbx.ResumeLayout(false);
            this.InputGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox InputGbx;
        private TextBox EndStationTxt;
        private Label EndStationLbl;
        private TextBox StartStationTxt;
        private Label StartStationLbl;
        private Button SearchBtn;
        private DataGridView dataGridView1;
        private Label ConnactionsLbl;
    }
}
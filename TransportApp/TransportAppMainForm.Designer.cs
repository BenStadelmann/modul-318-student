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
            this.ArrivalTimeBool = new System.Windows.Forms.CheckBox();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.TimeDtp = new System.Windows.Forms.DateTimePicker();
            this.EndStationCbx = new System.Windows.Forms.ComboBox();
            this.StartStationCbx = new System.Windows.Forms.ComboBox();
            this.EndStationLbl = new System.Windows.Forms.Label();
            this.StartStationLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ConnectionsDgv = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnactionsLbl = new System.Windows.Forms.Label();
            this.InputGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // InputGbx
            // 
            this.InputGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputGbx.Controls.Add(this.ArrivalTimeBool);
            this.InputGbx.Controls.Add(this.TimeLbl);
            this.InputGbx.Controls.Add(this.TimeDtp);
            this.InputGbx.Controls.Add(this.EndStationCbx);
            this.InputGbx.Controls.Add(this.StartStationCbx);
            this.InputGbx.Controls.Add(this.EndStationLbl);
            this.InputGbx.Controls.Add(this.StartStationLbl);
            this.InputGbx.Controls.Add(this.SearchBtn);
            this.InputGbx.Location = new System.Drawing.Point(12, 12);
            this.InputGbx.Name = "InputGbx";
            this.InputGbx.Size = new System.Drawing.Size(540, 82);
            this.InputGbx.TabIndex = 0;
            this.InputGbx.TabStop = false;
            this.InputGbx.Text = "Eingabe der Bedinungen:";
            // 
            // ArrivalTimeBool
            // 
            this.ArrivalTimeBool.AutoSize = true;
            this.ArrivalTimeBool.Location = new System.Drawing.Point(241, 53);
            this.ArrivalTimeBool.Name = "ArrivalTimeBool";
            this.ArrivalTimeBool.Size = new System.Drawing.Size(92, 19);
            this.ArrivalTimeBool.TabIndex = 4;
            this.ArrivalTimeBool.Text = "Ankunftszeit";
            this.ArrivalTimeBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ArrivalTimeBool.UseVisualStyleBackColor = true;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(6, 57);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(30, 15);
            this.TimeLbl.TabIndex = 4;
            this.TimeLbl.Text = "Zeit:";
            // 
            // TimeDtp
            // 
            this.TimeDtp.Checked = false;
            this.TimeDtp.CustomFormat = "dd.MM.yy HH:mm";
            this.TimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeDtp.Location = new System.Drawing.Point(82, 51);
            this.TimeDtp.Name = "TimeDtp";
            this.TimeDtp.Size = new System.Drawing.Size(121, 23);
            this.TimeDtp.TabIndex = 3;
            // 
            // EndStationCbx
            // 
            this.EndStationCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndStationCbx.FormattingEnabled = true;
            this.EndStationCbx.Location = new System.Drawing.Point(313, 22);
            this.EndStationCbx.Name = "EndStationCbx";
            this.EndStationCbx.Size = new System.Drawing.Size(121, 23);
            this.EndStationCbx.TabIndex = 2;
            this.EndStationCbx.DropDown += new System.EventHandler(this.GetOffers);
            this.EndStationCbx.Leave += new System.EventHandler(this.SetRealStationNameInComboBox);
            // 
            // StartStationCbx
            // 
            this.StartStationCbx.FormattingEnabled = true;
            this.StartStationCbx.Location = new System.Drawing.Point(82, 22);
            this.StartStationCbx.Name = "StartStationCbx";
            this.StartStationCbx.Size = new System.Drawing.Size(121, 23);
            this.StartStationCbx.TabIndex = 1;
            this.StartStationCbx.DropDown += new System.EventHandler(this.GetOffers);
            this.StartStationCbx.Leave += new System.EventHandler(this.SetRealStationNameInComboBox);
            // 
            // EndStationLbl
            // 
            this.EndStationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndStationLbl.AutoSize = true;
            this.EndStationLbl.Location = new System.Drawing.Point(241, 26);
            this.EndStationLbl.Name = "EndStationLbl";
            this.EndStationLbl.Size = new System.Drawing.Size(66, 15);
            this.EndStationLbl.TabIndex = 3;
            this.EndStationLbl.Text = "Endstation:";
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
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(459, 22);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 50);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Suchen";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ConnectionsDgv
            // 
            this.ConnectionsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.Startstation,
            this.Platform,
            this.EndTime,
            this.Endstation});
            this.ConnectionsDgv.Location = new System.Drawing.Point(15, 128);
            this.ConnectionsDgv.Name = "ConnectionsDgv";
            this.ConnectionsDgv.RowTemplate.Height = 25;
            this.ConnectionsDgv.Size = new System.Drawing.Size(540, 428);
            this.ConnectionsDgv.TabIndex = 1;
            this.ConnectionsDgv.TabStop = false;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Abfahrtszeit ";
            this.StartTime.MinimumWidth = 30;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 98;
            // 
            // Startstation
            // 
            this.Startstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Startstation.DataPropertyName = "StartStation";
            this.Startstation.HeaderText = "Startstation";
            this.Startstation.MinimumWidth = 50;
            this.Startstation.Name = "Startstation";
            this.Startstation.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Platform.DataPropertyName = "Platform";
            this.Platform.HeaderText = "Gl.";
            this.Platform.MinimumWidth = 10;
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            this.Platform.Width = 46;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "Ankunftszeit";
            this.EndTime.MinimumWidth = 30;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 98;
            // 
            // Endstation
            // 
            this.Endstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Endstation.DataPropertyName = "EndStation";
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.MinimumWidth = 50;
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            // 
            // ConnactionsLbl
            // 
            this.ConnactionsLbl.AutoSize = true;
            this.ConnactionsLbl.Location = new System.Drawing.Point(18, 110);
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
            this.ClientSize = new System.Drawing.Size(564, 568);
            this.Controls.Add(this.ConnactionsLbl);
            this.Controls.Add(this.ConnectionsDgv);
            this.Controls.Add(this.InputGbx);
            this.Name = "TransportAppMainForm";
            this.Text = "Transport App";
            this.Load += new System.EventHandler(this.TransportAppMainForm_Load);
            this.InputGbx.ResumeLayout(false);
            this.InputGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox InputGbx;
        private Label EndStationLbl;
        private Label StartStationLbl;
        private Button SearchBtn;
        private DataGridView ConnectionsDgv;
        private Label ConnactionsLbl;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn Startstation;
        private DataGridViewTextBoxColumn Platform;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn Endstation;
        private ComboBox StartStationCbx;
        private ComboBox EndStationCbx;
        private DateTimePicker TimeDtp;
        private Label TimeLbl;
        private CheckBox ArrivalTimeBool;
    }
}
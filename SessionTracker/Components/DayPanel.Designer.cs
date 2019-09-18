namespace SessionTracker.Components
{
    partial class DayPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WeekDayLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.HourCount = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // WeekDayLabel
            // 
            this.WeekDayLabel.AutoSize = true;
            this.WeekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekDayLabel.Location = new System.Drawing.Point(131, 12);
            this.WeekDayLabel.Name = "WeekDayLabel";
            this.WeekDayLabel.Size = new System.Drawing.Size(46, 18);
            this.WeekDayLabel.TabIndex = 1;
            this.WeekDayLabel.Text = "label1";
            this.toolTip1.SetToolTip(this.WeekDayLabel, "Wochentag");
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(131, 47);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 18);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "label1";
            this.toolTip1.SetToolTip(this.DateLabel, "Datum");
            // 
            // WeekLabel
            // 
            this.WeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(251, 12);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(29, 20);
            this.WeekLabel.TabIndex = 3;
            this.WeekLabel.Text = "53";
            this.toolTip1.SetToolTip(this.WeekLabel, "Woche");
            // 
            // HourCount
            // 
            this.HourCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HourCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourCount.Location = new System.Drawing.Point(11, 18);
            this.HourCount.Name = "HourCount";
            this.HourCount.ReadOnly = true;
            this.HourCount.Size = new System.Drawing.Size(100, 40);
            this.HourCount.TabIndex = 4;
            this.HourCount.Text = "7,66";
            this.HourCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.HourCount, "gearbeitete Stunden");
            // 
            // DayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HourCount);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.WeekDayLabel);
            this.Name = "DayPanel";
            this.Size = new System.Drawing.Size(284, 76);
            this.DoubleClick += new System.EventHandler(this.DayPanel_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WeekDayLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.TextBox HourCount;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

﻿namespace WinBackup
{
    partial class frmMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlStatusBar = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctrlMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predefinedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlTabs = new System.Windows.Forms.TabControl();
            this.tabPreconfiguration = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock1 = new LCARS.Clock();
            this.curve1 = new LCARS.Curve();
            this.button2 = new LCARS.Button();
            this.bar1 = new LCARS.Bar();
            this.threeMonthCalendar1 = new LCARS.ThreeMonthCalendar();
            this.ctrlStatusBar.SuspendLayout();
            this.ctrlMenuBar.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.ctrlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlStatusBar
            // 
            this.ctrlStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus,
            this.txtCurrent});
            this.ctrlStatusBar.Location = new System.Drawing.Point(0, 614);
            this.ctrlStatusBar.Name = "ctrlStatusBar";
            this.ctrlStatusBar.Size = new System.Drawing.Size(1156, 22);
            this.ctrlStatusBar.TabIndex = 0;
            this.ctrlStatusBar.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(79, 17);
            this.txtStatus.Text = "Kein Job aktiv";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.txtCurrent.Size = new System.Drawing.Size(1062, 17);
            this.txtCurrent.Spring = true;
            // 
            // ctrlMenuBar
            // 
            this.ctrlMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.jobToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ctrlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.ctrlMenuBar.Name = "ctrlMenuBar";
            this.ctrlMenuBar.Size = new System.Drawing.Size(1156, 24);
            this.ctrlMenuBar.TabIndex = 1;
            this.ctrlMenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem,
            this.openJobToolStripMenuItem,
            this.closeJobToolStripMenuItem,
            this.saveJobToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "&Datei";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.newJobToolStripMenuItem.Text = "&Neu";
            this.newJobToolStripMenuItem.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openJobToolStripMenuItem.Text = "&Öffnen";
            // 
            // closeJobToolStripMenuItem
            // 
            this.closeJobToolStripMenuItem.Enabled = false;
            this.closeJobToolStripMenuItem.Name = "closeJobToolStripMenuItem";
            this.closeJobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeJobToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeJobToolStripMenuItem.Text = "S&chließen";
            // 
            // saveJobToolStripMenuItem
            // 
            this.saveJobToolStripMenuItem.Enabled = false;
            this.saveJobToolStripMenuItem.Name = "saveJobToolStripMenuItem";
            this.saveJobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveJobToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveJobToolStripMenuItem.Text = "&Speichern";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.jobToolStripMenuItem.Enabled = false;
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.jobToolStripMenuItem.Text = "Job";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.runToolStripMenuItem.Text = "Sta&rten";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.pauseToolStripMenuItem.Text = "Anhalten";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.stopToolStripMenuItem.Text = "Abbrechen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predefinedSettingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Hilfe";
            // 
            // predefinedSettingsToolStripMenuItem
            // 
            this.predefinedSettingsToolStripMenuItem.Name = "predefinedSettingsToolStripMenuItem";
            this.predefinedSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.predefinedSettingsToolStripMenuItem.Text = "Voreinstellungen";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "Über";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabStart
            // 
            this.tabStart.BackColor = System.Drawing.SystemColors.Control;
            this.tabStart.Controls.Add(this.threeMonthCalendar1);
            this.tabStart.Controls.Add(this.clock1);
            this.tabStart.Controls.Add(this.curve1);
            this.tabStart.Controls.Add(this.button2);
            this.tabStart.Controls.Add(this.bar1);
            this.tabStart.Controls.Add(this.button1);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(1148, 564);
            this.tabStart.TabIndex = 0;
            this.tabStart.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlTabs
            // 
            this.ctrlTabs.Controls.Add(this.tabStart);
            this.ctrlTabs.Controls.Add(this.tabPreconfiguration);
            this.ctrlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTabs.Location = new System.Drawing.Point(0, 24);
            this.ctrlTabs.Name = "ctrlTabs";
            this.ctrlTabs.SelectedIndex = 0;
            this.ctrlTabs.Size = new System.Drawing.Size(1156, 590);
            this.ctrlTabs.TabIndex = 2;
            // 
            // tabPreconfiguration
            // 
            this.tabPreconfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPreconfiguration.Name = "tabPreconfiguration";
            this.tabPreconfiguration.Size = new System.Drawing.Size(1148, 564);
            this.tabPreconfiguration.TabIndex = 1;
            this.tabPreconfiguration.Text = "Voreinstellungen";
            this.tabPreconfiguration.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // clock1
            // 
            this.clock1.AutoTimer = true;
            this.clock1.DrawCircle = true;
            this.clock1.DrawFiveMinutes = true;
            this.clock1.DrawHourHand = true;
            this.clock1.DrawMinuteHand = true;
            this.clock1.DrawMinutes = true;
            this.clock1.DrawSecondHand = true;
            this.clock1.FaceColor = System.Drawing.Color.Orange;
            this.clock1.FaceLineWidth = 1F;
            this.clock1.HandColor = System.Drawing.Color.Red;
            this.clock1.HourHandWidth = 5F;
            this.clock1.Location = new System.Drawing.Point(371, 197);
            this.clock1.MinuteHandWidth = 3F;
            this.clock1.Name = "clock1";
            this.clock1.SecondHandWidth = 1F;
            this.clock1.Size = new System.Drawing.Size(150, 150);
            this.clock1.TabIndex = 4;
            // 
            // curve1
            // 
            this.curve1.BackgroundColor = System.Drawing.Color.Blue;
            this.curve1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
            this.curve1.HoverColor = System.Drawing.Color.Silver;
            this.curve1.Location = new System.Drawing.Point(101, 100);
            this.curve1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.curve1.Name = "curve1";
            this.curve1.Size = new System.Drawing.Size(287, 100);
            this.curve1.Style = LCARS.CurveStyle.UpRight;
            this.curve1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FillStyle = LCARS.ButtonFillStyle.Filled;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
            this.button2.HoverColor = System.Drawing.Color.Silver;
            this.button2.Label = "TEST";
            this.button2.Location = new System.Drawing.Point(101, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 2;
            // 
            // bar1
            // 
            this.bar1.BackgroundColor = System.Drawing.Color.Blue;
            this.bar1.HoverColor = System.Drawing.Color.Silver;
            this.bar1.Label = "";
            this.bar1.Location = new System.Drawing.Point(395, 100);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(243, 51);
            this.bar1.TabIndex = 1;
            // 
            // threeMonthCalendar1
            // 
            this.threeMonthCalendar1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
            this.threeMonthCalendar1.Location = new System.Drawing.Point(262, 389);
            this.threeMonthCalendar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.threeMonthCalendar1.Name = "threeMonthCalendar1";
            this.threeMonthCalendar1.Size = new System.Drawing.Size(200, 127);
            this.threeMonthCalendar1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 636);
            this.Controls.Add(this.ctrlTabs);
            this.Controls.Add(this.ctrlStatusBar);
            this.Controls.Add(this.ctrlMenuBar);
            this.MainMenuStrip = this.ctrlMenuBar;
            this.Name = "frmMain";
            this.Text = "WinBackup";
            this.ctrlStatusBar.ResumeLayout(false);
            this.ctrlStatusBar.PerformLayout();
            this.ctrlMenuBar.ResumeLayout(false);
            this.ctrlMenuBar.PerformLayout();
            this.tabStart.ResumeLayout(false);
            this.ctrlTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ctrlStatusBar;
        private System.Windows.Forms.MenuStrip ctrlMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabControl ctrlTabs;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripStatusLabel txtCurrent;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predefinedSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPreconfiguration;
        private System.Windows.Forms.Button button1;
        private LCARS.Curve curve1;
        private LCARS.Button button2;
        private LCARS.Bar bar1;
        private LCARS.Clock clock1;
        private LCARS.ThreeMonthCalendar threeMonthCalendar1;
    }
}


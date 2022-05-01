namespace Netch.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportServersFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProcessModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRouteTableRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHideConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanDNSCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UninstallServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNetchFirewallRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForceExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewVersionLabel = new System.Windows.Forms.ToolStripLabel();
            this.VersionLabel = new System.Windows.Forms.ToolStripLabel();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.configLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.ProfileNameText = new System.Windows.Forms.TextBox();
            this.EditServerPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteServerPictureBox = new System.Windows.Forms.PictureBox();
            this.SpeedPictureBox = new System.Windows.Forms.PictureBox();
            this.CopyLinkPictureBox = new System.Windows.Forms.PictureBox();
            this.EditModePictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteModePictureBox = new System.Windows.Forms.PictureBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsedBandwidthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DownloadSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UploadSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.blankToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HttpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NatTypeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NatTypeStatusLightLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ControlButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMainFormToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.ProfileTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtomControlContainerControl = new System.Windows.Forms.ContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.configLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyLinkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteModePictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.ProfileGroupBox.SuspendLayout();
            this.ButtomControlContainerControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerToolStripMenuItem,
            this.ModeToolStripMenuItem,
            this.SubscriptionToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ForceExitToolStripMenuItem,
            this.AboutToolStripButton,
            this.NewVersionLabel,
            this.VersionLabel});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1121, 33);
            this.MenuStrip.TabIndex = 0;
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportServersFromClipboardToolStripMenuItem});
            this.ServerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 1);
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.ServerToolStripMenuItem.Text = "Server";
            // 
            // ImportServersFromClipboardToolStripMenuItem
            // 
            this.ImportServersFromClipboardToolStripMenuItem.Name = "ImportServersFromClipboardToolStripMenuItem";
            this.ImportServersFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.ImportServersFromClipboardToolStripMenuItem.Text = "Import Servers From Clipboard";
            this.ImportServersFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.ImportServersFromClipboardToolStripMenuItem_Click);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProcessModeToolStripMenuItem,
            this.CreateRouteTableRuleToolStripMenuItem,
            this.ReloadModesToolStripMenuItem});
            this.ModeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.ModeToolStripMenuItem.Text = "Mode";
            // 
            // CreateProcessModeToolStripMenuItem
            // 
            this.CreateProcessModeToolStripMenuItem.Name = "CreateProcessModeToolStripMenuItem";
            this.CreateProcessModeToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.CreateProcessModeToolStripMenuItem.Text = "Create Process Mode";
            this.CreateProcessModeToolStripMenuItem.Click += new System.EventHandler(this.CreateProcessModeToolStripButton_Click);
            // 
            // CreateRouteTableRuleToolStripMenuItem
            // 
            this.CreateRouteTableRuleToolStripMenuItem.Name = "CreateRouteTableRuleToolStripMenuItem";
            this.CreateRouteTableRuleToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.CreateRouteTableRuleToolStripMenuItem.Text = "Create Route Table Rule";
            this.CreateRouteTableRuleToolStripMenuItem.Click += new System.EventHandler(this.createRouteTableModeToolStripMenuItem_Click);
            // 
            // ReloadModesToolStripMenuItem
            // 
            this.ReloadModesToolStripMenuItem.Name = "ReloadModesToolStripMenuItem";
            this.ReloadModesToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.ReloadModesToolStripMenuItem.Text = "Reload Modes";
            this.ReloadModesToolStripMenuItem.Click += new System.EventHandler(this.ReloadModesToolStripMenuItem_Click);
            // 
            // SubscriptionToolStripMenuItem
            // 
            this.SubscriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageSubscriptionsToolStripMenuItem,
            this.UpdateServersToolStripMenuItem});
            this.SubscriptionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.SubscriptionToolStripMenuItem.Name = "SubscriptionToolStripMenuItem";
            this.SubscriptionToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.SubscriptionToolStripMenuItem.Text = "Subscription";
            // 
            // ManageSubscriptionsToolStripMenuItem
            // 
            this.ManageSubscriptionsToolStripMenuItem.Name = "ManageSubscriptionsToolStripMenuItem";
            this.ManageSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.ManageSubscriptionsToolStripMenuItem.Text = "Manage Subscriptions";
            this.ManageSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.ManageSubscriptionLinksToolStripMenuItem_Click);
            // 
            // UpdateServersToolStripMenuItem
            // 
            this.UpdateServersToolStripMenuItem.Name = "UpdateServersToolStripMenuItem";
            this.UpdateServersToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.UpdateServersToolStripMenuItem.Text = "Update Servers";
            this.UpdateServersToolStripMenuItem.Click += new System.EventHandler(this.UpdateServersFromSubscriptionLinksToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDirectoryToolStripMenuItem,
            this.ShowHideConsoleToolStripMenuItem,
            this.CleanDNSCacheToolStripMenuItem,
            this.UninstallServiceToolStripMenuItem,
            this.RemoveNetchFirewallRulesToolStripMenuItem});
            this.OptionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.OptionsToolStripMenuItem.Text = "Options";
            // 
            // OpenDirectoryToolStripMenuItem
            // 
            this.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem";
            this.OpenDirectoryToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.OpenDirectoryToolStripMenuItem.Text = "Open Directory";
            this.OpenDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OpenDirectoryToolStripMenuItem_Click);
            // 
            // ShowHideConsoleToolStripMenuItem
            // 
            this.ShowHideConsoleToolStripMenuItem.Name = "ShowHideConsoleToolStripMenuItem";
            this.ShowHideConsoleToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.ShowHideConsoleToolStripMenuItem.Text = "Show/Hide Console";
            this.ShowHideConsoleToolStripMenuItem.Click += new System.EventHandler(this.ShowHideConsoleToolStripMenuItem_Click);
            // 
            // CleanDNSCacheToolStripMenuItem
            // 
            this.CleanDNSCacheToolStripMenuItem.Name = "CleanDNSCacheToolStripMenuItem";
            this.CleanDNSCacheToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.CleanDNSCacheToolStripMenuItem.Text = "Clean DNS Cache";
            this.CleanDNSCacheToolStripMenuItem.Click += new System.EventHandler(this.CleanDNSCacheToolStripMenuItem_Click);
            // 
            // UninstallServiceToolStripMenuItem
            // 
            this.UninstallServiceToolStripMenuItem.Name = "UninstallServiceToolStripMenuItem";
            this.UninstallServiceToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.UninstallServiceToolStripMenuItem.Text = "Uninstall NF Service";
            this.UninstallServiceToolStripMenuItem.Click += new System.EventHandler(this.UninstallServiceToolStripMenuItem_Click);
            // 
            // RemoveNetchFirewallRulesToolStripMenuItem
            // 
            this.RemoveNetchFirewallRulesToolStripMenuItem.Name = "RemoveNetchFirewallRulesToolStripMenuItem";
            this.RemoveNetchFirewallRulesToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.RemoveNetchFirewallRulesToolStripMenuItem.Text = "Remove Netch Firewall Rules";
            this.RemoveNetchFirewallRulesToolStripMenuItem.Click += new System.EventHandler(this.RemoveNetchFirewallRulesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdateToolStripMenuItem,
            this.FAQToolStripMenuItem});
            this.HelpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // CheckForUpdateToolStripMenuItem
            // 
            this.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem";
            this.CheckForUpdateToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.CheckForUpdateToolStripMenuItem.Text = "Check for update";
            this.CheckForUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // FAQToolStripMenuItem
            // 
            this.FAQToolStripMenuItem.Name = "FAQToolStripMenuItem";
            this.FAQToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.FAQToolStripMenuItem.Text = "FAQ";
            this.FAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // ForceExitToolStripMenuItem
            // 
            this.ForceExitToolStripMenuItem.Name = "ForceExitToolStripMenuItem";
            this.ForceExitToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.ForceExitToolStripMenuItem.Text = "Exit";
            this.ForceExitToolStripMenuItem.Click += new System.EventHandler(this.ForceExitToolStripMenuItem_Click);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutToolStripButton.AutoToolTip = false;
            this.AboutToolStripButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(68, 28);
            this.AboutToolStripButton.Text = "About";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripButton_Click);
            // 
            // NewVersionLabel
            // 
            this.NewVersionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NewVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewVersionLabel.ForeColor = System.Drawing.Color.Red;
            this.NewVersionLabel.IsLink = true;
            this.NewVersionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NewVersionLabel.LinkColor = System.Drawing.Color.Red;
            this.NewVersionLabel.Name = "NewVersionLabel";
            this.NewVersionLabel.Size = new System.Drawing.Size(196, 24);
            this.NewVersionLabel.Text = "New version available";
            this.NewVersionLabel.Visible = false;
            this.NewVersionLabel.Click += new System.EventHandler(this.NewVersionLabel_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.ForeColor = System.Drawing.Color.Red;
            this.VersionLabel.IsLink = true;
            this.VersionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(37, 24);
            this.VersionLabel.Text = "xxx";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationGroupBox.AutoSize = true;
            this.ConfigurationGroupBox.Controls.Add(this.configLayoutPanel);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(23, 23);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(1075, 139);
            this.ConfigurationGroupBox.TabIndex = 1;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // configLayoutPanel
            // 
            this.configLayoutPanel.AutoSize = true;
            this.configLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configLayoutPanel.ColumnCount = 6;
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.configLayoutPanel.Controls.Add(this.ServerLabel, 0, 0);
            this.configLayoutPanel.Controls.Add(this.ModeLabel, 0, 1);
            this.configLayoutPanel.Controls.Add(this.ProfileLabel, 0, 2);
            this.configLayoutPanel.Controls.Add(this.ServerComboBox, 1, 0);
            this.configLayoutPanel.Controls.Add(this.ModeComboBox, 1, 1);
            this.configLayoutPanel.Controls.Add(this.ProfileNameText, 1, 2);
            this.configLayoutPanel.Controls.Add(this.EditServerPictureBox, 2, 0);
            this.configLayoutPanel.Controls.Add(this.DeleteServerPictureBox, 3, 0);
            this.configLayoutPanel.Controls.Add(this.SpeedPictureBox, 4, 0);
            this.configLayoutPanel.Controls.Add(this.CopyLinkPictureBox, 5, 0);
            this.configLayoutPanel.Controls.Add(this.EditModePictureBox, 2, 1);
            this.configLayoutPanel.Controls.Add(this.DeleteModePictureBox, 3, 1);
            this.configLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.configLayoutPanel.Name = "configLayoutPanel";
            this.configLayoutPanel.RowCount = 3;
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.Size = new System.Drawing.Size(1069, 110);
            this.configLayoutPanel.TabIndex = 15;
            // 
            // ServerLabel
            // 
            this.ServerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(3, 6);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(79, 24);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server";
            // 
            // ModeLabel
            // 
            this.ModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(3, 43);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(79, 24);
            this.ModeLabel.TabIndex = 3;
            this.ModeLabel.Text = "Mode";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(3, 80);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(79, 24);
            this.ProfileLabel.TabIndex = 10;
            this.ProfileLabel.Text = "Profile";
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.IntegralHeight = false;
            this.ServerComboBox.Location = new System.Drawing.Point(88, 3);
            this.ServerComboBox.MaxDropDownItems = 16;
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(849, 31);
            this.ServerComboBox.TabIndex = 1;
            this.ServerComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            this.ServerComboBox.SelectionChangeCommitted += new System.EventHandler(this.ServerComboBox_SelectionChangeCommitted);
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.IntegralHeight = false;
            this.ModeComboBox.Location = new System.Drawing.Point(88, 40);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(849, 31);
            this.ModeComboBox.TabIndex = 2;
            this.ModeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            this.ModeComboBox.SelectionChangeCommitted += new System.EventHandler(this.ModeComboBox_SelectionChangeCommitted);
            // 
            // ProfileNameText
            // 
            this.ProfileNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileNameText.Location = new System.Drawing.Point(88, 77);
            this.ProfileNameText.Name = "ProfileNameText";
            this.ProfileNameText.Size = new System.Drawing.Size(849, 30);
            this.ProfileNameText.TabIndex = 11;
            // 
            // EditServerPictureBox
            // 
            this.EditServerPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.EditServerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditServerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditServerPictureBox.Image = global::Netch.Properties.Resources.edit;
            this.EditServerPictureBox.Location = new System.Drawing.Point(943, 3);
            this.EditServerPictureBox.Name = "EditServerPictureBox";
            this.EditServerPictureBox.Size = new System.Drawing.Size(26, 31);
            this.EditServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditServerPictureBox.TabIndex = 7;
            this.EditServerPictureBox.TabStop = false;
            this.EditServerPictureBox.Click += new System.EventHandler(this.EditServerPictureBox_Click);
            // 
            // DeleteServerPictureBox
            // 
            this.DeleteServerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteServerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteServerPictureBox.Image = global::Netch.Properties.Resources.delete;
            this.DeleteServerPictureBox.Location = new System.Drawing.Point(975, 3);
            this.DeleteServerPictureBox.Name = "DeleteServerPictureBox";
            this.DeleteServerPictureBox.Size = new System.Drawing.Size(26, 31);
            this.DeleteServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteServerPictureBox.TabIndex = 8;
            this.DeleteServerPictureBox.TabStop = false;
            this.DeleteServerPictureBox.Click += new System.EventHandler(this.DeleteServerPictureBox_Click);
            // 
            // SpeedPictureBox
            // 
            this.SpeedPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedPictureBox.Image = global::Netch.Properties.Resources.speed;
            this.SpeedPictureBox.Location = new System.Drawing.Point(1007, 3);
            this.SpeedPictureBox.Name = "SpeedPictureBox";
            this.SpeedPictureBox.Size = new System.Drawing.Size(26, 31);
            this.SpeedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeedPictureBox.TabIndex = 9;
            this.SpeedPictureBox.TabStop = false;
            this.SpeedPictureBox.Click += new System.EventHandler(this.SpeedPictureBox_Click);
            // 
            // CopyLinkPictureBox
            // 
            this.CopyLinkPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyLinkPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyLinkPictureBox.Image = global::Netch.Properties.Resources.CopyLink;
            this.CopyLinkPictureBox.Location = new System.Drawing.Point(1039, 3);
            this.CopyLinkPictureBox.Name = "CopyLinkPictureBox";
            this.CopyLinkPictureBox.Size = new System.Drawing.Size(27, 31);
            this.CopyLinkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CopyLinkPictureBox.TabIndex = 14;
            this.CopyLinkPictureBox.TabStop = false;
            this.CopyLinkPictureBox.Click += new System.EventHandler(this.CopyLinkPictureBox_Click);
            // 
            // EditModePictureBox
            // 
            this.EditModePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditModePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditModePictureBox.Image = global::Netch.Properties.Resources.edit;
            this.EditModePictureBox.Location = new System.Drawing.Point(943, 40);
            this.EditModePictureBox.Name = "EditModePictureBox";
            this.EditModePictureBox.Size = new System.Drawing.Size(26, 31);
            this.EditModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditModePictureBox.TabIndex = 12;
            this.EditModePictureBox.TabStop = false;
            this.EditModePictureBox.Click += new System.EventHandler(this.EditModePictureBox_Click);
            // 
            // DeleteModePictureBox
            // 
            this.DeleteModePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteModePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteModePictureBox.Image = global::Netch.Properties.Resources.delete;
            this.DeleteModePictureBox.Location = new System.Drawing.Point(975, 40);
            this.DeleteModePictureBox.Name = "DeleteModePictureBox";
            this.DeleteModePictureBox.Size = new System.Drawing.Size(26, 31);
            this.DeleteModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteModePictureBox.TabIndex = 13;
            this.DeleteModePictureBox.TabStop = false;
            this.DeleteModePictureBox.Click += new System.EventHandler(this.DeleteModePictureBox_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.UsedBandwidthLabel,
            this.DownloadSpeedLabel,
            this.UploadSpeedLabel,
            this.blankToolStripStatusLabel,
            this.HttpStatusLabel,
            this.NatTypeStatusLabel,
            this.NatTypeStatusLightLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 388);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1121, 31);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(261, 24);
            this.StatusLabel.Text = "Status: Waiting for command";
            // 
            // UsedBandwidthLabel
            // 
            this.UsedBandwidthLabel.Name = "UsedBandwidthLabel";
            this.UsedBandwidthLabel.Size = new System.Drawing.Size(100, 24);
            this.UsedBandwidthLabel.Text = "Used: 0 KB";
            this.UsedBandwidthLabel.Visible = false;
            // 
            // DownloadSpeedLabel
            // 
            this.DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            this.DownloadSpeedLabel.Size = new System.Drawing.Size(82, 24);
            this.DownloadSpeedLabel.Text = "↓: 0 KB/s";
            this.DownloadSpeedLabel.Visible = false;
            // 
            // UploadSpeedLabel
            // 
            this.UploadSpeedLabel.Name = "UploadSpeedLabel";
            this.UploadSpeedLabel.Size = new System.Drawing.Size(82, 24);
            this.UploadSpeedLabel.Text = "↑: 0 KB/s";
            this.UploadSpeedLabel.Visible = false;
            // 
            // blankToolStripStatusLabel
            // 
            this.blankToolStripStatusLabel.Name = "blankToolStripStatusLabel";
            this.blankToolStripStatusLabel.Size = new System.Drawing.Size(771, 24);
            this.blankToolStripStatusLabel.Spring = true;
            // 
            // HttpStatusLabel
            // 
            this.HttpStatusLabel.Name = "HttpStatusLabel";
            this.HttpStatusLabel.Size = new System.Drawing.Size(59, 24);
            this.HttpStatusLabel.Text = "HTTP:";
            this.HttpStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.HttpStatusLabel.Visible = false;
            this.HttpStatusLabel.Click += new System.EventHandler(this.TcpStatusLabel_Click);
            // 
            // NatTypeStatusLabel
            // 
            this.NatTypeStatusLabel.Name = "NatTypeStatusLabel";
            this.NatTypeStatusLabel.Size = new System.Drawing.Size(52, 24);
            this.NatTypeStatusLabel.Text = "NAT:";
            this.NatTypeStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NatTypeStatusLabel.Click += new System.EventHandler(this.NatTypeStatusLabel_Click);
            // 
            // NatTypeStatusLightLabel
            // 
            this.NatTypeStatusLightLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.NatTypeStatusLightLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NatTypeStatusLightLabel.ForeColor = System.Drawing.Color.Red;
            this.NatTypeStatusLightLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.NatTypeStatusLightLabel.Name = "NatTypeStatusLightLabel";
            this.NatTypeStatusLightLabel.Size = new System.Drawing.Size(22, 30);
            this.NatTypeStatusLightLabel.Text = "⬤";
            this.NatTypeStatusLightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NatTypeStatusLightLabel.Click += new System.EventHandler(this.NatTypeStatusLabel_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlButton.Location = new System.Drawing.Point(925, 0);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(150, 50);
            this.ControlButton.TabIndex = 3;
            this.ControlButton.Text = "Start";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.NotifyIcon.Text = "Netch";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMainFormToolStripButton,
            this.ExitToolStripButton});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.ShowItemToolTips = false;
            this.NotifyMenu.Size = new System.Drawing.Size(127, 64);
            // 
            // ShowMainFormToolStripButton
            // 
            this.ShowMainFormToolStripButton.Name = "ShowMainFormToolStripButton";
            this.ShowMainFormToolStripButton.Size = new System.Drawing.Size(126, 30);
            this.ShowMainFormToolStripButton.Text = "Show";
            this.ShowMainFormToolStripButton.Click += new System.EventHandler(this.ShowMainFormToolStripButton_Click);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(126, 30);
            this.ExitToolStripButton.Text = "Exit";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(150, 50);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ProfileGroupBox
            // 
            this.ProfileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileGroupBox.Controls.Add(this.ProfileTable);
            this.ProfileGroupBox.Location = new System.Drawing.Point(23, 168);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Size = new System.Drawing.Size(1075, 100);
            this.ProfileGroupBox.TabIndex = 13;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles";
            // 
            // ProfileTable
            // 
            this.ProfileTable.AutoSize = true;
            this.ProfileTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProfileTable.ColumnCount = 2;
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTable.Location = new System.Drawing.Point(3, 26);
            this.ProfileTable.Name = "ProfileTable";
            this.ProfileTable.RowCount = 1;
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.Size = new System.Drawing.Size(1069, 71);
            this.ProfileTable.TabIndex = 0;
            // 
            // ButtomControlContainerControl
            // 
            this.ButtomControlContainerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtomControlContainerControl.Controls.Add(this.SettingsButton);
            this.ButtomControlContainerControl.Controls.Add(this.ControlButton);
            this.ButtomControlContainerControl.Location = new System.Drawing.Point(23, 278);
            this.ButtomControlContainerControl.Name = "ButtomControlContainerControl";
            this.ButtomControlContainerControl.Size = new System.Drawing.Size(1075, 50);
            this.ButtomControlContainerControl.TabIndex = 14;
            this.ButtomControlContainerControl.TabStop = false;
            this.ButtomControlContainerControl.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ConfigurationGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProfileGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtomControlContainerControl, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.configLayoutPanel.ResumeLayout(false);
            this.configLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyLinkPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteModePictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.NotifyMenu.ResumeLayout(false);
            this.ProfileGroupBox.ResumeLayout(false);
            this.ProfileGroupBox.PerformLayout();
            this.ButtomControlContainerControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem CreateRouteTableRuleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem RemoveNetchFirewallRulesToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CleanDNSCacheToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel configLayoutPanel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.PictureBox CopyLinkPictureBox;
        private System.Windows.Forms.ToolStripMenuItem CreateProcessModeToolStripMenuItem;
        private System.Windows.Forms.PictureBox DeleteModePictureBox;
        private System.Windows.Forms.PictureBox DeleteServerPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel DownloadSpeedLabel;
        private System.Windows.Forms.PictureBox EditModePictureBox;
        private System.Windows.Forms.PictureBox EditServerPictureBox;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ForceExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportServersFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageSubscriptionsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLabel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProfileGroupBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.TextBox ProfileNameText;
        private System.Windows.Forms.TableLayoutPanel ProfileTable;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdateToolStripMenuItem;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem ShowMainFormToolStripButton;
        private System.Windows.Forms.PictureBox SpeedPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem SubscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UninstallServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UploadSpeedLabel;
        private System.Windows.Forms.ToolStripStatusLabel UsedBandwidthLabel;
        private System.Windows.Forms.ToolStripLabel NewVersionLabel;
        private System.Windows.Forms.ToolStripLabel VersionLabel;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLightLabel;
        private System.Windows.Forms.ToolStripStatusLabel blankToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem FAQToolStripMenuItem;

        #endregion
        private System.Windows.Forms.ContainerControl ButtomControlContainerControl;
        private System.Windows.Forms.ToolStripMenuItem ShowHideConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel HttpStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ReloadModesToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
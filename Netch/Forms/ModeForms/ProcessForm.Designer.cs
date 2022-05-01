﻿using System;
using System.Windows.Forms;

namespace Netch.Forms.ModeForms
{
    partial class ProcessForm
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
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigurationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModeSpecificOptionsLabel = new System.Windows.Forms.Label();
            this.HandleTCPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleUDPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleProcDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.ProxyDNSCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleICMPCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.HandleLoopbackCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleLANCheckBox = new System.Windows.Forms.CheckBox();
            this.HandleChildProcCheckBox = new Netch.Forms.SyncGlobalCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DNSLabel = new System.Windows.Forms.Label();
            this.DNSTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ICMPDelayLabel = new System.Windows.Forms.Label();
            this.ICMPDelayTextBox = new System.Windows.Forms.TextBox();
            this.RuleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.HandleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HandleHelperFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.HandleSelectButton = new System.Windows.Forms.Button();
            this.HandleScanButton = new System.Windows.Forms.Button();
            this.HandleContentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HandleRuleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BypassTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BypassFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BypassLabel = new System.Windows.Forms.Label();
            this.BypassSelectButton = new System.Windows.Forms.Button();
            this.BypassScanButton = new System.Windows.Forms.Button();
            this.BypassContentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BypassRuleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConfigurationGroupBox.SuspendLayout();
            this.ConfigurationLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.RuleTableLayoutPanel.SuspendLayout();
            this.HandleTableLayoutPanel.SuspendLayout();
            this.HandleHelperFlowLayoutPanel.SuspendLayout();
            this.HandleContentTableLayoutPanel.SuspendLayout();
            this.BypassTableLayoutPanel.SuspendLayout();
            this.BypassFlowLayoutPanel.SuspendLayout();
            this.BypassContentTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.AutoSize = true;
            this.ConfigurationGroupBox.Controls.Add(this.ConfigurationLayoutPanel);
            this.ConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(1412, 916);
            this.ConfigurationGroupBox.TabIndex = 0;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // ConfigurationLayoutPanel
            // 
            this.ConfigurationLayoutPanel.AutoSize = true;
            this.ConfigurationLayoutPanel.ColumnCount = 1;
            this.ConfigurationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ConfigurationLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.ConfigurationLayoutPanel.Controls.Add(this.OptionsGroupBox, 0, 1);
            this.ConfigurationLayoutPanel.Controls.Add(this.RuleTableLayoutPanel, 0, 2);
            this.ConfigurationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationLayoutPanel.Location = new System.Drawing.Point(3, 27);
            this.ConfigurationLayoutPanel.Name = "ConfigurationLayoutPanel";
            this.ConfigurationLayoutPanel.RowCount = 3;
            this.ConfigurationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConfigurationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConfigurationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConfigurationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConfigurationLayoutPanel.Size = new System.Drawing.Size(1406, 886);
            this.ConfigurationLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.RemarkLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemarkTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilenameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FilenameTextBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 94);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(3, 6);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(122, 24);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "Remark";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemarkTextBox.Location = new System.Drawing.Point(131, 3);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(720, 31);
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.TextChanged += new System.EventHandler(this.RemarkTextBox_TextChanged);
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(3, 43);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(122, 24);
            this.FilenameLabel.TabIndex = 2;
            this.FilenameLabel.Text = "Filename";
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilenameTextBox.Location = new System.Drawing.Point(131, 40);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.ReadOnly = true;
            this.FilenameTextBox.Size = new System.Drawing.Size(720, 31);
            this.FilenameTextBox.TabIndex = 3;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.AutoSize = true;
            this.OptionsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsGroupBox.Location = new System.Drawing.Point(3, 103);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(1400, 151);
            this.OptionsGroupBox.TabIndex = 1;
            this.OptionsGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ModeSpecificOptionsLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HandleTCPCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HandleUDPCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HandleDNSCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HandleLoopbackCheckBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.HandleLANCheckBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.HandleChildProcCheckBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HandleProcDNSCheckBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HandleICMPCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProxyDNSCheckBox, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 121);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // ModeSpecificOptionsLabel
            // 
            this.ModeSpecificOptionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModeSpecificOptionsLabel.AutoSize = true;
            this.ModeSpecificOptionsLabel.Location = new System.Drawing.Point(1047, 5);
            this.ModeSpecificOptionsLabel.Name = "ModeSpecificOptionsLabel";
            this.ModeSpecificOptionsLabel.Size = new System.Drawing.Size(200, 24);
            this.ModeSpecificOptionsLabel.TabIndex = 13;
            this.ModeSpecificOptionsLabel.Text = "Mode specific options";
            // 
            // HandleTCPCheckBox
            // 
            this.HandleTCPCheckBox.AutoCheck = false;
            this.HandleTCPCheckBox.AutoSize = true;
            this.HandleTCPCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleTCPCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleTCPCheckBox.GlobalValue = false;
            this.HandleTCPCheckBox.Location = new System.Drawing.Point(3, 3);
            this.HandleTCPCheckBox.Name = "HandleTCPCheckBox";
            this.HandleTCPCheckBox.Size = new System.Drawing.Size(142, 29);
            this.HandleTCPCheckBox.SyncGlobal = false;
            this.HandleTCPCheckBox.TabIndex = 0;
            this.HandleTCPCheckBox.Text = "Handle TCP";
            this.HandleTCPCheckBox.ThreeState = true;
            this.HandleTCPCheckBox.UseVisualStyleBackColor = true;
            this.HandleTCPCheckBox.Value = false;
            // 
            // HandleUDPCheckBox
            // 
            this.HandleUDPCheckBox.AutoCheck = false;
            this.HandleUDPCheckBox.AutoSize = true;
            this.HandleUDPCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleUDPCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleUDPCheckBox.GlobalValue = false;
            this.HandleUDPCheckBox.Location = new System.Drawing.Point(351, 3);
            this.HandleUDPCheckBox.Name = "HandleUDPCheckBox";
            this.HandleUDPCheckBox.Size = new System.Drawing.Size(147, 29);
            this.HandleUDPCheckBox.SyncGlobal = false;
            this.HandleUDPCheckBox.TabIndex = 1;
            this.HandleUDPCheckBox.Text = "Handle UDP";
            this.HandleUDPCheckBox.ThreeState = true;
            this.HandleUDPCheckBox.UseVisualStyleBackColor = true;
            this.HandleUDPCheckBox.Value = false;
            // 
            // HandleDNSCheckBox
            // 
            this.HandleDNSCheckBox.AutoCheck = false;
            this.HandleDNSCheckBox.AutoSize = true;
            this.HandleDNSCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleDNSCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleDNSCheckBox.GlobalValue = false;
            this.HandleDNSCheckBox.Location = new System.Drawing.Point(3, 38);
            this.HandleDNSCheckBox.Name = "HandleDNSCheckBox";
            this.HandleDNSCheckBox.Size = new System.Drawing.Size(292, 29);
            this.HandleDNSCheckBox.SyncGlobal = false;
            this.HandleDNSCheckBox.TabIndex = 2;
            this.HandleDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            this.HandleDNSCheckBox.ThreeState = true;
            this.HandleDNSCheckBox.UseVisualStyleBackColor = true;
            this.HandleDNSCheckBox.Value = false;
            // 
            // HandleProcDNSCheckBox
            // 
            this.HandleProcDNSCheckBox.AutoCheck = false;
            this.HandleProcDNSCheckBox.AutoSize = true;
            this.HandleProcDNSCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleProcDNSCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleProcDNSCheckBox.GlobalValue = false;
            this.HandleProcDNSCheckBox.Location = new System.Drawing.Point(3, 81);
            this.HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            this.HandleProcDNSCheckBox.Size = new System.Drawing.Size(314, 29);
            this.HandleProcDNSCheckBox.SyncGlobal = false;
            this.HandleProcDNSCheckBox.TabIndex = 5;
            this.HandleProcDNSCheckBox.Text = "Handle handled process\'s DNS";
            this.HandleProcDNSCheckBox.ThreeState = true;
            this.HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            this.HandleProcDNSCheckBox.Value = false;
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoCheck = false;
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.ProxyDNSCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ProxyDNSCheckBox.GlobalValue = false;
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(699, 38);
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(285, 29);
            this.ProxyDNSCheckBox.SyncGlobal = false;
            this.ProxyDNSCheckBox.TabIndex = 6;
            this.ProxyDNSCheckBox.Text = "Handle DNS through proxy";
            this.ProxyDNSCheckBox.ThreeState = true;
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            this.ProxyDNSCheckBox.Value = false;
            // 
            // HandleICMPCheckBox
            // 
            this.HandleICMPCheckBox.AutoCheck = false;
            this.HandleICMPCheckBox.AutoSize = true;
            this.HandleICMPCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleICMPCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleICMPCheckBox.GlobalValue = false;
            this.HandleICMPCheckBox.Location = new System.Drawing.Point(351, 81);
            this.HandleICMPCheckBox.Name = "HandleICMPCheckBox";
            this.HandleICMPCheckBox.Size = new System.Drawing.Size(156, 29);
            this.HandleICMPCheckBox.SyncGlobal = false;
            this.HandleICMPCheckBox.TabIndex = 7;
            this.HandleICMPCheckBox.Text = "Handle ICMP";
            this.HandleICMPCheckBox.ThreeState = true;
            this.HandleICMPCheckBox.UseVisualStyleBackColor = true;
            this.HandleICMPCheckBox.Value = false;
            // 
            // HandleLoopbackCheckBox
            // 
            this.HandleLoopbackCheckBox.AutoSize = true;
            this.HandleLoopbackCheckBox.Location = new System.Drawing.Point(1047, 38);
            this.HandleLoopbackCheckBox.Name = "HandleLoopbackCheckBox";
            this.HandleLoopbackCheckBox.Size = new System.Drawing.Size(228, 28);
            this.HandleLoopbackCheckBox.TabIndex = 10;
            this.HandleLoopbackCheckBox.Text = "Handle local loopback";
            this.HandleLoopbackCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleLANCheckBox
            // 
            this.HandleLANCheckBox.AutoSize = true;
            this.HandleLANCheckBox.Location = new System.Drawing.Point(1047, 81);
            this.HandleLANCheckBox.Name = "HandleLANCheckBox";
            this.HandleLANCheckBox.Size = new System.Drawing.Size(140, 28);
            this.HandleLANCheckBox.TabIndex = 11;
            this.HandleLANCheckBox.Text = "Handle LAN";
            this.HandleLANCheckBox.UseVisualStyleBackColor = true;
            // 
            // HandleChildProcCheckBox
            // 
            this.HandleChildProcCheckBox.AutoCheck = false;
            this.HandleChildProcCheckBox.AutoSize = true;
            this.HandleChildProcCheckBox.BackColor = System.Drawing.Color.Yellow;
            this.HandleChildProcCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HandleChildProcCheckBox.GlobalValue = false;
            this.HandleChildProcCheckBox.Location = new System.Drawing.Point(699, 3);
            this.HandleChildProcCheckBox.Name = "HandleChildProcCheckBox";
            this.HandleChildProcCheckBox.Size = new System.Drawing.Size(224, 29);
            this.HandleChildProcCheckBox.SyncGlobal = false;
            this.HandleChildProcCheckBox.TabIndex = 12;
            this.HandleChildProcCheckBox.Text = "Handle child process";
            this.HandleChildProcCheckBox.ThreeState = true;
            this.HandleChildProcCheckBox.UseVisualStyleBackColor = true;
            this.HandleChildProcCheckBox.Value = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.DNSLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DNSTextBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(351, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(261, 37);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // DNSLabel
            // 
            this.DNSLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DNSLabel.AutoSize = true;
            this.DNSLabel.Location = new System.Drawing.Point(3, 6);
            this.DNSLabel.Name = "DNSLabel";
            this.DNSLabel.Size = new System.Drawing.Size(49, 24);
            this.DNSLabel.TabIndex = 3;
            this.DNSLabel.Text = "DNS";
            // 
            // DNSTextBox
            // 
            this.DNSTextBox.Location = new System.Drawing.Point(58, 3);
            this.DNSTextBox.Name = "DNSTextBox";
            this.DNSTextBox.Size = new System.Drawing.Size(200, 31);
            this.DNSTextBox.TabIndex = 4;
            this.DNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.ICMPDelayTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ICMPDelayLabel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(699, 81);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(237, 37);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // ICMPDelayLabel
            // 
            this.ICMPDelayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ICMPDelayLabel.AutoSize = true;
            this.ICMPDelayLabel.Location = new System.Drawing.Point(3, 6);
            this.ICMPDelayLabel.Name = "ICMPDelayLabel";
            this.ICMPDelayLabel.Size = new System.Drawing.Size(145, 24);
            this.ICMPDelayLabel.TabIndex = 8;
            this.ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            this.ICMPDelayTextBox.Location = new System.Drawing.Point(154, 3);
            this.ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            this.ICMPDelayTextBox.Size = new System.Drawing.Size(80, 31);
            this.ICMPDelayTextBox.TabIndex = 9;
            this.ICMPDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RuleTableLayoutPanel
            // 
            this.RuleTableLayoutPanel.AutoSize = true;
            this.RuleTableLayoutPanel.ColumnCount = 2;
            this.RuleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RuleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RuleTableLayoutPanel.Controls.Add(this.ValidationButton, 0, 0);
            this.RuleTableLayoutPanel.Controls.Add(this.ControlButton, 1, 0);
            this.RuleTableLayoutPanel.Controls.Add(this.HandleTableLayoutPanel, 0, 1);
            this.RuleTableLayoutPanel.Controls.Add(this.BypassTableLayoutPanel, 1, 1);
            this.RuleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuleTableLayoutPanel.Location = new System.Drawing.Point(3, 260);
            this.RuleTableLayoutPanel.Name = "RuleTableLayoutPanel";
            this.RuleTableLayoutPanel.RowCount = 2;
            this.RuleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RuleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RuleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RuleTableLayoutPanel.Size = new System.Drawing.Size(1400, 725);
            this.RuleTableLayoutPanel.TabIndex = 2;
            // 
            // ValidationButton
            // 
            this.ValidationButton.AutoSize = true;
            this.ValidationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ValidationButton.Location = new System.Drawing.Point(589, 3);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(108, 34);
            this.ValidationButton.TabIndex = 0;
            this.ValidationButton.Text = "Validation";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.ValidationButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ControlButton.AutoSize = true;
            this.ControlButton.Location = new System.Drawing.Point(703, 3);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(108, 34);
            this.ControlButton.TabIndex = 4;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // HandleTableLayoutPanel
            // 
            this.HandleTableLayoutPanel.AutoSize = true;
            this.HandleTableLayoutPanel.ColumnCount = 1;
            this.HandleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HandleTableLayoutPanel.Controls.Add(this.HandleHelperFlowLayoutPanel, 0, 0);
            this.HandleTableLayoutPanel.Controls.Add(this.HandleContentTableLayoutPanel, 0, 1);
            this.HandleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleTableLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.HandleTableLayoutPanel.Name = "HandleTableLayoutPanel";
            this.HandleTableLayoutPanel.RowCount = 2;
            this.HandleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HandleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HandleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HandleTableLayoutPanel.Size = new System.Drawing.Size(694, 679);
            this.HandleTableLayoutPanel.TabIndex = 1;
            // 
            // HandleHelperFlowLayoutPanel
            // 
            this.HandleHelperFlowLayoutPanel.AutoSize = true;
            this.HandleHelperFlowLayoutPanel.Controls.Add(this.HandleLabel);
            this.HandleHelperFlowLayoutPanel.Controls.Add(this.HandleSelectButton);
            this.HandleHelperFlowLayoutPanel.Controls.Add(this.HandleScanButton);
            this.HandleHelperFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HandleHelperFlowLayoutPanel.Name = "HandleHelperFlowLayoutPanel";
            this.HandleHelperFlowLayoutPanel.Size = new System.Drawing.Size(300, 40);
            this.HandleHelperFlowLayoutPanel.TabIndex = 0;
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(3, 0);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Padding = new System.Windows.Forms.Padding(7);
            this.HandleLabel.Size = new System.Drawing.Size(132, 38);
            this.HandleLabel.TabIndex = 0;
            this.HandleLabel.Text = "Handle rules";
            // 
            // HandleSelectButton
            // 
            this.HandleSelectButton.AutoSize = true;
            this.HandleSelectButton.Location = new System.Drawing.Point(141, 3);
            this.HandleSelectButton.Name = "HandleSelectButton";
            this.HandleSelectButton.Size = new System.Drawing.Size(75, 34);
            this.HandleSelectButton.TabIndex = 1;
            this.HandleSelectButton.Text = "Select";
            this.HandleSelectButton.UseVisualStyleBackColor = true;
            this.HandleSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // HandleScanButton
            // 
            this.HandleScanButton.AutoSize = true;
            this.HandleHelperFlowLayoutPanel.SetFlowBreak(this.HandleScanButton, true);
            this.HandleScanButton.Location = new System.Drawing.Point(222, 3);
            this.HandleScanButton.Name = "HandleScanButton";
            this.HandleScanButton.Size = new System.Drawing.Size(75, 34);
            this.HandleScanButton.TabIndex = 2;
            this.HandleScanButton.Text = "Scan";
            this.HandleScanButton.UseVisualStyleBackColor = true;
            this.HandleScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // HandleContentTableLayoutPanel
            // 
            this.HandleContentTableLayoutPanel.AutoSize = true;
            this.HandleContentTableLayoutPanel.ColumnCount = 1;
            this.HandleContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HandleContentTableLayoutPanel.Controls.Add(this.HandleRuleRichTextBox, 0, 0);
            this.HandleContentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleContentTableLayoutPanel.Location = new System.Drawing.Point(3, 49);
            this.HandleContentTableLayoutPanel.Name = "HandleContentTableLayoutPanel";
            this.HandleContentTableLayoutPanel.RowCount = 1;
            this.HandleContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HandleContentTableLayoutPanel.Size = new System.Drawing.Size(688, 627);
            this.HandleContentTableLayoutPanel.TabIndex = 1;
            // 
            // HandleRuleRichTextBox
            // 
            this.HandleRuleRichTextBox.DetectUrls = false;
            this.HandleRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandleRuleRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.HandleRuleRichTextBox.Name = "HandleRuleRichTextBox";
            this.HandleRuleRichTextBox.Size = new System.Drawing.Size(682, 621);
            this.HandleRuleRichTextBox.TabIndex = 0;
            this.HandleRuleRichTextBox.Text = "";
            this.HandleRuleRichTextBox.WordWrap = false;
            // 
            // BypassTableLayoutPanel
            // 
            this.BypassTableLayoutPanel.AutoSize = true;
            this.BypassTableLayoutPanel.ColumnCount = 1;
            this.BypassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BypassTableLayoutPanel.Controls.Add(this.BypassFlowLayoutPanel, 0, 0);
            this.BypassTableLayoutPanel.Controls.Add(this.BypassContentTableLayoutPanel, 0, 1);
            this.BypassTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassTableLayoutPanel.Location = new System.Drawing.Point(703, 43);
            this.BypassTableLayoutPanel.Name = "BypassTableLayoutPanel";
            this.BypassTableLayoutPanel.RowCount = 2;
            this.BypassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BypassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BypassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BypassTableLayoutPanel.Size = new System.Drawing.Size(694, 679);
            this.BypassTableLayoutPanel.TabIndex = 2;
            // 
            // BypassFlowLayoutPanel
            // 
            this.BypassFlowLayoutPanel.AutoSize = true;
            this.BypassFlowLayoutPanel.Controls.Add(this.BypassLabel);
            this.BypassFlowLayoutPanel.Controls.Add(this.BypassSelectButton);
            this.BypassFlowLayoutPanel.Controls.Add(this.BypassScanButton);
            this.BypassFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.BypassFlowLayoutPanel.Name = "BypassFlowLayoutPanel";
            this.BypassFlowLayoutPanel.Size = new System.Drawing.Size(297, 40);
            this.BypassFlowLayoutPanel.TabIndex = 0;
            // 
            // BypassLabel
            // 
            this.BypassLabel.AutoSize = true;
            this.BypassLabel.Location = new System.Drawing.Point(3, 0);
            this.BypassLabel.Name = "BypassLabel";
            this.BypassLabel.Padding = new System.Windows.Forms.Padding(7);
            this.BypassLabel.Size = new System.Drawing.Size(129, 38);
            this.BypassLabel.TabIndex = 0;
            this.BypassLabel.Text = "Bypass rules";
            // 
            // BypassSelectButton
            // 
            this.BypassSelectButton.AutoSize = true;
            this.BypassSelectButton.Location = new System.Drawing.Point(138, 3);
            this.BypassSelectButton.Name = "BypassSelectButton";
            this.BypassSelectButton.Size = new System.Drawing.Size(75, 34);
            this.BypassSelectButton.TabIndex = 1;
            this.BypassSelectButton.Text = "Select";
            this.BypassSelectButton.UseVisualStyleBackColor = true;
            this.BypassSelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BypassScanButton
            // 
            this.BypassScanButton.AutoSize = true;
            this.BypassScanButton.Location = new System.Drawing.Point(219, 3);
            this.BypassScanButton.Name = "BypassScanButton";
            this.BypassScanButton.Size = new System.Drawing.Size(75, 34);
            this.BypassScanButton.TabIndex = 2;
            this.BypassScanButton.Text = "Scan";
            this.BypassScanButton.UseVisualStyleBackColor = true;
            this.BypassScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // BypassContentTableLayoutPanel
            // 
            this.BypassContentTableLayoutPanel.AutoSize = true;
            this.BypassContentTableLayoutPanel.ColumnCount = 1;
            this.BypassContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BypassContentTableLayoutPanel.Controls.Add(this.BypassRuleRichTextBox, 0, 0);
            this.BypassContentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassContentTableLayoutPanel.Location = new System.Drawing.Point(3, 49);
            this.BypassContentTableLayoutPanel.Name = "BypassContentTableLayoutPanel";
            this.BypassContentTableLayoutPanel.RowCount = 1;
            this.BypassContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BypassContentTableLayoutPanel.Size = new System.Drawing.Size(688, 627);
            this.BypassContentTableLayoutPanel.TabIndex = 1;
            // 
            // BypassRuleRichTextBox
            // 
            this.BypassRuleRichTextBox.DetectUrls = false;
            this.BypassRuleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassRuleRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.BypassRuleRichTextBox.Name = "BypassRuleRichTextBox";
            this.BypassRuleRichTextBox.Size = new System.Drawing.Size(682, 621);
            this.BypassRuleRichTextBox.TabIndex = 0;
            this.BypassRuleRichTextBox.Text = "";
            this.BypassRuleRichTextBox.WordWrap = false;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1412, 916);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(950, 630);
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Process Mode";
            this.Load += new System.EventHandler(this.ModeForm_Load);
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.ConfigurationLayoutPanel.ResumeLayout(false);
            this.ConfigurationLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.RuleTableLayoutPanel.ResumeLayout(false);
            this.RuleTableLayoutPanel.PerformLayout();
            this.HandleTableLayoutPanel.ResumeLayout(false);
            this.HandleTableLayoutPanel.PerformLayout();
            this.HandleHelperFlowLayoutPanel.ResumeLayout(false);
            this.HandleHelperFlowLayoutPanel.PerformLayout();
            this.HandleContentTableLayoutPanel.ResumeLayout(false);
            this.BypassTableLayoutPanel.ResumeLayout(false);
            this.BypassTableLayoutPanel.PerformLayout();
            this.BypassFlowLayoutPanel.ResumeLayout(false);
            this.BypassFlowLayoutPanel.PerformLayout();
            this.BypassContentTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HandleScanButton;
        public System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Button HandleSelectButton;
        public System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.TextBox FilenameTextBox;
        private RichTextBox HandleRuleRichTextBox;
        private Button ValidationButton;
        private RichTextBox BypassRuleRichTextBox;
        private Button BypassSelectButton;
        private Button BypassScanButton;
        private Label BypassLabel;
        private Label HandleLabel;
        private GroupBox OptionsGroupBox;
        private SyncGlobalCheckBox ProxyDNSCheckBox;
        private SyncGlobalCheckBox HandleDNSCheckBox;
        private SyncGlobalCheckBox HandleUDPCheckBox;
        private SyncGlobalCheckBox HandleTCPCheckBox;
        private CheckBox HandleLANCheckBox;
        private CheckBox HandleLoopbackCheckBox;
        private TextBox ICMPDelayTextBox;
        private TextBox DNSTextBox;
        private SyncGlobalCheckBox HandleICMPCheckBox;
        private SyncGlobalCheckBox HandleProcDNSCheckBox;
        private Label ICMPDelayLabel;
        private Label DNSLabel;
        private FlowLayoutPanel BypassFlowLayoutPanel;
        private FlowLayoutPanel HandleHelperFlowLayoutPanel;
        private TableLayoutPanel ConfigurationLayoutPanel;
        private TableLayoutPanel HandleTableLayoutPanel;
        private TableLayoutPanel RuleTableLayoutPanel;
        private TableLayoutPanel BypassTableLayoutPanel;
        private TableLayoutPanel HandleContentTableLayoutPanel;
        private TableLayoutPanel BypassContentTableLayoutPanel;
        private SyncGlobalCheckBox HandleChildProcCheckBox;
        private Label ModeSpecificOptionsLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TimeTableAutomation.Properties;

namespace TimeTableAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_closedb = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_file1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_file_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.tslbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.welcome_tab = new System.Windows.Forms.TabPage();
            this.pnl_welcome = new System.Windows.Forms.Panel();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.tlp_inner = new System.Windows.Forms.TableLayoutPanel();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.spcn_main_view = new System.Windows.Forms.SplitContainer();
            this.trvw_sidepanel = new System.Windows.Forms.TreeView();
            this.trvw_icon_list = new System.Windows.Forms.ImageList(this.components);
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tsb_toggle_panel = new System.Windows.Forms.ToolStripButton();
            this.tsdd_close = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddi_close_current = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddi_close_others = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddi_close_on_left = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddi_close_on_right = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddi_close_all = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.status_bar.SuspendLayout();
            this.tabs.SuspendLayout();
            this.welcome_tab.SuspendLayout();
            this.pnl_welcome.SuspendLayout();
            this.tlp_main.SuspendLayout();
            this.tlp_inner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcn_main_view)).BeginInit();
            this.spcn_main_view.Panel1.SuspendLayout();
            this.spcn_main_view.Panel2.SuspendLayout();
            this.spcn_main_view.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit,
            this.tsmi_view,
            this.tsmi_help});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.main_menu.Size = new System.Drawing.Size(730, 24);
            this.main_menu.TabIndex = 0;
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file_new,
            this.tsmi_file_open,
            this.tsmi_file_closedb,
            this.tss_file1,
            this.tsmi_file_quit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(51, 20);
            this.tsmi_file.Text = "Dosya";
            // 
            // tsmi_file_new
            // 
            this.tsmi_file_new.Name = "tsmi_file_new";
            this.tsmi_file_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_file_new.Size = new System.Drawing.Size(214, 22);
            this.tsmi_file_new.Text = "Yeni";
            this.tsmi_file_new.Click += new System.EventHandler(this.tsmi_file_new_n_open_Click);
            // 
            // tsmi_file_open
            // 
            this.tsmi_file_open.Name = "tsmi_file_open";
            this.tsmi_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_file_open.Size = new System.Drawing.Size(214, 22);
            this.tsmi_file_open.Text = "Aç";
            this.tsmi_file_open.Click += new System.EventHandler(this.tsmi_file_new_n_open_Click);
            // 
            // tsmi_file_closedb
            // 
            this.tsmi_file_closedb.Name = "tsmi_file_closedb";
            this.tsmi_file_closedb.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsmi_file_closedb.Size = new System.Drawing.Size(214, 22);
            this.tsmi_file_closedb.Text = "Veritabanını Kapat";
            this.tsmi_file_closedb.Visible = false;
            this.tsmi_file_closedb.Click += new System.EventHandler(this.tsmi_file_closedb_Click);
            // 
            // tss_file1
            // 
            this.tss_file1.Name = "tss_file1";
            this.tss_file1.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmi_file_quit
            // 
            this.tsmi_file_quit.Name = "tsmi_file_quit";
            this.tsmi_file_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmi_file_quit.Size = new System.Drawing.Size(214, 22);
            this.tsmi_file_quit.Text = "Çıkış";
            this.tsmi_file_quit.Click += new System.EventHandler(this.tsmi_file_quit_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(61, 20);
            this.tsmi_edit.Text = "Düzenle";
            // 
            // tsmi_view
            // 
            this.tsmi_view.Name = "tsmi_view";
            this.tsmi_view.Size = new System.Drawing.Size(70, 20);
            this.tsmi_view.Text = "Görünüm";
            // 
            // tsmi_help
            // 
            this.tsmi_help.Name = "tsmi_help";
            this.tsmi_help.Size = new System.Drawing.Size(56, 20);
            this.tsmi_help.Text = "Yardım";
            // 
            // status_bar
            // 
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl_status});
            this.status_bar.Location = new System.Drawing.Point(0, 419);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(730, 22);
            this.status_bar.TabIndex = 1;
            // 
            // tslbl_status
            // 
            this.tslbl_status.Name = "tslbl_status";
            this.tslbl_status.Size = new System.Drawing.Size(69, 17);
            this.tslbl_status.Text = "Hoşgeldiniz";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.welcome_tab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(0, 0);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(728, 355);
            this.tabs.TabIndex = 4;
            // 
            // welcome_tab
            // 
            this.welcome_tab.Controls.Add(this.pnl_welcome);
            this.welcome_tab.Location = new System.Drawing.Point(4, 24);
            this.welcome_tab.Name = "welcome_tab";
            this.welcome_tab.Padding = new System.Windows.Forms.Padding(3);
            this.welcome_tab.Size = new System.Drawing.Size(720, 327);
            this.welcome_tab.TabIndex = 0;
            this.welcome_tab.Text = "Hoşgeldiniz";
            this.welcome_tab.UseVisualStyleBackColor = true;
            this.welcome_tab.Resize += new System.EventHandler(this.welcome_tab_Resize);
            // 
            // pnl_welcome
            // 
            this.pnl_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_welcome.Controls.Add(this.tlp_main);
            this.pnl_welcome.Location = new System.Drawing.Point(211, 85);
            this.pnl_welcome.MaximumSize = new System.Drawing.Size(298, 156);
            this.pnl_welcome.MinimumSize = new System.Drawing.Size(298, 156);
            this.pnl_welcome.Name = "pnl_welcome";
            this.pnl_welcome.Size = new System.Drawing.Size(298, 156);
            this.pnl_welcome.TabIndex = 1;
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.lbl_title, 0, 0);
            this.tlp_main.Controls.Add(this.lbl_text, 0, 1);
            this.tlp_main.Controls.Add(this.tlp_inner, 0, 2);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_main.Size = new System.Drawing.Size(298, 156);
            this.tlp_main.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(298, 57);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Hoş Geldiniz";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_text
            // 
            this.lbl_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_text.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_text.Location = new System.Drawing.Point(0, 57);
            this.lbl_text.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(298, 58);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Başlamak için bir veribanı dosyası açın veya yeni bir veritabanı oluşturun";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_inner
            // 
            this.tlp_inner.ColumnCount = 2;
            this.tlp_inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_inner.Controls.Add(this.btn_open, 0, 0);
            this.tlp_inner.Controls.Add(this.btn_new, 1, 0);
            this.tlp_inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_inner.Location = new System.Drawing.Point(3, 118);
            this.tlp_inner.Name = "tlp_inner";
            this.tlp_inner.RowCount = 1;
            this.tlp_inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_inner.Size = new System.Drawing.Size(292, 35);
            this.tlp_inner.TabIndex = 2;
            // 
            // btn_open
            // 
            this.btn_open.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_open.Location = new System.Drawing.Point(56, 6);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Aç";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.welcome_tab_btn_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_new.Location = new System.Drawing.Point(161, 6);
            this.btn_new.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Yeni";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.welcome_tab_btn_Click);
            // 
            // spcn_main_view
            // 
            this.spcn_main_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcn_main_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcn_main_view.Location = new System.Drawing.Point(0, 62);
            this.spcn_main_view.Name = "spcn_main_view";
            // 
            // spcn_main_view.Panel1
            // 
            this.spcn_main_view.Panel1.Controls.Add(this.trvw_sidepanel);
            this.spcn_main_view.Panel1Collapsed = true;
            this.spcn_main_view.Panel1MinSize = 250;
            // 
            // spcn_main_view.Panel2
            // 
            this.spcn_main_view.Panel2.Controls.Add(this.tabs);
            this.spcn_main_view.Panel2MinSize = 400;
            this.spcn_main_view.Size = new System.Drawing.Size(730, 357);
            this.spcn_main_view.SplitterDistance = 250;
            this.spcn_main_view.SplitterIncrement = 5;
            this.spcn_main_view.SplitterWidth = 10;
            this.spcn_main_view.TabIndex = 0;
            // 
            // trvw_sidepanel
            // 
            this.trvw_sidepanel.BackColor = System.Drawing.SystemColors.Control;
            this.trvw_sidepanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvw_sidepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvw_sidepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.trvw_sidepanel.HideSelection = false;
            this.trvw_sidepanel.Indent = 15;
            this.trvw_sidepanel.Location = new System.Drawing.Point(0, 0);
            this.trvw_sidepanel.Name = "trvw_sidepanel";
            this.trvw_sidepanel.Size = new System.Drawing.Size(248, 98);
            this.trvw_sidepanel.StateImageList = this.trvw_icon_list;
            this.trvw_sidepanel.TabIndex = 0;
            this.trvw_sidepanel.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvw_sidepanel_NodeMouseDoubleClick);
            // 
            // trvw_icon_list
            // 
            this.trvw_icon_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("trvw_icon_list.ImageStream")));
            this.trvw_icon_list.TransparentColor = System.Drawing.Color.Transparent;
            this.trvw_icon_list.Images.SetKeyName(0, "select");
            this.trvw_icon_list.Images.SetKeyName(1, "faculties");
            this.trvw_icon_list.Images.SetKeyName(2, "faculty");
            this.trvw_icon_list.Images.SetKeyName(3, "departments");
            this.trvw_icon_list.Images.SetKeyName(4, "program");
            this.trvw_icon_list.Images.SetKeyName(5, "lesson");
            this.trvw_icon_list.Images.SetKeyName(6, "lecturers");
            this.trvw_icon_list.Images.SetKeyName(7, "lecturer_man");
            this.trvw_icon_list.Images.SetKeyName(8, "lecturer_woman");
            this.trvw_icon_list.Images.SetKeyName(9, "collapsed");
            this.trvw_icon_list.Images.SetKeyName(10, "expanded");
            this.trvw_icon_list.Images.SetKeyName(11, "classroom");
            this.trvw_icon_list.Images.SetKeyName(12, "department");
            this.trvw_icon_list.Images.SetKeyName(13, "class");
            this.trvw_icon_list.Images.SetKeyName(14, "it_lab");
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_toggle_panel,
            this.tsdd_close});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolbar.Size = new System.Drawing.Size(730, 38);
            this.toolbar.TabIndex = 2;
            this.toolbar.Text = "toolStrip1";
            // 
            // tsb_toggle_panel
            // 
            this.tsb_toggle_panel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_toggle_panel.Image = global::TimeTableAutomation.Properties.Resources.icons8_navigation_toolbar_left_80;
            this.tsb_toggle_panel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_toggle_panel.Name = "tsb_toggle_panel";
            this.tsb_toggle_panel.Size = new System.Drawing.Size(23, 35);
            this.tsb_toggle_panel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_toggle_panel.Click += new System.EventHandler(this.tsb_toggle_panel_Click);
            // 
            // tsdd_close
            // 
            this.tsdd_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsdd_close.DoubleClickEnabled = true;
            this.tsdd_close.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddi_close_current,
            this.tsddi_close_others,
            this.tsddi_close_on_left,
            this.tsddi_close_on_right,
            this.tsddi_close_all});
            this.tsdd_close.Image = global::TimeTableAutomation.Properties.Resources.close_icon;
            this.tsdd_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdd_close.Name = "tsdd_close";
            this.tsdd_close.Size = new System.Drawing.Size(50, 35);
            this.tsdd_close.Text = "Kapat";
            this.tsdd_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsddi_close_current
            // 
            this.tsddi_close_current.Name = "tsddi_close_current";
            this.tsddi_close_current.Size = new System.Drawing.Size(180, 22);
            this.tsddi_close_current.Text = "Mevcut Sekmeyi";
            this.tsddi_close_current.Click += new System.EventHandler(this.tsddi_close_current_Click);
            // 
            // tsddi_close_others
            // 
            this.tsddi_close_others.Name = "tsddi_close_others";
            this.tsddi_close_others.Size = new System.Drawing.Size(180, 22);
            this.tsddi_close_others.Text = "Diğer Sekmeleri";
            this.tsddi_close_others.Click += new System.EventHandler(this.tsddi_close_others_Click);
            // 
            // tsddi_close_on_left
            // 
            this.tsddi_close_on_left.Name = "tsddi_close_on_left";
            this.tsddi_close_on_left.Size = new System.Drawing.Size(180, 22);
            this.tsddi_close_on_left.Text = "Soldaki Sekmeleri";
            this.tsddi_close_on_left.Click += new System.EventHandler(this.tsddi_close_on_left_Click);
            // 
            // tsddi_close_on_right
            // 
            this.tsddi_close_on_right.Name = "tsddi_close_on_right";
            this.tsddi_close_on_right.Size = new System.Drawing.Size(180, 22);
            this.tsddi_close_on_right.Text = "Sağdaki Sekmeleri";
            this.tsddi_close_on_right.Click += new System.EventHandler(this.tsddi_close_on_right_Click);
            // 
            // tsddi_close_all
            // 
            this.tsddi_close_all.Name = "tsddi_close_all";
            this.tsddi_close_all.Size = new System.Drawing.Size(180, 22);
            this.tsddi_close_all.Text = "Tüm Sekmeleri";
            this.tsddi_close_all.Click += new System.EventHandler(this.tsddi_close_all_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 441);
            this.Controls.Add(this.spcn_main_view);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.main_menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu;
            this.MinimumSize = new System.Drawing.Size(746, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı Otomasyonu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.welcome_tab.ResumeLayout(false);
            this.pnl_welcome.ResumeLayout(false);
            this.tlp_main.ResumeLayout(false);
            this.tlp_inner.ResumeLayout(false);
            this.spcn_main_view.Panel1.ResumeLayout(false);
            this.spcn_main_view.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcn_main_view)).EndInit();
            this.spcn_main_view.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip main_menu;
        private ToolStripMenuItem tsmi_file;
        private ToolStripMenuItem tsmi_file_new;
        private ToolStripMenuItem tsmi_file_open;
        private ToolStripMenuItem tsmi_file_quit;
        private ToolStripMenuItem tsmi_edit;
        private ToolStripMenuItem tsmi_view;
        private ToolStripMenuItem tsmi_help;
        private StatusStrip status_bar;
        private ToolStripMenuItem tsmi_file_closedb;
        private ToolStripSeparator tss_file1;
        private ColumnHeader columnHeader1;
        private TabControl tabs;
        private SplitContainer spcn_main_view;
        private TreeView trvw_sidepanel;
        private ToolStripStatusLabel tslbl_status;
        private ImageList trvw_icon_list;
        private ToolStrip toolbar;
        private ToolStripButton tsb_toggle_panel;
        private Panel pnl_welcome;
        private TableLayoutPanel tlp_main;
        private Label lbl_title;
        private Label lbl_text;
        private TableLayoutPanel tlp_inner;
        private Button btn_open;
        private Button btn_new;
        private TabPage welcome_tab;
        private ToolStripDropDownButton tsdd_close;
        private ToolStripMenuItem tsddi_close_current;
        private ToolStripMenuItem tsddi_close_others;
        private ToolStripMenuItem tsddi_close_all;
        private ToolStripMenuItem tsddi_close_on_left;
        private ToolStripMenuItem tsddi_close_on_right;
    }
}


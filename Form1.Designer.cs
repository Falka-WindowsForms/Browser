
namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sites_list = new System.Windows.Forms.ListBox();
            this.categories_list = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.url_textBox = new System.Windows.Forms.TextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.front_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sites_list);
            this.groupBox1.Controls.Add(this.categories_list);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(325, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sites_list
            // 
            this.sites_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sites_list.FormattingEnabled = true;
            this.sites_list.ItemHeight = 24;
            this.sites_list.Location = new System.Drawing.Point(6, 60);
            this.sites_list.Margin = new System.Windows.Forms.Padding(6);
            this.sites_list.Name = "sites_list";
            this.sites_list.Size = new System.Drawing.Size(313, 415);
            this.sites_list.TabIndex = 1;
            this.sites_list.SelectedIndexChanged += new System.EventHandler(this.sites_list_SelectedIndexChanged);
            // 
            // categories_list
            // 
            this.categories_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.categories_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_list.FormattingEnabled = true;
            this.categories_list.Location = new System.Drawing.Point(6, 28);
            this.categories_list.Margin = new System.Windows.Forms.Padding(6);
            this.categories_list.Name = "categories_list";
            this.categories_list.Size = new System.Drawing.Size(313, 32);
            this.categories_list.TabIndex = 0;
            this.categories_list.SelectedIndexChanged += new System.EventHandler(this.categories_list_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.url_textBox);
            this.groupBox2.Controls.Add(this.go_button);
            this.groupBox2.Controls.Add(this.home_button);
            this.groupBox2.Controls.Add(this.front_button);
            this.groupBox2.Controls.Add(this.back_button);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(325, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1013, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // url_textBox
            // 
            this.url_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.url_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.url_textBox.Location = new System.Drawing.Point(297, 28);
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(613, 31);
            this.url_textBox.TabIndex = 4;
            this.url_textBox.Click += new System.EventHandler(this.url_textBox_Click);
            this.url_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_textBox_KeyDown);
            // 
            // go_button
            // 
            this.go_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.go_button.Location = new System.Drawing.Point(910, 28);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(97, 33);
            this.go_button.TabIndex = 3;
            this.go_button.Text = "Go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // home_button
            // 
            this.home_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.home_button.Location = new System.Drawing.Point(200, 28);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(97, 33);
            this.home_button.TabIndex = 2;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // front_button
            // 
            this.front_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.front_button.Location = new System.Drawing.Point(103, 28);
            this.front_button.Name = "front_button";
            this.front_button.Size = new System.Drawing.Size(97, 33);
            this.front_button.TabIndex = 1;
            this.front_button.Text = ">>>";
            this.front_button.UseVisualStyleBackColor = true;
            this.front_button.Click += new System.EventHandler(this.front_button_Click);
            // 
            // back_button
            // 
            this.back_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_button.Location = new System.Drawing.Point(6, 28);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(97, 33);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "<<<";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem,
            this.editCategoryToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "&Categories";
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSiteToolStripMenuItem,
            this.deleteSiteToolStripMenuItem,
            this.editSiteToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "&Sites";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(325, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 414);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1007, 386);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.bing.com", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCategoryToolStripMenuItem.Text = "&Add category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCategoryToolStripMenuItem.Text = "&Delete category";
            this.deleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteCategoryToolStripMenuItem_Click);
            // 
            // editCategoryToolStripMenuItem
            // 
            this.editCategoryToolStripMenuItem.Name = "editCategoryToolStripMenuItem";
            this.editCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCategoryToolStripMenuItem.Text = "&Edit category";
            this.editCategoryToolStripMenuItem.Click += new System.EventHandler(this.editCategoryToolStripMenuItem_Click);
            // 
            // addSiteToolStripMenuItem
            // 
            this.addSiteToolStripMenuItem.Name = "addSiteToolStripMenuItem";
            this.addSiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSiteToolStripMenuItem.Text = "&Add site";
            this.addSiteToolStripMenuItem.Click += new System.EventHandler(this.addSiteToolStripMenuItem_Click);
            // 
            // deleteSiteToolStripMenuItem
            // 
            this.deleteSiteToolStripMenuItem.Name = "deleteSiteToolStripMenuItem";
            this.deleteSiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSiteToolStripMenuItem.Text = "&Delete site";
            this.deleteSiteToolStripMenuItem.Click += new System.EventHandler(this.deleteSiteToolStripMenuItem_Click);
            // 
            // editSiteToolStripMenuItem
            // 
            this.editSiteToolStripMenuItem.Name = "editSiteToolStripMenuItem";
            this.editSiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editSiteToolStripMenuItem.Text = "&Edit site";
            this.editSiteToolStripMenuItem.Click += new System.EventHandler(this.editSiteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox sites_list;
        private System.Windows.Forms.ComboBox categories_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button front_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox url_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSiteToolStripMenuItem;
    }
}


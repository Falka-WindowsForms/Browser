
namespace Browser
{
    partial class DeleteSiteForm
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
            this.categories_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.action_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.site_name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categories_list
            // 
            this.categories_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_list.FormattingEnabled = true;
            this.categories_list.Location = new System.Drawing.Point(15, 40);
            this.categories_list.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.categories_list.Name = "categories_list";
            this.categories_list.Size = new System.Drawing.Size(440, 33);
            this.categories_list.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Site category:";
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(130, 153);
            this.action_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(208, 65);
            this.action_button.TabIndex = 13;
            this.action_button.Text = "Delete";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Site name:";
            // 
            // site_name_textBox
            // 
            this.site_name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site_name_textBox.Location = new System.Drawing.Point(10, 113);
            this.site_name_textBox.Name = "site_name_textBox";
            this.site_name_textBox.Size = new System.Drawing.Size(445, 31);
            this.site_name_textBox.TabIndex = 19;
            // 
            // DeleteSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 233);
            this.Controls.Add(this.site_name_textBox);
            this.Controls.Add(this.categories_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DeleteSiteForm";
            this.Text = "DeleteSiteForm";
            this.Load += new System.EventHandler(this.DeleteSiteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categories_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox site_name_textBox;
    }
}
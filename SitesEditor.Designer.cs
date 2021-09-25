
namespace Browser
{
    partial class SitesEditor
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
            this.action_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categories_list = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(65, 209);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(104, 34);
            this.action_button.TabIndex = 5;
            this.action_button.Text = "Action";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Site name:";
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(11, 111);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(223, 29);
            this.name_field.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Site address:";
            // 
            // address_field
            // 
            this.address_field.Location = new System.Drawing.Point(11, 174);
            this.address_field.Name = "address_field";
            this.address_field.Size = new System.Drawing.Size(223, 29);
            this.address_field.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Site category:";
            // 
            // categories_list
            // 
            this.categories_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_list.FormattingEnabled = true;
            this.categories_list.Location = new System.Drawing.Point(12, 48);
            this.categories_list.Name = "categories_list";
            this.categories_list.Size = new System.Drawing.Size(222, 32);
            this.categories_list.TabIndex = 10;
            // 
            // SitesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 253);
            this.Controls.Add(this.categories_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address_field);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_field);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "SitesEditor";
            this.Text = "SitesEditor";
            this.Load += new System.EventHandler(this.SitesEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categories_list;
    }
}
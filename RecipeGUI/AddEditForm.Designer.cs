namespace RecipeGUI
{
    partial class AddEditForm
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
            this.tb_RecipeName = new System.Windows.Forms.TextBox();
            this.rtb_Zubereitung = new System.Windows.Forms.RichTextBox();
            this.lb_reciptItems = new System.Windows.Forms.ListBox();
            this.cb_ingredient = new System.Windows.Forms.ComboBox();
            this.tb_einheit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_ammount = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_ammount)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_RecipeName
            // 
            this.tb_RecipeName.Location = new System.Drawing.Point(13, 13);
            this.tb_RecipeName.Name = "tb_RecipeName";
            this.tb_RecipeName.Size = new System.Drawing.Size(310, 22);
            this.tb_RecipeName.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.rtb_Zubereitung.Location = new System.Drawing.Point(12, 295);
            this.rtb_Zubereitung.Name = "richTextBox1";
            this.rtb_Zubereitung.Size = new System.Drawing.Size(308, 179);
            this.rtb_Zubereitung.TabIndex = 1;
            this.rtb_Zubereitung.Text = "";
            // 
            // lb_reciptItems
            // 
            this.lb_reciptItems.FormattingEnabled = true;
            this.lb_reciptItems.ItemHeight = 16;
            this.lb_reciptItems.Location = new System.Drawing.Point(12, 141);
            this.lb_reciptItems.Name = "lb_reciptItems";
            this.lb_reciptItems.Size = new System.Drawing.Size(308, 100);
            this.lb_reciptItems.TabIndex = 2;
            // 
            // cb_ingredient
            // 
            this.cb_ingredient.FormattingEnabled = true;
            this.cb_ingredient.Location = new System.Drawing.Point(13, 42);
            this.cb_ingredient.Name = "cb_ingredient";
            this.cb_ingredient.Size = new System.Drawing.Size(121, 24);
            this.cb_ingredient.TabIndex = 3;
            // 
            // tb_einheit
            // 
            this.tb_einheit.Location = new System.Drawing.Point(225, 43);
            this.tb_einheit.Name = "tb_einheit";
            this.tb_einheit.Size = new System.Drawing.Size(98, 22);
            this.tb_einheit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zutaten";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zutat hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_addReciptItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zubereitung";
            // 
            // num_ammount
            // 
            this.num_ammount.Location = new System.Drawing.Point(140, 44);
            this.num_ammount.Name = "num_ammount";
            this.num_ammount.Size = new System.Drawing.Size(79, 22);
            this.num_ammount.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(245, 488);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 523);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.num_ammount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_einheit);
            this.Controls.Add(this.cb_ingredient);
            this.Controls.Add(this.lb_reciptItems);
            this.Controls.Add(this.rtb_Zubereitung);
            this.Controls.Add(this.tb_RecipeName);
            this.Name = "AddEditForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_ammount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_RecipeName;
        private System.Windows.Forms.RichTextBox rtb_Zubereitung;
        private System.Windows.Forms.ListBox lb_reciptItems;
        private System.Windows.Forms.ComboBox cb_ingredient;
        private System.Windows.Forms.TextBox tb_einheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_ammount;
        private System.Windows.Forms.Button btn_save;
    }
}
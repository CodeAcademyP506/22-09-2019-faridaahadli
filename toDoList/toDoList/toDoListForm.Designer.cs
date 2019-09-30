namespace toDoList
{
    partial class toDoListForm
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
            this.lstBoxDo = new System.Windows.Forms.CheckedListBox();
            this.txtBxListItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxDo
            // 
            this.lstBoxDo.FormattingEnabled = true;
            this.lstBoxDo.Location = new System.Drawing.Point(464, 12);
            this.lstBoxDo.Name = "lstBoxDo";
            this.lstBoxDo.Size = new System.Drawing.Size(331, 409);
            this.lstBoxDo.TabIndex = 0;
            this.lstBoxDo.SelectedIndexChanged += new System.EventHandler(this.lstBoxDo_SelectedIndexChanged);
            // 
            // txtBxListItem
            // 
            this.txtBxListItem.Location = new System.Drawing.Point(21, 191);
            this.txtBxListItem.Multiline = true;
            this.txtBxListItem.Name = "txtBxListItem";
            this.txtBxListItem.Size = new System.Drawing.Size(423, 59);
            this.txtBxListItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxListItem);
            this.Controls.Add(this.lstBoxDo);
            this.Name = "toDoListForm";
            this.Text = "toDoListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstBoxDo;
        private System.Windows.Forms.TextBox txtBxListItem;
        private System.Windows.Forms.Button btnAdd;
    }
}
namespace IcecreamForGarden
{
    partial class frmBoard
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
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.lbMapList = new System.Windows.Forms.ListBox();
            this.btnRunMapItem = new System.Windows.Forms.Button();
            this.lbRunMapItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.AutoSize = true;
            this.btnReadFromFile.Location = new System.Drawing.Point(8, 8);
            this.btnReadFromFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(103, 26);
            this.btnReadFromFile.TabIndex = 0;
            this.btnReadFromFile.Text = "Read from file";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // lbMapList
            // 
            this.lbMapList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMapList.DisplayMember = "name";
            this.lbMapList.FormattingEnabled = true;
            this.lbMapList.ItemHeight = 15;
            this.lbMapList.Location = new System.Drawing.Point(9, 42);
            this.lbMapList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMapList.Name = "lbMapList";
            this.lbMapList.Size = new System.Drawing.Size(363, 154);
            this.lbMapList.Sorted = true;
            this.lbMapList.TabIndex = 2;
            this.lbMapList.SelectedIndexChanged += new System.EventHandler(this.lbMapList_SelectedIndexChanged);
            // 
            // btnRunMapItem
            // 
            this.btnRunMapItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunMapItem.AutoSize = true;
            this.btnRunMapItem.Location = new System.Drawing.Point(271, 8);
            this.btnRunMapItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRunMapItem.Name = "btnRunMapItem";
            this.btnRunMapItem.Size = new System.Drawing.Size(102, 26);
            this.btnRunMapItem.TabIndex = 3;
            this.btnRunMapItem.Text = "Run map item";
            this.btnRunMapItem.UseVisualStyleBackColor = true;
            this.btnRunMapItem.Click += new System.EventHandler(this.btnRunMapItem_Click);
            // 
            // lbRunMapItem
            // 
            this.lbRunMapItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRunMapItem.Location = new System.Drawing.Point(118, 8);
            this.lbRunMapItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRunMapItem.Name = "lbRunMapItem";
            this.lbRunMapItem.Size = new System.Drawing.Size(146, 26);
            this.lbRunMapItem.TabIndex = 4;
            this.lbRunMapItem.Text = "0 / 0";
            this.lbRunMapItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 205);
            this.Controls.Add(this.lbRunMapItem);
            this.Controls.Add(this.btnRunMapItem);
            this.Controls.Add(this.lbMapList);
            this.Controls.Add(this.btnReadFromFile);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBoard";
            this.Text = "Ice cream for Garden";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBoard_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.ListBox lbMapList;
        private System.Windows.Forms.Button btnRunMapItem;
        private System.Windows.Forms.Label lbRunMapItem;
    }
}


namespace CentosCashFlow.ChildForms
{
    partial class CurrencyItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTransaction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCurrencyCode = new System.Windows.Forms.Label();
            this.labelCurrencyName = new System.Windows.Forms.Label();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBoxTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(68, 75);
            this.panel1.MinimumSize = new System.Drawing.Size(68, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(68, 75);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxTransaction
            // 
            this.pictureBoxTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTransaction.Image = global::CentosCashFlow.Properties.Resources.globalization;
            this.pictureBoxTransaction.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTransaction.Name = "pictureBoxTransaction";
            this.pictureBoxTransaction.Size = new System.Drawing.Size(56, 63);
            this.pictureBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTransaction.TabIndex = 0;
            this.pictureBoxTransaction.TabStop = false;
            this.pictureBoxTransaction.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelExchangeRate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 72);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnEditing
            // 
            this.btnEditing.BackColor = System.Drawing.Color.Black;
            this.btnEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditing.FlatAppearance.BorderSize = 0;
            this.btnEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditing.ForeColor = System.Drawing.Color.White;
            this.btnEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditing.Location = new System.Drawing.Point(391, 12);
            this.btnEditing.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(90, 48);
            this.btnEditing.TabIndex = 27;
            this.btnEditing.Text = "Edit";
            this.btnEditing.UseVisualStyleBackColor = false;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // btnDeleting
            // 
            this.btnDeleting.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleting.FlatAppearance.BorderSize = 0;
            this.btnDeleting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleting.ForeColor = System.Drawing.Color.White;
            this.btnDeleting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleting.Location = new System.Drawing.Point(503, 12);
            this.btnDeleting.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(91, 48);
            this.btnDeleting.TabIndex = 26;
            this.btnDeleting.Text = "Delete";
            this.btnDeleting.UseVisualStyleBackColor = false;
            this.btnDeleting.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCurrencyCode);
            this.panel2.Controls.Add(this.labelCurrencyName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 64);
            this.panel2.TabIndex = 22;
            this.panel2.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // labelCurrencyCode
            // 
            this.labelCurrencyCode.AutoSize = true;
            this.labelCurrencyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCurrencyCode.ForeColor = System.Drawing.Color.Black;
            this.labelCurrencyCode.Location = new System.Drawing.Point(0, 31);
            this.labelCurrencyCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrencyCode.Name = "labelCurrencyCode";
            this.labelCurrencyCode.Size = new System.Drawing.Size(54, 25);
            this.labelCurrencyCode.TabIndex = 5;
            this.labelCurrencyCode.Text = "VND";
            this.labelCurrencyCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCurrencyCode.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // labelCurrencyName
            // 
            this.labelCurrencyName.AutoSize = true;
            this.labelCurrencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.labelCurrencyName.Location = new System.Drawing.Point(0, 6);
            this.labelCurrencyName.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrencyName.Name = "labelCurrencyName";
            this.labelCurrencyName.Size = new System.Drawing.Size(161, 26);
            this.labelCurrencyName.TabIndex = 4;
            this.labelCurrencyName.Text = "Việt Nam Đồng";
            this.labelCurrencyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCurrencyName.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExchangeRate.Location = new System.Drawing.Point(190, 0);
            this.labelExchangeRate.Margin = new System.Windows.Forms.Padding(0);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(190, 72);
            this.labelExchangeRate.TabIndex = 18;
            this.labelExchangeRate.Text = "23590.00";
            this.labelExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelExchangeRate.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // CurrencyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(675, 74);
            this.Name = "CurrencyItem";
            this.Size = new System.Drawing.Size(673, 72);
            this.Load += new System.EventHandler(this.CurrencyItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCurrencyCode;
        private System.Windows.Forms.Label labelCurrencyName;
        private System.Windows.Forms.Label labelExchangeRate;
    }
}

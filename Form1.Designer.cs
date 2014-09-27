namespace ASCII2Hex
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxASCII = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearASCII = new System.Windows.Forms.Button();
            this.buttonASCII2Hex = new System.Windows.Forms.Button();
            this.buttonHex2ASCII = new System.Windows.Forms.Button();
            this.buttonClearHex = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 50);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(612, 427);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxASCII);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASCII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxHex);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 427);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hex";
            // 
            // textBoxASCII
            // 
            this.textBoxASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxASCII.Location = new System.Drawing.Point(3, 21);
            this.textBoxASCII.Multiline = true;
            this.textBoxASCII.Name = "textBoxASCII";
            this.textBoxASCII.Size = new System.Drawing.Size(300, 403);
            this.textBoxASCII.TabIndex = 0;
            // 
            // textBoxHex
            // 
            this.textBoxHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHex.Location = new System.Drawing.Point(3, 21);
            this.textBoxHex.Multiline = true;
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(296, 403);
            this.textBoxHex.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonClearASCII, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonASCII2Hex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHex2ASCII, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClearHex, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonClearASCII
            // 
            this.buttonClearASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearASCII.Location = new System.Drawing.Point(3, 3);
            this.buttonClearASCII.Name = "buttonClearASCII";
            this.buttonClearASCII.Size = new System.Drawing.Size(147, 44);
            this.buttonClearASCII.TabIndex = 0;
            this.buttonClearASCII.Text = "Clear ASCII";
            this.buttonClearASCII.UseVisualStyleBackColor = true;
            this.buttonClearASCII.Click += new System.EventHandler(this.buttonClearASCII_Click);
            // 
            // buttonASCII2Hex
            // 
            this.buttonASCII2Hex.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonASCII2Hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonASCII2Hex.Location = new System.Drawing.Point(156, 3);
            this.buttonASCII2Hex.Name = "buttonASCII2Hex";
            this.buttonASCII2Hex.Size = new System.Drawing.Size(147, 44);
            this.buttonASCII2Hex.TabIndex = 1;
            this.buttonASCII2Hex.Text = "ASCII -> Hex";
            this.buttonASCII2Hex.UseVisualStyleBackColor = false;
            this.buttonASCII2Hex.Click += new System.EventHandler(this.buttonASCII2Hex_Click);
            // 
            // buttonHex2ASCII
            // 
            this.buttonHex2ASCII.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHex2ASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHex2ASCII.Location = new System.Drawing.Point(309, 3);
            this.buttonHex2ASCII.Name = "buttonHex2ASCII";
            this.buttonHex2ASCII.Size = new System.Drawing.Size(147, 44);
            this.buttonHex2ASCII.TabIndex = 2;
            this.buttonHex2ASCII.Text = "Hex -> ASCII";
            this.buttonHex2ASCII.UseVisualStyleBackColor = false;
            this.buttonHex2ASCII.Click += new System.EventHandler(this.buttonHex2ASCII_Click);
            // 
            // buttonClearHex
            // 
            this.buttonClearHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearHex.Location = new System.Drawing.Point(462, 3);
            this.buttonClearHex.Name = "buttonClearHex";
            this.buttonClearHex.Size = new System.Drawing.Size(147, 44);
            this.buttonClearHex.TabIndex = 3;
            this.buttonClearHex.Text = "OCROBOT-WIFI";
            this.buttonClearHex.UseVisualStyleBackColor = true;
            this.buttonClearHex.Click += new System.EventHandler(this.buttonClearHex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII2Hex";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonClearASCII;
        private System.Windows.Forms.Button buttonASCII2Hex;
        private System.Windows.Forms.Button buttonHex2ASCII;
        private System.Windows.Forms.Button buttonClearHex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxASCII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxHex;
    }
}


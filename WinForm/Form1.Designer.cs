namespace WinForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xmlOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soapOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serilizeEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlOlarakAktarToolStripMenuItem,
            this.jsonOlarakAktarToolStripMenuItem,
            this.soapOlarakAktarToolStripMenuItem,
            this.serilizeEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // xmlOlarakAktarToolStripMenuItem
            // 
            this.xmlOlarakAktarToolStripMenuItem.Name = "xmlOlarakAktarToolStripMenuItem";
            this.xmlOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xmlOlarakAktarToolStripMenuItem.Text = "Xml Olarak Aktar";
            this.xmlOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.xmlOlarakAktarToolStripMenuItem_Click);
            // 
            // jsonOlarakAktarToolStripMenuItem
            // 
            this.jsonOlarakAktarToolStripMenuItem.Name = "jsonOlarakAktarToolStripMenuItem";
            this.jsonOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jsonOlarakAktarToolStripMenuItem.Text = "Json Olarak Aktar";
            this.jsonOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.jsonOlarakAktarToolStripMenuItem_Click);
            // 
            // soapOlarakAktarToolStripMenuItem
            // 
            this.soapOlarakAktarToolStripMenuItem.Name = "soapOlarakAktarToolStripMenuItem";
            this.soapOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soapOlarakAktarToolStripMenuItem.Text = "Soap Olarak Aktar";
            this.soapOlarakAktarToolStripMenuItem.Click += new System.EventHandler(this.soapOlarakAktarToolStripMenuItem_Click);
            // 
            // serilizeEtToolStripMenuItem
            // 
            this.serilizeEtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.productToolStripMenuItem,
            this.personToolStripMenuItem});
            this.serilizeEtToolStripMenuItem.Name = "serilizeEtToolStripMenuItem";
            this.serilizeEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serilizeEtToolStripMenuItem.Text = "Serilize Et";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.personToolStripMenuItem.Text = "Person";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dışa Aktar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xmlOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soapOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serilizeEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
    }
}


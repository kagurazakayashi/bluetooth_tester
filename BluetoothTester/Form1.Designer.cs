namespace BluetoothTester
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSearchBluetooth = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLinkStart = new System.Windows.Forms.Button();
            this.listBluetooth = new System.Windows.Forms.ListBox();
            this.listBluetoothData = new System.Windows.Forms.BindingSource(this.components);
            this.btnSent = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBluetoothData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchBluetooth
            // 
            this.btnSearchBluetooth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchBluetooth.Location = new System.Drawing.Point(8, 443);
            this.btnSearchBluetooth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBluetooth.Name = "btnSearchBluetooth";
            this.btnSearchBluetooth.Size = new System.Drawing.Size(100, 36);
            this.btnSearchBluetooth.TabIndex = 0;
            this.btnSearchBluetooth.Text = "搜索";
            this.btnSearchBluetooth.UseVisualStyleBackColor = true;
            this.btnSearchBluetooth.Click += new System.EventHandler(this.btnSearchBluetooth_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLinkStart);
            this.groupBox1.Controls.Add(this.listBluetooth);
            this.groupBox1.Controls.Add(this.btnSearchBluetooth);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(267, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "蓝牙设备";
            // 
            // btnLinkStart
            // 
            this.btnLinkStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLinkStart.Location = new System.Drawing.Point(160, 443);
            this.btnLinkStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLinkStart.Name = "btnLinkStart";
            this.btnLinkStart.Size = new System.Drawing.Size(100, 36);
            this.btnLinkStart.TabIndex = 3;
            this.btnLinkStart.Text = "连接";
            this.btnLinkStart.UseVisualStyleBackColor = true;
            this.btnLinkStart.Click += new System.EventHandler(this.btnLinkStart_Click);
            // 
            // listBluetooth
            // 
            this.listBluetooth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBluetooth.FormattingEnabled = true;
            this.listBluetooth.ItemHeight = 19;
            this.listBluetooth.Location = new System.Drawing.Point(7, 26);
            this.listBluetooth.Name = "listBluetooth";
            this.listBluetooth.Size = new System.Drawing.Size(253, 403);
            this.listBluetooth.TabIndex = 2;
            // 
            // btnSent
            // 
            this.btnSent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSent.Location = new System.Drawing.Point(873, 457);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(100, 36);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "发送";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(287, 463);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(580, 25);
            this.txtMessage.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(287, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 422);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 517);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBluetoothData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchBluetooth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource listBluetoothData;
        private System.Windows.Forms.ListBox listBluetooth;
        private System.Windows.Forms.Button btnLinkStart;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox listBox1;
    }
}


namespace RFIDcommunity
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.labcomchoice = new System.Windows.Forms.Label();
            this.ComportName = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.btnreadantid = new System.Windows.Forms.Button();
            this.radByte = new System.Windows.Forms.RadioButton();
            this.radAsc = new System.Windows.Forms.RadioButton();
            this.btnReadVersion = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtantid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labcomchoice
            // 
            this.labcomchoice.AutoSize = true;
            this.labcomchoice.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcomchoice.Location = new System.Drawing.Point(12, 23);
            this.labcomchoice.Name = "labcomchoice";
            this.labcomchoice.Size = new System.Drawing.Size(79, 15);
            this.labcomchoice.TabIndex = 6;
            this.labcomchoice.Text = "選擇COM :";
            // 
            // ComportName
            // 
            this.ComportName.FormattingEnabled = true;
            this.ComportName.Location = new System.Drawing.Point(87, 22);
            this.ComportName.Name = "ComportName";
            this.ComportName.Size = new System.Drawing.Size(121, 20);
            this.ComportName.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(226, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 45);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(9, 148);
            this.txtLabel.Multiline = true;
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLabel.Size = new System.Drawing.Size(644, 240);
            this.txtLabel.TabIndex = 8;
            // 
            // btnreadantid
            // 
            this.btnreadantid.Location = new System.Drawing.Point(15, 85);
            this.btnreadantid.Name = "btnreadantid";
            this.btnreadantid.Size = new System.Drawing.Size(106, 33);
            this.btnreadantid.TabIndex = 9;
            this.btnreadantid.Text = "Read ANT ID";
            this.btnreadantid.UseVisualStyleBackColor = true;
            this.btnreadantid.Click += new System.EventHandler(this.btnreadantid_Click);
            // 
            // radByte
            // 
            this.radByte.AutoSize = true;
            this.radByte.Location = new System.Drawing.Point(330, 40);
            this.radByte.Name = "radByte";
            this.radByte.Size = new System.Drawing.Size(45, 16);
            this.radByte.TabIndex = 10;
            this.radByte.TabStop = true;
            this.radByte.Text = "Byte";
            this.radByte.UseVisualStyleBackColor = true;
            // 
            // radAsc
            // 
            this.radAsc.AutoSize = true;
            this.radAsc.Location = new System.Drawing.Point(390, 40);
            this.radAsc.Name = "radAsc";
            this.radAsc.Size = new System.Drawing.Size(45, 16);
            this.radAsc.TabIndex = 11;
            this.radAsc.TabStop = true;
            this.radAsc.Text = "ASC";
            this.radAsc.UseVisualStyleBackColor = true;
            // 
            // btnReadVersion
            // 
            this.btnReadVersion.Location = new System.Drawing.Point(145, 85);
            this.btnReadVersion.Name = "btnReadVersion";
            this.btnReadVersion.Size = new System.Drawing.Size(106, 33);
            this.btnReadVersion.TabIndex = 12;
            this.btnReadVersion.Text = "Read Version";
            this.btnReadVersion.UseVisualStyleBackColor = true;
            this.btnReadVersion.Click += new System.EventHandler(this.btnReadVersion_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(276, 85);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(106, 33);
            this.btnScan.TabIndex = 13;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(578, 97);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 45);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ANT ID :";
            // 
            // txtantid
            // 
            this.txtantid.Location = new System.Drawing.Point(400, 7);
            this.txtantid.Name = "txtantid";
            this.txtantid.Size = new System.Drawing.Size(40, 22);
            this.txtantid.TabIndex = 16;
            this.txtantid.Text = "01";
            this.txtantid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 408);
            this.Controls.Add(this.txtantid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnReadVersion);
            this.Controls.Add(this.radAsc);
            this.Controls.Add(this.radByte);
            this.Controls.Add(this.btnreadantid);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labcomchoice);
            this.Controls.Add(this.ComportName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labcomchoice;
        private System.Windows.Forms.ComboBox ComportName;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Button btnreadantid;
        private System.Windows.Forms.RadioButton radByte;
        private System.Windows.Forms.RadioButton radAsc;
        private System.Windows.Forms.Button btnReadVersion;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtantid;
    }
}


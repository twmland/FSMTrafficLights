namespace FSMTrafficLights
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
            this.panelGreenLightH = new System.Windows.Forms.Panel();
            this.panelYellowLightH = new System.Windows.Forms.Panel();
            this.panelRedLightH = new System.Windows.Forms.Panel();
            this.panelGreenLightV = new System.Windows.Forms.Panel();
            this.panelYellowLightV = new System.Windows.Forms.Panel();
            this.panelRedLightV = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGreenLightH
            // 
            this.panelGreenLightH.Location = new System.Drawing.Point(0, 0);
            this.panelGreenLightH.Name = "panelGreenLightH";
            this.panelGreenLightH.Size = new System.Drawing.Size(29, 39);
            this.panelGreenLightH.TabIndex = 0;
            // 
            // panelYellowLightH
            // 
            this.panelYellowLightH.Location = new System.Drawing.Point(37, 0);
            this.panelYellowLightH.Name = "panelYellowLightH";
            this.panelYellowLightH.Size = new System.Drawing.Size(29, 39);
            this.panelYellowLightH.TabIndex = 1;
            // 
            // panelRedLightH
            // 
            this.panelRedLightH.Location = new System.Drawing.Point(75, 0);
            this.panelRedLightH.Name = "panelRedLightH";
            this.panelRedLightH.Size = new System.Drawing.Size(29, 39);
            this.panelRedLightH.TabIndex = 2;
            // 
            // panelGreenLightV
            // 
            this.panelGreenLightV.Location = new System.Drawing.Point(213, 56);
            this.panelGreenLightV.Name = "panelGreenLightV";
            this.panelGreenLightV.Size = new System.Drawing.Size(39, 29);
            this.panelGreenLightV.TabIndex = 3;
            // 
            // panelYellowLightV
            // 
            this.panelYellowLightV.Location = new System.Drawing.Point(213, 90);
            this.panelYellowLightV.Name = "panelYellowLightV";
            this.panelYellowLightV.Size = new System.Drawing.Size(39, 29);
            this.panelYellowLightV.TabIndex = 4;
            // 
            // panelRedLightV
            // 
            this.panelRedLightV.Location = new System.Drawing.Point(213, 125);
            this.panelRedLightV.Name = "panelRedLightV";
            this.panelRedLightV.Size = new System.Drawing.Size(39, 29);
            this.panelRedLightV.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRedLightV);
            this.Controls.Add(this.panelYellowLightV);
            this.Controls.Add(this.panelGreenLightV);
            this.Controls.Add(this.panelRedLightH);
            this.Controls.Add(this.panelYellowLightH);
            this.Controls.Add(this.panelGreenLightH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGreenLightH;
        private System.Windows.Forms.Panel panelYellowLightH;
        private System.Windows.Forms.Panel panelRedLightH;
        private System.Windows.Forms.Panel panelGreenLightV;
        private System.Windows.Forms.Panel panelYellowLightV;
        private System.Windows.Forms.Panel panelRedLightV;
    }
}


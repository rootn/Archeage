namespace Plotter
{
    partial class PlotForm
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
            this.mapButton = new System.Windows.Forms.Button();
            this.designList = new System.Windows.Forms.ComboBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.zBox = new System.Windows.Forms.TextBox();
            this.formX = new System.Windows.Forms.Button();
            this.formZ = new System.Windows.Forms.Button();
            this.formY = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(12, 90);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(211, 36);
            this.mapButton.TabIndex = 0;
            this.mapButton.Text = "Mark Map";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // designList
            // 
            this.designList.FormattingEnabled = true;
            this.designList.Items.AddRange(new object[] {
            "Rustic Slate Cottage",
            "Rustic Rose Cottage Design",
            "Rustic Spring Cottage Design",
            "Scarecrow Farm Design",
            "Thatch House Design"});
            this.designList.Location = new System.Drawing.Point(12, 132);
            this.designList.Name = "designList";
            this.designList.Size = new System.Drawing.Size(211, 21);
            this.designList.TabIndex = 1;
            this.designList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(12, 159);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(211, 36);
            this.plotButton.TabIndex = 2;
            this.plotButton.Text = "Plot House";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(123, 12);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 20);
            this.xBox.TabIndex = 3;
            this.xBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(123, 38);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(100, 20);
            this.yBox.TabIndex = 4;
            this.yBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // zBox
            // 
            this.zBox.Location = new System.Drawing.Point(123, 64);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(100, 20);
            this.zBox.TabIndex = 5;
            this.zBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // formX
            // 
            this.formX.Location = new System.Drawing.Point(12, 12);
            this.formX.Name = "formX";
            this.formX.Size = new System.Drawing.Size(94, 20);
            this.formX.TabIndex = 6;
            this.formX.Text = "X:";
            this.formX.UseVisualStyleBackColor = true;
            this.formX.Click += new System.EventHandler(this.formX_Click);
            // 
            // formZ
            // 
            this.formZ.Location = new System.Drawing.Point(12, 64);
            this.formZ.Name = "formZ";
            this.formZ.Size = new System.Drawing.Size(94, 20);
            this.formZ.TabIndex = 7;
            this.formZ.Text = "Z:";
            this.formZ.UseVisualStyleBackColor = true;
            this.formZ.Click += new System.EventHandler(this.formZ_Click);
            // 
            // formY
            // 
            this.formY.Location = new System.Drawing.Point(12, 38);
            this.formY.Name = "formY";
            this.formY.Size = new System.Drawing.Size(94, 20);
            this.formY.TabIndex = 8;
            this.formY.Text = "Y:";
            this.formY.UseVisualStyleBackColor = true;
            this.formY.Click += new System.EventHandler(this.formY_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(211, 36);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 248);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formY);
            this.Controls.Add(this.formZ);
            this.Controls.Add(this.formX);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.designList);
            this.Controls.Add(this.mapButton);
            this.Name = "PlotForm";
            this.Text = "House Plotter";
            this.Load += new System.EventHandler(this.PlotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.ComboBox designList;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.Button formX;
        private System.Windows.Forms.Button formZ;
        private System.Windows.Forms.Button formY;
        private System.Windows.Forms.Button exitButton;
    }
}


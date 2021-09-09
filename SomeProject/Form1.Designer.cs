namespace SomeProject
{
    partial class ComedyGold
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComedyGold));
            this.labelName = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonFinishProcess = new System.Windows.Forms.Button();
            this.buttonAdvanceProcess = new System.Windows.Forms.Button();
            this.settingsBox = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSuccess = new System.Windows.Forms.TextBox();
            this.textFailure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerNonClickerMode = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(207, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Progress Bar Simulator";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 389);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 6;
            // 
            // buttonFinishProcess
            // 
            this.buttonFinishProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFinishProcess.Enabled = false;
            this.buttonFinishProcess.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinishProcess.Location = new System.Drawing.Point(678, 418);
            this.buttonFinishProcess.Name = "buttonFinishProcess";
            this.buttonFinishProcess.Size = new System.Drawing.Size(110, 24);
            this.buttonFinishProcess.TabIndex = 7;
            this.buttonFinishProcess.Text = "Finish Process";
            this.buttonFinishProcess.UseVisualStyleBackColor = true;
            this.buttonFinishProcess.Click += new System.EventHandler(this.FinishProgressBar);
            // 
            // buttonAdvanceProcess
            // 
            this.buttonAdvanceProcess.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvanceProcess.Location = new System.Drawing.Point(562, 418);
            this.buttonAdvanceProcess.Name = "buttonAdvanceProcess";
            this.buttonAdvanceProcess.Size = new System.Drawing.Size(110, 24);
            this.buttonAdvanceProcess.TabIndex = 8;
            this.buttonAdvanceProcess.Text = "Advance Process";
            this.buttonAdvanceProcess.UseVisualStyleBackColor = true;
            this.buttonAdvanceProcess.Click += new System.EventHandler(this.AdvanceProgressBar);
            // 
            // settingsBox
            // 
            this.settingsBox.CheckOnClick = true;
            this.settingsBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBox.FormattingEnabled = true;
            this.settingsBox.Items.AddRange(new object[] {
            "Do Fun Fact on Advance",
            "Do Fun Fact on Finish",
            "Clicker Game Mode"});
            this.settingsBox.Location = new System.Drawing.Point(12, 35);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(776, 49);
            this.settingsBox.TabIndex = 9;
            this.settingsBox.ThreeDCheckBoxes = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fun Fact:";
            // 
            // textSuccess
            // 
            this.textSuccess.Enabled = false;
            this.textSuccess.Location = new System.Drawing.Point(504, 337);
            this.textSuccess.Name = "textSuccess";
            this.textSuccess.Size = new System.Drawing.Size(100, 20);
            this.textSuccess.TabIndex = 12;
            // 
            // textFailure
            // 
            this.textFailure.Enabled = false;
            this.textFailure.Location = new System.Drawing.Point(688, 337);
            this.textFailure.Name = "textFailure";
            this.textFailure.Size = new System.Drawing.Size(100, 20);
            this.textFailure.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Success";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Failure";
            // 
            // timerNonClickerMode
            // 
            this.timerNonClickerMode.Tick += new System.EventHandler(this.UpdateProgressBar);
            // 
            // ComedyGold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFailure);
            this.Controls.Add(this.textSuccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.buttonAdvanceProcess);
            this.Controls.Add(this.buttonFinishProcess);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComedyGold";
            this.Text = "Progress Bar Simulator V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonFinishProcess;
        private System.Windows.Forms.Button buttonAdvanceProcess;
        private System.Windows.Forms.CheckedListBox settingsBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSuccess;
        private System.Windows.Forms.TextBox textFailure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerNonClickerMode;
    }
}


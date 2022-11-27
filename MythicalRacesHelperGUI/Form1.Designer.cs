namespace MythicalRacesHelperGUI
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
            this.raceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.abilityButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.consoleLogger = new MyRichTextBox();
            this.mainTextBox = new MyRichTextBox();
            this.updater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raceButton
            // 
            this.raceButton.FlatAppearance.BorderSize = 2;
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.raceButton.Location = new System.Drawing.Point(789, 231);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(141, 51);
            this.raceButton.TabIndex = 0;
            this.raceButton.Text = "Race";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.race_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(487, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you making a race or an ability?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // abilityButton
            // 
            this.abilityButton.FlatAppearance.BorderSize = 2;
            this.abilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abilityButton.Location = new System.Drawing.Point(493, 231);
            this.abilityButton.Name = "abilityButton";
            this.abilityButton.Size = new System.Drawing.Size(141, 51);
            this.abilityButton.TabIndex = 3;
            this.abilityButton.Text = "Ability";
            this.abilityButton.UseVisualStyleBackColor = true;
            this.abilityButton.Click += new System.EventHandler(this.abilityButton_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exit.Location = new System.Drawing.Point(1332, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(51, 42);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // consoleLogger
            // 
            this.consoleLogger.BackColor = System.Drawing.Color.LightSlateGray;
            this.consoleLogger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.consoleLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLogger.ForeColor = System.Drawing.SystemColors.Info;
            this.consoleLogger.Location = new System.Drawing.Point(446, 491);
            this.consoleLogger.Name = "consoleLogger";
            this.consoleLogger.ReadOnly = true;
            this.consoleLogger.Size = new System.Drawing.Size(937, 169);
            this.consoleLogger.TabIndex = 6;
            this.consoleLogger.Text = "Console";
            this.consoleLogger.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.Color.Black;
            this.mainTextBox.CausesValidation = false;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.mainTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(428, 648);
            this.mainTextBox.TabIndex = 5;
            this.mainTextBox.Text = "";
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBoxChanged);
            // 
            // updater
            // 
            this.updater.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.updater.FlatAppearance.BorderSize = 3;
            this.updater.ForeColor = System.Drawing.Color.Teal;
            this.updater.Location = new System.Drawing.Point(446, 12);
            this.updater.Name = "updater";
            this.updater.Size = new System.Drawing.Size(75, 23);
            this.updater.TabIndex = 7;
            this.updater.Text = "Update";
            this.updater.UseVisualStyleBackColor = true;
            this.updater.Click += new System.EventHandler(this.updater_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1395, 691);
            this.Controls.Add(this.updater);
            this.Controls.Add(this.consoleLogger);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.abilityButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceButton);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mythical Races GUI Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button abilityButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button updater;
        private MyRichTextBox mainTextBox;
        private MyRichTextBox consoleLogger;
    }
}


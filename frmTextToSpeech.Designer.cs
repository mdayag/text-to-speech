namespace TextToSpeech
{
    partial class frmTextToSpeech
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cboSelectVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnSave);
            this.gbMain.Controls.Add(this.btnResume);
            this.gbMain.Controls.Add(this.btnPause);
            this.gbMain.Controls.Add(this.btnSpeak);
            this.gbMain.Controls.Add(this.txtContent);
            this.gbMain.Controls.Add(this.cboSelectVoice);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(715, 412);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(615, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sa&ve";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResume.Location = new System.Drawing.Point(530, 357);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(79, 33);
            this.btnResume.TabIndex = 6;
            this.btnResume.Text = "&Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPause.Location = new System.Drawing.Point(441, 357);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(79, 33);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSpeak.Location = new System.Drawing.Point(356, 357);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(79, 33);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "&Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(22, 65);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(672, 268);
            this.txtContent.TabIndex = 3;
            // 
            // cboSelectVoice
            // 
            this.cboSelectVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectVoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSelectVoice.FormattingEnabled = true;
            this.cboSelectVoice.Items.AddRange(new object[] {
            "Not Set",
            "Male",
            "Female",
            "Neutral"});
            this.cboSelectVoice.Location = new System.Drawing.Point(109, 22);
            this.cboSelectVoice.Name = "cboSelectVoice";
            this.cboSelectVoice.Size = new System.Drawing.Size(158, 23);
            this.cboSelectVoice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Voice :";
            // 
            // frmTextToSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 439);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmTextToSpeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text to Speech powered by Mar-ay";
            this.Load += new System.EventHandler(this.frmTextToSpeech_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbMain;
        private Button btnSave;
        private Button btnResume;
        private Button btnPause;
        private Button btnSpeak;
        private TextBox txtContent;
        private ComboBox cboSelectVoice;
        private Label label1;
    }
}
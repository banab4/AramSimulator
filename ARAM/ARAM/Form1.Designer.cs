namespace ARAM
{
    partial class MainForm
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
            Button = new Button();
            ListBoxA = new ListBox();
            ListBoxB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            Btn_Unban = new Button();
            ChampList = new ListBox();
            BanList = new ListBox();
            RotationList = new ListBox();
            Btn_Ban = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(872, 537);
            Button.Name = "Button";
            Button.Size = new Size(118, 39);
            Button.TabIndex = 0;
            Button.Text = "Pick";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // ListBoxA
            // 
            ListBoxA.Anchor = AnchorStyles.Top;
            ListBoxA.Font = new Font("맑은 고딕", 11F);
            ListBoxA.FormattingEnabled = true;
            ListBoxA.ItemHeight = 20;
            ListBoxA.Location = new Point(27, 57);
            ListBoxA.Name = "ListBoxA";
            ListBoxA.Size = new Size(221, 464);
            ListBoxA.TabIndex = 1;
            // 
            // ListBoxB
            // 
            ListBoxB.Font = new Font("맑은 고딕", 11F);
            ListBoxB.FormattingEnabled = true;
            ListBoxB.ItemHeight = 20;
            ListBoxB.Location = new Point(271, 57);
            ListBoxB.Name = "ListBoxB";
            ListBoxB.Size = new Size(221, 464);
            ListBoxB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 3;
            label1.Text = "Team A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label2.Location = new Point(271, 25);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 4;
            label2.Text = "Team B";
            // 
            // Btn_Unban
            // 
            Btn_Unban.Location = new Point(578, 408);
            Btn_Unban.Name = "Btn_Unban";
            Btn_Unban.Size = new Size(40, 39);
            Btn_Unban.TabIndex = 5;
            Btn_Unban.Text = "▲";
            Btn_Unban.UseVisualStyleBackColor = true;
            Btn_Unban.Click += Btn_Unban_Click;
            // 
            // ChampList
            // 
            ChampList.Font = new Font("맑은 고딕", 11F);
            ChampList.FormattingEnabled = true;
            ChampList.ItemHeight = 20;
            ChampList.Location = new Point(532, 57);
            ChampList.Name = "ChampList";
            ChampList.Size = new Size(221, 344);
            ChampList.TabIndex = 6;
            // 
            // BanList
            // 
            BanList.Font = new Font("맑은 고딕", 11F);
            BanList.FormattingEnabled = true;
            BanList.ItemHeight = 20;
            BanList.Location = new Point(532, 457);
            BanList.Name = "BanList";
            BanList.Size = new Size(221, 64);
            BanList.TabIndex = 7;
            // 
            // RotationList
            // 
            RotationList.Font = new Font("맑은 고딕", 11F);
            RotationList.FormattingEnabled = true;
            RotationList.ItemHeight = 20;
            RotationList.Location = new Point(769, 57);
            RotationList.Name = "RotationList";
            RotationList.Size = new Size(221, 224);
            RotationList.TabIndex = 8;
            // 
            // Btn_Ban
            // 
            Btn_Ban.Location = new Point(532, 408);
            Btn_Ban.Name = "Btn_Ban";
            Btn_Ban.Size = new Size(40, 39);
            Btn_Ban.TabIndex = 9;
            Btn_Ban.Text = "▼";
            Btn_Ban.UseVisualStyleBackColor = true;
            Btn_Ban.Click += Btn_Ban_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label3.Location = new Point(532, 25);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 10;
            label3.Text = "Champions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label4.Location = new Point(714, 433);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 11;
            label4.Text = "Ban";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            label5.Location = new Point(769, 25);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 12;
            label5.Text = "Rotation Champ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 588);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Btn_Ban);
            Controls.Add(RotationList);
            Controls.Add(BanList);
            Controls.Add(ChampList);
            Controls.Add(Btn_Unban);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListBoxB);
            Controls.Add(ListBoxA);
            Controls.Add(Button);
            Name = "MainForm";
            Text = "ARAM Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button;
        private ListBox ListBoxA;
        private ListBox ListBoxB;
        private Label label1;
        private Label label2;
        private Button Btn_Unban;
        private ListBox ChampList;
        private ListBox BanList;
        private ListBox RotationList;
        private Button Btn_Ban;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

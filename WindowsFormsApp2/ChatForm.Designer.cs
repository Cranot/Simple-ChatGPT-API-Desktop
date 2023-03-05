namespace SimpleChatAPI
{
	partial class SimpleChatGPT
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleChatGPT));
			this.label1 = new System.Windows.Forms.Label();
			this.apibox = new System.Windows.Forms.TextBox();
			this.send_button = new System.Windows.Forms.Button();
			this.resultbox = new System.Windows.Forms.TextBox();
			this.promptbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.fontbox = new System.Windows.Forms.TextBox();
			this.mysterylistbox = new System.Windows.Forms.ListBox();
			this.screenbox = new System.Windows.Forms.TextBox();
			this.runbutton = new System.Windows.Forms.Button();
			this.familybox = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.total_spent_box = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.completion_token_box = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.prompt_token_box = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.total_token_box = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.total_m_spent_box = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.current_spent_box = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "API";
			// 
			// apibox
			// 
			this.apibox.Location = new System.Drawing.Point(59, 10);
			this.apibox.Name = "apibox";
			this.apibox.Size = new System.Drawing.Size(126, 20);
			this.apibox.TabIndex = 1;
			this.apibox.Text = "YOUR API HERE";
			this.apibox.TextChanged += new System.EventHandler(this.apibox_TextChanged);
			// 
			// send_button
			// 
			this.send_button.Location = new System.Drawing.Point(606, 544);
			this.send_button.Name = "send_button";
			this.send_button.Size = new System.Drawing.Size(90, 30);
			this.send_button.TabIndex = 2;
			this.send_button.Text = "Send Prompt";
			this.send_button.UseVisualStyleBackColor = true;
			this.send_button.Click += new System.EventHandler(this.send_prompt_click);
			// 
			// resultbox
			// 
			this.resultbox.Location = new System.Drawing.Point(59, 306);
			this.resultbox.Multiline = true;
			this.resultbox.Name = "resultbox";
			this.resultbox.Size = new System.Drawing.Size(637, 232);
			this.resultbox.TabIndex = 3;
			// 
			// promptbox
			// 
			this.promptbox.Location = new System.Drawing.Point(59, 39);
			this.promptbox.Multiline = true;
			this.promptbox.Name = "promptbox";
			this.promptbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.promptbox.Size = new System.Drawing.Size(637, 261);
			this.promptbox.TabIndex = 5;
			this.promptbox.Text = "Paste or write here";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Prompt";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 651);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "V0.5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 651);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Offered by";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(126, 651);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(38, 13);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Cranot";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(702, 39);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(183, 26);
			this.button2.TabIndex = 9;
			this.button2.Text = "Magic ✨ ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(329, 697);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 21);
			this.button3.TabIndex = 11;
			this.button3.Text = "Set Font Size";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// fontbox
			// 
			this.fontbox.Location = new System.Drawing.Point(277, 697);
			this.fontbox.Name = "fontbox";
			this.fontbox.Size = new System.Drawing.Size(46, 20);
			this.fontbox.TabIndex = 12;
			// 
			// mysterylistbox
			// 
			this.mysterylistbox.FormattingEnabled = true;
			this.mysterylistbox.Location = new System.Drawing.Point(702, 68);
			this.mysterylistbox.Name = "mysterylistbox";
			this.mysterylistbox.Size = new System.Drawing.Size(564, 264);
			this.mysterylistbox.TabIndex = 13;
			// 
			// screenbox
			// 
			this.screenbox.Location = new System.Drawing.Point(702, 338);
			this.screenbox.Multiline = true;
			this.screenbox.Name = "screenbox";
			this.screenbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.screenbox.Size = new System.Drawing.Size(564, 200);
			this.screenbox.TabIndex = 14;
			// 
			// runbutton
			// 
			this.runbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.runbutton.Location = new System.Drawing.Point(891, 39);
			this.runbutton.Name = "runbutton";
			this.runbutton.Size = new System.Drawing.Size(183, 26);
			this.runbutton.TabIndex = 15;
			this.runbutton.Text = "Run This ✨ ";
			this.runbutton.UseVisualStyleBackColor = true;
			this.runbutton.Visible = false;
			this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
			// 
			// familybox
			// 
			this.familybox.Location = new System.Drawing.Point(32, 696);
			this.familybox.Name = "familybox";
			this.familybox.Size = new System.Drawing.Size(138, 20);
			this.familybox.TabIndex = 17;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(176, 696);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 21);
			this.button4.TabIndex = 16;
			this.button4.Text = "Set Font Family";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 673);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "If you like this you can always";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(176, 673);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(84, 13);
			this.linkLabel2.TabIndex = 19;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Buy me a coffee";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// total_spent_box
			// 
			this.total_spent_box.Location = new System.Drawing.Point(818, 551);
			this.total_spent_box.Name = "total_spent_box";
			this.total_spent_box.Size = new System.Drawing.Size(110, 20);
			this.total_spent_box.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(700, 554);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Total Tokens Spent";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(699, 632);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Completion Tokens";
			// 
			// completion_token_box
			// 
			this.completion_token_box.Location = new System.Drawing.Point(818, 629);
			this.completion_token_box.Name = "completion_token_box";
			this.completion_token_box.Size = new System.Drawing.Size(110, 20);
			this.completion_token_box.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(700, 606);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Prompt Tokens";
			// 
			// prompt_token_box
			// 
			this.prompt_token_box.Location = new System.Drawing.Point(818, 603);
			this.prompt_token_box.Name = "prompt_token_box";
			this.prompt_token_box.Size = new System.Drawing.Size(110, 20);
			this.prompt_token_box.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(699, 658);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 13);
			this.label9.TabIndex = 27;
			this.label9.Text = "Current Total Tokens";
			// 
			// total_token_box
			// 
			this.total_token_box.Location = new System.Drawing.Point(818, 655);
			this.total_token_box.Name = "total_token_box";
			this.total_token_box.Size = new System.Drawing.Size(110, 20);
			this.total_token_box.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(699, 580);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 13);
			this.label10.TabIndex = 29;
			this.label10.Text = "Total $ Spent";
			// 
			// total_m_spent_box
			// 
			this.total_m_spent_box.Location = new System.Drawing.Point(818, 577);
			this.total_m_spent_box.Name = "total_m_spent_box";
			this.total_m_spent_box.Size = new System.Drawing.Size(110, 20);
			this.total_m_spent_box.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(700, 684);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 13);
			this.label11.TabIndex = 31;
			this.label11.Text = "Current $ Spent";
			// 
			// current_spent_box
			// 
			this.current_spent_box.Location = new System.Drawing.Point(818, 681);
			this.current_spent_box.Name = "current_spent_box";
			this.current_spent_box.Size = new System.Drawing.Size(110, 20);
			this.current_spent_box.TabIndex = 32;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Summarize",
            "Find Bugs",
            "Explain",
            "Analyze",
            "Find Key Points",
            "Paraphrase",
            "Evaluate",
            "Compare and Contrast",
            "Predict",
            "Connect",
            "Critique",
            "Interpret",
            "Categorize",
            "Question",
            "Visualize"});
			this.comboBox1.Location = new System.Drawing.Point(59, 551);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 33;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(186, 551);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 34;
			this.button1.Text = "Run This";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// SimpleChatGPT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1323, 740);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.current_spent_box);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.total_m_spent_box);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.total_token_box);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.prompt_token_box);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.completion_token_box);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.total_spent_box);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.familybox);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.runbutton);
			this.Controls.Add(this.screenbox);
			this.Controls.Add(this.mysterylistbox);
			this.Controls.Add(this.fontbox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.promptbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.resultbox);
			this.Controls.Add(this.send_button);
			this.Controls.Add(this.apibox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SimpleChatGPT";
			this.Opacity = 0.96D;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Simple ChatGPT API";
			this.Load += new System.EventHandler(this.chatapiapp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox apibox;
		private System.Windows.Forms.Button send_button;
		private System.Windows.Forms.TextBox resultbox;
		private System.Windows.Forms.TextBox promptbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox fontbox;
		private System.Windows.Forms.ListBox mysterylistbox;
		private System.Windows.Forms.TextBox screenbox;
		private System.Windows.Forms.Button runbutton;
		private System.Windows.Forms.TextBox familybox;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.TextBox total_spent_box;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox completion_token_box;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox prompt_token_box;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox total_token_box;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox total_m_spent_box;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox current_spent_box;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}


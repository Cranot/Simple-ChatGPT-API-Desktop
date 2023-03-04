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
			this.button1 = new System.Windows.Forms.Button();
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(606, 544);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// resultbox
			// 
			this.resultbox.Location = new System.Drawing.Point(59, 234);
			this.resultbox.Multiline = true;
			this.resultbox.Name = "resultbox";
			this.resultbox.Size = new System.Drawing.Size(637, 304);
			this.resultbox.TabIndex = 3;
			// 
			// promptbox
			// 
			this.promptbox.Location = new System.Drawing.Point(59, 39);
			this.promptbox.Multiline = true;
			this.promptbox.Name = "promptbox";
			this.promptbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.promptbox.Size = new System.Drawing.Size(637, 189);
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
			this.label3.Location = new System.Drawing.Point(9, 571);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "V0.3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 571);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Offered by";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(101, 571);
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
			this.button3.Location = new System.Drawing.Point(304, 604);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 21);
			this.button3.TabIndex = 11;
			this.button3.Text = "Set Font Size";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// fontbox
			// 
			this.fontbox.Location = new System.Drawing.Point(252, 605);
			this.fontbox.Name = "fontbox";
			this.fontbox.Size = new System.Drawing.Size(46, 20);
			this.fontbox.TabIndex = 12;
			// 
			// mysterylistbox
			// 
			this.mysterylistbox.FormattingEnabled = true;
			this.mysterylistbox.Location = new System.Drawing.Point(702, 68);
			this.mysterylistbox.Name = "mysterylistbox";
			this.mysterylistbox.Size = new System.Drawing.Size(564, 160);
			this.mysterylistbox.TabIndex = 13;
			// 
			// screenbox
			// 
			this.screenbox.Location = new System.Drawing.Point(702, 234);
			this.screenbox.Multiline = true;
			this.screenbox.Name = "screenbox";
			this.screenbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.screenbox.Size = new System.Drawing.Size(564, 304);
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
			this.familybox.Location = new System.Drawing.Point(7, 605);
			this.familybox.Name = "familybox";
			this.familybox.Size = new System.Drawing.Size(138, 20);
			this.familybox.TabIndex = 17;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(151, 604);
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
			this.label5.Location = new System.Drawing.Point(9, 584);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "If you like this you can always";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(156, 584);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(84, 13);
			this.linkLabel2.TabIndex = 19;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Buy me a coffee";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// SimpleChatGPT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1323, 672);
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
			this.Controls.Add(this.button1);
			this.Controls.Add(this.apibox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SimpleChatGPT";
			this.ShowInTaskbar = false;
			this.Text = "Simple ChatGPT API";
			this.Load += new System.EventHandler(this.chatapiapp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox apibox;
		private System.Windows.Forms.Button button1;
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
	}
}


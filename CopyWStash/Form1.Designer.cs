namespace CopyWStash
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textRemove = new TextBox();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textPrefix = new TextBox();
            label3 = new Label();
            textSuffix = new TextBox();
            imageList1 = new ImageList(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // textRemove
            // 
            textRemove.Location = new Point(3, 233);
            textRemove.Name = "textRemove";
            textRemove.Size = new Size(239, 27);
            textRemove.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(textSuffix);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textPrefix);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(textRemove);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Size = new Size(776, 426);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(252, 94);
            button1.TabIndex = 1;
            button1.Text = "Choose folder...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 210);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 2;
            label1.Text = "Text to remove...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 298);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 4;
            label2.Text = "Add to front of text...";
            // 
            // textPrefix
            // 
            textPrefix.Location = new Point(3, 321);
            textPrefix.Name = "textPrefix";
            textPrefix.Size = new Size(239, 27);
            textPrefix.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(101, 351);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 6;
            label3.Text = "...add to end of text.";
            // 
            // textSuffix
            // 
            textSuffix.Location = new Point(3, 374);
            textSuffix.Name = "textSuffix";
            textSuffix.Size = new Size(239, 27);
            textSuffix.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 7;
            label4.Text = "File not selected...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textRemove;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox textSuffix;
        private Label label2;
        private TextBox textPrefix;
        private Label label4;
        private ImageList imageList1;
    }
}
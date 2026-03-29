namespace GesWord;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonGenerateWord = new System.Windows.Forms.Button();
        labelWord = new System.Windows.Forms.Label();
        textBoxFall = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // buttonGenerateWord
        // 
        buttonGenerateWord.Location = new System.Drawing.Point(27, 27);
        buttonGenerateWord.Name = "buttonGenerateWord";
        buttonGenerateWord.Size = new System.Drawing.Size(119, 60);
        buttonGenerateWord.TabIndex = 0;
        buttonGenerateWord.Text = "загадать слово";
        buttonGenerateWord.UseVisualStyleBackColor = true;
        buttonGenerateWord.Click += buttonGenerateWord_Click;
        // 
        // labelWord
        // 
        labelWord.Location = new System.Drawing.Point(186, 47);
        labelWord.Name = "labelWord";
        labelWord.Size = new System.Drawing.Size(100, 47);
        labelWord.TabIndex = 1;
        labelWord.Text = "label1";
        // 
        // textBoxFall
        // 
        textBoxFall.BackColor = System.Drawing.SystemColors.InactiveCaption;
        textBoxFall.Location = new System.Drawing.Point(562, 411);
        textBoxFall.Name = "textBoxFall";
        textBoxFall.Size = new System.Drawing.Size(100, 27);
        textBoxFall.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(292, 47);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(120, 47);
        label1.TabIndex = 3;
        label1.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(textBoxFall);
        Controls.Add(labelWord);
        Controls.Add(buttonGenerateWord);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBoxFall;

    private System.Windows.Forms.Label labelWord;

    private System.Windows.Forms.Button buttonGenerateWord;

    #endregion
}
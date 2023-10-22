namespace Example.View
{
  partial class Example
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAction = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(14, 19);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(141, 34);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Open Action file";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(14, 19);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(141, 34);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input XML";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(14, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(813, 128);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(14, 19);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(141, 34);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Open INPUT file";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAction);
            this.groupBox2.Controls.Add(this.btnAction);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action XML";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(14, 59);
            this.txtAction.Name = "txtAction";
            this.txtAction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAction.Size = new System.Drawing.Size(813, 128);
            this.txtAction.TabIndex = 5;
            this.txtAction.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.btnResult);
            this.groupBox3.Location = new System.Drawing.Point(12, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 194);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result XML";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(14, 59);
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(813, 128);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "";
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 615);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Example";
            this.Text = "Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnAction;
    private System.Windows.Forms.Button btnResult;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RichTextBox txtInput;
    private System.Windows.Forms.Button btnInput;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RichTextBox txtAction;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.RichTextBox txtResult;
  }
}


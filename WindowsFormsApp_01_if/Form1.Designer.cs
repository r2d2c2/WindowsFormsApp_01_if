namespace WindowsFormsApp_01_if
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonfalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(3, 346);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(707, 341);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(88, 53);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(339, 25);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonInput.Location = new System.Drawing.Point(572, 69);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(170, 76);
            this.buttonInput.TabIndex = 1;
            this.buttonInput.Text = "input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(52, 264);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(52, 19);
            this.radioButtonTrue.TabIndex = 4;
            this.radioButtonTrue.TabStop = true;
            this.radioButtonTrue.Text = "true";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            this.radioButtonTrue.CheckedChanged += new System.EventHandler(this.radioButtonTrue_CheckedChanged);
            // 
            // radioButtonfalse
            // 
            this.radioButtonfalse.AutoSize = true;
            this.radioButtonfalse.Location = new System.Drawing.Point(176, 264);
            this.radioButtonfalse.Name = "radioButtonfalse";
            this.radioButtonfalse.Size = new System.Drawing.Size(59, 19);
            this.radioButtonfalse.TabIndex = 5;
            this.radioButtonfalse.TabStop = true;
            this.radioButtonfalse.Text = "false";
            this.radioButtonfalse.UseVisualStyleBackColor = true;
            this.radioButtonfalse.CheckedChanged += new System.EventHandler(this.radioButtonfalse_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 699);
            this.Controls.Add(this.radioButtonfalse);
            this.Controls.Add(this.radioButtonTrue);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.RadioButton radioButtonfalse;
    }
}


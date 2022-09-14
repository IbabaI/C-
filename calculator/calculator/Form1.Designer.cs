namespace calculator
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
            this.button0 = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button0.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(96, 450);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 69);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.numButton_click);
            // 
            // plusMinus
            // 
            this.plusMinus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.plusMinus.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusMinus.ForeColor = System.Drawing.Color.Black;
            this.plusMinus.Location = new System.Drawing.Point(19, 450);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(71, 69);
            this.plusMinus.TabIndex = 0;
            this.plusMinus.Text = "±";
            this.plusMinus.UseVisualStyleBackColor = false;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dot.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dot.ForeColor = System.Drawing.Color.Black;
            this.dot.Location = new System.Drawing.Point(173, 450);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(71, 69);
            this.dot.TabIndex = 0;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.equal.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.equal.ForeColor = System.Drawing.Color.Black;
            this.equal.Location = new System.Drawing.Point(250, 450);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(71, 69);
            this.equal.TabIndex = 0;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Add_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(96, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 69);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numButton_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numButton_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(173, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 69);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numButton_click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sum.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum.ForeColor = System.Drawing.Color.Black;
            this.sum.Location = new System.Drawing.Point(250, 375);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(71, 69);
            this.sum.TabIndex = 0;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.Add_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(96, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 69);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numButton_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(19, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 69);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numButton_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(173, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 69);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numButton_click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sub.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sub.ForeColor = System.Drawing.Color.Black;
            this.sub.Location = new System.Drawing.Point(250, 300);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(71, 69);
            this.sub.TabIndex = 0;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.Add_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button8.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(96, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 69);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numButton_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button7.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(19, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 69);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numButton_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button9.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(173, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 69);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numButton_click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.multi.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multi.ForeColor = System.Drawing.Color.Black;
            this.multi.Location = new System.Drawing.Point(250, 225);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(71, 69);
            this.multi.TabIndex = 0;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.Add_click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clean.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clean.ForeColor = System.Drawing.Color.Black;
            this.clean.Location = new System.Drawing.Point(96, 150);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(71, 69);
            this.clean.TabIndex = 0;
            this.clean.Text = "C";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CE.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CE.ForeColor = System.Drawing.Color.Black;
            this.CE.Location = new System.Drawing.Point(19, 150);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(71, 69);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.back.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(173, 150);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(71, 69);
            this.back.TabIndex = 0;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.div.Font = new System.Drawing.Font("레시피코리아OTF Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div.ForeColor = System.Drawing.Color.Black;
            this.div.Location = new System.Drawing.Point(250, 150);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(71, 69);
            this.div.TabIndex = 0;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.Add_click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("카페24 동동", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("카페24 동동", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 35);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(342, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


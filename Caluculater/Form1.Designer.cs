using System.Windows.Forms.VisualStyles;

namespace Caluculater
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number0 = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.conma = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(260, 157);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 23);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.OneClick);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(341, 157);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 23);
            this.number2.TabIndex = 1;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.TwoClick);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(422, 157);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 23);
            this.number3.TabIndex = 2;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.ThreeClick);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(422, 128);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 23);
            this.number6.TabIndex = 3;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.SixClick);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(341, 128);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 23);
            this.number5.TabIndex = 4;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.FiveClick);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(260, 128);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 23);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.FourClick);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(422, 99);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 23);
            this.number9.TabIndex = 6;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.NineClick);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(341, 99);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 23);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.EightClick);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(260, 99);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 23);
            this.number7.TabIndex = 8;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.SevenClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(341, 186);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 23);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.ZeroClick);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(260, 186);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 11;
            this.convert.Text = "+/-";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.PlusMinusInversion);
            // 
            // conma
            // 
            this.conma.Location = new System.Drawing.Point(422, 186);
            this.conma.Name = "conma";
            this.conma.Size = new System.Drawing.Size(75, 23);
            this.conma.TabIndex = 12;
            this.conma.Text = ".";
            this.conma.UseVisualStyleBackColor = true;
            this.conma.Click += new System.EventHandler(this.ConmaButtonClick);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(260, 215);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(318, 23);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.EqualButton);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(504, 186);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.PlusButton);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(504, 157);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.MinusButton);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(503, 128);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 16;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.MultiButton);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(504, 99);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 17;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.DivButton);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(260, 70);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(237, 23);
            this.clear.TabIndex = 19;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.ClearButton);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(503, 70);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 20;
            this.delete.Text = "☒";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.DeleteButton);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(745, 403);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.conma);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button conma;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
    }
}


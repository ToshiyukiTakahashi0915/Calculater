using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Caluculater
{
    public partial class Form1 : Form
    {
        //privateが「_」が頭
        //publicが「頭文字が大文字」
        // 定数「全て大文字」　参照可能だが変更はできない
        // イニシャライズメソッド
        // bool型は頭文字に「b」か末尾に「flg」
        // _をつける
        // stringは頭文字に「str」
        //　フィールド変数はthis.
        
        private double _firstNumber;
        private bool _bPushOpeButton;
        private bool _bDivByZero;
        private opeSym _opeSymbol;

        // 演算子の保持の仕方が変わる
        enum opeSym
        {
            none,
            plus,
            minus,
            multi,
            div
        }

        private struct Calc
        {
            public double FirstNum;
            public double SecondNum;
            public opeSym Symbol;

            public Calc(double x, double v, opeSym sym)
            {
                this.FirstNum = x;
                this.SecondNum = v;
                this.Symbol = sym;
            }
        }

        public Form1()
        {
            InitializeComponent();
            // フィールドを初期化時に起動するメソッドをここで呼び出す
            Initialize();
        }

        private void Initialize()
        {
            this._firstNumber = 0;
            this._bPushOpeButton = false;
            this._bDivByZero = false;
            this._opeSymbol = opeSym.none;
        }

        private double Calclate(Calc calc)
        {
            switch (calc.Symbol)
            {
                case opeSym.plus:
                    return calc.FirstNum + calc.SecondNum;
                case opeSym.minus:
                    return calc.FirstNum - calc.SecondNum;
                case opeSym.multi:
                    return calc.FirstNum * calc.SecondNum;
                case opeSym.div:
                    return calc.FirstNum / calc.SecondNum;
                case opeSym.none:
                    return calc.FirstNum;
            }
            return 0;
        }

        // Numberボタンも別にする
        // object sender, 
        // イベントが発生したツールbutton等の情報を渡す
        // オブジェクトとして渡される
        // EventArgs e
        // 特別な情報を持ってる場合使われるが基本使わない
        private void NumButtonClick(string num)
        {
            // 前回の計算で0割り算が行われた場合
            if (_bDivByZero)
            {
                textBox1.Text = num;
                this._bDivByZero = false;
            }
            // 演算子ボタンが押された場合
            else if (_bPushOpeButton)
            {
                textBox1.Text = num;
                this._bPushOpeButton = false;
            }
            // 演算子ボタンが押されたことがなく0割り算をしたことがない場合
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = num;
                }
                else
                {
                    textBox1.Text += num;
                }
            }
        }

        private double Calclation(opeSym sym)
        {
            Calc calc = new Calc(_firstNumber, Convert.ToDouble(textBox1.Text), sym);
            return Calclate(calc);
        }

        private void OpeButtonPush(opeSym ope)
        {
            //OpeButtonが連続して押されたときの処理
            if (this._bPushOpeButton)
            {
                this._opeSymbol = ope;
                return;
            }

            this._bPushOpeButton = true;

            // 前回の計算で0割り算が行われた場合
            if (this._bDivByZero)
            {
                return;
            }
            else if (this._firstNumber == 0)
            {
                // 現状の画面の数字を取得
                this._firstNumber = Convert.ToDouble(textBox1.Text);
                // 押されたボタンの演算子のテキストを取得。
                this._opeSymbol = ope;
            }
            // イコールボタンが押されず演算子が続いた場合
            else
            {
                this._firstNumber = Calclation(_opeSymbol);
                textBox1.Text = this._firstNumber.ToString();
                // 押されたボタンの演算子のテキストを取得。
                this._opeSymbol = ope;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroClick(object sender, EventArgs e)
        {
            NumButtonClick("0");
        }

        private void OneClick(object sender, EventArgs e)
        {
            NumButtonClick("1");
        }

        private void TwoClick(object sender, EventArgs e)
        {
            NumButtonClick("2");
        }

        private void ThreeClick(object sender, EventArgs e)
        {
            NumButtonClick("3");
        }

        private void FourClick(object sender, EventArgs e)
        {
            NumButtonClick("4");
        }

        private void FiveClick(object sender, EventArgs e)
        {
            NumButtonClick("5");
        }

        private void SixClick(object sender, EventArgs e)
        {
            NumButtonClick("6");
        }

        private void SevenClick(object sender, EventArgs e)
        {
            NumButtonClick("7");
        }

        private void EightClick(object sender, EventArgs e)
        {
            NumButtonClick("8");
        }

        private void NineClick(object sender, EventArgs e)
        {
            NumButtonClick("9");
        }

        private void ConmaButtonClick(object sender, EventArgs e)
        {
            if (this._bDivByZero)
            {
                return;
            }
            //引数の文字列が含まれるか判断しリターンをbool型で返す
            else if (textBox1.Text.Contains(","))
            {
                return;
            }
            else
            {
                textBox1.Text += ",";
            }
        }

        private void ConvertNum(object sender, EventArgs e)
        {
            if (this._bDivByZero)
            {
                return;
            }
            else
            {
                int currentNum = Convert.ToInt32(textBox1.Text);
                currentNum = -(currentNum);
                textBox1.Text = currentNum.ToString();
            }
        }

        // 演算子それぞれのイベント関数
        private void PlusButton(object sender, EventArgs e)
        {
            OpeButtonPush(opeSym.plus);
        }

        private void MinusButton(object sender, EventArgs e)
        {
            OpeButtonPush(opeSym.minus);
        }

        private void MultiButton(object sender, EventArgs e)
        {
            OpeButtonPush(opeSym.multi);
        }

        private void DivButton(object sender, EventArgs e)
        {
            OpeButtonPush(opeSym.div); 
        }

        private void ClearButton(object sender, EventArgs e)
        {
            this._firstNumber = 0;
            this._bPushOpeButton = false;
            this._bDivByZero = false;
            this._opeSymbol = opeSym.none;
            textBox1.Text = "0";
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            if (this._bDivByZero)
            {
                return;
            }
            if(textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void EqualButton(object sender, EventArgs e)
        {
            if (this._opeSymbol == opeSym.none)
            {
                return;
            }
            // 0割り算の時の処理
            else if(textBox1.Text == "0" && this._opeSymbol == opeSym.div)
            {
                textBox1.Text = "0で割ることはできません。";
                this._opeSymbol = opeSym.none;
                this._firstNumber = 0;
                this._bDivByZero = true;
            }
            else
            {
                // Stringクラスのメソッドで引数の値を指定された形で成形する。戻り値はstring。
                // 小数点を何桁まで載せるか検討が必要
                textBox1.Text = String.Format("{0:#.#####}", Calclation(this._opeSymbol));
                this._opeSymbol = opeSym.none;
                this._firstNumber = 0;
            }
        }
    }
}

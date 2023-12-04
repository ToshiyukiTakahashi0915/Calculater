using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Caluculater.Form1;
// 静的なenumを使用できるようにしてる

namespace Caluculator
{
    public class Calcrate
    {
        //privateが「_」が頭
        //publicが「頭文字が大文字」
        // 定数「全て大文字」　参照可能だが変更はできない
        // イニシャライズメソッド
        // bool型は頭文字に「b」か末尾に「flg」
        // _をつける
        // stringは頭文字に「str」
        //　フィールド変数はthis.
        // buff 一時的な値
        private double _buffNumber;
        private bool _bPushOpeButton;
        private opeSym _opeSymbol;
        

        // 演算子の保持の仕方が変わる
        public enum opeSym
        {
            none,
            plus,
            minus,
            multi,
            div
        }
        public struct Calc
        {
            public double FirstNum;
            public double SecondNum;
            public opeSym Symbol;

            // 関数が長い場合は変数わかりやすく
            public Calc(double firstNum, double secondNum, opeSym sym)
            {
                this.FirstNum = firstNum;
                this.SecondNum = secondNum;
                this.Symbol = sym;
            }
        }

        public Calcrate()
        {
            Initialize();
        }

        private void Initialize()
        {
            this._buffNumber = 0;
            this._bPushOpeButton = false;
            this._opeSymbol = opeSym.none;
        }
        /// <summary>
        /// 四則演算に沿った計算を行う
        /// 構造体で定義した値を用いる
        /// </summary>
        /// <param name="buffNumber"></param>
        /// <param name="currentNumber"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public double Calculate(double buffNumber, double currentNumber,opeSym symbol)
        {
            Calc calc = new Calc(buffNumber, currentNumber, symbol);
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
                default:
                    return 0;
            }
        }

        /// <summary>
        ///計算処理の時と文字入力で処理を分ける
        ///-の値の時に-文字列だからそれも考慮して
        /// </summary>
        /// <param name="num"></param>
        /// <returns>成形された文字列</returns>
        public string CustomRounding(string num)
        {
            // doubleで表示できる16桁を超えた場合文字列を含む
            if (num.Contains("E"))
            {
                return num;
            }
            // －を含んでいる場合
            if (num.Contains("-"))
            {
                if (num.Length > 16)
                {
                    if (num.Contains(".") && num.IndexOf(".") > 16)
                    {
                        return "表示できる桁数を超えています。";
                    }
                    return num.Substring(0, 16);
                }
                return num;
            }

            if (num.Length > 15)
            {
                if (num.Contains(".") && num.IndexOf(".") > 15)
                {
                    return "表示できる桁数を超えています。";
                }
                return num.Substring(0, 15);
            }
            return num;
        }
        /// <summary>
        /// 数字ボタンが押されたときの関数
        /// </summary>
        /// <param name="num">押された文字が引数として渡される</param>
        /// <param name="textBoxNum">textBoxの現状の値</param>
        /// <returns>TextBoxに入る値が返される</returns>
        public string NumButtonClick(string num, string textBoxNum)
        {
            // 前回の計算で0割り算が行われた場合
            if (!(double.TryParse(textBoxNum, out _)))
            {
                return num;
            }
            // 演算子ボタンが押された場合
            if (_bPushOpeButton)
            {
                this._bPushOpeButton = false;
                return num;
            }
            // 演算子ボタンが押されたことがなく0割り算をしたことがない場合
            if (textBoxNum == "0")
            {
                return num;
            }
            else
            {
                string customTextBoxValue = textBoxNum + num;
                return CustomRounding(customTextBoxValue);
            }
        }

        /// <summary>
        /// textBox1の値の末尾を1文字消す
        /// </summary>
        /// <param name="textBoxNum">textBoxの現状の値</param>
        /// <returns>TextBoxに入る値が返される</returns>
        public string Deleate(string textBoxNum)
        {
            if (!(double.TryParse(textBoxNum, out _)))
            {
                return textBoxNum;
            }
            if (textBoxNum.Contains(".") && textBoxNum.IndexOf('.') == textBoxNum.Length - 2)
            {
                // 小数点以下が1つだけの時DeleateButtonが押されたら切り捨てて表示する。
                // Substringを使う
                return textBoxNum.Substring(0, textBoxNum.Length - 2); 
            }
            if (textBoxNum.Contains("-") && textBoxNum.Length == 2 && textBoxNum.Length == 1)
            {
                return "0";
            }
            return textBoxNum.Remove(textBoxNum.Length - 1);
        }

        public void Clear()
        {
            this._buffNumber = 0;
            this._bPushOpeButton = false;
            this._opeSymbol = opeSym.none;
        }
        /// <summary>
        /// 押された演算子をフィールド変数に登録する
        /// 条件によって計算を行う
        /// </summary>
        /// <param name="ope">押された演算子</param>
        /// <param name="textBoxNum">textBoxの現状の値</param>
        /// <returns>TextBoxに入る値が返される</returns>
        public string OpeButtonPush(opeSym ope, string textBoxNum)
        {
            //OpeButtonが連続して押されたときの処理
            if (this._bPushOpeButton)
            {
                this._opeSymbol = ope;
                return textBoxNum;
            }
            // 前回の計算で0割り算が行われた場合
            if (!(double.TryParse(textBoxNum, out _)))
            {
                return textBoxNum;
            }

            this._bPushOpeButton = true;

            if (this._buffNumber == 0)
            {
                // 現状の画面の数字を取得
                this._buffNumber = Convert.ToDouble(textBoxNum);
                // 押されたボタンの演算子を取得。
                this._opeSymbol = ope;
                return textBoxNum;
            }
            // イコールボタンが押されず演算子が続いた場合
            else
            {
                this._buffNumber = Calculate(this._buffNumber,
                                            Convert.ToDouble(textBoxNum),
                                            this._opeSymbol);
                // 押されたボタンの演算子を取得。
                this._opeSymbol = ope;
            }
            return CustomRounding(this._buffNumber.ToString());
        }
        /// <summary>
        /// 計算を実行する
        /// </summary>
        /// <param name="textBoxNum">textBoxの現状の値</param>
        /// <returns>TextBoxに入る値が返される</returns>
        public string Equal(string textBoxNum)
        {
            if (this._opeSymbol == opeSym.none)
            {
                return textBoxNum;
            }
            // 0割り算の時の処理
            if (textBoxNum == "0" && this._opeSymbol == opeSym.div)
            {
                this._opeSymbol = opeSym.none;
                this._buffNumber = 0;
                return "0で割ることはできません。";
            }
            // Stringクラスのメソッドで引数の値を指定された形で成形する。戻り値はstring。
            double calcrateNum = Calculate(this._buffNumber,
                                          Convert.ToDouble(textBoxNum),
                                          this._opeSymbol);
            string calcraterNum = CustomRounding(calcrateNum.ToString());
            this._opeSymbol = opeSym.none;
            this._buffNumber = 0;
            return calcraterNum;
        }
    }
}

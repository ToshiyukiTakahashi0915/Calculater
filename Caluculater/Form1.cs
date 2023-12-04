using Caluculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caluculater
{
    public partial class Form1 : Form
    {
        private Calcrate _calcrate = new Calcrate();

        // 演算子の保持の仕方が変わる
        public enum opeSym
        {
            none,
            plus,
            minus,
            multi,
            div
        }

        public Form1()
        {
            InitializeComponent();
        }


        // object sender, 
        // イベントが発生したツールbutton等の情報を渡す
        // オブジェクトとして渡される
        // EventArgs e
        // 特別な情報を持ってる場合使われるが基本使わない
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("0", textBox1.Text);
        }

        private void OneClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("1", textBox1.Text);
        }


        private void TwoClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("2", textBox1.Text);
        }

        private void ThreeClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("3", textBox1.Text);  
        }

        private void FourClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("4", textBox1.Text);
        }

        private void FiveClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("5", textBox1.Text);
        }

        private void SixClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("6", textBox1.Text);
        }

        private void SevenClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("7", textBox1.Text);
        }

        private void EightClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("8", textBox1.Text);
        }

        private void NineClick(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.NumButtonClick("9", textBox1.Text);
        }
        /// <summary>
        /// イベントハンドラ
        /// textBox1の値にコンマを追加する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConmaButtonClick(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox1.Text, out _)))
            {
                return;
            }
            //引数の文字列が含まれるか判断しリターンをbool型で返す
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += ".";
        }
        /// <summary>
        /// イベントハンドラ
        /// ±の符号を反転する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusMinusInversion(object sender, EventArgs e)
        {
            if (!(double.TryParse(textBox1.Text, out _)))
            {
                return;
            }
            textBox1.Text = (-(Convert.ToDouble(textBox1.Text))).ToString();
        }

        // 演算子それぞれのイベントハンドラ
        private void PlusButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.OpeButtonPush((Calcrate.opeSym)opeSym.plus, textBox1.Text);
        }

        private void MinusButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.OpeButtonPush((Calcrate.opeSym)opeSym.minus, textBox1.Text);
        }

        private void MultiButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.OpeButtonPush((Calcrate.opeSym)opeSym.multi, textBox1.Text);
        }

        private void DivButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.OpeButtonPush((Calcrate.opeSym)opeSym.div, textBox1.Text); 
        }
        /// <summary>
        /// イベントハンドラ
        /// Calcrateクラスのフィールド変数と
        /// textBox1の値を初期化する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton(object sender, EventArgs e)
        {
            _calcrate.Clear();
            textBox1.Text = "0";
        }
        /// <summary>
        /// イベントハンドラ
        /// textBox1の値をCalcrateクラスのDeleateメソッドに渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.Deleate(textBox1.Text);
        }
        /// <summary>
        /// イベントハンドラ
        /// textBox1の値をCalcrateクラスのEqualメソッドに渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton(object sender, EventArgs e)
        {
            textBox1.Text = _calcrate.Equal(textBox1.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamResultSystem
{
    public partial class FrmMain : Form
    {
        enum TLetterGrade {LgNull, LgA, LgB, LgC, LgD, LgE, LgF };
        enum TExamResult {ErNull, ErPass, ErFail, ErSecondChance };
        TLetterGrade LetterGrade;
        TExamResult ExamResult;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnShowResult_Click(object sender, EventArgs e)
        {
            LblHappy.Visible = false;
            LblSad.Visible = false;
            int Point = (int)TxtPoint.Value;
            int Result = ShowResult(Point, out LetterGrade);
            if (Result == 2)
            {
                LblResult.Text = "(Geçti)";
                LblHappy.Visible = true;
            }
            else if (Result == 1)
                LblResult.Text = "(Büte Kaldı)";
            else if (Result == 0)
            {
                LblResult.Text = "(Kaldı)";
                LblSad.Visible = true;
            }
            switch (LetterGrade)
            {
                case TLetterGrade.LgNull:
                    break;
                case TLetterGrade.LgA:
                    LblGrade.Text = "A";
                    break;
                case TLetterGrade.LgB:
                    LblGrade.Text = "B";
                    break;
                case TLetterGrade.LgC:
                    LblGrade.Text = "C";
                    break;
                case TLetterGrade.LgD:
                    LblGrade.Text = "D";
                    break;
                case TLetterGrade.LgE:
                    LblGrade.Text = "E";
                    break;
                case TLetterGrade.LgF:
                    LblGrade.Text = "F";
                    break;
                default:
                    break;
            }
        }
        int ShowResult(int Point, out TLetterGrade LeterGrade)
        {
            int Result = 0;
            LeterGrade = TLetterGrade.LgNull;
            if (Point >= 85)
            {
                LetterGrade = TLetterGrade.LgA;
                Result= 2;
            }
            else if (Point >= 75 && Point < 85)
            {
                LetterGrade = TLetterGrade.LgB;
                Result = 2;
            }
            else if (Point >= 65 && Point < 75)
            {
                LetterGrade = TLetterGrade.LgC;
                Result= 2;
            }
            else if (Point >= 55 && Point < 65)
            {
                LetterGrade = TLetterGrade.LgD;
                Result= 1;
            }
            else if (Point >= 45 && Point < 55)
            {
                LetterGrade = TLetterGrade.LgE;
                Result= 1;
            }
            else if (Point<45)
            {
                LetterGrade= TLetterGrade.LgF;
                Result= 0;
            }
            return Result;
        }
    }
}

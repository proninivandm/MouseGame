using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/***********************************************************************
* КАФЕДРА   №304    2 КУРС ООП                                      	*
*-------------------------------------------------------------------  	*
*Project Type          :  Windows Forms Application                   	*
*Project Name          :  lab_oop							           	*
*File Name             :  FormLevel4.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              4 УРОВЕНЬ                              */
/* Наследник 1 уровня с добавлением кубиков, по нажатию старта запомнить
   порядок их исчезания и повторить его, чтобы открыть путь к финишу   */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public partial class FormLevel4 : FormLevel1
    {
        public FormLevel4()
        {
            InitializeComponent();
        }

        int k = 0;//количество правильно нажатых квадратиков

        public override void startGame()
        {
            base.startGame();
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            //показать все квадратики
            k = 0;
            label16.BackColor = Color.Lavender;
        }//StartGame_4()


        private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            //при нажатии на старт кубики по очереди исчезвют и появляются
            label12.Visible = false;
            Thread.Sleep(400);
            label12.Visible = true;
            Thread.Sleep(200);
            label6.Visible = false;
            Thread.Sleep(400);
            label6.Visible = true;
            Thread.Sleep(200);
            label7.Visible = false;
            Thread.Sleep(400);
            label7.Visible = true;
            Thread.Sleep(200);
            label8.Visible = false;
            Thread.Sleep(400);
            label8.Visible = true;
            Thread.Sleep(200);
            label9.Visible = false;
            Thread.Sleep(400);
            label9.Visible = true;
            Thread.Sleep(200);
            label10.Visible = false;
            Thread.Sleep(400);
            label10.Visible = true;
            Thread.Sleep(200);
            label11.Visible = false;
            Thread.Sleep(400);
            label11.Visible = true;
            Thread.Sleep(200);
        }

        private void FormLevel4_MouseClick(object sender, MouseEventArgs e)
        {
            //здесь мы проверяем, что индекс нажатого квадратика равен k (количеству правильно нажатых)
            if (((Label)sender).TabIndex == k + 25)
            {
                k++;
                ((Label)sender).Visible = false;//квадрат исчезает
            }
            else
                FinishGame();
            if (k==7)//если все нажали правильно, то блок меняет цвет->открыт проход к финишу
            {
                sound.PlayYouWin();
                Thread.Sleep(1000);
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label16.BackColor = Color.LavenderBlush;
            }

        }// если нажали на нужный квадратик, убрать его

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            //при наезде на блок проигрыш если он розовый, иначе проходим и он становится розовым
            if (label16.BackColor == Color.Violet)
                FinishGame();
            else
                if (label16.BackColor!=Color.LavenderBlush)
                    label16.BackColor = Color.Violet;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            FinishGame();
        }
    }
}

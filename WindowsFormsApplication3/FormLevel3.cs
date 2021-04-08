using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***********************************************************************
* КАФЕДРА   №304    2 КУРС ООП                                      	*
*-------------------------------------------------------------------  	*
*Project Type          :  Windows Forms Application                   	*
*Project Name          :  lab_oop							           	*
*File Name             :  FormLevel3.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              3 УРОВЕНЬ                              */
/* Наследник 2 уровня с добавлением лабиринтика и таймера, за время 
  которого надо добежать до финиша                                    */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public partial class FormLevel3 : FormLevel2
    {

        public FormLevel3()
        {
            InitializeComponent();
        }

        private void StartGame_3()
        {
            StartGame_2();
            labelBlink3.Visible = true;//показать мигающий блок
        }//StartGame_3()

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelBlink3.Visible = !labelBlink3.Visible;//блок появляется и исчезает
        }

        private void FormLevel3_MouseEnter(object sender, EventArgs e)
        {
            FinishGame_2();//если наехали на блок
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            if (label16.BackColor != Color.Lavender)//если блок не белый, то проигрыш
                FinishGame_2();
            else
                label16.BackColor = Color.Violet;//если белый, то его можно пройти, и затем он станет розовым
        }
        private void label15_MouseClick(object sender, MouseEventArgs e)
        {
            sound.PlayTimer();/*при нажатии на кнопку старт блок поменяет цвет,значит его можно пройти, и запустится 
            таймер на 5 сек, за время которого надо дойти до финиша*/
            label16.BackColor = Color.Lavender ;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((DialogResult != DialogResult.OK))//если диалоговое окно не открыто
            {
                timer2.Stop();//остановить таймер
                FinishGame_2();//проигрыш
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/***********************************************************************
* КАФЕДРА   №304    2 КУРС ООП                                      	*
*-------------------------------------------------------------------  	*
*Project Type          :  Windows Forms Application                   	*
*Project Name          :  lab_oop							           	*
*File Name             :  FormMain.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              МЕНЮ                                   */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //Начать игру с первого уровня
        private void StartLevel1()
        {
            //создать форму для лабиринта 1 уровня
            FormLevel1 Level1 = new FormLevel1();

            //запускаем игру с 1 уровня в модальном режиме,чтобы нельзя было вернуться в начальную форму
            //Level1.ShowDialog();

            DialogResult dRes = Level1.ShowDialog();

            //Анализируем что получилось на первом уровне

            if (dRes == DialogResult.OK)
                StartLevel2();

        }//StartLevel1

        //Переход на второй уровень - на первом уровне наехали на финиш
        private void StartLevel2()
        {
            sound.PlayYouWin();
            FormLevel2 Level2 = new FormLevel2();

            DialogResult dRes = Level2.ShowDialog();

            //Анализируем что получилось на первом уровне

            if (dRes == DialogResult.OK)
                StartLevel3();

        }

        private void StartLevel3()
        {
            sound.PlayYouWin();
            FormLevel3 Level3 = new FormLevel3();
            DialogResult dRes = Level3.ShowDialog();

            //Анализируем что получилось на прошлом уровне

            if (dRes == DialogResult.OK)
                StartLevel4();

        }

        private void StartLevel4()
        {
            sound.PlayYouWin();
            FormLevel4 Level4 = new FormLevel4();
            DialogResult dRes = Level4.ShowDialog();

            //Анализируем что получилось на прошлом уровне

            if (dRes == DialogResult.OK)
                StartLevel5();
        }

        private void StartLevel5()
        {
            sound.PlayYouWin();
            FormLevel5 Level5 = new FormLevel5();
            DialogResult dRes = Level5.ShowDialog();

            //Анализируем что получилось на первом уровне

            if (dRes == DialogResult.OK)
            {
                DialogResult dr = MessageBox.Show(
                "Вы выиграли! Поздравляем",
                "Конец игры",
                MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    DialogResult = DialogResult.Abort;
            }

                
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Начать игру-кнопка "старт"
            sound.PlayStart();

            //Начать игру с первого уровня
            StartLevel1();

        }//buttonStart

       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Выход из игры-кнопка "выход"
            sound.PlayExit();
            //задержка,чтобы доиграл звук до закрытия формы
            Thread.Sleep(1000);
            this.Close();
            
        }



        //--------------------------------------------
        //обработчик-звук есть/звука нет
        private void Sound_CheckedChanged(object sender, EventArgs e)
        {
            //если было изменение галочки
            if(Sound.Checked)//Галочка установлена
            {
                Sound.Text = "Звук включен";
                sound.SoundOn();//звуковое сопровождение на смене галочки включить
            }
            else
            {
                Sound.Text = "Звука нет. Не завезли";
                sound.SoundOff();//звуковое сопровождение на смене галочки включить
            }

            sound.PlayKey();
        }

       

    }
}
/**********************************END****************************************/
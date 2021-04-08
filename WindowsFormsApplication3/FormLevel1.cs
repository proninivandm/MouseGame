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
*File Name             :  FormLevel1.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              1 УРОВЕНЬ                              */
/* Собираем кубики и идем к финишу                                     */
/**********************************************************************/


namespace WindowsFormsApplication3
{
    public partial class FormLevel1 : Form
    {
        int priserest;//сколько призовых кубиков осталось
        public FormLevel1()
        {
            InitializeComponent();
        }
        
        //--------------------------------
        //подготовка к запуску
        public virtual void startGame()//для вызова в наследнике
        {
            
            sound.PlayStart();
            //помещаем курсор мыши на начало игры от начала стартовой кнопки текущей формы
            //левый верхний угол кнопки старт формы первого уровня

            Point startPoint = labelStart.Location;
            //смещение курсора на серидину кнопки
            startPoint.Offset(labelStart.Width / 2,
                              labelStart.Height / 2);
           
            //относительно всего экрана!!!
            Cursor.Position = PointToScreen(startPoint);

            priserest = 6;

            //сделаем кубики видимыми на экране
            labelPrise1.Visible = true;
            labelPrise2.Visible = true;
            labelPrise3.Visible = true;
            labelPrise4.Visible = true;
            labelPrise5.Visible = true;
            labelPrise6.Visible = true;

        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            startGame();
        }//startGame

        private void FormLevel1_MouseEnter(object sender, EventArgs e)
        {
            

        }

        private void labelFINISH_MouseEnter(object sender, EventArgs e)
        {
            //Конец игры ок
            if(priserest==0) //Все призы собраны и выходим из игры
                DialogResult = DialogResult.OK; //Закрытие модального окна
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            FinishGame();
        }

        //Реализация препятствия 

        public virtual void FinishGame()//для вызова в наследнике
        {
            sound.PlayFail();
            //Что дальше повторить или закончить игру?
            DialogResult dr = MessageBox.Show(
                "Вы проиграли! Еще раз попробуем?",
                "Печальное сообщение 1",
                MessageBoxButtons.YesNo);

            //Сотрим ответ пользователя
            if (dr == DialogResult.Yes)
                startGame();//начать заново
            else
                DialogResult= DialogResult.Abort;//Закрыть форму
        }

        private void labelPrise1_MouseEnter(object sender, EventArgs e)
        {
            //Надо спрятать тот кирпич на который наехали
            //узнаем по параметру sender
            //приведем его к типу Label и спрячем фишку

            ((Label)sender).Visible = false;
            sound.PlayKey();
            priserest--;
        }
    }//class
}//namespace

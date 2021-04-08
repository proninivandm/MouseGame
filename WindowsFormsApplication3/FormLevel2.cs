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
*File Name             :  FormLevel2.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              2 УРОВЕНЬ                              */
/*    Проходим мигающие блоки, собираем ключик, и через дверь на финиш */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }
        //Событие при первом отображении формы Level2


        private void labelDoor_Click(object sender, EventArgs e)
        {

        }
        //Начнем второй уровень
        protected void StartGame_2()//для вызова в наследнике
        {
            ReturnBlocks();
            sound.PlayStart(); //начало игры

            //Помещаем курсор мыши на начало игры 
            Point startPoint = labelStart.Location;

            //смещение курсора на серидину кнопки на кнопку старт
            startPoint.Offset(labelStart.Width / 2,
                              labelStart.Height / 2);
            //относительно всего экрана!!!
            Cursor.Position = PointToScreen(startPoint);

        }//StartGame_2()

        protected void ReturnBlocks()//для вызова в наследнике
        {
            //Ключ и дверь вновь видимы
            labelKey.Visible = true;
            labelDoor.Visible = true;

            labelBlink1.Visible = true;
            labelBlink2.Visible = false;
        }
        protected void FinishGame_2()//для вызова в наследнике
        {
            sound.PlayFail();
            //Что дальше повторить или закончить игру?
            DialogResult dr = MessageBox.Show(
                "Вы проиграли! Еще раз попробуем?",
                "Печальное сообщение 2",
                MessageBoxButtons.YesNo);

            //Сотрим ответ пользователя
            if (dr == DialogResult.Yes)
                StartGame_2();//начать заново
            else
                DialogResult = DialogResult.Abort;//Закрыть форму
        }

        protected void label6_MouseEnter(object sender, EventArgs e)//вызов в наследнике
        {
            FinishGame_2();
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            StartGame_2();
        }
        //Наехали на ключ, ключ делается невидимым и дверь пропадает
        private void labelKey_MouseEnter(object sender, EventArgs e)
        {
            //Дверь пропадает когда мы на 
            labelKey.Visible = false;
            sound.PlayKey();
        }

        private void labelDoor_MouseEnter(object sender, EventArgs e)
        {
            //Проверим взят ли ключ
            if (labelKey.Visible) //
                FinishGame_2();
            else
            {
                labelDoor.Visible = false;
                sound.PlayKey();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //переключить наоборот
            labelBlink1.Visible = !labelBlink1.Visible;
            labelBlink2.Visible = !labelBlink2.Visible;

        }

        private void labelFINISH_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //Закрытие модального окна

        }

        private void labelStart_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelBlink2_Click(object sender, EventArgs e)
        {

        }

        private void labelBlink1_Click(object sender, EventArgs e)
        {

        }

        private void labelFINISH_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel2_Load(object sender, EventArgs e)
        {

        }

        private void labelKey_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

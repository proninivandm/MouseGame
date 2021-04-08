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
*File Name             :  FormLevel5.cs						       		*
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                              5 УРОВЕНЬ                              */
/* Наследник 4 уровня с добавлением блоков и кнопки, открывающей проход
   к финишу                                                            */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public partial class FormLevel5 : FormLevel4
    {
        public FormLevel5()
        {
            InitializeComponent();
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            //при наезде на блоки проигрыш
            FinishGame();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //по нажатию кнопки открыть проход к финишу
            label16.Visible = false;
        }
    }
}

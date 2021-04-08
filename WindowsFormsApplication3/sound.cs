using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

/***********************************************************************
* КАФЕДРА   №304    2 КУРС ООП                                      	*
*-------------------------------------------------------------------  	*
*Project Type          :  Windows Forms Application                   	*
*Project Name          :  lab_oop							           	*
*File Name             :  sound.cs				   		       		    *
*Language              :  C#                                           	*
*Programmer(s)         :  Пронин И.Д       					 		    * 
*Modified By           :  Пронин И.Д                                   	*
*Created               :   19.05.2019                                  	*   
*Last Revision         :   30.05.2019                                	*
/**********************************************************************	/
/*                    Класс для воспроизведения звуков                 */
/**********************************************************************/

namespace WindowsFormsApplication3
{
    public static class sound
    {
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.FailGame);
        static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.KeyGame); 
        static SoundPlayer soundYouWin = new SoundPlayer(Properties.Resources.youWinGame);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.StartGame);
        static SoundPlayer soundExit = new SoundPlayer(Properties.Resources.ExitGame);
        static SoundPlayer soundTimer = new SoundPlayer(Properties.Resources.tic_tac_reveil);

        //играемся с флагом
        static bool soundEnable = true;//звук вкл

        //----------------------------------------
        //ф-я вкл звука
        public static void SoundOn()
        {
            soundEnable = true;
        }//SoundOn

        //ф-я выкл звука
        public static void SoundOff()
        {
            soundEnable = false;
        }//SoundOff
        //----------------------------------------


        public static void PlayFail()
        {
            //Если флаг позволяет-играем
            if (soundEnable)
            { 
                soundFail.Play(); 
            }
        }//PlayFail()
        public static void PlayTimer()
        {
            if (soundEnable)
            {
                soundTimer.Play();
            }
        }

        public static void PlayKey()
        {
            //Если флаг позволяет-играем
            if (soundEnable)
            {
                soundKey.Play();
            }
        }//PlayKey()

        public static void PlayYouWin()
        {
            //Если флаг позволяет-играем
            if (soundEnable)
            {
                soundYouWin.Play();
            }
        }//PlayYouWin()

        public static void PlayStart()
        {
            //Если флаг позволяет-играем
            if (soundEnable)
            {

                soundStart.Play();
            }
        }//PlayStart()

        public static void PlayExit()
        {
            //Если флаг позволяет-играем
            if (soundEnable)
            {
                soundExit.Play();
            }
        }//PlayExit()
        
    }//classSound
}//namespace

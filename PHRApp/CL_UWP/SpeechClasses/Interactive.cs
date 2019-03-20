using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code Set - Interactive

namespace CL_UWP.SpeechClasses
{
    public class Interactive
    {
        public int RepStatus { get; set; }
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string PlName { get; set; }
        public string TtsRaw { get; set; }
        public string FileUri { get; set; }
        public bool IsRandomized { get; set; }

        // *Note Each Method, is equilivant to a single ICommand.

        /// <summary>
        ///  Make Titles change based on Timer Repitition Status.
        /// </summary>
        /// <param name="repStatus"></param>
        /// <param name="titleId"></param>
        /// <param name="titleName"></param>
        /// <param name="plName"></param>
        /// <param name="ttsRaw"></param>
        /// <param name="fileUri"></param>
        public void ChangeTitle(int repStatus, int titleId = 0, string titleName = "Status", string plName = "NA", string ttsRaw = "Status Info", string fileUri = "NA")
        {

            //if (plName == "PL10P")
            //{
            //    PlName = plName;
            //    Debug.WriteLine("plName: " + repStatus.ToString() + "\n");
            Debug.WriteLine("________________________");
            Debug.WriteLine("\n\nrepStatusNo: " + repStatus.ToString());
            if (repStatus != 0)
            {
                RepStatus = repStatus;
                switch (RepStatus)
                {
                    case 1:
                        TitleName = "Say the Point-to-Point, SED-IceBreakers Cycle 1-10 , Say IB 1.";
                        //1 - Speed - Rehearsal to Readiness.
                        //2 - Speed - Window Shopping and Obvious Personal Space IceBreakers.
                        //3 - Speed - As soon as see them "Mix it up", "light and casual".
                        //4 - Speed - In under 2 minutes, Take them Aside.
                        //5 - Speed - As soon as you all are aside, Begin "the Hard Sell", touch them after they touch you first.
                        //6 - Speed - "Dirty Talk".
                        //7 - Speed - "Closing, Logistics, and Cock-Block Handling".
                        //8 - Keep them hot on way home.
                        //9 - Speed - Mental Prepare to break final ice by all getting naked as soon as close door.
                        //10 - Speed - Tell them you had fun as soon as done, so you don't seem needy incase you want upper hand to see them again.
                        return;
                    case 2:
                        TitleName = "Hint, R 2 R";
                        return;
                    case 3:
                        TitleName = "1 , Speed - Rehearsal to Readiness.";
                        return;
                    case 4:
                        TitleName = "Say IB 2";
                        return;
                    case 5:
                        TitleName = "Hint, 2 Windows";
                        return;
                    case 6:
                        TitleName = "2 , Speed - Window Shopping and Obvious Personal Space IceBreakers.";
                        return;

                    case 7:
                        TitleName = "Say IB 3";
                        return;
                    case 8:
                        TitleName = "Hint, Mixie 3";
                        return;
                    case 9:
                        TitleName = "3 , Speed - As soon as see them \"Mix it up\", \"light and casual\".";
                        return;

                    case 10:
                        TitleName = "Say IB 4";
                        return;
                    case 11:
                        TitleName = "Hint, 4 this step also Initiates the hook up";
                        return;
                    case 12:
                        TitleName = "4 , Speed - In under 2 minutes, Take them Aside.";
                        return;

                    case 13:
                        TitleName = "Say IB 5";
                        return;
                    case 14:
                        TitleName = "Hint, I'm Serious times 5";
                        return;
                    case 15:
                        TitleName = "5 , Speed - As soon as you all are aside, Begin \"the Hard Sell\", touch them after they touch you first.";
                        return;

                    case 16:
                        TitleName = "Say IB 6";
                        return;
                    case 17:
                        TitleName = "hint, 6 Nuts";
                        return;
                    case 18:
                        TitleName = "6 , Speed - \"Dirty Talk\".";
                        return;


                    case 19:
                        TitleName = "Say IB 7";
                        return;
                    case 20:
                        TitleName = "Hint, 7th Closing";
                        return;
                    case 21:
                        TitleName = "7 , Speed - \"Closing, Logistics, and Cock-Block Handling\".";
                        return;

                    case 22:
                        TitleName = "Say IB 8";
                        return;
                    case 23:
                        TitleName = "Hint, I 8 hot meat";
                        return;
                    case 24:
                        TitleName = "8 , Keep them hot on the way home.";
                        return;

                    case 25:
                        TitleName = "Say IB 9";
                        return;
                    case 26:
                        TitleName = "Hint, open door 9";
                        return;
                    case 27:
                        TitleName = "9 , Speed - Mental Prepare to break final ice by all getting naked as soon as close door.";
                        return;

                    case 28:
                        TitleName = "Say IB 10";
                        return;
                    case 29:
                        TitleName = "Hint, Hang Fun 10";
                        return;
                    case 30:
                        TitleName = "10 , Speed - Tell them you had fun as soon as done, so you don't seem needy incase you want upper hand to see them again.";
                        return;

                    default:
                        return;
                }
            }

            //Test Optional Arguments Default Values
            Debug.WriteLine("Test Optional Arguments Default Values\n");
            Debug.WriteLine(repStatus.ToString() + ", " + titleId.ToString() + ", " +
                            titleName + ", " + ttsRaw + ", " +
                            fileUri + "\n");
            //}
            //else
            //{
            //    Debug.WriteLine("in else >> plName: " + plName + "\n");
            //}

        }


        /// <summary>
        ///  Make Titles change Randomly based on Timer Repitition Status.
        /// </summary>
        /// <param name="repStatus"></param>
        /// <param name="titleId"></param>
        /// <param name="titleName"></param>
        /// <param name="ttsRaw"></param>
        /// <param name="fileUri"></param>
        /// <param name="isRandomized"></param>
        //public void ChangeTitle(int repStatus, int titleId, string titleName, string ttsRaw, string fileUri, bool isRandomized)
        //{
        //}

        // Show Hints, Mnemonic devices, or helpful reminders and sayings.


        #region VISUALIZATION
        //  RepeaterUC-1      |  InteractiveUC    |   RepeaterUC-2
        //   Questions        |     Hints         |     Answers
        //      or            |   Mnemonics       |        or
        // Rehearse Prompts   |  Helpful Sayings  |   Degree of Ready
        #endregion
    }
}

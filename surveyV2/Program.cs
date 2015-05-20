using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surveyV2
{
    public class Statement
    {
        public string statement = String.Empty;
        public List<string> programs = new List<string>();
    }

    class Program
    {
        public static int threshold = -30;
        public static Dictionary<string, int> dictionary = new Dictionary<string, int>();
        

        public static bool stopITQuestions = false;
        public static bool stopHITQuestions = false;
        public static bool stopBAMQuestions = false;
        public static bool stopCJQuestions = false;
        public static bool stopMEDQuestions = false;
        public static bool stopIT2Questions = true;
        public static int count = 0;
        public static int agree = 0;
        public static int disagree = 0;
        public static int neutral = 0;
        public static string idiot = null;

        public static Statement[] statements = new Statement[27];
        
        public static void survey()
        {
           

        }


        public static void prime()
        {
            string choice = null;

            Console.WriteLine("Do you enjoy computers?");
            Console.WriteLine("1. yes   2. no");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                stopITQuestions = false;
            }

            else if(choice == "2")
            {
                Console.WriteLine("Would you be willing to work with comupters all day?");
                Console.WriteLine("1. yes   2. no");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    stopITQuestions = true;
                    stopHITQuestions = false;
                }

                else if (choice == "2")
                {
                    stopITQuestions = true;
                    stopHITQuestions = true;
                }
                
                else
                {
                    Console.WriteLine("error");
                    choice = Console.ReadLine();
                }

            }
        }

        public static void updateTally(List<string> programs, int tallyScore)
        {
            if(programs.Contains("IT"))
            {
                dictionary["IT"] = dictionary["IT"] + tallyScore;
            }

            if (programs.Contains("HIT"))
            {
                dictionary["HIT"] = dictionary["HIT"] + tallyScore;
            }

            if (programs.Contains("CJ"))
            {
                dictionary["CJ"] = dictionary["CJ"] + tallyScore;
            }

            if (programs.Contains("BAM"))
            {
                dictionary["BAM"] = dictionary["BAM"] + tallyScore;
            }

            if (programs.Contains("MA"))
            {
                dictionary["MA"] = dictionary["MA"] + tallyScore;
            }


            if (programs.Contains("ITProgram"))
            {
                dictionary["ITProgram"] = dictionary["ITProgram"] + tallyScore;
            }

            if (programs.Contains("ITNetwork"))
            {
                dictionary["ITNetwork"] = dictionary["ITNetwork"] + tallyScore;
            }


            if (programs.Contains("AMA"))
            {
                dictionary["AMA"] = dictionary["AMA"] + tallyScore;
            }

            if (programs.Contains("BOS"))
            {
                dictionary["BOS"] = dictionary["BOS"] + tallyScore;
            }

            if (programs.Contains("AP"))
            {
                dictionary["AP"] = dictionary["AP"] + tallyScore;
            }

        }

        static void Main(string[] args)
        {
            dictionary.Add("IT", 0);
            dictionary.Add("ITProgram", 0);
            dictionary.Add("ITNetwork", 0);
            dictionary.Add("HIT", 0);
            dictionary.Add("BAMM", 0);
            dictionary.Add("CJ", 0);
            dictionary.Add("MA", 0);
            dictionary.Add("AMA", 0);
            dictionary.Add("BAA", 0);
            dictionary.Add("BOS", 0);
            dictionary.Add("AP", 0);


            

            string choice = null;
            prime();
            //initialize data structure
            statements[0] = new Statement();
            statements[0].statement = "I play video games at least 3 times a week.";
            statements[0].programs.Add("IT");

            statements[1] = new Statement();
            statements[1].statement = "I see myself becoming an office manager of a medical clinic and being in charge of all of the office staff.";
            statements[1].programs.Add("HIT");

            statements[2] = new Statement();
            statements[2].statement = "I can see myself performing minor medical procedures accurately and effectively.";
            statements[2].programs.Add("MA");


            statements[3] = new Statement();
            statements[3].statement = "i like CJ and BAM";
            statements[3].programs.Add("CJ");
            statements[3].programs.Add("BAMM");

            statements[4] = new Statement();
            statements[4].statement = "i like IT, HIT and BAM ";
            statements[4].programs.Add("IT");
            statements[4].programs.Add("HIT");
            statements[4].programs.Add("BAMM");

            statements[5] = new Statement();
            statements[5].statement = "i like CJ, HIT and BAM ";
            statements[5].programs.Add("CJ");
            statements[5].programs.Add("HIT");
            statements[5].programs.Add("BAMM");


            statements[6] = new Statement();
            statements[6].statement = "i like programming";
            statements[6].programs.Add("ITProgram");


            statements[7] = new Statement();
            statements[7].statement = "i like IT";
            statements[7].programs.Add("IT");

            statements[8] = new Statement();
            statements[8].statement = "i like IT";
            statements[8].programs.Add("IT");

            statements[9] = new Statement();
            statements[9].statement = "i like IT";
            statements[9].programs.Add("IT");

            statements[10] = new Statement();
            statements[10].statement = "i like IT";
            statements[10].programs.Add("IT");

            statements[11] = new Statement();
            statements[11].statement = "i like IT";
            statements[11].programs.Add("IT");

            statements[12] = new Statement();
            statements[12].statement = "i like IT";
            statements[12].programs.Add("IT");

            statements[13] = new Statement();
            statements[13].statement = "i like IT";
            statements[13].programs.Add("IT");

            statements[14] = new Statement();
            statements[14].statement = "i like IT";
            statements[14].programs.Add("IT");

            statements[15] = new Statement();
            statements[15].statement = "i like IT";
            statements[15].programs.Add("IT");

            statements[16] = new Statement();
            statements[16].statement = "i like IT";
            statements[16].programs.Add("IT");

            statements[17] = new Statement();
            statements[17].statement = "i like IT";
            statements[17].programs.Add("IT");

            statements[18] = new Statement();
            statements[18].statement = "i like IT";
            statements[18].programs.Add("IT");

            statements[19] = new Statement();
            statements[19].statement = "i like IT";
            statements[19].programs.Add("IT");

            statements[20] = new Statement();
            statements[20].statement = "i like IT";
            statements[20].programs.Add("IT");

            statements[21] = new Statement();
            statements[21].statement = "i like IT";
            statements[21].programs.Add("IT");

            statements[22] = new Statement();
            statements[22].statement = "i like IT";
            statements[22].programs.Add("IT");

            statements[23] = new Statement();
            statements[23].statement = "i like IT";
            statements[23].programs.Add("IT");

            statements[24] = new Statement();
            statements[24].statement = "i like IT";
            statements[24].programs.Add("IT");

            statements[25] = new Statement();
            statements[25].statement = "i like IT";
            statements[25].programs.Add("IT");

            statements[26] = new Statement();
            statements[26].statement = "i like IT";
            statements[26].programs.Add("IT");

            //array shuffle goes here
            //Array.
            foreach (Statement stmt in statements)
            {
                bool showQuestion = false;

                foreach (String program in stmt.programs)
                {
                    
                    
                    if (program == "IT")
                    {
                        if(stopITQuestions == false)
                        {
                            showQuestion = true;
                        }
                    }


                    if (program == "ITProgram" || program == "ITNetwork")
                    {
                        if (stopIT2Questions == false)
                        {
                            showQuestion = true;
                        }
                    }

                    if (program == "HIT")
                    {
                        if (stopHITQuestions == false)
                        {
                            showQuestion = true;
                        }
                    }

                    if (program == "BAMM")
                    {
                        if (stopBAMQuestions == false)
                        {
                            showQuestion = true;
                        }
                    }

                    if (program == "CJ")
                    {
                        if (stopCJQuestions == false)
                        {
                            showQuestion = true;
                        }
                    }

                    if (program == "MED")
                    {
                        if (stopMEDQuestions == false)
                        {
                            showQuestion = true;
                        }
                    }
                }
                if(showQuestion)
                {
                    Console.WriteLine(stmt.statement);
                    Console.WriteLine("1: strongly Agree  2:Agree   3:Neutral   4:disagree   5:Strongly Disagree");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        updateTally(stmt.programs, 3);
                        agree++;
                    }

                    else if (choice == "2")
                    {
                        updateTally(stmt.programs, 1);
                        agree++;
                    }

                    else if (choice == "3")
                    {
                        updateTally(stmt.programs, 0);
                        neutral++;
                    }

                    else if (choice == "4")
                    {
                        updateTally(stmt.programs, -1);
                        disagree++;
                    }

                    else if (choice == "5")
                    {
                        updateTally(stmt.programs, -3);
                        disagree++;
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine();
                    }
                    
                    count++;

                    if ((agree > 18) || (disagree > 18) && (count == 25))
                    {
                        Console.WriteLine("Are you sure you are thinking about this enough? Results could be inconclusive given these answers.");
                    }


                    if((neutral > 12)&& (count == 25))
                    {
                        Console.WriteLine("You don't care for any of this? Your results will be inconclusive given your responses.");
                        Console.WriteLine("Please type \"I understand\" to continue. Please type \"restart\" to conclude this test and start over");
                        idiot = Console.ReadLine();

                        while ((idiot != "I understand") && (idiot != "restart"))
                        {
                            Console.WriteLine("please type in a valid answer");
                            idiot = Console.ReadLine();
                        }

                        if (idiot == "I understand")
                        {

                        }
                        else if (idiot == "restart")
                        {
                            Console.WriteLine("The program will now terminate. Please follow ALL directions in the future and think carefully.");
                            break;

                        }

                       
                    }

                    Console.WriteLine();
                    //Console.WriteLine("IT is at " + IT + " points, HIT is at " + HIT + " points, CJ is at " + CJ + " points, BAM is at " + BAM + " points, MED is at " + MED + " points");
                    Console.WriteLine();
                    
                    if(dictionary["IT"] <= threshold)
                    {
                        stopITQuestions = true;
                    }

                    if (dictionary["CJ"] <= threshold)
                    {
                        stopCJQuestions = true;
                    }

                    if (dictionary["HIT"] <= threshold)
                    {
                        stopHITQuestions = true;
                    }

                    if (dictionary["BAMM"] <= threshold)
                    {
                        stopBAMQuestions = true;
                    }


                    //if (dictionary["MED"] <= threshold)
                    //{
                    //    stopMEDQuestions = true;
                    //}

                    if ((dictionary["IT"] > dictionary["BAMM"]) && (dictionary["IT"] > dictionary["HIT"]) && (dictionary["IT"] > dictionary["CJ"]))
                    {
                        stopIT2Questions = false;
                    }

                }

              
            }
            List<String> results = new List<String>();


            var max = dictionary["IT"];
            foreach (var DictonaryEntry in dictionary)
            {
                if (max < DictonaryEntry.Value)
                {
                    max = DictonaryEntry.Value;
                }
            }

            foreach (var DictonaryEntry in dictionary)
            {
                if (max - DictonaryEntry.Value <= 3)
                {
                    results.Add(DictonaryEntry.Key);
                }
            }


            Console.WriteLine("you're best course/s would be:");
            results.ForEach(Console.WriteLine);
        }
    }
}

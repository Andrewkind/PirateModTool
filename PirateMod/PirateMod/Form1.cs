using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PirateMod
{
    public partial class Form1 : Form
    {

        string fileName = "events.txt";

        public Form1()
        {
          

            InitializeComponent();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         

            string[] arrayCombo = new string[] { "1", "2", "3", "4" };

            //optionsCombo.add

        //    optionsCombo.Items.Add("1");
        //    optionsCombo.Items.Add("2");
        //    optionsCombo.Items.Add("3");
         /*   optionsCombo.Items.Add("4");
            optionsCombo.SelectedIndex = 0;
            optionsChoiceCombo.SelectedIndex = 0;

            SuccessChoiceCombo.Items.Add("Success");
            SuccessChoiceCombo.Items.Add("Failure");
            SuccessChoiceCombo.SelectedIndex = 0; */


            FightDif1.Items.Add("Random");
            FightDif1.Items.Add("Easy");
            FightDif1.Items.Add("Medium");
            FightDif1.Items.Add("Hard");
            FightDif1.SelectedIndex = 0;


            FightDif2.Items.Add("Random");
            FightDif2.Items.Add("Easy");
            FightDif2.Items.Add("Medium");
            FightDif2.Items.Add("Hard");
            FightDif2.SelectedIndex = 0;
            
        }

        private void typesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //If crew is a selected change, have user be able to select which crew
          
        }

        private void optionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

         /*   optionsChoiceCombo.Items.Clear();

            int itemsInt = optionsCombo.SelectedIndex;
            itemsInt += 2;

            string itemsString;


            int p = 1;
            while (p < itemsInt)
            {
                itemsString = p.ToString();

                optionsChoiceCombo.Items.Add(itemsString);

                p++;
            }

            optionsChoiceCombo.SelectedIndex = 0;
        */
        } 

        private void firstOdds1_ValueChanged(object sender, EventArgs e)
        {


          //  secondOdds1.Value = (100 - firstOdds1.Value);

        }

        private void secondOdds1_ValueChanged(object sender, EventArgs e)
        {
            //firstOdds1.Value = (100 - secondOdds1.Value);

        }

        private void typesCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save attributes to file

            string f_eventName = eventName.Text;            
            string f_eventText = eventText.Text;            //event text description
            


            //THIS IS FIRST OUTPUT OF 1/4

            // for the first option...
            

            string f_firstResultText1 = FirstResultText1.Text;            //this is the description of the result


            //THIS IS FIRST OUTPUT OF 1/4

            // for the first option...


            int f_firstOdds1 = (int)firstOdds1.Value;           //this is to calculate the odds for first output


            //rewards
            //just one reward for now
            // DONE FOR FIRST, NOW SECOND
            
            // THIS IS SECOND OUTPUT OF ... 1/4


            string f_secondResultText1 = FirstResultText1.Text;            //this is the description of the result



            // lets parse into our textfile

            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true);
            file.WriteLine("~eventName^" + f_eventName);   // MUST CHECK IF An EVENT BY THIS nAME EXISTS....
            file.Close();

            file = new System.IO.StreamWriter(fileName, true);  // adding true makes it append instead of overwrite

            //System.IO.StreamWriter file = new System.IO.StreamWriter(fileName); // overwrites..

            file.WriteLine("~event text^" + f_eventText);      
            

            // start of 1
            //SUCCESS FAILURE TEXT INFO 1
            file.WriteLine("~option text1^" + optionText1.Text);
            file.WriteLine("~success text1^" + f_firstResultText1);
            file.WriteLine("~fail text1^" + SecondResultText1.Text);

            

            // ODDS INFO 1
            file.WriteLine("~odds1^" + f_firstOdds1);

            file.WriteLine("~odds Wit1^" + numericUpDownOddsWit1.Value);
            file.WriteLine("~odds Morale1^" + numericUpDownOddsMorale1.Value);
            file.WriteLine("~odds Notoriety1^" + numericUpDownOddsNotoriety1.Value);
            file.WriteLine("~odds Charisma1^" + numericUpDownOddsCharisma1.Value);
            file.WriteLine("~odds Evil1^" + numericUpDownOddsEvil1.Value);

            file.WriteLine("~odds Crew1^" + numericUpDownOddsCrew1.Value);
            file.WriteLine("~odds Integrity1^" + numericUpDownOddsIntegrity1.Value);
            file.WriteLine("~odds Ale1^" + numericUpDownOddsAle1.Value);
            file.WriteLine("~odds Gunpowder1^" + numericUpDownOddsGunpowder1.Value);
            file.WriteLine("~odds Coins1^" + numericUpDownOddsGold1.Value);
            
            //End of odds  1

            //success rewards 1
            file.WriteLine("~Success Wit1^" + numericUpDownFirstWit1.Value);
            file.WriteLine("~Success Morale1^" + numericUpDownFirstMorale1.Value);
            file.WriteLine("~Success Notoriety1^" + numericUpDownFirstNotoriety1.Value);
            file.WriteLine("~Success Charisma1^" + numericUpDownFirstCharisma1.Value);
            file.WriteLine("~Success Evil1^" + numericUpDownFirstEvil1.Value);

            file.WriteLine("~Success Crew1^" + numericUpDownFirstCrew1.Value);
            file.WriteLine("~Success Integrity1^" + numericUpDownFirstIntegrity1.Value);
            file.WriteLine("~Success Ale1^" + numericUpDownFirstAle1.Value);
            file.WriteLine("~Success Gunpowder1^" + numericUpDownFirstGunpowder1.Value);
            file.WriteLine("~Success Coins1^" + numericUpDownFirstGold1.Value);

            //failure rewards 1
            file.WriteLine("~Failure Wit1^" + numericUpDownSecondWit1.Value);
            file.WriteLine("~Failure Morale1^" + numericUpDownSecondMorale1.Value);
            file.WriteLine("~Failure Notoriety1^" + numericUpDownSecondNotoriety1.Value);
            file.WriteLine("~Failure Charisma1^" + numericUpDownSecondCharisma1.Value);
            file.WriteLine("~Failure Evil1^" + numericUpDownSecondEvil1.Value);

            file.WriteLine("~Failure Crew1^" + numericUpDownSecondCrew1.Value);
            file.WriteLine("~Failure Integrity1^" + numericUpDownSecondIntegrity1.Value);
            file.WriteLine("~Failure Ale1^" + numericUpDownSecondAle1.Value);
            file.WriteLine("~Failure Gunpowder1^" + numericUpDownSecondGunpowder1.Value);
            file.WriteLine("~Failure Coins1^" + numericUpDownSecondGold1.Value);


            file.WriteLine("~Make Fight1^" + FightCheck1.Checked);
            file.WriteLine("~Fight Dif1^" + FightDif1.Text);
            // END OF 1

       


            // start of 2
            //SUCCESS FAILURE TEXT INFO 1
            file.WriteLine("~option text2^" + optionText2.Text);
            file.WriteLine("~success text2^" + FirstResultText2.Text);
            file.WriteLine("~fail text2^" + SecondResultText2.Text);


            // ODDS INFO 2
            file.WriteLine("~odds2^" + firstOdds2.Value);

            file.WriteLine("~odds Wit2^" + numericUpDownOddsWit2.Value);
            file.WriteLine("~odds Morale2^" + numericUpDownOddsMorale2.Value);
            file.WriteLine("~odds Notoriety2^" + numericUpDownOddsNotoriety2.Value);
            file.WriteLine("~odds Charisma2^" + numericUpDownOddsCharisma2.Value);
            file.WriteLine("~odds Evil2^" + numericUpDownOddsEvil2.Value);

            file.WriteLine("~odds Crew2^" + numericUpDownOddsCrew2.Value);
            file.WriteLine("~odds Integrity2^" + numericUpDownOddsIntegrity2.Value);
            file.WriteLine("~odds Ale2^" + numericUpDownOddsAle2.Value);
            file.WriteLine("~odds Gunpowder2^" + numericUpDownOddsGunpowder2.Value);
            file.WriteLine("~odds Coins2^" + numericUpDownOddsGold2.Value);

            //End of odds  2 46

            //success rewards 2
            file.WriteLine("~Success Wit2^" + numericUpDownFirstWit2.Value);
            file.WriteLine("~Success Morale2^" + numericUpDownFirstMorale2.Value);
            file.WriteLine("~Success Notoriety2^" + numericUpDownFirstNotoriety2.Value);
            file.WriteLine("~Success Charisma2^" + numericUpDownFirstCharisma2.Value);
            file.WriteLine("~Success Evil2^" + numericUpDownFirstEvil2.Value);

            file.WriteLine("~Success Crew2^" + numericUpDownFirstCrew2.Value);
            file.WriteLine("~Success Integrity2^" + numericUpDownFirstIntegrity2.Value);
            file.WriteLine("~Success Ale2^" + numericUpDownFirstAle2.Value);
            file.WriteLine("~Success Gunpowder2^" + numericUpDownFirstGunpowder2.Value);
            file.WriteLine("~Success Coins2^" + numericUpDownFirstGold2.Value);

            //failure rewards 2
            file.WriteLine("~Failure Wit2^" + numericUpDownSecondWit2.Value);
            file.WriteLine("~Failure Morale2^" + numericUpDownSecondMorale2.Value);
            file.WriteLine("~Failure Notoriety2^" + numericUpDownSecondNotoriety2.Value);
            file.WriteLine("~Failure Charisma2^" + numericUpDownSecondCharisma2.Value);
            file.WriteLine("~Failure Evil2^" + numericUpDownSecondEvil2.Value);

            file.WriteLine("~Failure Crew2^" + numericUpDownSecondCrew2.Value);
            file.WriteLine("~Failure Integrity2^" + numericUpDownSecondIntegrity2.Value);
            file.WriteLine("~Failure Ale2^" + numericUpDownSecondAle2.Value);
            file.WriteLine("~Failure Gunpowder2^" + numericUpDownSecondGunpowder2.Value);
            file.WriteLine("~Failure Coins2^" + numericUpDownSecondGold2.Value);

            file.WriteLine("~Make Fight2^" + FightCheck2.Checked);
            file.WriteLine("~Fight Dif2^" + FightDif2.Text);


       
            //End of   2

           

            file.Close();



        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void optionsChoiceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void numericUpDownOddsWit1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            FightDif2.Visible = false;

        }

        private void FightDifCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

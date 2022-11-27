using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace MythicalRacesHelperGUI
{
    public partial class Form1 : Form
    {
        AbilityHelper AbilityHelper = new AbilityHelper();
        RaceHelper RaceHelper= new RaceHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            raceButton.FlatStyle = FlatStyle.Flat;
            raceButton.FlatAppearance.BorderSize = 2;
            abilityButton.FlatStyle = FlatStyle.Flat;
            abilityButton.FlatAppearance.BorderSize = 3;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 3;
            mainTextBox.Visible = false;
            mainTextBox.Enabled = false;
            consoleLogger.Visible = false;
            consoleLogger.Enabled = false;
            updater.Visible = false;
            updater.Enabled = false;
            consoleLogger.Text = "Console: \n";

        }

        private void race_Click(object sender, EventArgs e)
        {
            DisableBeginningButtons();
            RaceHelper.SetIsCreatingRace(true);

            mainTextBox.Text = "   Human:\r\n     displayName: '&cHuman'\r\n     material: 'BOOK'\r\n     isSubRace: false\r\n     subRaceType: ''\r\n     treeSlot: 4\r\n     levelRequire: 0\r\n     guiPage: 1\r\n     slot: 11\r\n     lvlType: 'RUNNING'\r\n     maxLevel: 100\r\n     gainXP: 2\r\n     xpPerLevel: 24\r\n     lore:\r\n         - '&4----- &cHuman Race &4-----'\r\n         - '&cWell I think you know what a human is'\r\n         - ' '\r\n         - '&5----- Day Time Passive Effects -----'\r\n         - 'None'\r\n         - '&5----- Night Time Passive Effects -----'\r\n         - 'None'\r\n     dayPassivePotionEffects:\r\n         - 'null'\r\n     dayPassivePotionEffectsBase:\r\n         - 'null'\r\n     dayRaceDataPotion:\r\n         - 'null'\r\n     dayPassiveGenericAttributes:\r\n         - 'GENERIC_MOVEMENT_SPEED'\r\n     dayPassiveGenericAttributesBase:\r\n         - 0.1\r\n     dayRacePassiveAttributesLevel:\r\n         - 0.0\r\n     dayRaceDataAttribute:\r\n         - 'ALL Y > -1000 -1 ALL ALL ALL ALL'\r\n     nightPassivePotionEffects:\r\n         - 'null'\r\n     nightPassivePotionEffectsBase:\r\n         - 'null'\r\n     nightRaceDataPotion:\r\n         - 'null'\r\n     nightPassiveGenericAttributes:\r\n         - 'GENERIC_MOVEMENT_SPEED'\r\n     nightPassiveGenericAttributesBase:\r\n         - 0.1\r\n     nightRacePassiveAttributesLevel:\r\n         - 0.0\r\n     nightRaceDataAttribute:\r\n         - 'ALL Y > -1000 -1 ALL ALL ALL ALL'\r\n     executeCommandUponSwitching:\r\n         - 'null'";


        }

        private void mainTextBoxChanged(object sender, EventArgs e)
        {
            mainTextBox.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Ive been clicked");

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void abilityButton_Click(object sender, EventArgs e)
        {
            DisableBeginningButtons();
            AbilityHelper.SetIsCreatingAbility(true);
        }

        private void DisableBeginningButtons()
        {
            abilityButton.Visible = false;
            abilityButton.Enabled = false;
            raceButton.Enabled = false;
            raceButton.Visible = false;
            label1.Visible = false;
            label1.Enabled= false;
            mainTextBox.Visible = true;
            mainTextBox.Enabled = true;
            consoleLogger.Visible = true;
            consoleLogger.Enabled = true;
            updater.Visible = true;
            updater.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HighlightKeyWords(RichTextBox rtb, string[] phrases, Color color)
        {
            ClearMistakes(rtb);
            string pattern = string.Join("|", phrases.Select(phr => Regex.Escape(phr)));

            var matches = Regex.Matches(rtb.Text, pattern, RegexOptions.None);
            foreach (Match m in matches)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionColor = color;
            }
        }
        private void ClearMistakes(RichTextBox rtb)
        {
            int selStart = rtb.SelectionStart;
            rtb.SelectAll();
            rtb.SelectionBackColor = rtb.BackColor;
            rtb.SelectionStart = selStart;
            rtb.SelectionLength = 0;
        }

        private void updater_Click(object sender, EventArgs e)
        {
            consoleLogger.AppendText("\n");
            if (RaceHelper.GetIsCreatingRace())
            {

                String[] phrases = { "displayName", "material", "isSubRace", "subRaceType", "treeSlot", "lore", "levelRequire", "guiPage", "slot", "lvlType", "maxLevel", "gainXP", "xpPerLevel" };
                HighlightKeyWords(mainTextBox, phrases, Color.Aquamarine);

                String[] nightPotion = { "nightPassivePotionEffectsBase", "nightPassivePotionEffects", "nightRaceDataPotion" };
                HighlightKeyWords(mainTextBox, nightPotion, Color.DarkGreen);


                String[] dayPotion = { "dayPassivePotionEffectsBase", "dayPassivePotionEffects", "dayRaceDataPotion" };
                HighlightKeyWords(mainTextBox, dayPotion, Color.DarkOrange);

                String[] nightAttribute = { "nightPassiveGenericAttributesBase", "nightPassiveGenericAttributes", "nightRacePassiveAttributesLevel", "nightRaceDataAttribute" };
                HighlightKeyWords(mainTextBox, nightAttribute, Color.DarkBlue);


                String[] dayAttribute = { "dayPassiveGenericAttributesBase", "dayRacePassiveAttributesLevel", "dayRaceDataAttribute", "dayPassiveGenericAttributes", };
                HighlightKeyWords(mainTextBox, dayAttribute, Color.DarkCyan);
                String[] nums = new String[400];

                for (int i = 0; i != 400; i++) {
                    nums[i] = i.ToString();
                }
                HighlightKeyWords(mainTextBox, nums, Color.BlueViolet);

                // dont forget to put between '' and between " " ok

                char[] arr = mainTextBox.Text.Replace("\\\'", "").ToCharArray();
                int highlightLength = 0;
                int placeholder = 0;
                for (int i = 0; i != mainTextBox.Text.Length - 1; i++)
                {
                    if (highlightLength > 0 && arr[i].Equals('\'')) {
                        mainTextBox.Select(placeholder, highlightLength);
                        mainTextBox.SelectionColor = Color.Green;
                        highlightLength = 0;
                        placeholder = 0;
                        continue;
                    }
                    if (highlightLength > 0) highlightLength++;
                    if (arr[i].Equals('\'')) {
                        highlightLength += 1;
                        placeholder = i;
                    }


                }

                String[] specialChars = { "'", ":", "-" };

                HighlightKeyWords(mainTextBox, specialChars, Color.DarkGoldenrod);

                String[] doubleQuo = { "\"" };
                HighlightKeyWords(mainTextBox, doubleQuo, Color.DarkGoldenrod);

                String[] potionEffects = { "ABSORPTION", "BAD_OMEN", "BLINDNESS", "CONDUIT_POWER", "CONFUSION", "DAMAGE_RESISTANCE", "DARKNESS", "DOLPHOMS_GRACE", "FAST_DIGGING", "FIRE_RESISTANCE", "GLOWING", "HARM", "HEAL", "HEALTH_BOOST", "HERO_OF_THE_VILLAGE", "HUNGER", "INCREASE_DAMAGE", "INVISIBILITY", "JUMP", "LEVITATION", "LUCK", "NIGHT_VISION", "POISON", "REGENERATION", "SATURATION", "SLOW", "SLOW_DIGGING", "SLOW_FALLING", "SPEED", "UNLUCK", "WATER_BREATHING", "WEAKNESS", "WITHER" };
                HighlightKeyWords(mainTextBox, potionEffects, Color.CornflowerBlue);

                String[] attributes = { "GENERIC_MAX_HEALTH", "GENERIC_KNOCKBACK_RESISTANCE", "GENERIC_MOVEMENT_SPEED", "GENERIC_ATTACK_DAMAGE", "GENERIC_ATTACK_SPEED", "GENERIC_ARMOR", "GENERIC_ARMOR_TOUGHNESS", "GENERIC_LUCK" };
                HighlightKeyWords(mainTextBox, attributes, Color.Crimson);

                String[] booleans = { "false", "true" };
                HighlightKeyWords(mainTextBox, booleans, Color.DodgerBlue);


                String[] strings = mainTextBox.Text.Split(new[] { "\n" }, StringSplitOptions.None);
                int LengthDayPotions1 = 0;
                int LengthDayPotions2 = 0;
                int LengthDayPotions3 = 0;

                int LengthDataDayAttributes1 = 0;
                int LengthDataDayAttributes2 = 0;
                int LengthDataDayAttributes3 = 0;
                int LengthDataDayAttributes4 = 0;


                int LengthNightPotions1 = 0;
                int LengthNightPotions2 = 0;
                int LengthNightPotions3 = 0;

                int LengthDataNightAttributes1 = 0;
                int LengthDataNightAttributes2 = 0;

                int LengthDataNightAttributes3 = 0;
                int LengthDataNightAttributes4 = 0;


                String Type = "";
                int count = 1;
                foreach (String Str in strings)
                {
                    if (Str.Contains("lore"))
                    {
                        Type = "lore:";
                        continue;
                    }

                    if (Str.Contains("dayPassivePotionEffects") && !Str.Contains("Base")) {
                        Type = "daypotion1";
                        continue;
                    }

                    if (Str.Contains("dayPassivePotionEffectsBase"))
                    {
                        Type = "daypotion2";
                        continue;
                    }

                    if (Str.Contains("dayRaceDataPotion"))
                    {
                        Type = "daypotion3";
                        continue;
                    }


                    if (Str.Contains("dayPassiveGenericAttributes") && !Str.Contains("Level") && !Str.Contains("Base"))
                    {
                        Type = "dayattribute1";
                        continue;
                    }

                    if (Str.Contains("dayPassiveGenericAttributesBase"))
                    {
                        Type = "dayattribute2";

                        continue;
                    }

                    if (Str.Contains("dayRacePassiveAttributesLevel"))
                    {
                        Type = "dayattribute3";
                        continue;
                    }

                    if (Str.Contains("dayRaceDataAttribute"))
                    {
                        Type = "dayattribute4";

                        continue;
                    }
                    ///

                    if (Str.Contains("nightPassivePotionEffects") && !Str.Contains("Base"))
                    {
                        Type = "nightpotion1";
                        continue;
                    }

                    if (Str.Contains("nightPassivePotionEffectsBase"))
                    {
                        Type = "nightpotion2";
                        continue;
                    }

                    if (Str.Contains("nightRaceDataPotion"))
                    {
                        Type = "nightpotion3";
                        continue;
                    }


                    if (Str.Contains("nightPassiveGenericAttributes") && !Str.Contains("Level") && !Str.Contains("Base"))
                    {
                        Type = "nightattribute1";
                        continue;
                    }

                    if (Str.Contains("nightPassiveGenericAttributesBase"))
                    {
                        Type = "nightattribute2";

                        continue;
                    }

                    if (Str.Contains("nightRacePassiveAttributesLevel"))
                    {
                        Type = "nightattribute3";
                        continue;
                    }

                    if (Str.Contains("nightRaceDataAttribute"))
                    {
                        Type = "nightattribute4";

                        continue;
                    }
                    ///

                    if (Str.Contains("executeCommand")) Type = "none";




                    switch (Type)
                    {
                        case "daypotion1":
                            LengthDayPotions1++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Day potion effect is missing an '-', make sure it aligned properly | on line " + count +" \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("Day potion effect | Seems like there is no two -> ' <- inside one of the lines in day potion effect (or its not 'null')" + count + " \n");

                            break;
                        case "daypotion2":
                            LengthDayPotions2++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Day potion Base is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("Day potion Base | Seems like there is no two -> ' <- inside one of the lines in day potion effect (or its not 'null')" + count + " \n");
                            break;
                        case "daypotion3":
                            LengthDayPotions3++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Day potion Data is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("Day potion Data | Seems like there is no two -> ' <- inside one of the lines in day potion effect (or its not 'null')" + count + " \n");
                            if (Str.Contains("'null'")) return;
                            char[] arrPlaceholder = Str.ToCharArray();
                            int amountOfSpace = 0;
                            String checking = "";
                            for (int i = 0; i != Str.Length; i++)
                            {
                                if (amountOfSpace > 0 && arrPlaceholder[i].Equals('\''))
                                {
                                    break;
                                }
                                if (amountOfSpace > 0)
                                {
                                    checking += arrPlaceholder[i];
                                    amountOfSpace++;
                                }
                                if (arrPlaceholder[i].Equals('\'')) amountOfSpace++;

                            }
                            if (checking.Split(' ').Length != 9)
                            {
                                consoleLogger.AppendText("Something seems to be wrong in Day potion Data, the amount of data does not match the required data length inside the plugin, line: " + count + " \n");
                            }
                            break;
                        case "dayattribute1":
                            LengthDataDayAttributes1++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("dayPassiveGenericAttributes is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("dayPassiveGenericAttributes | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "dayattribute2":
                            LengthDataDayAttributes2++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("dayPassiveGenericAttributesBase is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("dayPassiveGenericAttributesBase | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "dayattribute3":
                            LengthDataDayAttributes3++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("dayRacePassiveAttributesLevel is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("dayRacePassiveAttributesLevel | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "dayattribute4":
                            LengthDataDayAttributes4++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("dayRaceDataAttribute is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("dayRaceDataAttribute | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");

                            char[] arrPlaceholder2 = Str.ToCharArray();
                            int amountOfSpace2 = 0;
                            String checking2 = "";
                            for (int i = 0; i != Str.Length; i++)
                            {
                                if (amountOfSpace2 > 0 && arrPlaceholder2[i].Equals('\''))
                                {
                                    break;
                                }
                                if (amountOfSpace2 > 0)
                                {
                                    checking2 += arrPlaceholder2[i];
                                    amountOfSpace2++;
                                }
                                if (arrPlaceholder2[i].Equals('\'')) amountOfSpace2++;

                            }
                            if (checking2.Split(' ').Length != 9)
                            {
                                consoleLogger.AppendText("Something seems to be wrong indayRaceDataAttribute, the amount of data does not match the required data length inside the plugin, line: " + count + " \n");
                            }

                            break;
                        ///
                        case "nightpotion1":
                            LengthNightPotions1++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Night potion effect is missing an '-', make sure it aligned properly | on line " + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("Night potion effect | Seems like there is no two -> ' <- inside one of the lines in night potion effect (or its not 'null')" + count + " \n");
                            break;
                        case "nightpotion2":
                            LengthNightPotions2++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Night potion Base is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("Night potion Base | Seems like there is no two -> ' <- inside one of the lines in night potion base (or its not 'null')" + count + " \n");
                            break;
                        case "nightpotion3":
                            LengthNightPotions3++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("Night potion Data is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("Night potion Data | Seems like there is no two -> ' <- inside one of the lines in night potion data (or its not 'null')" + count + " \n");
                            if (Str.Contains("'null'")) return;

                            char[] arrPlaceholder3 = Str.ToCharArray();
                            int amountOfSpace3 = 0;
                            String checking3 = "";
                            for (int i = 0; i != Str.Length; i++)
                            {
                                if (amountOfSpace3 > 0 && arrPlaceholder3[i].Equals('\''))
                                {
                                    break;
                                }
                                if (amountOfSpace3 > 0)
                                {
                                    checking3 += arrPlaceholder3[i];
                                    amountOfSpace3++;
                                }
                                if (arrPlaceholder3[i].Equals('\'')) amountOfSpace3++;

                            }
                            if (checking3.Split(' ').Length != 9)
                            {
                                consoleLogger.AppendText("Something seems to be wrong in night potion data, the amount of data does not match the required data length inside the plugin, line: " + count + " \n");
                            }



                            break;
                        case "nightattribute1":
                            LengthDataNightAttributes1++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("nightPassiveGenericAttributes is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("nightPassiveGenericAttributes | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "nightattribute2":
                            LengthDataNightAttributes2++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("nightPassiveGenericAttributesBase is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("nightPassiveGenericAttributesBase | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "nightattribute3":
                            LengthDataNightAttributes3++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("nightRacePassiveAttributesLevel is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Contains("null") && Str.Split('\'').Length != 3) consoleLogger.AppendText("nightRacePassiveAttributesLevel | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            break;
                        case "nightattribute4":
                            LengthDataNightAttributes4++;
                            if (!Str.Contains("-")) consoleLogger.AppendText("nightRaceDataAttribute is missing an '-', make sure it aligned properly" + count + " \n");
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("nightRaceDataAttribute | Seems like there is no two -> ' <- (or its not 'null')" + count + " \n");
                            char[] arrPlaceholder4 = Str.ToCharArray();
                            int amountOfSpace4 = 0;
                            String checking4 = "";
                            for (int i = 0; i != Str.Length; i++)
                            {
                                if (amountOfSpace4 > 0 && arrPlaceholder4[i].Equals('\''))
                                {
                                    break;
                                }
                                if (amountOfSpace4 > 0)
                                {
                                    checking4 += arrPlaceholder4[i];
                                    amountOfSpace4++;
                                }
                                if (arrPlaceholder4[i].Equals('\'')) amountOfSpace4++;
                                
                            }
                            if(checking4.Split(' ').Length != 9)
                            {
                                consoleLogger.AppendText("Something seems to be wrong in nightRaceDataAttribute, the amount of data does not match the required data length inside the plugin, line: " + count + " \n");
                            }


                            break;
                        case "lore:":
                            if (Str.Split('\'').Length != 3) consoleLogger.AppendText("lore | Seems like there is no two -> ' <- (or its not 'null', please do not use ' within your lore description, just for ending/starting the phrase)" + count + " \n");
                            break;

                    }
                    count++;
                }
                if (LengthDayPotions2 != LengthDayPotions1 || LengthDayPotions1 != LengthDayPotions3 || LengthDayPotions2 != LengthDayPotions3) {
                    consoleLogger.AppendText("Something seems to be wrong with the day potion effects, not all of the lists for day potions have the same list length \n");
                }

                if (LengthNightPotions2 != LengthNightPotions1 || LengthNightPotions1 != LengthNightPotions3 || LengthNightPotions2 != LengthNightPotions3)
                {
                    consoleLogger.AppendText("Something seems to be wrong with the night potion effects, not all of the lists for night potions have the same list length \n");
                }

                if (LengthDataDayAttributes1 != LengthDataDayAttributes2 || LengthDataDayAttributes1 != LengthDataDayAttributes2 || LengthDataDayAttributes1 != LengthDataDayAttributes3 || LengthDataDayAttributes1 != LengthDataDayAttributes4)
                {
                    consoleLogger.AppendText("Something seems to be wrong with the day attributes effects, not all of the lists for day attributes have the same list length \n");
                }


                if (LengthDataNightAttributes1 != LengthDataNightAttributes2 || LengthDataNightAttributes1 != LengthDataNightAttributes2 || LengthDataNightAttributes1 != LengthDataNightAttributes3 || LengthDataNightAttributes1 != LengthDataNightAttributes4)
                {
                    consoleLogger.AppendText("Something seems to be wrong with the night attributes effects, not all of the lists for night attributes have the same list length \n");
                }

                consoleLogger.AppendText("\nDone Checking\n--------------");
                ClearMistakes(mainTextBox);
                mainTextBox.SelectionColor = Color.White;
            
            }
            return;
        }
    }
}

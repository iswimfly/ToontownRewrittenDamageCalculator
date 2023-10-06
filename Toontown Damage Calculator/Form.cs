using System.Resources;

namespace Toontown_Damage_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public static int aliveCogs = 0;
        public static List<Attack> attacks = new List<Attack>();

        public static Cog cog1 = new Cog();
        public static Cog cog2 = new Cog();
        public static Cog cog3 = new Cog();
        public static Cog cog4 = new Cog();
        public static List<Cog> cogs = new List<Cog>();

        public static Toon toon1 = new Toon();
        public static Toon toon2 = new Toon();
        public static Toon toon3 = new Toon();
        public static Toon toon4 = new Toon();
        public static List<Toon> toons = new List<Toon>();

        public static List<CheckBox> chkboxAlive = new List<CheckBox>();
        public static List<CheckBox> chkboxLured = new List<CheckBox>();
        public static List<CheckBox> chkboxVer2 = new List<CheckBox>();
        public static List<CheckBox> chkboxOrg = new List<CheckBox>();
        public static List<CheckBox> chkboxNotMaxed = new List<CheckBox>();
        public static List<CheckBox> chkboxToonAlive = new List<CheckBox>();

        public static List<ComboBox> comboxLvl = new List<ComboBox>();
        public static List<ComboBox> comboxLureTurns = new List<ComboBox>();
        public static List<ComboBox> comboxTrap = new List<ComboBox>();
        public static List<ComboBox> comboxOrg = new List<ComboBox>();
        public static List<ComboBox> comboxGagTrack = new List<ComboBox>();
        public static List<ComboBox> comboxGag = new List<ComboBox>();
        public static List<ComboBox> comboxTarget = new List<ComboBox>();

        public static List<TextBox> txtboxHealth = new List<TextBox>();
        public static List<TextBox> txtboxNotMaxed = new List<TextBox>();

        public Form()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            txtboxHealth.Add(txtboxHealth1);
            txtboxHealth.Add(txtboxHealth2);
            txtboxHealth.Add(txtboxHealth3);
            txtboxHealth.Add(txtboxHealth4);

            txtboxNotMaxed.Add(txtboxMaxed1);
            txtboxNotMaxed.Add(txtboxMaxed2);
            txtboxNotMaxed.Add(txtboxMaxed3);
            txtboxNotMaxed.Add(txtboxMaxed4);

            comboxLvl.Add(comboxLvl1);
            comboxLvl.Add(comboxLvl2);
            comboxLvl.Add(comboxLvl3);
            comboxLvl.Add(comboxLvl4);

            comboxLureTurns.Add(comboxLureTurns1);
            comboxLureTurns.Add(comboxLureTurns2);
            comboxLureTurns.Add(comboxLureTurns3);
            comboxLureTurns.Add(comboxLureTurns4);

            comboxTrap.Add(comboxTrap1);
            comboxTrap.Add(comboxTrap2);
            comboxTrap.Add(comboxTrap3);
            comboxTrap.Add(comboxTrap4);

            comboxOrg.Add(comboxOrg1);
            comboxOrg.Add(comboxOrg2);
            comboxOrg.Add(comboxOrg3);
            comboxOrg.Add(comboxOrg4);

            comboxGagTrack.Add(comboxTrack1);
            comboxGagTrack.Add(comboxTrack2);
            comboxGagTrack.Add(comboxTrack3);
            comboxGagTrack.Add(comboxTrack4);

            comboxGag.Add(comboxGag1);
            comboxGag.Add(comboxGag2);
            comboxGag.Add(comboxGag3);
            comboxGag.Add(comboxGag4);

            comboxTarget.Add(comboxTarget1);
            comboxTarget.Add(comboxTarget2);
            comboxTarget.Add(comboxTarget3);
            comboxTarget.Add(comboxTarget4);

            chkboxAlive.Add(chkboxAlive1);
            chkboxAlive.Add(chkboxAlive2);
            chkboxAlive.Add(chkboxAlive3);
            chkboxAlive.Add(chkboxAlive4);

            chkboxLured.Add(chkboxLured1);
            chkboxLured.Add(chkboxLured2);
            chkboxLured.Add(chkboxLured3);
            chkboxLured.Add(chkboxLured4);

            chkboxVer2.Add(chkboxVer21);
            chkboxVer2.Add(chkboxVer22);
            chkboxVer2.Add(chkboxVer23);
            chkboxVer2.Add(chkboxVer24);

            chkboxOrg.Add(chkboxOrg1);
            chkboxOrg.Add(chkboxOrg2);
            chkboxOrg.Add(chkboxOrg3);
            chkboxOrg.Add(chkboxOrg4);

            chkboxToonAlive.Add(chkboxToon1);
            chkboxToonAlive.Add(chkboxToon2);
            chkboxToonAlive.Add(chkboxToon3);
            chkboxToonAlive.Add(chkboxToon4);

            chkboxNotMaxed.Add(chkboxMaxed1);
            chkboxNotMaxed.Add(chkboxMaxed2);
            chkboxNotMaxed.Add(chkboxMaxed3);
            chkboxNotMaxed.Add(chkboxMaxed4);

            chkboxAlive1.Enabled = true;
            chkboxAlive2.Enabled = false;
            chkboxAlive3.Enabled = false;
            chkboxAlive4.Enabled = false;

            foreach(TextBox txtbox in txtboxHealth)
            {
                txtbox.Enabled = false;
            }

            comboxOrg1.Items.Add("Organic");
            comboxOrg2.Items.Add("Organic");
            comboxOrg3.Items.Add("Organic");
            comboxOrg4.Items.Add("Organic");

            comboxTrack1.Items.Add("Gag Track");
            comboxTrack2.Items.Add("Gag Track");
            comboxTrack3.Items.Add("Gag Track");
            comboxTrack4.Items.Add("Gag Track");

            comboxLvl1.Items.Add("");
            comboxLvl2.Items.Add("");
            comboxLvl3.Items.Add("");
            comboxLvl4.Items.Add("");

            for (int i = 1; i < 21; i++)
            {
                comboxLvl1.Items.Add(i);
                comboxLvl2.Items.Add(i);
                comboxLvl3.Items.Add(i);
                comboxLvl4.Items.Add(i);
            }

            foreach (string gagTrack in Information.gagTracks)
            {
                // Organics
                comboxOrg1.Items.Add(gagTrack);
                comboxOrg2.Items.Add(gagTrack);
                comboxOrg3.Items.Add(gagTrack);
                comboxOrg4.Items.Add(gagTrack);

                // Tracks
                comboxTrack1.Items.Add(gagTrack);
                comboxTrack2.Items.Add(gagTrack);
                comboxTrack3.Items.Add(gagTrack);
                comboxTrack4.Items.Add(gagTrack);
            }

            for (int i = 0; i < 6; i++)
            {
                comboxLureTurns1.Items.Add(i);
                comboxLureTurns2.Items.Add(i);
                comboxLureTurns3.Items.Add(i);
                comboxLureTurns4.Items.Add(i);
            }

            comboxLureTurns1.SelectedIndex = 0;
            comboxLureTurns2.SelectedIndex = 0;
            comboxLureTurns3.SelectedIndex = 0;
            comboxLureTurns4.SelectedIndex = 0;

            comboxLureTurns1.Enabled = false;
            comboxLureTurns2.Enabled = false;
            comboxLureTurns3.Enabled = false;
            comboxLureTurns4.Enabled = false;

            comboxTrap1.Items.Add("Set Trap");
            comboxTrap1.SelectedIndex = 0;
            comboxTrap2.Items.Add("Set Trap");
            comboxTrap2.SelectedIndex = 0;
            comboxTrap3.Items.Add("Set Trap");
            comboxTrap3.SelectedIndex = 0;
            comboxTrap4.Items.Add("Set Trap");
            comboxTrap4.SelectedIndex = 0;

            foreach (string trapGag in Information.trapGags)
            {
                comboxTrap1.Items.Add(trapGag);
                comboxTrap2.Items.Add(trapGag);
                comboxTrap3.Items.Add(trapGag);
                comboxTrap4.Items.Add(trapGag);
            }

            chkboxToon2.Enabled = false;
            chkboxToon3.Enabled = false;
            chkboxToon4.Enabled = false;

            comboxOrg1.Enabled = true;
            comboxOrg2.Enabled = false;
            comboxOrg3.Enabled = false;
            comboxOrg4.Enabled = false;

            comboxTrack1.Enabled = false;
            comboxTrack2.Enabled = false;
            comboxTrack3.Enabled = false;
            comboxTrack4.Enabled = false;

            comboxGag1.Enabled = false;
            comboxGag2.Enabled = false;
            comboxGag3.Enabled = false;
            comboxGag4.Enabled = false;

            comboxTarget1.Enabled = false;
            comboxTarget2.Enabled = false;
            comboxTarget3.Enabled = false;
            comboxTarget4.Enabled = false;


            DisableCog(0);
            DisableCog(1);
            DisableCog(2);
            DisableCog(3);

            cogs.Add(cog1);
            cogs.Add(cog2);
            cogs.Add(cog3);
            cogs.Add(cog4);

            toons.Add(toon1);
            toons.Add(toon2);
            toons.Add(toon3);
            toons.Add(toon4);

            chkboxToon1.Checked = true;
            toon1.alive = true;
            toon2.alive = false;
            toon3.alive = false;
            toon4.alive = false;
        }
        private void EnableCog(int cogNumber)
        {
            comboxLvl[cogNumber].Text = "";
            comboxLvl[cogNumber].Text = "";
            comboxLvl[cogNumber].Enabled = true;
            txtboxHealth[cogNumber].Text = "";
            chkboxLured[cogNumber].Checked = false;
            chkboxLured[cogNumber].Enabled = true;
            chkboxVer2[cogNumber].Checked = false;
            chkboxVer2[cogNumber].Enabled = true;
            chkboxOrg[cogNumber].Checked = false;
            chkboxOrg[cogNumber].Enabled = true;
            comboxTrap[cogNumber].Enabled = true;
        }
        private void DisableCog(int cogNumber)
        {
            chkboxAlive[cogNumber].Checked = false;
            comboxLvl[cogNumber].SelectedIndex = 0;
            comboxLvl[cogNumber].Enabled = false;
            txtboxHealth[cogNumber].Text = "";
            comboxLureTurns[cogNumber].Enabled = false;
            comboxLureTurns[cogNumber].SelectedIndex = 0;
            chkboxLured[cogNumber].Checked = false;
            chkboxLured[cogNumber].Enabled = false;
            chkboxVer2[cogNumber].Checked = false;
            chkboxVer2[cogNumber].Enabled = false;
            chkboxOrg[cogNumber].Checked = false;
            chkboxOrg[cogNumber].Enabled = false;
            comboxTrap[cogNumber].SelectedIndex = 0;
            comboxTrap[cogNumber].Enabled = false;

        }
        private void EnableToon(int toonNumber)
        {
            chkboxToonAlive[toonNumber].Enabled = true;
            chkboxToonAlive[toonNumber].Checked = false;
        }
        private void DisableToon(int toonNumber)
        {
            chkboxToonAlive[toonNumber].Enabled = false;
            chkboxToonAlive[toonNumber].Checked = false;
        }
        private void chkboxAlive1_CheckedChanged(object sender, EventArgs e)
        {
            cog1.alive = chkboxAlive1.Checked;
            foreach(ComboBox combox in comboxTarget)
            {
                CheckCogsAlive(combox, true);
            }
            if (!chkboxAlive1.Checked)
            {
                DisableCog(0);
                chkboxAlive2.Checked = false;
                chkboxAlive2.Enabled = false;
                DisableCog(1);
                chkboxAlive3.Checked = false;
                chkboxAlive3.Enabled = false;
                DisableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = false;
                DisableCog(3);

                if (toon1.alive)
                {
                    comboxTrack1.Enabled = false;
                    comboxGag1.Enabled = false;
                    comboxTarget1.Enabled = false;
                }
                if (toon2.alive)
                {
                    comboxTrack2.Enabled = false;
                    comboxGag2.Enabled = false;
                    comboxTarget2.Enabled = false;
                }
                if (toon3.alive)
                {
                    comboxTrack3.Enabled = false;
                    comboxGag3.Enabled = false;
                    comboxTarget3.Enabled = false;
                }
                if (toon4.alive)
                {
                    comboxTrack4.Enabled = false;
                    comboxGag4.Enabled = false;
                    comboxTarget4.Enabled = false;
                }
            }
            else
            {
                EnableCog(0);
                chkboxAlive2.Checked = false;
                chkboxAlive2.Enabled = true;
                DisableCog(1);
                chkboxAlive3.Checked = false;
                chkboxAlive3.Enabled = false;
                DisableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = false;
                DisableCog(3);

                if (toon1.alive)
                {
                    comboxOrg1.Enabled = true;
                    comboxTrack1.Enabled = true;
                }
                if (toon2.alive)
                {
                    comboxOrg2.Enabled = true;
                    comboxTrack2.Enabled = true;
                }
                if (toon3.alive)
                {
                    comboxOrg3.Enabled = true;
                    comboxTrack3.Enabled = true;
                }
                if (toon4.alive)
                {
                    comboxOrg4.Enabled = true;
                    comboxTrack4.Enabled = true;
                }
            }

        }
        private void chkboxAlive2_CheckedChanged(object sender, EventArgs e)
        {
            cog2.alive = chkboxAlive2.Checked;
            foreach (ComboBox combox in comboxTarget)
            {
                CheckCogsAlive(combox, true);
            }
            if (!chkboxAlive2.Checked)
            {
                DisableCog(1);
                chkboxAlive3.Checked = false;
                chkboxAlive3.Enabled = false;
                DisableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = false;
                DisableCog(3);
            }
            else
            {
                EnableCog(1);
                chkboxAlive3.Checked = false;
                chkboxAlive3.Enabled = true;
                DisableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = false;
                DisableCog(3);
                if (toon1.alive)
                {
                    comboxOrg1.Enabled = true;
                    comboxTrack1.Enabled = true;
                }
                if (toon2.alive)
                {
                    comboxOrg2.Enabled = true;
                    comboxTrack2.Enabled = true;
                }
                if (toon3.alive)
                {
                    comboxOrg3.Enabled = true;
                    comboxTrack3.Enabled = true;
                }
                if (toon4.alive)
                {
                    comboxOrg4.Enabled = true;
                    comboxTrack4.Enabled = true;
                }
            }
        }
        private void chkboxAlive3_CheckedChanged(object sender, EventArgs e)
        {
            cog3.alive = chkboxAlive3.Checked;
            foreach (ComboBox combox in comboxTarget)
            {
                CheckCogsAlive(combox, true);
            }
            if (!chkboxAlive3.Checked)
            {
                DisableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = false;
            }
            else
            {
                EnableCog(2);
                chkboxAlive4.Checked = false;
                chkboxAlive4.Enabled = true;
            }
        }
        private void chkboxAlive4_CheckedChanged(object sender, EventArgs e)
        {
            cog4.alive = chkboxAlive4.Checked;
            foreach (ComboBox combox in comboxTarget)
            {
                CheckCogsAlive(combox, true);
            }
            if (chkboxAlive4.Checked)
            {
                EnableCog(3);
            }
            else
            {
                DisableCog(3);
            }
        }
        private int CheckCogsAlive(ComboBox combox, bool addEntries)
        {
            aliveCogs = 0;
            List<string> targets = new List<string>();
            if (chkboxAlive1.Checked)
            {
                aliveCogs++;
            }
            if (chkboxAlive2.Checked)
            {
                aliveCogs++;
            }
            if (chkboxAlive3.Checked)
            {
                aliveCogs++;
            }
            if (chkboxAlive4.Checked)
            {
                aliveCogs++;
            }
            if (aliveCogs > 0)
            {
                if (chkboxToon1.Checked)
                {
                    comboxTrack1.Enabled = true;
                }
                if (chkboxToon2.Checked)
                {
                    comboxTrack2.Enabled = true;
                }
                if (chkboxToon3.Checked)
                {
                    comboxTrack3.Enabled = true;
                }
                if (chkboxToon4.Checked)
                {
                    comboxTrack4.Enabled = true;
                }
            }
            if (!addEntries) return aliveCogs;
            switch (aliveCogs)
            {
                case 0:
                    targets.Add("----");
                    break;
                case 1:
                    targets.Add("-");
                    targets.Add("x");
                    break;
                case 2:
                    targets.Add("--");
                    targets.Add("-x");
                    targets.Add("x-");
                    break;
                case 3:
                    targets.Add("---");
                    targets.Add("--x");
                    targets.Add("-x-");
                    targets.Add("x--");
                    break;
                case 4:
                    targets.Add("----");
                    targets.Add("---x");
                    targets.Add("--x-");
                    targets.Add("-x--");
                    targets.Add("x---");
                    break;
            }
            combox.Items.Clear();
            foreach (string target in targets)
            {
                combox.Items.Add(target);
            }
            combox.SelectedIndex = 0;
            if (toon1.alive)
            {
                CheckMultiHit(comboxTrack1, comboxGag1, comboxTarget1);
            }
            if (toon2.alive)
            {
                CheckMultiHit(comboxTrack2, comboxGag2, comboxTarget2);
            }
            if (toon3.alive)
            {
                CheckMultiHit(comboxTrack3, comboxGag3, comboxTarget3);
            }
            if (toon4.alive)
            {
                CheckMultiHit(comboxTrack4, comboxGag4, comboxTarget4);
            }

            return aliveCogs;
        }
        private void CheckMultiHit(ComboBox comboxTrack, ComboBox comboxGag, ComboBox comboxTarget)
        {
            // Toon-up Multi-hit
            if (comboxTrack.SelectedIndex == 1)
            {
                if (comboxGag.SelectedIndex == 2 || comboxGag.SelectedIndex == 4 || comboxGag.SelectedIndex == 6)
                {
                    comboxTarget.Items.Clear();
                    comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("-", CheckCogsAlive(comboxTarget, false))));
                    comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("x", CheckCogsAlive(comboxTarget, false))));
                    comboxTarget.SelectedIndex = 1;
                    comboxTarget.Enabled = false;
                    return;
                }
            }
            // Lure multi-hit
            if (comboxTrack1.SelectedIndex == 3)
            {
                if (comboxGag.SelectedIndex == 2 || comboxGag.SelectedIndex == 4 || comboxGag.SelectedIndex == 6)
                {
                    comboxTarget.Items.Clear();
                    comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("-", CheckCogsAlive(comboxTarget, false))));
                    comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("x", CheckCogsAlive(comboxTarget, false))));
                    comboxTarget.SelectedIndex = 1;
                    comboxTarget.Enabled = false;
                    return;
                }
            }
            // Sound + Tier 7
            if (comboxTrack.SelectedIndex == 4 || comboxGag.SelectedIndex == 7)
            {
                comboxTarget.Items.Clear();
                comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("-", CheckCogsAlive(comboxTarget, false))));
                comboxTarget.Items.Add(string.Concat(Enumerable.Repeat("x", CheckCogsAlive(comboxTarget, false))));
                comboxTarget.SelectedIndex = 1;
                comboxTarget.Enabled = false;
                return;
            }
            else
            {
                comboxTarget.Enabled = true;
            }
            if (aliveCogs == 1 && comboxTarget.Items.Count > 0)
            {
                comboxTarget.SelectedIndex = 1;
                comboxTarget.Enabled = false;
            }
        }
        private void comboxGag1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMultiHit(comboxTrack1, comboxGag1, comboxTarget1);
        }
        private void comboxGag2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMultiHit(comboxTrack2, comboxGag2, comboxTarget2);
        }
        private void comboxGag3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMultiHit(comboxTrack3, comboxGag3, comboxTarget3);
        }
        private void comboxGag4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMultiHit(comboxTrack4, comboxGag4, comboxTarget4);
        }
        private void getGagTrack(ComboBox comboxTrack, ComboBox comboxGag, ComboBox comboxTarget, int gagTrack)
        {
            comboxGag.Items.Clear();
            comboxGag.Items.Add("Select Gag");
            switch (gagTrack)
            {
                case 0:
                    comboxGag.Items.Clear();
                    comboxGag.Items.Add("Select Gag");
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 1:
                    foreach (string gag in Information.toonupGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 2:
                    foreach (string gag in Information.trapGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 3:
                    foreach (string gag in Information.lureGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 4:
                    foreach (string gag in Information.soundGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 5:
                    foreach (string gag in Information.throwGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
                case 6:
                    foreach (string gag in Information.squirtGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    break;
                case 7:
                    foreach (string gag in Information.dropGags)
                    {
                        comboxGag.Items.Add(gag);
                    }
                    comboxGag.SelectedIndex = 0;
                    comboxTarget.SelectedIndex = 0;
                    break;
            }
            comboxGag.Enabled = true;
            CheckCogsAlive(comboxTarget, true);
        }
        private void comboxTrack1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toon1.alive) return;
            getGagTrack(comboxTrack1, comboxGag1, comboxTarget1, comboxTrack1.SelectedIndex);
        }
        private void comboxTrack2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toon2.alive) return;
            getGagTrack(comboxTrack2, comboxGag2, comboxTarget2, comboxTrack2.SelectedIndex);
        }
        private void comboxTrack3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toon3.alive) return;
            getGagTrack(comboxTrack3, comboxGag3, comboxTarget3, comboxTrack3.SelectedIndex);
        }
        private void comboxTrack4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toon4.alive) return;
            getGagTrack(comboxTrack4, comboxGag4, comboxTarget4, comboxTrack4.SelectedIndex);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Data Checks

            foreach(ComboBox combox in comboxLvl)
            {
                if (combox.Enabled && combox.SelectedIndex == 0)
                {
                    MessageBox.Show("One or more Cogs is missing a level! Please set the level for all of your Cogs then try again.", "A Cog is missing a level!");
                }
            }
            foreach(ComboBox combox in comboxGagTrack)
            {
                if (combox.Enabled && combox.SelectedIndex == 0)
                {
                    MessageBox.Show("No gag track selected! Make sure all Toons have a gag track, then try again.", "No Gag Track!");
                    return;
                }
            }
            foreach (ComboBox combox in comboxGag)
            {
                if (combox.Enabled && combox.SelectedIndex == 0)
                {
                    MessageBox.Show("No gag selected! Make sure all Toons have a gag selected, then try again.", "No Gag!");
                    return;
                }
            }
            foreach (ComboBox combox in comboxTarget)
            {
                if (combox.Enabled && combox.SelectedIndex == 0)
                {
                    MessageBox.Show("No target selected! Make sure all Toons have a cog targetted, then try again.", "No Target!");
                    return;
                }
            }

            // End of Data Checks

            toon1.attack.chosenGag.gagTrack = comboxTrack1.SelectedIndex - 1;
            if (toon1.attack.chosenGag.gagTrack == toon1.organic - 1) toon1.attack.chosenGag.organic = true;
            else toon1.attack.chosenGag.organic = false;
            toon2.attack.chosenGag.gagTrack = comboxTrack2.SelectedIndex - 1;
            if (toon2.attack.chosenGag.gagTrack + 1 == toon2.organic - 1) toon2.attack.chosenGag.organic = true;
            else toon2.attack.chosenGag.organic = false;
            toon3.attack.chosenGag.gagTrack = comboxTrack3.SelectedIndex - 1;
            if (toon3.attack.chosenGag.gagTrack + 1 == toon3.organic - 1) toon3.attack.chosenGag.organic = true;
            else toon3.attack.chosenGag.organic = false;
            toon4.attack.chosenGag.gagTrack = comboxTrack4.SelectedIndex - 1;
            if (toon4.attack.chosenGag.gagTrack + 1 == toon4.organic - 1) toon4.attack.chosenGag.organic = true;
            else toon4.attack.chosenGag.organic = false;

            if (chkboxMaxed1.Checked)
            {
                toon1.attack.chosenGag.gagTier = Convert.ToInt32(txtboxMaxed1.Text);
            }
            else
            {
                toon1.attack.chosenGag.gagTier = comboxGag1.SelectedIndex;
            }
            if (chkboxMaxed2.Checked)
            {
                toon2.attack.chosenGag.gagTier = Convert.ToInt32(txtboxMaxed2.Text);
            }
            else
            {
                toon2.attack.chosenGag.gagTier = comboxGag2.SelectedIndex;
            }
            if (chkboxMaxed3.Checked)
            {
                toon3.attack.chosenGag.gagTier = Convert.ToInt32(txtboxMaxed3.Text);
            }
            else
            {
                toon3.attack.chosenGag.gagTier = comboxGag3.SelectedIndex;
            }
            if (chkboxMaxed4.Checked)
            {
                toon4.attack.chosenGag.gagTier = Convert.ToInt32(txtboxMaxed4.Text);
            }
            else
            {
                toon4.attack.chosenGag.gagTier = comboxGag4.SelectedIndex;
            }

            if (!comboxTarget1.Text.Contains('-'))
            {
                toon1.attack.target = 5;
            }
            else
            {
                toon1.attack.target = comboxTarget1.SelectedIndex;
            }
            if (!comboxTarget2.Text.Contains('-'))
            {
                toon2.attack.target = 5;
            }
            else
            {
                toon2.attack.target = comboxTarget2.SelectedIndex;
            }
            if (!comboxTarget3.Text.Contains('-'))
            {
                toon3.attack.target = 5;
            }
            else
            {
                toon3.attack.target = comboxTarget3.SelectedIndex;
            }
            if (!comboxTarget4.Text.Contains('-'))
            {
                toon4.attack.target = 5;
            }
            else
            {
                toon4.attack.target = comboxTarget4.SelectedIndex;
            }
            attacks.Clear();
            if (toon1.alive)
            {
                attacks.Add(toon1.attack);
            }
            if (toon2.alive)
            {
                attacks.Add(toon2.attack);
            }
            if (toon3.alive)
            {
                attacks.Add(toon3.attack);
            }
            if (toon4.alive)
            {
                attacks.Add(toon4.attack);
            }
            Combat();
        }
        public void Combat()
        {
            if (aliveCogs == 1)
            {
                cogs[0].health = Int32.Parse(txtboxHealth1.Text);
            }
            if (aliveCogs == 2)
            {
                cogs[0].health = Int32.Parse(txtboxHealth1.Text);
                cogs[1].health = Int32.Parse(txtboxHealth2.Text);
            }
            if (aliveCogs == 3)
            {
                cogs[0].health = Int32.Parse(txtboxHealth1.Text);
                cogs[1].health = Int32.Parse(txtboxHealth2.Text);
                cogs[2].health = Int32.Parse(txtboxHealth3.Text);
            }
            if (aliveCogs == 4)
            {
                cogs[0].health = Int32.Parse(txtboxHealth1.Text);
                cogs[1].health = Int32.Parse(txtboxHealth2.Text);
                cogs[2].health = Int32.Parse(txtboxHealth3.Text);
                cogs[3].health = Int32.Parse(txtboxHealth4.Text);
            }
            List<int> gagTiers = new List<int>();
            List<bool> gagOrganic = new List<bool>();
            List<int> targets = new List<int>();

            // Trap
            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack != 1) continue;
                gagTiers.Add(attack.chosenGag.gagTier);
                targets.Add(attack.target);
                if (attack.target == 5)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        cogs[i].Trapped(attack);
                    }
                }
                else
                {
                    cogs[attack.target - 1].Trapped(attack);
                }
            }
            gagTiers.Clear();
            targets.Clear();
            // Lure
            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack != 2) continue;
                if (attack.target == 5)
                {
                    // if Hit
                    if (MessageBox.Show($"Did your {Information.lureGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            cogs[i].Lured();
                        }
                    }
                }
                else
                {
                    if (!cogs[attack.target - 1].lured)
                    {
                        if (MessageBox.Show($"Did your {Information.lureGags[attack.chosenGag.gagTier - 1]} hit in slot {attack.target}?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            cogs[attack.target - 1].Lured();
                        }
                    }
                }
            }
            // Check Trap that will remain until next turn
            for (int i = 0; i < 4; i++)
            {
                if (cogs[i].trapGag != 0)
                {
                    switch (i + 1)
                    {
                        case 1:
                            ShowTrap(1, cogs[i].trapGag);
                            break;
                        case 2:
                            ShowTrap(2, cogs[i].trapGag);
                            break;
                        case 3:
                            ShowTrap(3, cogs[i].trapGag);
                            break;
                        case 4:
                            ShowTrap(4, cogs[i].trapGag);
                            break;
                    }

                }
            }
            // Sound
            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack == 3)
                {
                    gagTiers.Add(attack.chosenGag.gagTier);
                    gagOrganic.Add(attack.chosenGag.organic);
                    targets.Add(attack.target);
                }
            }
            bool willHit = false;
            foreach (Cog cog in cogs)
            {
                if (cog.lured)
                {
                    willHit = true;
                }
            }
            if (gagTiers.Count != 0)
            {
                if (willHit)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        cogs[i].GagAttack(4, gagTiers, gagOrganic);
                    }
                }
                else if (MessageBox.Show($"Did your Sound hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        cogs[i].GagAttack(4, gagTiers, gagOrganic);
                    }
                }
            }
            gagTiers.Clear();
            targets.Clear();

            // Throw

            List<int> gagTier1 = new List<int>();
            List<int> gagTier2 = new List<int>();
            List<int> gagTier3 = new List<int>();
            List<int> gagTier4 = new List<int>();

            List<bool> gagOrganic1 = new List<bool>();
            List<bool> gagOrganic2 = new List<bool>();
            List<bool> gagOrganic3 = new List<bool>();
            List<bool> gagOrganic4 = new List<bool>();

            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack != 4) continue;
                if (attack.target == 5)
                {
                    bool hit = false;
                    foreach(Cog cog in cogs)
                    {
                        if (cog.lured)
                        {
                            hit = true;
                        }
                    }
                    if (hit)
                    {
                        gagTier1.Add(attack.chosenGag.gagTier);
                        gagOrganic1.Add(attack.chosenGag.organic);
                        gagTier2.Add(attack.chosenGag.gagTier);
                        gagOrganic2.Add(attack.chosenGag.organic);
                        gagTier3.Add(attack.chosenGag.gagTier);
                        gagOrganic3.Add(attack.chosenGag.organic);
                        gagTier4.Add(attack.chosenGag.gagTier);
                        gagOrganic4.Add(attack.chosenGag.organic);
                    }
                    else if (MessageBox.Show($"Did your {Information.throwGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        gagTier1.Add(attack.chosenGag.gagTier);
                        gagOrganic1.Add(attack.chosenGag.organic);
                        gagTier2.Add(attack.chosenGag.gagTier);
                        gagOrganic2.Add(attack.chosenGag.organic);
                        gagTier3.Add(attack.chosenGag.gagTier);
                        gagOrganic3.Add(attack.chosenGag.organic);
                        gagTier4.Add(attack.chosenGag.gagTier);
                        gagOrganic4.Add(attack.chosenGag.organic);
                    }
                    
                    break;
                }
                else if (cogs[attack.target].lured)
                {
                    switch (attack.target)
                    {
                        case 1:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            break;
                        case 2:
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            break;
                        case 3:
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            break;
                        case 4:
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                    }
                }
                else if (MessageBox.Show($"Did your {Information.throwGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    switch (attack.target)
                    {
                        case 1:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            break;
                        case 2:
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            break;
                        case 3:
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            break;
                        case 4:
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                    }
                }
            }
            cogs[0].GagAttack(5, gagTier1, gagOrganic1);
            cogs[1].GagAttack(5, gagTier2, gagOrganic2);
            cogs[2].GagAttack(5, gagTier3, gagOrganic3);
            cogs[3].GagAttack(5, gagTier4, gagOrganic4);

            gagTier1.Clear();
            gagTier2.Clear();
            gagTier3.Clear();
            gagTier4.Clear();

            gagOrganic1.Clear();
            gagOrganic2.Clear();
            gagOrganic3.Clear();
            gagOrganic4.Clear();

            // Squirt

            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack != 5) continue;
                if (attack.target == 5)
                {
                    bool hit = false;
                    foreach (Cog cog in cogs)
                    {
                        if (cog.lured)
                        {
                            hit = true;
                        }
                    }
                    if (hit)
                    {
                        gagTier1.Add(attack.chosenGag.gagTier);
                        gagOrganic1.Add(attack.chosenGag.organic);
                        gagTier2.Add(attack.chosenGag.gagTier);
                        gagOrganic2.Add(attack.chosenGag.organic);
                        gagTier3.Add(attack.chosenGag.gagTier);
                        gagOrganic3.Add(attack.chosenGag.organic);
                        gagTier4.Add(attack.chosenGag.gagTier);
                        gagOrganic4.Add(attack.chosenGag.organic);
                    }
                    else if (MessageBox.Show($"Did your {Information.squirtGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        gagTier1.Add(attack.chosenGag.gagTier);
                        gagOrganic1.Add(attack.chosenGag.organic);
                        gagTier2.Add(attack.chosenGag.gagTier);
                        gagOrganic2.Add(attack.chosenGag.organic);
                        gagTier3.Add(attack.chosenGag.gagTier);
                        gagOrganic3.Add(attack.chosenGag.organic);
                        gagTier4.Add(attack.chosenGag.gagTier);
                        gagOrganic4.Add(attack.chosenGag.organic);
                    }

                    break;
                }
                else if (cogs[attack.target].lured)
                {
                    switch (attack.target)
                    {
                        case 1:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            break;
                        case 2:
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            break;
                        case 3:
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            break;
                        case 4:
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                    }
                }
                else if (MessageBox.Show($"Did your {Information.squirtGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    switch (attack.target)
                    {
                        case 1:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            break;
                        case 2:
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            break;
                        case 3:
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            break;
                        case 4:
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                    }
                }
            }

            cogs[0].GagAttack(6, gagTier1, gagOrganic1);
            cogs[1].GagAttack(6, gagTier2, gagOrganic2);
            cogs[2].GagAttack(6, gagTier3, gagOrganic3);
            cogs[3].GagAttack(6, gagTier4, gagOrganic4);

            gagTier1.Clear();
            gagTier2.Clear();
            gagTier3.Clear();
            gagTier4.Clear();

            gagOrganic1.Clear();
            gagOrganic2.Clear();
            gagOrganic3.Clear();
            gagOrganic4.Clear();

            // Drop
            foreach (Attack attack in attacks)
            {
                if (attack.chosenGag.gagTrack != 6) continue;
                if (attack.target == 5)
                {
                    for (int i = 0; i < cogs.Count; i++)
                    {
                        if (!cogs[i].lured)
                        {
                            switch (i)
                            {
                                case 0:
                                    gagTier1.Add(attack.chosenGag.gagTier);
                                    gagOrganic1.Add(attack.chosenGag.organic);
                                    break;
                                case 1:
                                    gagTier2.Add(attack.chosenGag.gagTier);
                                    gagOrganic2.Add(attack.chosenGag.organic);
                                    break;
                                case 2:
                                    gagTier3.Add(attack.chosenGag.gagTier);
                                    gagOrganic3.Add(attack.chosenGag.organic);
                                    break;
                                case 3:
                                    gagTier4.Add(attack.chosenGag.gagTier);
                                    gagOrganic4.Add(attack.chosenGag.organic);
                                    break;
                            }
                        }
                        
                    }
                }
                if (cogs[attack.target - 1].lured) continue;
                if (MessageBox.Show($"Did your {Information.dropGags[attack.chosenGag.gagTier - 1]} hit?", "Gag Hit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    switch (attack.target)
                    {
                        case 1:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            break;
                        case 2:
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            break;
                        case 3:
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            break;
                        case 4:
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                        case 5:
                            gagTier1.Add(attack.chosenGag.gagTier);
                            gagOrganic1.Add(attack.chosenGag.organic);
                            gagTier2.Add(attack.chosenGag.gagTier);
                            gagOrganic2.Add(attack.chosenGag.organic);
                            gagTier3.Add(attack.chosenGag.gagTier);
                            gagOrganic3.Add(attack.chosenGag.organic);
                            gagTier4.Add(attack.chosenGag.gagTier);
                            gagOrganic4.Add(attack.chosenGag.organic);
                            break;
                    }
                }
            }
            cogs[0].GagAttack(7, gagTier1, gagOrganic1);
            cogs[1].GagAttack(7, gagTier2, gagOrganic2);
            cogs[2].GagAttack(7, gagTier3, gagOrganic3);
            cogs[3].GagAttack(7, gagTier4, gagOrganic4);

            gagTier1.Clear();
            gagTier2.Clear();
            gagTier3.Clear();
            gagTier4.Clear();

            gagOrganic1.Clear();
            gagOrganic2.Clear();
            gagOrganic3.Clear();
            gagOrganic4.Clear();

            txtboxHealth1.Text = cogs[0].health.ToString();
            txtboxHealth2.Text = cogs[1].health.ToString();
            txtboxHealth3.Text = cogs[2].health.ToString();
            txtboxHealth4.Text = cogs[3].health.ToString();
            foreach (Cog cog in cogs)
            {
                if (cog.lured)
                {
                    cog.luredTurns--;
                }
            }
            comboxLureTurns1.SelectedIndex = cog1.luredTurns;
            comboxLureTurns2.SelectedIndex = cog2.luredTurns;
            comboxLureTurns3.SelectedIndex = cog3.luredTurns;
            comboxLureTurns4.SelectedIndex = cog4.luredTurns;
            if (!cog1.lured)
            {
                chkboxLured1.Checked = false;
                comboxLureTurns1.SelectedIndex = 0;
            }
            if (!cog2.lured)
            {
                chkboxLured2.Checked = false;
                comboxLureTurns2.SelectedIndex = 0;
            }
            if (!cog3.lured)
            {
                chkboxLured3.Checked = false;
                comboxLureTurns3.SelectedIndex = 0;
            }
            if (!cog4.lured)
            {
                chkboxLured4.Checked = false;
                comboxLureTurns4.SelectedIndex = 0;
            }

            if (cog1.health <= 0 && cog1.alive)
            {
                if (cog1.ver2)
                {
                    cog1.health = Information.CogHP(cog1.lvl);
                    cog1.lured = false;
                    cog1.luredTurns = 0;
                    cog1.trapGag = 0;
                    cog1.trapOrganic = false;
                    cog1.ver2 = false;
                    txtboxHealth1.Text = cog1.health.ToString();
                    comboxLvl1.SelectedIndex = cog1.lvl;
                    chkboxLured1.Checked = false;
                    comboxLureTurns1.SelectedIndex = 0;
                    chkboxVer21.Checked = false;
                    ShowTrap(1, 0);
                }
                else
                {
                    cog1.alive = false;
                }
            }
            if (cog2.health <= 0 && cog2.alive)
            {
                if (cog2.ver2)
                {
                    cog2.health = Information.CogHP(cog2.lvl);
                    cog2.lured = false;
                    cog2.luredTurns = 0;
                    cog2.trapGag = 0;
                    cog2.trapOrganic = false;
                    cog2.ver2 = false;
                    txtboxHealth2.Text = cog2.health.ToString();
                    comboxLvl2.SelectedIndex = cog2.lvl;
                    chkboxLured2.Checked = false;
                    comboxLureTurns2.SelectedIndex = 0;
                    chkboxVer22.Checked = false;
                    ShowTrap(2, 0);
                }
                else
                {
                    cog2.alive = false;
                }
            }
            if (cog3.health <= 0 && cog3.alive)
            {
                if (cog3.ver2)
                {
                    cog3.health = Information.CogHP(cog3.lvl);
                    cog3.lured = false;
                    cog3.luredTurns = 0;
                    cog3.trapGag = 0;
                    cog3.trapOrganic = false;
                    cog3.ver2 = false;
                    txtboxHealth3.Text = cog3.health.ToString();
                    comboxLvl3.SelectedIndex = cog3.lvl;
                    chkboxLured3.Checked = false;
                    comboxLureTurns3.SelectedIndex = 0;
                    chkboxVer23.Checked = false;
                    ShowTrap(3, 0);
                }
                else
                {
                    cog3.alive = false;
                }
            }
            if (cog4.health <= 0 && cog4.alive)
            {
                if (cog4.ver2)
                {
                    cog4.health = Information.CogHP(cog4.lvl);
                    cog4.lured = false;
                    cog4.luredTurns = 0;
                    cog4.trapGag = 0;
                    cog4.trapOrganic = false;
                    cog4.ver2 = false;
                    txtboxHealth4.Text = cog4.health.ToString();
                    comboxLvl4.SelectedIndex = cog4.lvl;
                    chkboxLured4.Checked = false;
                    comboxLureTurns4.SelectedIndex = 0;
                    chkboxVer24.Checked = false;
                    ShowTrap(4, 0);
                }
                else
                {
                    cog4.alive = false;
                }
            }
            List<Cog> updatedCogs = new List<Cog>();
            foreach (Cog cog in cogs)
            {
                if (cog.alive)
                {
                    updatedCogs.Add(cog);
                }
            }
            for(int i = 0; i < updatedCogs.Count; i++)
            {
                cogs[i] = updatedCogs[i];
            }
            UpdateDisplay(cogs);
        }
        private void SetOrganic(int toon, int track)
        {
            switch (toon)
            {
                case 1:
                    toon1.organic = track;
                    break;
                case 2:
                    toon2.organic = track;
                    break;
                case 3:
                    toon3.organic = track;
                    break;
                case 4:
                    toon4.organic = track;
                    break;
            }
        }
        public void ShowTrap(int cog, int gag)
        {
            PictureBox picbox = picboxTrap1;
            switch (cog)
            {
                case 1:
                    picbox = picboxTrap1;
                    break;
                case 2: 
                    picbox = picboxTrap2;
                    break;
                case 3:
                    picbox = picboxTrap3;
                    break;
                case 4:
                    picbox = picboxTrap4;
                    break;
            }
            switch (gag)
            {
                case 0:
                    picbox.Image = Properties.Resources.redx;
                    break;
                case 1:
                    picbox.Image = Properties.Resources.bananapeel;
                    break;
                case 2:
                    picbox.Image = Properties.Resources.rake;
                    break;
                case 3:
                    picbox.Image = Properties.Resources.marbles;
                    break;
                case 4:
                    picbox.Image = Properties.Resources.quicksand;
                    break;
                case 5:
                    picbox.Image = Properties.Resources.trapdoor;
                    break;
                case 6:
                    picbox.Image = Properties.Resources.tnt;
                    break;
                case 7:
                    picbox.Image = Properties.Resources.railroad;
                    break;
            }
        }
        public void UpdateDisplay(List<Cog> cogs)
        {
            for (int i = 0; i < cogs.Count; i++)
            {
                if (cogs[i].alive)
                {
                    chkboxAlive[i].Checked = cogs[i].alive;
                    chkboxAlive[i].Enabled = true;
                    comboxLvl[i].SelectedIndex = cogs[i].lvl;
                    comboxLvl[i].Enabled = true;
                    chkboxLured[i].Checked = cogs[i].lured;
                    chkboxLured[i].Enabled = true;
                    comboxLureTurns[i].SelectedIndex = cogs[i].luredTurns;
                    comboxLureTurns[i].Enabled = true;
                    chkboxVer2[i].Checked = cogs[i].ver2;
                    chkboxVer2[i].Enabled = true;
                    txtboxHealth[i].Text = cogs[i].health.ToString();
                    txtboxHealth[i].Enabled = true;
                    chkboxOrg[i].Checked = cogs[i].trapOrganic;
                    chkboxOrg[i].Enabled = true;
                    comboxTrap[i].SelectedIndex = cogs[i].trapGag;
                    comboxTrap[i].Enabled = true;
                }
                else
                {
                    chkboxAlive[i].Checked = false;
                    chkboxAlive[i].Enabled = true;
                    comboxLvl[i].SelectedIndex = 0;
                    comboxLvl[i].Enabled = false;
                    chkboxLured[i].Checked = false;
                    chkboxLured[i].Enabled = false;
                    comboxLureTurns[i].SelectedIndex = 0;
                    comboxLureTurns[i].Enabled = false;
                    chkboxVer2[i].Checked = false;
                    chkboxVer2[i].Enabled = false;
                    txtboxHealth[i].Text = "";
                    txtboxHealth[i].Enabled = false;
                    chkboxOrg[i].Checked = false;
                    chkboxOrg[i].Enabled = false;
                    comboxTrap[i].SelectedIndex = 0;
                    comboxTrap[i].Enabled = false;
                }
            }
        }
        private void comboxLvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxHealth1.Text = Information.CogHP(comboxLvl1.SelectedIndex).ToString();
            cog1.lvl = comboxLvl1.SelectedIndex;
        }
        private void comboxLvl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxHealth2.Text = Information.CogHP(comboxLvl2.SelectedIndex).ToString();
            cog2.lvl = comboxLvl2.SelectedIndex;
        }
        private void comboxLvl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxHealth3.Text = Information.CogHP(comboxLvl3.SelectedIndex).ToString();
            cog3.lvl = comboxLvl3.SelectedIndex;
        }
        private void comboxLvl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxHealth4.Text = Information.CogHP(comboxLvl4.SelectedIndex).ToString();
            cog4.lvl = comboxLvl4.SelectedIndex;
        }
        private void chkboxToon1_CheckedChanged(object sender, EventArgs e)
        {
            toon1.alive = chkboxToon1.Checked;
            if (toon1.alive)
            {
                if (aliveCogs > 0)
                {
                    comboxTrack1.Enabled = true;
                }
                EnableToon(1);
            }
            else
            {
                comboxTrack1.Enabled = false;
                comboxGag1.Enabled = false;
                comboxTrack1.Text= "Gag Track";
                comboxGag1.Text = "Gag";
                comboxTarget1.Enabled = false;
                DisableToon(1);
                chkboxToon2.Enabled = false;
                comboxGag2.Enabled = false;
                comboxTrack2.Text = "Gag Track";
                comboxGag2.Text = "Gag";
                comboxTarget2.Enabled = false;
                DisableToon(2);
                chkboxToon3.Enabled = false;
                comboxGag3.Enabled = false;
                comboxTrack3.Text = "Gag Track";
                comboxGag3.Text = "Gag";
                comboxTarget3.Enabled = false;
                DisableToon(3);
                chkboxToon4.Enabled = false;
                comboxGag4.Enabled = false;
                comboxTrack4.Text = "Gag Track";
                comboxGag4.Text = "Gag";
                comboxTarget4.Enabled = false;
            }
        }
        private void chkboxToon2_CheckedChanged(object sender, EventArgs e)
        {
            toon2.alive = chkboxToon2.Checked;
            if (toon2.alive)
            {
                if (aliveCogs > 0)
                {
                    comboxOrg2.Enabled = true;
                    comboxTrack2.Enabled = true;
                }
                EnableToon(2);
            }
            else
            {
                DisableToon(1);
                chkboxToon2.Enabled = true;
                comboxTrack2.Enabled = false;
                comboxOrg2.Enabled = false;
                DisableToon(2);
                chkboxToon3.Enabled = false;
                DisableToon(3);
                chkboxToon4.Enabled = false;
            }
        }
        private void chkboxToon3_CheckedChanged(object sender, EventArgs e)
        {
            toon3.alive = chkboxToon3.Checked;
            if (toon3.alive)
            {
                if (aliveCogs > 0)
                {
                    comboxOrg3.Enabled = true;
                    comboxTrack3.Enabled = true;
                }
                EnableToon(3);
            }
            else
            {
                DisableToon(2);
                chkboxToon3.Enabled = true;
                comboxTrack3.Enabled = false;
                comboxOrg3.Enabled = false;
                DisableToon(3);
                chkboxToon4.Enabled = false;
            }
        }
        private void chkboxToon4_CheckedChanged(object sender, EventArgs e)
        {
            toon4.alive = chkboxToon4.Checked;
            if (!toon4.alive)
            {
                DisableToon(3);
                chkboxToon4.Enabled = true;
                comboxTrack4.Enabled = false;
                comboxOrg4.Enabled = false;
            }
            else
            {
                if (aliveCogs > 0)
                {
                    comboxOrg4.Enabled = true;
                    comboxTrack4.Enabled = true;
                }
            }
        }
        private void chkboxLured1_CheckedChanged(object sender, EventArgs e)
        {
            cog1.lured = chkboxLured1.Checked;
            comboxLureTurns1.Enabled = chkboxLured1.Checked;
        }
        private void chkboxLured2_CheckedChanged(object sender, EventArgs e)
        {
            cog2.lured = chkboxLured2.Checked;
            comboxLureTurns2.Enabled = chkboxLured2.Checked;
        }
        private void chkboxLured3_CheckedChanged(object sender, EventArgs e)
        {
            cog3.lured = chkboxLured3.Checked;
            comboxLureTurns3.Enabled = chkboxLured3.Checked;
        }
        private void chkboxLured4_CheckedChanged(object sender, EventArgs e)
        {
            cog4.lured = chkboxLured1.Checked;
            comboxLureTurns4.Enabled = chkboxLured4.Checked;
        }
        private void comboxOrg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOrganic(1, comboxOrg1.SelectedIndex);
        }
        private void comboxOrg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOrganic(2, comboxOrg2.SelectedIndex);
        }
        private void comboxOrg3_SelectedIndexChanged(object sender, EventArgs e)
        {
           SetOrganic(3, comboxOrg3.SelectedIndex);
        }
        private void comboxOrg4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOrganic(4, comboxOrg4.SelectedIndex);
        }
        private void comboxTrap1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cog1.trapGag = comboxTrap1.SelectedIndex;
            ShowTrap(1, comboxTrap1.SelectedIndex);
        }
        private void comboxTrap2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTrap(2, comboxTrap1.SelectedIndex);
        }
        private void comboxTrap3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTrap(3, comboxTrap1.SelectedIndex);
        }
        private void comboxTrap4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTrap(4, comboxTrap1.SelectedIndex);
        }
        private void chkboxOrg1_CheckedChanged(object sender, EventArgs e)
        {
            cog1.trapOrganic = chkboxOrg1.Checked;
        }
        private void chkboxOrg2_CheckedChanged(object sender, EventArgs e)
        {
            cog2.trapOrganic = chkboxOrg2.Checked;
        }
        private void chkboxOrg3_CheckedChanged(object sender, EventArgs e)
        {
            cog3.trapOrganic = chkboxOrg3.Checked;
        }
        private void chkboxOrg4_CheckedChanged(object sender, EventArgs e)
        {
            cog4.trapOrganic = chkboxOrg4.Checked;
        }
        private void comboxLureTurns1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cog1.luredTurns = comboxLureTurns1.SelectedIndex;
        }
        private void comboxLureTurns2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cog2.luredTurns = comboxLureTurns2.SelectedIndex;
        }
        private void comboxLureTurns3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cog3.luredTurns = comboxLureTurns3.SelectedIndex;
        }
        private void comboxLureTurns4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cog4.luredTurns = comboxLureTurns4.SelectedIndex;
        }
        private void chkboxVer21_CheckedChanged(object sender, EventArgs e)
        {
            cog1.ver2 = chkboxVer21.Checked;
        }
        private void chkboxVer22_CheckedChanged(object sender, EventArgs e)
        {
            cog2.ver2 = chkboxVer22.Checked;
        }
        private void chkboxVer23_CheckedChanged(object sender, EventArgs e)
        {
            cog3.ver2 = chkboxVer23.Checked;
        }
        private void chkboxVer24_CheckedChanged(object sender, EventArgs e)
        {
            cog4.ver2 = chkboxVer24.Checked;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Hi :)
        }
    }
}
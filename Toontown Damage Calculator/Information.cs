using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toontown_Damage_Calculator
{
    public class Information
    {
        public static List<string> gagTracks = new List<string>()
        {
            "Toon-Up",
            "Trap",
            "Lure",
            "Sound",
            "Throw",
            "Squirt",
            "Drop"
        };
        public static List<string> toonupGags = new List<string>()
        {
            "Feather",
            "Megaphone",
            "Lipstick",
            "Bamboo Cane",
            "Pixie Dust",
            "Juggling Cubes",
            "High Dive"
        };
        public static List<string> trapGags = new List<string>()
        {
            "Banana Peel",
            "Rake",
            "Marbles",
            "Quicksand",
            "Trapdoor",
            "TNT",
            "Railroad"
        };
        public static List<string> lureGags = new List<string>()
        {
            "$1 Bill",
            "Small Magnet",
            "$5 Bill",
            "Big Magnet",
            "$10 Bill",
            "Hypno-goggles",
            "Presentation"
        };
        public static List<string> soundGags = new List<string>()
        {
            "Bike Horn",
            "Whistle",
            "Bugle",
            "Aoogah",
            "Elephant Trunk",
            "Foghorn",
            "Opera Singer"
        };
        public static List<string> throwGags = new List<string>()
        {
            "Cupcake",
            "Fruit Slice",
            "Cream Slice",
            "Whole Fruit",
            "Whole Cream",
            "Birthday Cake",
            "Wedding Cake"
        };
        public static List<string> squirtGags = new List<string>()
        {
            "Squirt Flower",
            "Water Glass",
            "Squirt Gun",
            "Seltzer Bottle",
            "Fire Hose",
            "Storm Cloud",
            "Geyser"
        };
        public static List<string> dropGags = new List<string>()
        {
            "Flower Pot",
            "Sandbag",
            "Anvil",
            "Big Weight",
            "Safe",
            "Grand Piano",
            "Toontanic"
        };

        public static ToonUp toonUp = new ToonUp();
        public static Trap trap = new Trap();
        public static Lure lure = new Lure();
        public static Sound sound = new Sound();
        public static Throw throwTrack = new Throw();
        public static Squirt squirt = new Squirt();
        public static Drop drop = new Drop();

        public static int CogHP(int lvl)
        {
            if (lvl < 12)
            {
                return ((lvl + 1) * (lvl + 2));
            }
            else
            {
                return ((lvl * lvl) + (3 * lvl) + 16);
            }
        }

        public static int GagDamage(Gag gag)
        {
            int damage = 0;
            if (gag.organic)
            {
                switch (gag.gagTrack)
                {
                    case 1:
                        damage = toonUp.Organic[gag.gagTier];
                        break;
                    case 2:
                        damage = trap.Organic[gag.gagTier];
                        break;
                    case 3:
                        // Lure, no damage
                        damage = 0;
                        break;
                    case 4:
                        damage = sound.Organic[gag.gagTier];
                        break;
                    case 5:
                        damage = throwTrack.Organic[gag.gagTier];
                        break;
                    case 6:
                        damage = squirt.Organic[gag.gagTier];
                        break;
                    case 7:
                        damage = drop.Organic[gag.gagTier];
                        break;
                }
            }
            else
            {
                switch (gag.gagTrack)
                {
                    case 1:
                        damage = toonUp.Normal[gag.gagTier];
                        break;
                    case 2:
                        damage = trap.Normal[gag.gagTier];
                        break;
                    case 3:
                        // Lure, no damage
                        damage = 0;
                        break;
                    case 4:
                        damage = sound.Normal[gag.gagTier];
                        break;
                    case 5:
                        damage = throwTrack.Normal[gag.gagTier];
                        break;
                    case 6:
                        damage = squirt.Normal[gag.gagTier];
                        break;
                    case 7:
                        damage = drop.Normal[gag.gagTier];
                        break;
                }
            }
            return damage;
        }
    }

    public class Attack
    {
        public Gag chosenGag = new Gag();
        public int damage = 0;
        public int target;
    }
    public class Gag
    {
        public int gagTrack = 0;
        public int gagTier = 0;
        public bool organic = false;
        public bool maxed = true;
        public int maxedDamage = 0;
    }
    public class Cog
    {
        public bool alive = false;
        public int lvl = 0;
        public bool lured = false;
        public int luredTurns = 0;
        public int trapGag = 0;
        public bool trapOrganic;
        public bool ver2 = false;
        public int health;

        public int Ver2Armor()
        {
            return Convert.ToInt32(Math.Floor((decimal)(lvl * 1.5)));
        }
        public void Trapped(Attack attack)
        {
            if (trapGag != 0)
            {
                trapGag = 0;
            }
            else
            {
                if (attack.chosenGag.maxed)
                {
                    trapGag = attack.chosenGag.gagTier;
                    trapOrganic = attack.chosenGag.organic;
                }
                else
                {
                    trapGag = attack.chosenGag.maxedDamage;
                    trapOrganic = attack.chosenGag.organic;
                }
            }
        }
        public void Lured()
        {
            if (trapGag != 0)
            {
                int damage = 0;
                if (!trapOrganic)
                {
                    if (ver2)
                    {
                        if (trapGag > 7)
                        {
                            damage = trapGag - Ver2Armor();
                        }
                        else
                        {
                            damage = Information.trap.Normal[trapGag] - Ver2Armor();
                        }
                    }
                    else
                    {
                        if (trapGag > 7)
                        {
                            damage = trapGag - Ver2Armor();
                        }
                        else
                        {
                            damage = Information.trap.Normal[trapGag] - Ver2Armor();
                        }
                    }
                }
                else
                {
                    if (ver2)
                    {
                        if (trapGag > 7)
                        {
                            damage = trapGag - Ver2Armor();
                        }
                        else
                        {
                            damage = Information.trap.Organic[trapGag] - Ver2Armor();
                        }
                    }
                    else
                    {
                        if (trapGag > 7)
                        {
                            damage = trapGag - Ver2Armor();
                        }
                        else
                        {
                            damage = Information.trap.Organic[trapGag] - Ver2Armor();
                        }
                    }
                }
                health = health - damage;
                trapGag = 0;
            }
            else
            {
                lured = true;
            }
        }
        public void GagAttack(int gagTrack, List<int> gags, List<bool> organic)
        {
            int totalDamage = 0;
            for(int i = 0; i < gags.Count; i++)
            {
                switch (gagTrack)
                {
                    case 4:
                        if (lured) lured = false;
                        if (organic[i] == false)
                        {
                            if (gags[i] > 7)
                            {
                                if (ver2)
                                {
                                    totalDamage += gags[i] - Ver2Armor();
                                }
                                else
                                {
                                    totalDamage += gags[i];
                                }
                            }
                            else
                            {
                                if (ver2)
                                {
                                    totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.sound.Normal[gags[i]] - Ver2Armor())));
                                }
                                else
                                {
                                    totalDamage += (Information.sound.Normal[gags[i]]);
                                }
                            }
                        }
                        else
                        {
                            if (ver2)
                            {
                                totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.sound.Organic[gags[i]] - Ver2Armor())));
                            }
                            else
                            {
                                totalDamage += (Information.sound.Organic[gags[i]]);
                            }
                        }
                        if (gags.Count > 1)
                        {
                            health = health - Damage(totalDamage, false, true);
                        }
                        else
                        {
                            health = health - Damage(totalDamage, false, false);
                        }
                        break;
                    case 5:
                        if (organic[i] == false)
                        {
                            if (gags[i] > 7)
                            {
                                if (ver2)
                                {
                                    totalDamage += gags[i] - Ver2Armor();
                                }
                                else
                                {
                                    totalDamage += gags[i];
                                }
                            }
                            else
                            {
                                if (ver2)
                                {
                                    totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.throwTrack.Normal[gags[i]] - Ver2Armor())));
                                }
                                else
                                {
                                    totalDamage += (Information.throwTrack.Normal[gags[i]]);
                                }
                            }
                        }
                        else
                        {
                            if (ver2)
                            {
                                totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.throwTrack.Organic[gags[i]] - Ver2Armor())));
                            }
                            else
                            {
                                totalDamage += (Information.throwTrack.Organic[gags[i]]);
                            }
                        }
                        if (gags.Count > 1)
                        {
                            health = health - Damage(totalDamage, lured, true);
                        }
                        else
                        {
                            health = health - Damage(totalDamage, lured, false);
                        }
                        lured = false;
                        break;
                    case 6:
                        if (organic[i] == false)
                        {
                            if (gags[i] > 7)
                            {
                                if (ver2)
                                {
                                    totalDamage += gags[i] - Ver2Armor();
                                }
                                else
                                {
                                    totalDamage += gags[i];
                                }
                            }
                            else
                            {
                                if (ver2)
                                {
                                    totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.squirt.Normal[gags[i]] - Ver2Armor())));
                                }
                                else
                                {
                                    totalDamage += (Information.squirt.Normal[gags[i]]);
                                }
                            }
                        }
                        else
                        {
                            if (ver2)
                            {
                                totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.squirt.Organic[gags[i]] - Ver2Armor())));
                            }
                            else
                            {
                                totalDamage += (Information.squirt.Organic[gags[i]]);
                            }
                        }
                        if (gags.Count > 1)
                        {
                            health = health - Damage(totalDamage, lured, true);
                        }
                        else
                        {
                            health = health - Damage(totalDamage, lured, false);
                        }
                        lured = false;
                        break;
                    case 7:
                        if (lured) return;
                        if (organic[i] == false)
                        {
                            if (gags[i] > 7)
                            {
                                if (ver2)
                                {
                                    totalDamage += gags[i] - Ver2Armor();
                                }
                                else
                                {
                                    totalDamage += gags[i];
                                }
                            }
                            else
                            {
                                if (ver2)
                                {
                                    totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.drop.Normal[gags[i]] - Ver2Armor())));
                                }
                                else
                                {
                                    totalDamage += (Information.drop.Normal[gags[i]]);
                                }
                            }
                        }
                        else
                        {
                            if (ver2)
                            {
                                totalDamage += Convert.ToInt32(Math.Ceiling((decimal)(Information.drop.Organic[gags[i]] - Ver2Armor())));
                            }
                            else
                            {
                                totalDamage += (Information.drop.Organic[gags[i]]);
                            }
                        }
                        if (gags.Count > 1)
                        {
                            health = health - Damage(totalDamage, false, true);
                        }
                        else
                        {
                            health = health - Damage(totalDamage, false, false);
                        }
                        break;
                }
            }
        }
        public int Damage(int totalDamage, bool lured, bool combo)
        {
            int Damage = 0;
            if (lured)
            {
                Damage = Convert.ToInt32(Math.Ceiling(totalDamage * 1.5));
                if (combo)
                {
                    Damage += Convert.ToInt32(Math.Ceiling((decimal)totalDamage / 5));
                    return Damage;
                }
                else
                {
                    return Damage;
                }
            }
            else
            {
                Damage = totalDamage;
                if (combo)
                {
                    Damage += Convert.ToInt32(Math.Ceiling((decimal)totalDamage / 5));
                    return Damage;
                }
                else
                {
                    return Damage;
                }
            }
        }

        public void Reset()
        {
            alive = false;
            lvl = 0;
            lured = false;
            luredTurns = 0;
            trapGag = 0;
            trapOrganic = false;
            ver2 = false;
            health = 0;
        }
    }
    public class Toon
    {
        public int organic { get; set; } = 8;
        public bool alive { get; set; } = false;
        public Attack attack { get; set; } = new Attack();
    }
    public class ToonUp
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 10},
            { 2, 6},
            { 3, 30},
            { 4, 15},
            { 5, 60},
            { 6, 35},
            { 7, 70}
        };
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 11},
            { 2, 7},
            { 3, 33},
            { 4, 17},
            { 5, 66},
            { 6, 39},
            { 7, 33}
        };
    }
    public class Trap
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 12},
            { 2, 20},
            { 3, 35},
            { 4, 50},
            { 5, 85},
            { 6, 180},
            { 7, 200}
        };
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 13},
            { 2, 22},
            { 3, 38},
            { 4, 55},
            { 5, 93},
            { 6, 198},
            { 7, 220}
        };
    }
    public class Lure
    {
        public Dictionary<int, string> Normal = new Dictionary<int, string>()
        {
            { 1, "O"},
            { 2, "A"},
            { 3, "O"},
            { 4, "A"},
            { 5, "O"},
            { 6, "A"},
            { 7, "A"}
        };
        public Dictionary<int, string> Organic = new Dictionary<int, string>()
        {
            { 1, "O"},
            { 2, "A"},
            { 3, "O"},
            { 4, "A"},
            { 5, "O"},
            { 6, "A"},
            { 7, "A"}
        };
    }
    public class Sound
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 4 },
            { 2, 7 },
            { 3, 11},
            { 4, 16},
            { 5, 21},
            { 6, 50},
            { 7, 90 }
        };
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 5 },
            { 2, 8 },
            { 3, 12},
            { 4, 17},
            { 5, 23},
            { 6, 55},
            { 7, 99 }
        };
    }
    public class Throw
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 6 },
            { 2, 10 },
            { 3, 17 },
            { 4, 27 },
            { 5, 40 },
            { 6, 100 },
            { 7, 120 }
        };   
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 7 },
            { 2, 11 },
            { 3, 18 },
            { 4, 29 },
            { 5, 44 },
            { 6, 110 },
            { 7, 132 }
        };
    }
    public class Squirt
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 4 },
            { 2, 8 },
            { 3, 12 },
            { 4, 21 },
            { 5, 30 },
            { 6, 80 },
            { 7, 105 }
        };
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 5 },
            { 2, 9 },
            { 3, 13 },
            { 4, 23 },
            { 5, 33 },
            { 6, 88 },
            { 7, 115 }
        };
    }
    public class Drop
    {
        public Dictionary<int, int> Normal = new Dictionary<int, int>()
        {
            { 1, 10 },
            { 2, 18},
            { 3, 30},
            { 4, 45},
            { 5, 70},
            { 6, 170},
            { 7, 180}
        };
        public Dictionary<int, int> Organic = new Dictionary<int, int>()
        {
            { 1, 11},
            { 2, 19},
            { 3, 33},
            { 4, 49},
            { 5, 77},
            { 6, 187},
            { 7, 198}
        };
    }
}

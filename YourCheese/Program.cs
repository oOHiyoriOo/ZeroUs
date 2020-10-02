
using HamsterCheese.AmongUsMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


// added
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace YourCheese
{
    static class Globals
    {
        public static String NotifyOnDead = "0";
        public static String ImposterOnDead = "0";
        public static String WriteImposter = "0";
        public static String ReviveMe = "0";
        public static String LightValue = "0";
        public static String InstaWin = "0";
        public static String RainbowSkin = "0";

        // save stats in string first to prevent text flickering
        public static String Player = ""; 
        public static String Imposter = "";
        public static String Dead = "";

        public static HeaderDead PlayerForm = new HeaderDead();
    }

    class Program
    {
        static int tableWidth = 75;

       
        static List<PlayerData> playerDatas = new List<PlayerData>(); 
        static void UpdateCheat()
        {
       
            while (true)
            {
                // PlayerStats
                Globals.Player = "";
                Globals.Imposter = "";
                Globals.Dead = "";
                foreach (var data in playerDatas)
                {

                    var Name = HamsterCheese.AmongUsMemory.Utils.ReadString(data.PlayerInfo.Value.PlayerName);

                    if(Globals.PlayerForm.Visible) {
                        if(data.PlayerInfo.Value.IsImpostor == 0 && data.PlayerInfo.Value.IsDead == 0)
                            Globals.Player = Globals.Player + "\n>" + Name;
                        else if(data.PlayerInfo.Value.IsImpostor == 1 && data.PlayerInfo.Value.IsDead == 0)
                            Globals.Imposter = Globals.Imposter + "\n>" + Name;
                        else if(data.PlayerInfo.Value.IsImpostor == 0 && data.PlayerInfo.Value.IsDead == 1)
                            Globals.Dead = Globals.Dead + "\n>" + Name;
                    }

                    if(Globals.ReviveMe == "1" && data.IsLocalPlayer && data.PlayerInfo.Value.IsDead == 1) {
                        data.WriteMemory_IsDead(0);
                    }

                    if(Globals.WriteImposter == "1" && data.IsLocalPlayer) {
                        data.WriteMemory_Impostor(1);
                    }else if(Globals.WriteImposter == "-1" && data.IsLocalPlayer) {
                        data.WriteMemory_Impostor(0);
                        Globals.WriteImposter = "0";
                    }
                    if(Globals.LightValue == "1") {
                        Cheese.mem.FreezeValue("data.Instance.myLight","float","100f");
                    }

                    if(Globals.InstaWin == "1") {
                        if(!data.IsLocalPlayer) {
                            data.WriteMemory_IsDead(1);
                        }
                    }

                    //if(Globals.RainbowSkin == "1") {
                    //    data.Instance.killTimer
                    //}



                    //public void WriteMemory_LightRange( float value ) { 
                    //    var targetPointer = Utils.GetMemberPointer(Instance.myLight,typeof(LightSource),"LightRadius"); 
                    //    Cheese.mem.WriteMemory(targetPointer.GetAddress(),"float",value.ToString("0.0")); 
                    //}






                }
                System.Threading.Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            // start new window :D 
            new Thread(() => new Form1().ShowDialog()).Start();

            // Cheat Init
            if (HamsterCheese.AmongUsMemory.Cheese.Init())
            { 
                // Update Player Data When Every Game
                HamsterCheese.AmongUsMemory.Cheese.ObserveShipStatus((x) =>
                {
                    
                    foreach(var player in playerDatas)
                    {
                        player.StopObserveState();
                    }


                    playerDatas = HamsterCheese.AmongUsMemory.Cheese.GetAllPlayers();
                    
                  
                    foreach (var player in playerDatas)
                    {
                        player.onDie += (pos, colorId) => {
                            // Console.WriteLine("OnPlayerDied! Color ID :" + colorId);
                        }; 
                        // player state check
                        player.StartObserveState();
                    }

                
                });

                // Cheat Logic
                CancellationTokenSource cts = new CancellationTokenSource();
                Task.Factory.StartNew(
                    UpdateCheat
                , cts.Token); 
            }

            System.Threading.Thread.Sleep(1000000);
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);

            
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        } 
    }
}



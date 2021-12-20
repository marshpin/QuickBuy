using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameInput;

namespace QuickBuy.Hotkeys
{
    public class QuickBuyHotkey
    {
        internal readonly Mod mod;
        internal readonly string name;
        internal readonly string uniqueName;
        internal readonly string defaultKey;
        public static int[] QuickBuyPossibleAmount = {1,100,500,1000,5000,9999};
        public static int QuickBuyAmount = QuickBuyPossibleAmount[1];
        internal QuickBuyHotkey(Mod mod, string name, string defaultKey)
        {
            this.mod = mod;
            this.name = name;
            this.defaultKey = defaultKey;
            this.uniqueName = mod.Name + ": " + name;
        }


        public bool JustPressed => PlayerInput.Triggers.JustPressed.KeyStatus[uniqueName];
        
        
    }
}

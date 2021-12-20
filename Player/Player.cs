using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;

namespace QuickBuy.Player
{
    class Player : ModPlayer
    {
        public static int count = 1;
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if(QuickBuy.QuickBuyHotkey.JustPressed == true && Main.npcShop == 0)
            {
                count += 1;
                if( count == Hotkeys.QuickBuyHotkey.QuickBuyPossibleAmount.Length)
                {
                    count = 0;
                }
                Main.NewText("Quick Buy Size: " + Hotkeys.QuickBuyHotkey.QuickBuyPossibleAmount[count], 240, 10, 171);
            }
            else if(QuickBuy.QuickBuyHotkey.JustPressed == true && Main.npcShop > 0)
            {
                if (Main.HoverItem.value * Hotkeys.QuickBuyHotkey.QuickBuyPossibleAmount[count] <= Utils.CoinsCount(out bool x, player.inventory, new int[0]))
                {
                    player.QuickSpawnItem(Main.HoverItem ,Hotkeys.QuickBuyHotkey.QuickBuyPossibleAmount[count]);
                    player.BuyItem(Main.HoverItem.value * Hotkeys.QuickBuyHotkey.QuickBuyPossibleAmount[count]);
                }
            }
        }
    }
}

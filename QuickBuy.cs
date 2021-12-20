using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria;
using Terraria.ID;

namespace QuickBuy
{
	public class QuickBuy : Mod
	{
        public static ModHotKey QuickBuyHotkey;

        public override void Load()
        {
            QuickBuyHotkey = RegisterHotKey("Quick Buy", "Insert");
        }

    }
}
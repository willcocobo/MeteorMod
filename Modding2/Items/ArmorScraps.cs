using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modding2.Items
{
    class ArmorScraps : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ArmorScraps");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 25);
            item.maxStack = 999;
        }
    
    }
}

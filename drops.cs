using System.Collections.Generic;

namespace AskForHammer
{
    internal class drops
    {

        internal static (bool, string) isValid(string material, string religion)
        {
            var _mat = material.ToLower();
            var list = new drops();
            var toCheck = list.opatosDrops;
            if (religion != "earth")
            {
                toCheck = list.itzpaltDrops;
            }
            
            foreach(var entry in toCheck)
            {
                if (entry.Key == _mat || entry.Value.Item1 == _mat || entry.Value.Item2 == _mat)
                {
                    return (true, entry.Key);
                }
            }
            return (false, null);
        }

        // itzpalt = element
        // opatos = earth

        Dictionary<string, (string, string)> opatosDrops = new Dictionary<string, (string, string)>
        // alias, name_jp, name
        // Iron, Granite, Copper, Bronze, Chromite, Diamond, Steel, Coral, Quartz sand, Crystal, Emerald, Adamantite, Platinum,
        // Obsidian, Mithril, Titanium, Amethyst, Rose Quartz, Oak, Grass, Sand, Jelly, Raw food, Silver, Mica, Rubynus, Bone, Paper, Ether, Plastic 
        {
            {"iron", ( "鉄" , "iron" ) },
            {"granite", ( "グラナイト" , "granite" ) },
            {"copper", ( "銅" , "copper" ) },
            {"bronze", ( "青銅" , "bronze" ) },
            {"chromite", ( "クロム" , "chromite" ) },
            {"diamond", ( "ダイヤモンド" , "diamond" ) },
            {"steel", ( "鋼" , "steel" ) },
            {"coral", ( "珊瑚" , "coral" ) },
            {"glass", ( "珪砂" , "quartz sand" ) },
            {"crystal", ( "水晶" , "crystal" ) },
            {"emerald", ( "エメラルド" , "emerald" ) },
            {"adamantite", ( "アダマンタイト" , "adamantite" ) },
            {"platinum", ( "白金" , "platinum" ) },
            {"obsidian", ( "黒曜石" , "obsidian" ) },
            {"mithril", ( "ミスリル" , "mithril" ) },
            {"titanium", ( "タイタニアム" , "titanium" ) },
            {"amethyst", ( "アメジスト" , "amethyst" ) },
            {"rosequartz", ( "ローズクオーツ" , "rose quartz" ) },
            {"oak", ( "オーク" , "oak" ) },
            {"grass", ( "草" , "grass" ) },
            {"sand", ( "砂" , "sand" ) },
            {"jelly", ( "ゼリー" , "jelly" ) },
            {"meat", ( "生もの" , "raw food" ) },
            {"silver", ( "銀" , "silver" ) },
            {"mica", ( "ミカ" , "mica" ) },
            {"rubinus", ( "ルビナス" , "rubynus" ) },
            {"bone", ( "骨" , "bone" ) },
            {"paper", ( "紙" , "paper" ) },
            {"ether", ( "エーテル" , "ether" ) },
            {"plastic", ( "プラスチック" , "plastic" ) },
        };
        Dictionary<string, (string, string)> itzpaltDrops = new Dictionary<string, (string, string)>
        // alias, name_jp, name
        // Gold, Hide, Dragon scale, Pearl, Straw, Cotton, Silk, Scale, Cashmere, Zylon, Spirit cloth, Dawn cloth,
        // Griffon scale, Wool, Spider silk, Hemp, Oak, Grass, Sand, Jelly, Raw food, Silver, Mica, Rubynus, Bone, Paper, Ether, Plastic 
        {
            {"gold", ( "金" , "gold" ) },
            {"hide", ( "革" , "hide" ) },
            {"hide_dragon", ( "竜鱗" , "dragon scale" ) },
            {"pearl", ( "真珠" , "pearl" ) },
            {"straw", ( "藁" , "straw" ) },
            {"cotton", ( "綿" , "cotton" ) },
            {"silk", ( "シルク" , "silk" ) },
            {"scale", ( "鱗" , "scale" ) },
            {"cashmere", ( "カシミア" , "cashmere" ) },
            {"zylon", ( "ザイロン" , "zylon" ) },
            {"spirit", ( "霊布" , "spirit cloth" ) },
            {"dusk", ( "宵晒" , "dawn cloth" ) },
            {"griffon", ( "翼鳥鱗" , "griffon scale" ) },
            {"wool", ( "ウール" , "wool" ) },
            {"spidersilk", ( "蜘蛛糸" , "spider silk" ) },
            {"hemp", ( "麻" , "hemp" ) },
            {"oak", ( "オーク" , "oak" ) },
            {"grass", ( "草" , "grass" ) },
            {"sand", ( "砂" , "sand" ) },
            {"jelly", ( "ゼリー" , "jelly" ) },
            {"meat", ( "生もの" , "raw food" ) },
            {"silver", ( "銀" , "silver" ) },
            {"mica", ( "ミカ" , "mica" ) },
            {"rubinus", ( "ルビナス" , "rubynus" ) },
            {"bone", ( "骨" , "bone" ) },
            {"paper", ( "紙" , "paper" ) },
            {"ether", ( "エーテル" , "ether" ) },
            {"plastic", ( "プラスチック" , "plastic" ) },
        };
    }
}

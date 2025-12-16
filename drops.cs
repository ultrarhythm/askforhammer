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
            
            /*
            if (religion != "earth")
            {
                toCheck = list.itzpaltDrops;
            }
            */
            
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
        {

        };
    }
}

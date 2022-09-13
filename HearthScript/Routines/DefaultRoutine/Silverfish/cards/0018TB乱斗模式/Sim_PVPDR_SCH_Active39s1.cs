using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active39s1 : SimTemplate //* 愤怒的暴徒 Angry Mob
	{
		//Destroy 2 random enemy minions. Upgrade this and shuffle it into your deck.
		//随机消灭两个敌方随从。将此牌升级并洗入你的牌库。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}

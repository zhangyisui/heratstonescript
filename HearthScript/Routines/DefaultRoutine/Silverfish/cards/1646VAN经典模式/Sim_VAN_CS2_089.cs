using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_089 : SimTemplate //* 圣光术 Holy Light
	{
		//Restore #6 Health.
		//恢复#6点生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(6) : p.getEnemySpellHeal(6);
            p.minionGetDamageOrHeal(target, -heal);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
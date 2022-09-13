using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_694 : SimTemplate //* 暗影大师 Shadow Sensei
//<b>Battlecry:</b> Give a <b>Stealthed</b> minion +2/+2.
//<b>战吼：</b>使一个<b>潜行</b>的随从获得+2/+2。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetBuffed(target, 2, 2);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_STEALTHED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_164 : SimTemplate //* 滋养 Nourish
	{
		//<b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
		//<b>抉择：</b>获得两个法力水晶；或者抽三张牌。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
				if (ownplay)
				{
					p.mana = Math.Min(10, p.mana+2);
					p.ownMaxMana = Math.Min(10, p.ownMaxMana+2);
				}
				else
				{
					p.mana = Math.Min(10, p.mana+2);
					p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+2);
				}
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                //this.owncarddraw+=3;
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }

    }


}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_006 : SimTemplate //* 达拉然铁骑士 Dalaran Aspirant
//<b>Inspire:</b> Gain <b>Spell Damage +1</b>.
//<b>激励：</b>获得<b>法术伤害+1</b>。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				m.spellpower++;
				if (m.own) p.spellpower++;
				else p.enemyspellpower++;
			}
        }
				
        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower -= m.spellpower;
            else p.enemyspellpower -= m.spellpower;
        }
	}
}
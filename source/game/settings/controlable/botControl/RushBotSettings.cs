﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using taw.game.basicInterfaces;
using taw.game.controlable.botControl;

namespace taw.game.settings.controlable.botControl {
	class RushBotSettings : BasicBotSettings {
		public override void SetSettings(Settingable obj) {
			RushBot bot = obj as RushBot;
			if (bot == null)
				throw new ApplicationException("Wrong generator in BasicIdSetterSettings.SetSettings");

			base.SetSettings(obj);

			bot.protectCities = true;
			bot.protectCities_MinimumUnitsLeft = 2;

			bot.dropOvercapacityUnit = true;
			bot.dropOvercapacityUnit_Nearby = 1;

			bot.moveUnitsToWeakSities = true;

			bot.rushWithMinimumMoreUnits = 1;
			bot.rushChances = new List<KeyValuePair<byte, byte>>() {
				new KeyValuePair<byte, byte>(1, 25),
				new KeyValuePair<byte, byte>(2, 50),
				new KeyValuePair<byte, byte>(3, 25),
			};

		}
	}
}

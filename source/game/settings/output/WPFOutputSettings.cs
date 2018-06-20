﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taw.game.settings;
using taw.game.basicInterfaces;
using taw.game.output;

using System.Windows.Media;

namespace taw.game.settings.output {
	class WPFOutputSettings : BasicOutputSettings {
		public override void SetSettings(ISettingable obj) {
			if (!(obj is WPFOutput output))
				throw new ApplicationException("Wrong generator in WPFOutputSettings.SetSettings");

			base.SetSettings(obj);

			output.windowBackgroundColor = Brushes.DimGray;


			output.gameGridBackgroundColor = Brushes.Black;
			output.roadColor = Brushes.Gray;
			output.roadWidthMod = 0.33;
			output.roadHeightMod = 0.33;


			output.cityIsSquere = true;
			output.citySizeMod = 0.80;

			output.cityShapesColors = new List<System.Windows.Media.Brush>() {
				Brushes.Wheat,
				Brushes.Red,
				Brushes.Blue,
				Brushes.Yellow,
				Brushes.DarkGreen,
				Brushes.Teal,
				Brushes.Purple,
				Brushes.Orange,
				Brushes.Green,
				Brushes.Pink,
				Brushes.Gray,
				Brushes.LightBlue,
				Brushes.Brown,
				Brushes.Maroon,
				Brushes.Navy,
				Brushes.Navy,
				Brushes.Turquoise,
				Brushes.Violet,
				Brushes.Wheat,
				Brushes.PeachPuff,
				Brushes.MintCream,
				Brushes.Lavender,
				Brushes.DarkGray,
				Brushes.Snow,
				Brushes.DarkGreen,
				Brushes.Peru,
			};

			output.cityStrokeThickness = 2;
			output.cityStrokesColors = new List<Brush>() {
				Brushes.White,
			};

		}

		protected override void LoadSettingsFromFile() {
			throw new NotImplementedException();
		}
	}
}

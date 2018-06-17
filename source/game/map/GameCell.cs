﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using taw.game.sity;
using taw.game.unit;
using taw.game.IO;

namespace taw.game.map {
	public partial class GameCell : GameCellDrawableObj {
		//---------------------------------------------- Fields ----------------------------------------------
		Lazy<List<BasicUnit>> units;

		//---------------------------------------------- Properties ----------------------------------------------
		public bool IsOpenLeft { get; set; }
		public bool IsOpenTop { get; set; }
		public bool IsOpenRight { get; set; }
		public bool IsOpenBottom { get; set; }

		public BasicSity Sity { get; set; }
		public List<BasicUnit> Units => units.Value;

		//---------------------------------------------- Ctor ----------------------------------------------
		public GameCell() {
			IsOpenBottom = IsOpenLeft = IsOpenRight = IsOpenTop = false;
			units = new Lazy<List<BasicUnit>>();
			Sity = null;
		}
	}
}

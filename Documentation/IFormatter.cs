﻿using System;
using System.Collections.Generic;
using TShockAPI;
using Terraria;

namespace Documentation
{
	/// <summary>
	/// Formats the output for writing docs to files.
	/// </summary>
	public interface IFormatter
	{
		/// <summary>
		/// In-game name that this formatter is referred to.
		/// </summary>
		string Name {get;}
		/// <summary>
		/// File extension to use for this format.
		/// </summary>
		string Extension {get;}
		string FormatWalls();
	    string FormatWallsSimple();
        string FormatTiles();
        string FormatTilesSimple();
        string FormatItems();
        string FormatItemsSimple();
        string FormatMobs();
        string FormatMobsSimple();
		string FormatCommands();
        string FormatProjectiles();
        string FormatProjectilesSimple();
	}
}

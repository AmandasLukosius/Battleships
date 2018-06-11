using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleShips
{
    public static class PanelExtensions
    {
        public static List<Panel> Range(this List<Panel> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.Coordinates.Row >= startRow
                                && x.Coordinates.Column >= startColumn
                                && x.Coordinates.Row <= endRow
                                && x.Coordinates.Column <= endColumn).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ChessComponents
{
    public partial class Board
    {
        private PieceType[,] PieceLocations { get; set; } = new PieceType[,]
            {
                { }
            };
    }
}
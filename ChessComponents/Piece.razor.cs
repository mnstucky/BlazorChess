using Microsoft.AspNetCore.Components;

namespace ChessComponents
{
    public partial class Piece
    {
        [Parameter]
        public PieceType PieceType { get; set; }
        private string SvgPath =>
            PieceType switch
            {
                PieceType.DarkPawn => "bP.svg",
                PieceType.LightPawn => "wP.svg",
                PieceType.DarkKnight => "bK.svg",
                PieceType.LightKnight => "wK.svg",
                PieceType.DarkBishop => "bB.svg",
                PieceType.LightBishop => "wB.svg",
                PieceType.DarkRook => "bR.svg",
                PieceType.LightRook => "wR.svg",
                PieceType.DarkQueen => "bQ.svg",
                PieceType.LightQueen => "wQ.svg",
                PieceType.DarkKing => "bK.svg",
                PieceType.LightKing => "wK.svg",
                _ => throw new NotImplementedException()
            };
    }
}

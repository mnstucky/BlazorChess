using System.ComponentModel.DataAnnotations;

namespace ChessComponents
{
    public enum File
    {
        A = 1, B, C, D, E, F, G, H
    }
    public enum Rank
    {
        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three,
        [Display(Name = "4")]
        Four,
        [Display(Name = "5")]
        Five,
        [Display(Name = "6")]
        Six,
        [Display(Name = "7")]
        Seven,
        [Display(Name = "8")]
        Eight
    }
    public enum PieceType
    {
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }
}
using Microsoft.AspNetCore.Components;

namespace ChessComponents
{
    public partial class Square
    {
        [Parameter]
        public int RowIndex { get; set; }
        [Parameter]
        public int ColumnIndex { get; set; }
        private SquareColor SquareColor => (RowIndex + ColumnIndex) % 2 == 0 ? SquareColor.Light : SquareColor.Dark;
        private string RoundedCornerClass =>
            (RowIndex, ColumnIndex) switch
            {
                (0, 0) => "top-left",
                (0, 7) => "top-right",
                (7, 0) => "bottom-left",
                (7, 7) => "bottom-right",
                _ => "",
            };
    }
}
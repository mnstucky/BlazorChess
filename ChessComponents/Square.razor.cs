using Microsoft.AspNetCore.Components;

namespace ChessComponents
{
    public partial class Square
    {
        [Parameter]
        public Rank Rank { get; set; }

        [Parameter]
        public File File { get; set; }
    }
}
﻿using Microsoft.AspNetCore.Components;
using StandupEngine.Services;

namespace StandupEngine.Components
{
    public partial class DialogueJumbotron : ComponentBase
    {
        /*
         Music from <a href="https://pixabay.com/music/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=music&amp;utm_content=38826">Pixabay</a>
        */
        [Inject]
        public Engine Engine { get; set; }
        [CascadingParameter]
        public string CurrentText { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CurrentText = await Engine.GetJokeAsync(true);
        }
    }
}

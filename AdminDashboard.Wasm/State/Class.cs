public class Class
{
    /*
        Display on Component

        @inject ProfileService ProfileService
        @implements IDisposable

        @if (ProfileService.Profile != null)
        {
            <h1>Welcome @ProfileService.Profile.Name !</h1>
        }

        
        @code {
            ******Update on Component******
            protected override async Task OnInitializedAsync()
            {
                await ProfileService.Set(new Profile { Name = "Jon" });
            }
            ******Subscribe to changes******
           protected override void OnInitialized()
            {
                ProfileService.OnChange += StateHasChanged;
            }

            public void Dispose()
            {
                ProfileService.OnChange -= StateHasChanged;
            }
        }
     */
}


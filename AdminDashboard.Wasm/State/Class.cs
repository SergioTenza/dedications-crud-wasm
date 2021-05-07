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


        protected override void OnInitialized()
    {
        // redirect to home if already logged in
        if (AuthenticationService.User != null)
        {
            _userName = AuthenticationService.User.UserName;
            for (var i = 0; i < AuthenticationService.User.Roles.Count(); i++)
            {
                   if (AuthenticationService.User.Roles[i] == "admin")
                   {
                       _elevatedRole = AuthenticationService.User.Roles[i];                       
                   }
                   else
                   {
                       _elevatedRole = "customer";
                   }
            }            
        }
        else
        {
            _userName = "Invitado";
            _elevatedRole = "Haga Login";
        }
    }
     */
}


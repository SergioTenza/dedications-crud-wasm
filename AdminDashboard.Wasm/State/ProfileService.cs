using AdminDashboard.Wasm.Models;
using System;
using System.Threading.Tasks;

namespace AdminDashboard.Wasm.State
{
    public class ProfileService
    {
        public event Action OnChange;
        public User User { get; private set; }

        public async Task Set(User user)
        {
            User = user;
            OnChange?.Invoke();
        }

        public async Task SetIfNull(User user)
        {
            if (User == null)
                User = user;
        }
    }
}

using Blazor_XP.Services.Interfaces;

namespace Blazor_XP.Services
{
    public class RefreshService : IRefreshService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}

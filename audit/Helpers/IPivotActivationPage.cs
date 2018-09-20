using System.Collections.Generic;
using System.Threading.Tasks;

namespace audit.Helpers
{
    public interface IPivotActivationPage
    {
        Task OnPivotActivatedAsync(Dictionary<string, string> parameters);
    }
}

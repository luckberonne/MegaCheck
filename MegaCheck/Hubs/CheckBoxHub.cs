using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class CheckboxHub : Hub
{
    public async Task UpdateCheckboxState(int checkboxId, bool isChecked)
    {
        await Clients.All.SendAsync("ReceiveCheckboxUpdate", checkboxId, isChecked);
    }
}

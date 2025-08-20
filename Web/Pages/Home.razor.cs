using Entidades;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web
{
    public class HomeBase : ComponentBase
    {
        protected string AccountNumber { get; set; }
        protected List<UserProfile> UserProfiles { get; set; } = new();

        protected async Task Buscar()
        {
            // Simulación temporal
            UserProfiles = new List<UserProfile>
            {
                new UserProfile
                {
                    UserId = 1,
                    UserName = "John Doe",
                    AccountNumber = AccountNumber,
                    AccountType = "Premium",
                    EmployeeNumber = 123,
                    StoreId = 5,
                    Checked = 1,
                    ValidationDate = DateTime.Now,
                    Status = "Active"
                }
            };
            await InvokeAsync(StateHasChanged);
        }
    }
}
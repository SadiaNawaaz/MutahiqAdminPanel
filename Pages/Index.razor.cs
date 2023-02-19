using AdminDashboard.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using System.Globalization;

namespace AdminDashboard.Pages
{
    public partial class Index
    {
        bool showDataLabels = false;
        bool smooth = false;
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        public IEnumerable<string> colors = new List<string>() { "Red", "Green", };
        void OnSeriesClick(SeriesClickEventArgs args)
        {

        }
        public async void fnNavbar()
        {
            /// await JSRuntime.InvokeVoidAsync("fnNavbar");
            await JSRuntime.InvokeAsync<string>("fnNavbar");
        }
        //public void logout()
        //{



        //    ((CustomAuthenticationStateProvider)authenticationStateProvider).MarkUserIsLogOut();
        //    localStorage.ClearAsync();
        //    navigationManager.NavigateTo("/");
        //}



        DataItem[] revenue = new DataItem[] {
        new DataItem
        {
            Quarter = "Need",
            Revenue = 30000
        },
        new DataItem
        {
            Quarter = "Collected",
            Revenue = 50000
        },

    };
        bool trend = true;
        bool median = false;
        bool mean = false;
        bool mode = false;
        string FormatAsUSD(object value)
        {
            return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-PK"));
        }

        string FormatAsMonth(object value)
        {
            if (value != null)
            {
                return Convert.ToDateTime(value).ToString("MMM");
            }

            return string.Empty;
        }

        DataItem[] revenue2019 = new DataItem[] {
        new DataItem
        {
            Date = ("2019-01-01"),
            Revenue = 234000
        },
        new DataItem
        {
            Date = ("2019-02-01"),
            Revenue = 269000
        },
        new DataItem
        {
            Date = ("2019-03-01"),
            Revenue = 233000
        },
        new DataItem
        {
            Date = ("2019-04-01"),
            Revenue = 244000
        },
        new DataItem
        {
            Date = ("2019-05-01"),
            Revenue = 214000
        },
        new DataItem
        {
            Date = ("2019-06-01"),
            Revenue = 253000
        },
        new DataItem
        {
            Date = ("2019-07-01"),
            Revenue = 274000
        },
        new DataItem
        {
            Date = ("2019-08-01"),
            Revenue = 284000
        },
        new DataItem
        {
            Date = ("2019-09-01"),
            Revenue = 273000
        },
        new DataItem
        {
            Date = ("2019-10-01"),
            Revenue = 282000
        },
        new DataItem
        {
            Date = ("2019-11-01"),
            Revenue = 289000
        },
        new DataItem
        {
            Date = ("2019-12-01"),
            Revenue = 294000
        }
    };

        DataItem[] revenue2020 = new DataItem[] {
        new DataItem
        {
            Date = ("2019-01-01"),
            Revenue = 334000
        },
        new DataItem
        {
            Date = ("2019-02-01"),
            Revenue = 369000
        },
        new DataItem
        {
            Date = ("2019-03-01"),
            Revenue = 333000
        },
        new DataItem
        {
            Date = ("2019-04-01"),
            Revenue = 344000
        },
        new DataItem
        {
            Date = ("2019-05-01"),
            Revenue = 314000
        },
        new DataItem
        {
            Date = ("2019-06-01"),
            Revenue = 353000
        },
        new DataItem
        {
            Date = ("2019-07-01"),
            Revenue = 374000
        },
        new DataItem
        {
            Date = ("2019-08-01"),
            Revenue = 384000
        },
        new DataItem
        {
            Date = ("2019-09-01"),
            Revenue = 373000
        },
        new DataItem
        {
            Date = ("2019-10-01"),
            Revenue = 382000
        },
        new DataItem
        {
            Date = ("2019-11-01"),
            Revenue = 389000
        },
        new DataItem
        {
            Date = ("2019-12-01"),
            Revenue = 394000
        }
    };

      
    }

    class DataItem
    {
        public string Date { get; set; }
        public string Quarter { get; set; }
        public double Revenue { get; set; }
    }
}

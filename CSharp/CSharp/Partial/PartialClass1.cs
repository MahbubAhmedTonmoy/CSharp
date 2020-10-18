using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharp.Partial
{

    /// <summary>
    /// partial class
    /// </summary>
    public partial class PurchaseService
    {
        public int GetTodayPurchase()
        {
            return 100;
        }
    }

    public partial class PurchaseService
    {
        public int GetYesterdayPurchase()
        {
            return 200;
        }
    }
    ///partial class end

    /// <summary>
    /// partial method
    /// </summary>
    public partial class UserService
    {
        // This file only contains 
        // declaration of partial method
        // Partial methods are implicitly private, and therefore they cannot be virtual.
        partial void TrackUser(string userId);
        public bool IsValidUser(string userId)
        {
            TrackUser(userId);
            Guid userGuid;
            bool ok = Guid.TryParse(userId, out userGuid);
            return ok;
        }
    }
    public partial class UserService
    {
        // This is the definition of 
        // partial method 
        partial void TrackUser(string userId)
        {
            Debug.WriteLine($"Tracked user id={userId}");
        }
    }


}

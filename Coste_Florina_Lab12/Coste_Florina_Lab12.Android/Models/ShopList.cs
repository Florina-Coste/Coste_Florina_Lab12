using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Coste_Florina_Lab12.Droid.Models
{
    class ShopList
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
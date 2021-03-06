﻿using Xamarin.Forms;
using static Betrayal.DataStoreKeys;

namespace Betrayal
{
    public class DataStore
    {
        public static void Save(Keys key, object value)
        {
            Application.Current.Properties[key.ToString()] = value;
            Application.Current.SavePropertiesAsync();
        }

        public static void Remove(Keys key)
        {
            if (Application.Current.Properties.ContainsKey(key.ToString()))
            {
                Application.Current.Properties.Remove(key.ToString());
                Application.Current.SavePropertiesAsync();
            }
        }

        public static object Get(Keys key)
        {
            if (Application.Current.Properties.ContainsKey(key.ToString()))
            {
                if (Application.Current.Properties[key.ToString()] != null)
                    return Application.Current.Properties[key.ToString()];
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
    }
}

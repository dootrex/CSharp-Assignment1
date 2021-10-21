using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MajorAssignment1
{
    class StoreStats
    {
        public static float TotalSales(List<Store> st)
        {
            float sum = 0f;
            for (int i = 1; i < st.Count(); i++)
            {
                sum += float.Parse(st[i].weeklySale);
            }
            return sum;
        }
        public static float MonthlySales(List<Store> st, string theMonth)
        {
            float sum = 0f;
            for (int i = 1; i < st.Count(); i++)
            {
                if (st[i].date.Substring(3).Equals(theMonth))
                {
                    sum += float.Parse(st[i].weeklySale);
                }
            }
            return sum;
        }
        public static float HolidaySales(List<Store> st)
        {
            float sum = 0f;
            for (int i = 0; i < st.Count(); i++)
            {
                if (st[i].holiday == "1")
                {
                    sum += float.Parse(st[i].weeklySale);
                }
            }
            return sum;
        }
        public static float TotalSalesForStore(List<Store> st, string store)
        {
            float sum = 0f;
            for (int i = 1; i < st.Count(); i++)
            {
                if (st[i].store == store)
                {
                    sum += float.Parse(st[i].weeklySale);
                }
            }
            return sum;
        }
        public static float TotalMonthlySalesForStore(List<Store> st, string store, string theMonth)
        {
            float sum = 0f;
            for (int i = 0; i < st.Count(); i++)
            {
                if (st[i].store == store)
                {
                    if (DateTime.ParseExact(st[i].date, "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("MM-yyyy") == theMonth)
                    {
                        sum += float.Parse(st[i].weeklySale);
                    }
                }
            }
            return sum;
        }

        public static float HolidaySalesForStore(List<Store> st, string store)
        {
            float sum = 0f;
            for (int i = 0; i < st.Count(); i++)
            {
                if (st[i].store == store)
                {
                    if (st[i].holiday == "1")
                    {
                        sum += float.Parse(st[i].weeklySale);
                    }
                }
            }
            return sum;
        }

    }
}

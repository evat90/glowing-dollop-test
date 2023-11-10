using Quote.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quote
{
    public class BaseMarginProvider:IMarginProviderDinamic
    {
        public decimal GetMargin(RootMarginResponse rootMarginResponse)
        {
            if (rootMarginResponse.code == 200)
            {
                return rootMarginResponse.data.margin;
            }
            else
            {
                return 0.25M;
            }
        }
    }
}

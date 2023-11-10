using Quote.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quote
{
    public interface IMarginProviderDinamic
    {
        decimal GetMargin(RootMarginResponse rootMargin);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using CovidChallenge.Localization;
using Volo.Abp.Application.Services;

namespace CovidChallenge
{
    /* Inherit your application services from this class.
     */
    public abstract class CovidChallengeAppService : ApplicationService
    {
        protected CovidChallengeAppService()
        {
            LocalizationResource = typeof(CovidChallengeResource);
        }
    }
}

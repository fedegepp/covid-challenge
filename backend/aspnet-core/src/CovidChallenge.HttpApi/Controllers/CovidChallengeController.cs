using CovidChallenge.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CovidChallenge.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CovidChallengeController : AbpController
    {
        protected CovidChallengeController()
        {
            LocalizationResource = typeof(CovidChallengeResource);
        }
    }
}
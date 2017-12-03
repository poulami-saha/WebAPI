using CountingKs.Data;
using CountingKs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace CountingKs.Controllers
{
    public class DiariesController : BaseApiController
    {
        public DiariesController(ICountingKsRepository repo, ICountingKsIdentityService identityService) : base(repo)
        {
            _identityService = identityService;

        }

        public ICountingKsIdentityService _identityService;

        //public object Get()
        //{
        //    var username = Thread.CurrentPrincipal.Identity.Name;
        //    var results = TheRepository.GetDiaries()
                                        
        //}
    }
}

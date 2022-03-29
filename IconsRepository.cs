using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http.Features.Authentication;
using static Unidad_2.Program;


namespace Unidad_2
{
    public class IconsRepository : BaseRepository<GeographicIcons, ChallengeContext>, IconsRepository
    {
        public IconsRepository(ChallengeContext dbContext) : base(dbContext)
        {
        }
    }

    public class GeographicIcons
    {
    }
   
}

﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkyMallCore.Data;
using SkyMallCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyMallCore.Respository
{
    public class SysItemsDetailRespository : RespositoryBase<SysItemsDetail>, ISysItemsDetailRespository
    {
        public SysItemsDetailRespository(ISkyMallDbContext skyMallDbContext) : base(skyMallDbContext)
        { }


     
    }

}

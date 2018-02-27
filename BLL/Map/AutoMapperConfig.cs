using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Map
{
    public class AutoMapperConfig
    {
        public static void Init()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<CardMapperProfile>();
            });

            AutoMapper.Mapper.AssertConfigurationIsValid();
        }
    }
}

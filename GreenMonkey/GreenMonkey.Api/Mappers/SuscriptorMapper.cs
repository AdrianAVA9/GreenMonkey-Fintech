using GreenMonkey.Dtos;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Mappers
{
    public static class SuscriptorMapper
    {
        public static Suscriptor GetSuscriptor(SuscriptorDto suscriptor)
        {
            return new Suscriptor(){ 
                BaseUrl = suscriptor.BaseUrl,
                Code = suscriptor.Code,
                Description = suscriptor.Description,
                Name = suscriptor.Name,
                Owner = suscriptor.Owner
            };
        }
        public static SuscriptorDto GetSuscriptor(Suscriptor suscriptor)
        {
            return new SuscriptorDto()
            {
                BaseUrl = suscriptor.BaseUrl,
                Code = suscriptor.Code,
                Description = suscriptor.Description,
                Name = suscriptor.Name,
                Owner = suscriptor.Owner
            };
        }
    }
}
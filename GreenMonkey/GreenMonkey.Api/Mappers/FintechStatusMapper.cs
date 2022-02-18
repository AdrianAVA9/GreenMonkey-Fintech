using GreenMonkey.Dtos;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.Api.Mappers
{
    public static class FintechStatusMapper
    {
        public static FintechStatus GetFintech(FintechStatusDto fintechStatus)
        {
            return new FintechStatus()
            {
                Status = fintechStatus.Status,
                Suscriptor = SuscriptorMapper.GetSuscriptor(fintechStatus.Suscriptor),
                UpdatedDate = fintechStatus.UpdatedDate
            };
        }
        public static FintechStatusDto GetFintech(FintechStatus fintechStatus)
        {
            return new FintechStatusDto()
            {
                Status = fintechStatus.Status,
                Suscriptor = SuscriptorMapper.GetSuscriptor(fintechStatus.Suscriptor),
                UpdatedDate = fintechStatus.UpdatedDate
            };
        }
    }
}
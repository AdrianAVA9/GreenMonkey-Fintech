using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using GreenMonkey.Api.Validators;
using GreenMonkey.Dtos;
using GreenMonkey.Models;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(GreenMonkey.Api.App_Start.Startup))]

namespace GreenMonkey.Api.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var mapperConfiguration = new MapperConfiguration(mapConfig => {
                mapConfig.CreateMap<Suscriptor, SuscriptorDto>()
                    .ReverseMap();
                mapConfig.CreateMap<SuscriptorStatus, SuscriptorStatusDto>()
                    .ReverseMap();
                mapConfig.CreateMap<Customer, CustomerDto>()
                    .ReverseMap();
                mapConfig.CreateMap<Coin, CoinDto>()
                    .ReverseMap();
                mapConfig.CreateMap<Account, AccountDto>()
                    .ReverseMap();
            });

            var mapper = mapperConfiguration.CreateMapper();

            var builder = new ContainerBuilder();
            builder.RegisterInstance(mapper);
            builder.RegisterInstance(new SuscriptorValidator());
            builder.RegisterInstance(new CustomerValidator());
            builder.RegisterInstance(new CoinValidator());
            builder.RegisterInstance(new AccountValidator());
            builder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());
            
            var container = builder.Build();
            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}

using Google.Apis.Requests;
using Google.Cloud.Storage.V1;
using Mapster;
using Meowgic.Repositories.Entities;
using Meowgic.Repositories.Models.Request.Account;
using Meowgic.Repositories.Models.Request.Card;
using Meowgic.Repositories.Models.Request.CardMeaning;
using Meowgic.Repositories.Models.Request.Category;
using Meowgic.Repositories.Models.Request.Promotion;
using Meowgic.Repositories.Models.Request.Question;
using Meowgic.Repositories.Models.Request.Service;
using Meowgic.Service.Interface;
using Meowgic.Service.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Meowgic.Service.Extension
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMapsterConfigurations();
            services.AddSingleton(opt => StorageClient.Create());
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICardMeaningService,CardMeaningService>();
            services.AddScoped<IFirebaseStorageService, FirebaseStorageService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPromotionService, PromotionService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IServiceService, ServiceService>();
            return services;
        }

        private static void AddMapsterConfigurations(this IServiceCollection services)
        {
            TypeAdapterConfig<Register, Account>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<CardRequest, Card>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<CardMeaningRequest, CardMeaning>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<CategoryRequest, Category>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<CreatePromotion, Promotion>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<QuestionRequest, Question>.NewConfig().IgnoreNullValues(true);
            TypeAdapterConfig<ServiceRequest, TarotService>.NewConfig().IgnoreNullValues(true);
        }
    }
}

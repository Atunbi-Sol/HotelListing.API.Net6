﻿using HotellistingAPI.Data;
using Microsoft.AspNetCore.Identity;

namespace HotellistingAPI
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<ApiUser>(q => q.User.RequireUniqueEmail = true);

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<HotelListingDbContext>().AddDefaultTokenProviders();
        }
    }
}





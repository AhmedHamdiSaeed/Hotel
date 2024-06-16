using Hotel_BL.Managers.Booking;
using Hotel_BL.Managers.Branch;
using Hotel_BL.Managers.Category;
using Hotel_BL.Managers.Room;
using Hotel_DAL.Repos.BookingRepo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BL.Services
{
    public static class ServiceExtention
    {
        public static void AddBLService(this IServiceCollection services)
        {
            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<IBranchManager,BranchManager>();
            services.AddScoped<IRoomManager, RoomManager>();
            services.AddScoped<ICategoryManager,CategoryManager>();
        }
      
            public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string orderByProperty, bool desc = false)
            {
                if (string.IsNullOrEmpty(orderByProperty))
                    return source;

                var type = typeof(T);
                var property = type.GetProperty(orderByProperty);
                if (property == null)
                    throw new ArgumentException("Property not found", nameof(orderByProperty));

                var parameter = Expression.Parameter(type, "p");
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExpression = Expression.Lambda(propertyAccess, parameter);

                string methodName = desc ? "OrderByDescending" : "OrderBy";
                var resultExpression = Expression.Call(typeof(Queryable), methodName,
                                                       new Type[] { type, property.PropertyType },
                                                       source.Expression, Expression.Quote(orderByExpression));

                return source.Provider.CreateQuery<T>(resultExpression);
            }
        
    }
}

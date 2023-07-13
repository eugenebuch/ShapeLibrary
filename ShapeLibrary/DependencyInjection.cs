using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using ShapeLibrary.Application.Interfaces;

namespace ShapeLibrary.Application;

public static class DependencyInjection
{
    public static void AddShapeLibrary(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IShapeFactory, ShapeFactory>();
    }
}
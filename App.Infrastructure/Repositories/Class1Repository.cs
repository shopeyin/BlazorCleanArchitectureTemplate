
using TemplateApp.Application.Interfaces;
using TemplateApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace TemplateApp.Infrastructure.Repositories
{
    public class Class1Repository : IClassRepository
    {

        private readonly AppDbContext _context;


        public Class1Repository(IDbContextFactory<AppDbContext> factory)
        {

            _context = factory.CreateDbContext();
        }

        public Task AddAsync(Class1 class1)
        {
            throw new NotImplementedException();
        }
    }
}

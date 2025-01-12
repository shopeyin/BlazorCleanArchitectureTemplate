using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApp.Domain.Entities;

namespace TemplateApp.Application.Interfaces
{
    public interface IClassRepository
    {

        Task AddAsync(Class1 class1);
    }
}

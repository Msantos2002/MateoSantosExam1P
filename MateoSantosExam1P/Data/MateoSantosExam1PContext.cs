using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoSantosExam1P.Models;

namespace MateoSantosExam1P.Data
{
    public class MateoSantosExam1PContext : DbContext
    {
        public MateoSantosExam1PContext (DbContextOptions<MateoSantosExam1PContext> options)
            : base(options)
        {
        }

        public DbSet<MateoSantosExam1P.Models.MS_Cerveza> MS_Cerveza { get; set; } = default!;
    }
}

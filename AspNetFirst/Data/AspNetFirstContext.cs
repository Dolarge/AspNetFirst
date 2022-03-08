#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetFirst.Models;

//Microsoft.EntityFrameworkCore.DbContext에서 파생됩니다.
//데이터 모델에 포함되는 엔터티를 지정합니다.
//Movie 모델에 대한 EF Core 기능(예: 만들기, 읽기, 업데이트, 삭제)을 조정합니다.

namespace AspNetFirst.Data
{
    public class AspNetFirstContext : DbContext
    {
        public AspNetFirstContext (DbContextOptions<AspNetFirstContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetFirst.Models.Movie>? Movie { get; set; }
    }
}

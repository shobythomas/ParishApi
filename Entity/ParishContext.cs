using Microsoft.EntityFrameworkCore;
using ParishApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Entity
{
    public class ParishContext:DbContext
    {
        public ParishContext(DbContextOptions<ParishContext> options) : base(options)
        {

        }

        public DbSet<Member> Member { get; set; }
        public DbSet<MemberFamilyDetail> MemberFamilyDetail { get; set; }
        public DbSet<MST_Documents> MST_Documents { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
     public class JsonContext : DbContext
     {
        public JsonContext(DbContextOptions<JsonContext> options) : base(options) {}
     }
}

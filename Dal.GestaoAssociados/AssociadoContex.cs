using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using Model.GestaoAssociados;

namespace Dal.GestaoAssociados
{
    class AssociadoContex : DbContext
    {
        public AssociadoContex() : base("AssociadoContex")
        {
        }
        public List<MD_Associados> assossiados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

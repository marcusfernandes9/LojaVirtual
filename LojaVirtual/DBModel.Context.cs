﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaVirtual
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Produtoes> Produtoes { get; set; }
    
        public virtual int sp_ins_produto(string nome, Nullable<float> preco, string descricao, ObjectParameter retorno)
        {
            var nomeParameter = nome != null ?
                new ObjectParameter("nome", nome) :
                new ObjectParameter("nome", typeof(string));
    
            var precoParameter = preco.HasValue ?
                new ObjectParameter("preco", preco) :
                new ObjectParameter("preco", typeof(float));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ins_produto", nomeParameter, precoParameter, descricaoParameter, retorno);
        }
    }
}
